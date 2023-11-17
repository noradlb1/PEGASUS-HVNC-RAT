using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PEGASUS
{
    public partial class VNCForm : Form
    {
        private const int StartExplorer = 0x401;
        private const int StartRun = 0x402;
        private const int StartChrome = 0x403;
        private const int StartEdge = 0x404;
        private const int StartBrave = 0x405;
        private const int StartFirefox = 0x406;
        private const int StartIexplore = 0x407;
        private const int StartPowershell = 0x408;
        private const int StartPalemoon = 0x409;
        private const int StartWaterfox = 0x40A;
        private const int StartOpera = 0x40B;
        private const int Start360 = 0x40C;
        private const int StartComodo = 0x40D;
        private const int StartNeon = 0x40F;

     

        public VNCForm()
        {
            InitializeComponent();
        }

      

        private void NewClient(object sender, EventArgs arg)
        {
            // 
#pragma warning disable CS0219 // The variable 'x' is assigned but its value is never used
            var x = 1;
#pragma warning restore CS0219 // The variable 'x' is assigned but its value is never used
        }

        private void OnDisconnected(object sender, int uhid)
        {
            //server.StopServer();
            //Thread.Sleep(1000);
            //Invoke(new EventHandler(StartNewServer), new object[]{this, null}); 
        }

        private void OnConnected(object sender, int uhid)
        {
            Invoke(new EventHandler(NewClient), new object[] { this, null });
        }

        private void VNCForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


     

      


      

     
     
     
    

        //private ushort GetPortSafe()
        //{
        // var portValue = numPort.Value.ToString(CultureInfo.InvariantCulture);
        // ushort port;
        // return (!ushort.TryParse(portValue, out port)) ? (ushort)0 : port;
        // }
    

       

        #region TASKS

      



        #endregion
    }
}