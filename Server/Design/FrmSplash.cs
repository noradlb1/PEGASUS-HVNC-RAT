using System;
using System.Windows.Forms;
using PEGASUS.Design;

namespace PEGASUS
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                var frml = new Splashes();
                frml.Show();
                frml.FormClosing += (obj, args) => { Close(); };
                Hide();
            }
        }
    }
}