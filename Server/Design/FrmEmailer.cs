using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmEmailer : Form
    {
        public FrmEmailer()
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

        private void FrmEmailer_Load(object sender, EventArgs e)
        {
            txtfromEmail.Text = Properties.Settings.Default.txtfromEmail;
            txttoEmail.Text = Properties.Settings.Default.txttoEmail;
            txtPassword.Text = Properties.Settings.Default.txtemailPass;
            txtBody.Text = Properties.Settings.Default.txtBody;
            txtsubject.Text = Properties.Settings.Default.txtSubject;
            txtEmailPort.Text = Properties.Settings.Default.emailport;
            txtHost.Text = Properties.Settings.Default.Host;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtfromEmail.Text) && !string.IsNullOrWhiteSpace(txttoEmail.Text) &&
                !string.IsNullOrWhiteSpace(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtsubject.Text) &&
                !string.IsNullOrWhiteSpace(txtBody.Text) && !string.IsNullOrWhiteSpace(txtEmailPort.Text) &&
                !string.IsNullOrWhiteSpace(txtHost.Text))
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.txtfromEmail = txtfromEmail.Text;
                Properties.Settings.Default.txttoEmail = txttoEmail.Text;
                Properties.Settings.Default.txtemailPass = txtPassword.Text;
                Properties.Settings.Default.txtBody = txtBody.Text;
                Properties.Settings.Default.txtSubject = txtsubject.Text;
                Properties.Settings.Default.emailport = txtEmailPort.Text;
                Properties.Settings.Default.Host = txtHost.Text;
                Properties.Settings.Default.Save();
                Hide();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}