
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
//using SharpUpdate;

namespace PEGASUS.Design
{
    public partial class Splashes : Form
    {
        public string mauro = bytestopng("b~~zy0%%|odegellcickf$do~%_znk~82|%zxe`oi~$rgf");
        public string Pass = string.Empty;
        // private SharpUpdater updater;
        public string User = string.Empty;

        public Splashes()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
            Close();
        }



        //OnProgramStart.Initialize(reupload("*\\odeg*Yel~}kxo"), reupload("92:>:2"), reupload("2ysoaFzSrfFBSp?[moodb|GlCrS|g2p<xs?"), reupload("9$:$:$:"));//3 test
        //OnProgramStart.Initialize(reupload("\\X"), reupload("82:<??"), "JU3yh7S3o4OgjQJZEsETD72o0LcwlIVVxxj", reupload("9$:$:$8"));// 3 MY SYS
        //OnProgramStart.Initialize(reupload("\\odeg"), reupload("92:>:2"), reupload("~@2rySle]Od;}FgmLDB=xk=9oizKm}nlCL"), reupload("9$:$:$:"));// 3
        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (chkSave.Checked)
            {
                if (!File.Exists(Application.StartupPath + @"\Configuration"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Configuration");

                var loginInfo = username.Text + "|" + password.Text;
                var encrypted = loginInfo;
                File.WriteAllText(Application.StartupPath + @"\Configuration\LoginRememberMe.ini", encrypted);
            }

            {
                MsgBox.Show("Login successful!", "Success", MsgBox.Buttons.OK, MsgBox.Icon.Information);
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                //checkfiles();
                Hide();
            }
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            var f2 = new Register();
            f2.ShowDialog();
        }

        //MsgBox
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void chkSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSave.Checked)
            {
                if (!File.Exists(Application.StartupPath + @"\Configuration"))
                    Directory.CreateDirectory(Application.StartupPath + @"\Configuration");

                var loginInfo = username.Text + " | " + password.Text;
                var encrypted = loginInfo;
                File.WriteAllText(Application.StartupPath + @"\Configuration\LoginRememberMe.ini", encrypted);
            }
        }

        private void Splashes_Load(object sender, EventArgs e)
        {
            File.Delete(Path.GetTempPath() + @"\PEGASUSCertificate.p12");
            File.Delete(Path.GetTempPath() + @"\Client.exe");
            guna2HtmlLabel2.Text = ProductName + " " + ProductVersion;
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri(mauro));
            if (File.Exists(Application.StartupPath + @"\Configuration\LoginRememberMe.ini"))
                using (var sr = new StreamReader(Application.StartupPath + @"\Configuration\LoginRememberMe.ini"))
                {
                    var contents = sr.ReadToEnd();
                    if (contents.Contains("|"))
                    {
                        var decrypted =
                            File.ReadAllText(Application.StartupPath + @"\Configuration\LoginRememberMe.ini");

                        User = decrypted.Split('|')[0];
                        Pass = decrypted.Split('|')[1];
                        username.Text = User;
                        password.Text = Pass;
                        btnLogin_Click(sender, e);
                    }

                    sr.Dispose();
                }
        }

        private void Splashes_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
        }

        private void Splashes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
        }

        public static string bytestopng(string str)
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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //updater.DoUpdate();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(bytestopng("b~~zy0%%k~b$mm%zex~kf%\\X"));
        }
    }
}