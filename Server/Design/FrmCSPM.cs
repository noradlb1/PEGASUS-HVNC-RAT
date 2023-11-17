using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmCSPM : Form
    {
        public FrmCSPM()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.message = txtMessage.Text;
                Properties.Settings.Default.Save();
                Hide();
            }
        }

        private void FrmCSPM_Load(object sender, EventArgs e)
        {
            try
            {
                txtMessage.Text = Properties.Settings.Default.message;
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
    }
}