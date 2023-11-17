using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmWebHookSPM : Form
    {
        public bool IsOK;
        public FrmWebHookSPM()
        {
            InitializeComponent();
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

        private void btnExec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtHook.Text) && !string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.hook = txtHook.Text;
                Properties.Settings.Default.message = txtMessage.Text;
                Properties.Settings.Default.times = Convert.ToInt32(txtTimes.Text);
                Properties.Settings.Default.Save();
                IsOK = false;
                Hide();
                //this.Close();
            }
        }

        private void FrmWebHookSPM_Load(object sender, EventArgs e)
        {
            try
            {
                txtHook.Text = Properties.Settings.Default.hook;
                txtMessage.Text = Properties.Settings.Default.message; 
                txtTimes.Text = Convert.ToString(Properties.Settings.Default.times);
            }
            catch
            {
            }
        }
    }
}