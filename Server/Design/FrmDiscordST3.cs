using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmDiscordST3 : Form
    {
        public bool IsOK;

        public FrmDiscordST3()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkDisc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisc.Checked)
                GroupDisc.Enabled = true;
            else
                GroupDisc.Enabled = false;
        }

        private void chkTel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTel.Checked)
                GroupTel.Enabled = true;
            else
                GroupTel.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (chkDisc.Checked)
            {
                Properties.Settings.Default.WebHook = txtWebHook.Text;
                Properties.Settings.Default.Save();
                if (IsOK)
                    Hide();
            }
            else if (chkTel.Checked)
            {
                Properties.Settings.Default.TelAPI = txtTelApi.Text;
                Properties.Settings.Default.TelID = txtTelID.Text;
                Properties.Settings.Default.Save();
                if (IsOK)
                    Hide();
            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsOK = false;
            Hide();
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

        private void FrmDiscordST3_Load(object sender, EventArgs e)
        {
            txtTelApi.Text = Properties.Settings.Default.TelAPI;
            txtTelID.Text = Properties.Settings.Default.TelID;
        }
    }
}