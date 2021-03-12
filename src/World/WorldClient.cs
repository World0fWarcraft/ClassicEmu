﻿using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using Classic.Shared;
using Classic.Shared.Data;
using Classic.Shared.Services;
using Classic.World.Cryptography;
using Classic.World.Entities;
using Classic.World.HeaderUtil;
using Classic.World.Messages;
using Classic.World.Messages.Server;
using Microsoft.Extensions.Logging;

namespace Classic.World
{
    public class WorldClient : ClientBase
    {
        private readonly WorldPacketHandler packetHandler;
        private readonly AccountService accountService;
        private readonly IWorldManager world;
        private AddressToClientBuildMap addressToClientBuildMap;

        public WorldClient(
            WorldPacketHandler packetHandler,
            ILogger<WorldClient> logger,
            AuthCrypt crypt,
            IWorldManager world,
            AccountService accountService) : base(logger)
        {
            this.packetHandler = packetHandler;
            this.Crypt = crypt;
            this.accountService = accountService;
            this.world = world;
        }

        public override async Task Initialize(TcpClient client)
        {
            await base.Initialize(client);

            this.addressToClientBuildMap = this.accountService.GetClientBuildFromAddress(this.Address, this.Port);

            if (this.addressToClientBuildMap is null)
            {
                this.logger.LogWarning($"Could not find client build for {this.Address}:{this.Port - 1}.");
                this.Build = ClientBuild.Vanilla;
            }
            else
            {
                this.Build = this.addressToClientBuildMap.ClientBuild;
            }

            this.HeaderUtil = HeaderUtilFactory.Create(this.Build, this.Crypt);
            this.logger.LogDebug($"{this.ClientInfo} - connected");

            ServerMessageBase<Opcode> message = this.Build switch
            {
                ClientBuild.Vanilla or ClientBuild.TBC => new SMSG_AUTH_CHALLENGE_VANILLA_TBC(),
                ClientBuild.WotLK => new SMSG_AUTH_CHALLENGE_WOTLK(),
                _ => throw new NotImplementedException($"SMSG_AUTH_CHALLENGE(build: {this.Build})"),
            };

            await Send(message.Get());
            this.logger.LogTrace($"{this.ClientInfo} - Sent {message.Opcode}");
            await HandleConnection();
        }

        public int Build { get; internal set; }
        public bool IsInWorld => this.CharacterId != default;

        public string Identifier { get; internal set; }
        public ulong CharacterId { get; internal set; }

        public PlayerEntity Player { get; internal set; }

        public AuthCrypt Crypt { get; internal set; }

        public IHeaderUtil HeaderUtil { get; internal set; }

        protected override async Task HandlePacket(byte[] data)
        {
            for (var i = 0; i < data.Length; i++)
            {
                // TODO: Spans instead of array.copy!
                var header = new byte[6];
                Array.Copy(data, i, header, 0, 6);

                var (length, opcode) = this.Decode(header);

                this.logger.LogTrace($"{this.ClientInfo} - Recv {opcode} ({length} bytes)");

                var packet = new byte[length];
                Array.Copy(data, i + 6, packet, 0, length - 4);

                var handler = packetHandler.GetHandler(opcode);
                await handler(new PacketHandlerContext
                {
                    Client = this,
                    Packet = packet,
                    Opcode = opcode,
                    World = this.world,
                    AccountService = this.accountService,
                });

                i += 2 + (length - 1);
            }
        }

        public async Task SendPacket(ServerMessageBase<Opcode> message)
        {
            var data = this.HeaderUtil.Encode(message);
            await this.Send(data);
            this.logger.LogTrace($"{this.ClientInfo} - Sent {message.Opcode}");
            message.Dispose();
        }

        // https://github.com/drolean/Servidor-Wow/blob/f77520bc8ad5d123139e34d3d0c8f40d161ad352/RealmServer/RealmServerSession.cs#L245
        private (ushort length, Opcode opcode) Decode(byte[] packet)
        {
            ushort length;
            short opcode;

            if (this.Crypt.IsInitialized)
            {
                this.Crypt.Decrypt(packet, 6);
                length = BitConverter.ToUInt16(new[] { packet[1], packet[0] });
                opcode = BitConverter.ToInt16(new[] { packet[2], packet[3] });
            }
            else
            {
                length = BitConverter.ToUInt16(new[] { packet[1], packet[0] });
                opcode = BitConverter.ToInt16(packet, 2);
            }

            return (length, (Opcode)opcode);
        }

        protected override void OnDisconnected()
        {
            this.world.Connections.Remove(this);
            if (this.addressToClientBuildMap is not null)
            {
                this.accountService.DeleteAddressToClientBuildMap(this.addressToClientBuildMap);
            }
            if (!this.accountService.DeleteSession(this.Identifier))
            {
                this.logger.LogError($"Could not remove session \"{this.Identifier}\"");
            }
        }
    }
}
