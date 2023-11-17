using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormBlockClients : Form
    {
        public FormBlockClients()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                listBlocked.Items.Add(txtBlock.Text);
                txtBlock.Clear();
            }
            catch
            {
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                for (var i = listBlocked.SelectedIndices.Count - 1; i >= 0; i--)
                    listBlocked.Items.RemoveAt(listBlocked.SelectedIndices[i]);
            }
            catch
            {
            }
        }

        private void FormBlockClients_Load(object sender, EventArgs e)
        {
            try
            {
                listBlocked.Items.Clear();
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.txtBlocked))
                    foreach (var client in Properties.Settings.Default.txtBlocked.Split(','))
                        if (!string.IsNullOrWhiteSpace(client))
                            listBlocked.Items.Add(client);
            }
            catch
            {
            }
        }

        private void FormBlockClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                lock (Settings.Blocked)
                {
                    Settings.Blocked.Clear();
                    var clients = new List<string>();
                    foreach (string client in listBlocked.Items)
                    {
                        clients.Add(client);
                        Settings.Blocked.Add(client);
                    }

                    Properties.Settings.Default.txtBlocked = string.Join(",", clients);
                    Properties.Settings.Default.Save();
                }
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