using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/w2hVN45E");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            MsgBox.Show("SkynetCorporation@protonmail.com");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCd6mDeM9gLKOMlbUGynEUbQ");
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pantheon.one/");
        }

        private void guna2PictureBox4_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://t.me/joinchat/Izuv0GvwIOU3ZTNk");
        }

        private void guna2PictureBox7_Click(object sender, EventArgs e)
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

        private static string reupload(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }

        public static void DeleteDirectory(string target_dir)
        {
            var files = Directory.GetFiles(target_dir);
            var dirs = Directory.GetDirectories(target_dir);

            foreach (var file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (var dir in dirs) DeleteDirectory(dir);

            Directory.Delete(target_dir, false);
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Close();
            /*
            if (File.Exists(Application.StartupPath + @"\Plugins"))
            {

                DeleteDirectory(Application.StartupPath + @"\Plugins");
            }
            */
            //ABC.abgd(reupload("ZOMKY_YL_FF"), reupload("82:<??"), "3xiUwGhkAtLTJwExKH00BLkC89apvFTwypK", reupload(";$:$:$>"));//;$:$:$>skynet 1.0.0.4
            //using (FormPorts portsFrm = new FormPorts())
            ///{
            //    portsFrm.ShowDialog();
            //}
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
        }

        private void btnIcon_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/+Izuv0GvwIOU3ZTNk");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pantheon.one/");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCd6mDeM9gLKOMlbUGynEUbQ");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://skynetcorp.sellix.io/");
        }
    }
}