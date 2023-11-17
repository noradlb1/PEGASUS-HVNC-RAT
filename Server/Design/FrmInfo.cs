using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmInfo : Form
    {
        public FrmInfo(string path)
        {
            InitializeComponent();
            var result = File.ReadAllText(path);
            textBox1.Text = result;
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
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