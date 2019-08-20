using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Classic.Common
{
    public abstract class ClientBase
    {
        protected bool isConnected; // TODO: Replace with cancellationtoken
        private readonly NetworkStream stream;

        public ClientBase(TcpClient client)
        {
            this.stream = client.GetStream();
            this.isConnected = true;
            var endPoint = (IPEndPoint)client.Client.RemoteEndPoint;
            this.ClientInfo = endPoint.Address + ":" + endPoint.Port;
        }

        public string ClientInfo { get; }

        public async Task HandleConnection()
        {
            while (this.isConnected)
            {
                // TODO try catch
                // Biggest package seen so far was 1190 bytes in length
                var buffer = new byte[2048];
                var length = await this.stream.ReadAsync(buffer, 0, buffer.Length);

                if (length == 0)
                {
                    this.Log($"-- disconnected");
                    this.isConnected = false;
                    break;
                }

                // Do not await
                _ = this.HandlePacket(buffer.Take(length).ToArray());
            }

            OnDisconnected();
        }

        public async Task Send(byte[] data)
        {
            if (!this.isConnected)
                throw new InvalidOperationException($"Client {this.ClientInfo} is not connected.");

            await this.stream.WriteAsync(data, 0, data.Length);
        }

        public void Log(string message)
        {
            Logger.Log($"[{this.ClientInfo}] [{this.GetType().Name}] " + message);
        }

        // Todo change to abstract later
        protected virtual void OnDisconnected() { }

        protected void LogPacket(byte[] packet)
        {
            this.Log($"Packet received {packet.Length} bytes");
        }

        protected abstract Task HandlePacket(byte[] packet);
    }
}