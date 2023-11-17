using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                if (textBox1.Text == null || textBox2.Text == null)
                    MessageBox.Show("Input the WebHook and secret");
            Properties.Settings.Default.DingDing = checkBox1.Checked;

            Properties.Settings.Default.WebHook = textBox1.Text;

            Properties.Settings.Default.Secret = textBox2.Text;

            Properties.Settings.Default.Save();

            Close();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.DingDing;

            textBox1.Text = Properties.Settings.Default.WebHook;

            textBox2.Text = Properties.Settings.Default.Secret;
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