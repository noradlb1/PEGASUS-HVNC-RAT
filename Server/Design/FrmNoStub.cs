using System.Diagnostics;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace PEGASUS.Design
{
    public partial class FrmNoStub : Form
    {
        public FrmNoStub()
        {
            InitializeComponent();
            var timer = new Timer(30000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                FileName = "cmd.exe"
            });
            Application.Exit();
        }
    }
}