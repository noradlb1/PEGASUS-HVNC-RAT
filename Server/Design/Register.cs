
using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private static readonly string
            name = info("");
        private static readonly string
            pegaid = info("");
        private static readonly string
            pegmystic =
                "";
        private static readonly string version = "4.2";
   
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            var f1 = new Splashes();
            f1.ShowDialog();
        }

     
    }
}