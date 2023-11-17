using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmReco : Form
    {
        public FrmReco(string pass, string cookies)
        {
            InitializeComponent();
            var result1 = File.ReadAllText(pass);
            txtPasswords.Text = result1;
            //string result2 = File.ReadAllText(history);
            //txtHistory.Text = result2;
            var result3 = File.ReadAllText(cookies);
            txtCookies.Text = result3;
            //string result4 = File.ReadAllText(bookmarks);
            //txtBookmarks.Text = result4;
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

        private void FrmReco_Load(object sender, EventArgs e)
        {
        }
    }
}