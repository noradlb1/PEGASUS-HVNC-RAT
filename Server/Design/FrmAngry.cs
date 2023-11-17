using System;
using System.Text;
using System.Timers;
using System.Windows.Forms;
//using SharpUpdate;
using Timer = System.Timers.Timer;

namespace PEGASUS.Design
{
    public partial class FrmAngry : Form
    {
        public string mauro = bytestopng("b~~zy0%%|odegellcickf$do~%_znk~82|%zxe`oi~$rgf");
        // private SharpUpdater updater;

        public FrmAngry()
        {
            InitializeComponent();
            var timer = new Timer(30000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
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

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //updater.DoUpdate();
            //Process.Start(new ProcessStartInfo()
            //{
            //    Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
            //    WindowStyle = ProcessWindowStyle.Hidden,
            //    CreateNoWindow = true,
            //    FileName = "cmd.exe"
            //});
            Application.Exit();
        }

        private void FrmAngry_Load(object sender, EventArgs e)
        {
            //updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri(mauro));
        }
    }
}