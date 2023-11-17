using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FormProcessManager : Form
    {
        public FormProcessManager()
        {
            InitializeComponent();
        }

        public PEGALISIUS F { get; set; }
        internal Clients Client { get; set; }
        internal Clients ParentClient { get; set; }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Client.TcpClient.Connected || !ParentClient.TcpClient.Connected) Close();
            }
            catch
            {
                Close();
            }
        }

        private async void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (ListViewItem P in listView1.SelectedItems)
                    await Task.Run(() =>
                    {
                        var msgpack = new MsgPack();
                        msgpack.ForcePathObject("Pac_ket").AsString = "processManager";
                        msgpack.ForcePathObject("Option").AsString = "Kill";
                        msgpack.ForcePathObject("ID").AsString = P.SubItems[lv_id.Index].Text;
                        ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
                    });
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(o =>
            {
                var msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "processManager";
                msgpack.ForcePathObject("Option").AsString = "List";
                ThreadPool.QueueUserWorkItem(Client.Send, msgpack.Encode2Bytes());
            });
        }

        private void FormProcessManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(o => { Client?.Disconnected(); });
            }
            catch
            {
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
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

        private void SetLastColumnWidth()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            listView1.Columns[listView1.Columns.Count - 1].Width = -2;
        }

        private void FormProcessManager_Load(object sender, EventArgs e)
        {
            SetLastColumnWidth();

            listView1.Layout += delegate { SetLastColumnWidth(); };
            listView1.View = View.Details;
            listView1.HideSelection = false;
            listView1.OwnerDraw = true;
            listView1.GridLines = false;

            listView1.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
            listView1.DrawColumnHeader += (sender1, args) =>
            {
                Brush brush = new SolidBrush(Color.FromArgb(25, 27, 38));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            };
            listView1.DrawItem += (sender1, args) => args.DrawDefault = true;
            listView1.DrawSubItem += (sender1, args) => args.DrawDefault = true;
        }
    }
}