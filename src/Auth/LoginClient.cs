using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using Classic.Auth.Cryptography;
using Classic.Auth.Packets;
using Classic.Shared;
using Classic.Shared.Data;
using Classic.Shared.Services;
using Microsoft.Extensions.Logging;

namespace Classic.Auth
{
    public class LoginClient : ClientBase
    {
        private readonly AccountService accountService;
        private readonly RealmlistService realmlistService;
        private SecureRemotePasswordProtocol srp;
        private bool isReconnect;

        public LoginClient(ILogger<LoginClient> logger, AccountService accountService, RealmlistService realmlistService)
            : base(logger)
        {
            this.accountService = accountService;
            this.realmlistService = realmlistService;
        }

        public override async Task Initialize(TcpClient client)
        {
            await base.Initialize(client);

            this.logger.LogDebug($"{this.ClientInfo} - connected");

            await HandleConnection();
        }

        public int Build { get; private set; }

        protected override async Task HandlePacket(byte[] packet)
        {
            using var reader = new PacketReader(packet);
            var cmd = (Opcode)reader.ReadByte();
            this.LogAuthState($"Recv {cmd} ({packet.Length} bytes)");

            var task = cmd switch
            {
                Opcode.LoginChallenge => this.HandleLoginChallenge(packet),
                Opcode.LoginProof => this.HandleLoginProof(packet),
                Opcode.Realmlist => this.HandleRealmlist(),
                Opcode.ReconnectChallenge => this.HandleReconnectChallenge(packet),
                Opcode.ReconnectProof => this.HandleReconnectProof(),
                _ => throw new ArgumentOutOfRangeException(nameof(cmd), $"Unknown auth opcode {cmd}"),
            };

            await task;
        }

        private async Task HandleLoginChallenge(byte[] packet)
        {
            var request = new ClientLoginChallenge(packet);

            if (request.Build > ClientBuild.WotLK)
            {
                // Send failed event
                this.Log($"Login with unsupported build {Build}");
                return;
            }

            this.Build = request.Build;

            this.srp = new SecureRemotePasswordProtocol(request.Identifier, request.Identifier); // TODO: Quick hack
            this.accountService.AddClientBuildForAddress(this.Address, this.Port, this.Build);

            // Create and send a ServerLogonChallenge as response.
            await this.Send(ServerLoginChallenge.Success(this.srp));
        }

        private async Task HandleLoginProof(byte[] packet)
        {
            var request = new ClientLoginProof(packet);

            if (!this.srp.ValidateClientProof(request.PublicValue, request.Proof))
            {
                await this.Send(ServerLoginProof.Failed());
                this.LogAuthState("Client authentication failed");
                this.isConnected = false;
                return;
            }

            await this.Send(ServerLoginProof.Success(this.srp, this.Build));
            this.LogAuthState("Client authenticated");
        }

        private async Task HandleRealmlist()
        {
            if (!this.isReconnect) // TODO: This should not be done in here?
            {
                var account = this.accountService.GetAccount(this.srp.I);

                // for development, create new account if not found
                if (account is null)
                {
                    account = new Account { Identifier = this.srp.I };
                    this.accountService.AddAccount(account);
                }

                var session = new AccountSession(this.srp.I, this.srp.SessionKey);
                this.accountService.AddSession(session);
            }

            var realms = this.realmlistService.GetRealms();
            await this.Send(ServerRealmlist.Get(realms, this.Build));
        }

        private async Task HandleReconnectChallenge(byte[] packet)
        {
            this.isReconnect = true;
            var request = new ClientLoginChallenge(packet);
            this.Build = request.Build;
            await this.Send(ServerReconnectChallenge.Success());
        }

        private async Task HandleReconnectProof()
        {
            // uint8    cmd
            // char[16] proof_data
            // char[20] client_proof
            // char[20] unk_hash
            // uint8    unk
            await this.Send(ServerReconnectProof.Success());
        }

        private void LogAuthState(string message) => this.logger.LogTrace($"{this.ClientInfo} - {message}");
    }
}