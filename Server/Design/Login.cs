
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class Login : Form
    {

        private static readonly string
            name = "";

        private static readonly string
            pegaid = "";
        private static readonly string
            pegmystic =
                "";

        private static readonly string version = "4.2";


        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public string User = string.Empty;
        public string Pass = string.Empty;
        public string Keys = string.Empty;
        private void Login_Load(object sender, EventArgs e)
        {

            this.password.UseSystemPasswordChar = true;

            if (File.Exists(Application.StartupPath + @"\Configuration\LoginRememberMe.ini"))
            {
                chkSave.Checked = true;
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Configuration\LoginRememberMe.ini"))
                {
                    string contents = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(contents))
                    {
                        string decrypted =
                            File.ReadAllText(Application.StartupPath + @"\Configuration\LoginRememberMe.ini");

                        User = decrypted.Split('|')[0];
                        Pass = decrypted.Split('|')[1];

                        username.Text = User;
                        password.Text = Pass;
                        sr.Dispose();


                    }




                }
                //Thread.Sleep(7000);
                LoginBtn.PerformClick();
                // LoginBtn.PerformClick();


            }
            else if (File.Exists(Application.StartupPath + @"\Configuration\Key.ini"))
            {
                chkSave.Checked = true;
                using (StreamReader sr = new StreamReader(Application.StartupPath + @"\Configuration\Key.ini"))
                {
                    string contents = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(contents))
                    {
                        string decrypted =
                            File.ReadAllText(Application.StartupPath + @"\Configuration\Key.ini");

                        User = decrypted.Split('|')[0];
                        Keys = decrypted.Split('|')[1];

                        key.Text = Keys;
                        sr.Dispose();


                    }



                }
                //Thread.Sleep(7000);
                LicBtn.PerformClick();
                //  LicBtn.PerformClick();

            }



        }

       
        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {


            
            




        }

        



       




        }


      
    
   
}