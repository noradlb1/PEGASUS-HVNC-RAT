using PEGASUS.IcarusWings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PEGASUS.Design
{
    public partial class FrmKATANA : Form
    {
        public FrmKATANA()
        {
            InitializeComponent();
        }

        private void SetLastColumnWidth()
        {
            // Force the last ListView column width to occupy all the
            // available space.
            aeroListView1.Columns[aeroListView1.Columns.Count - 1].Width = -2;
        }

        private void FrmKATANA_Load(object sender, EventArgs e)
        {
            ListviewDoubleBuffer.Enable(aeroListView1);

            aeroListView1.Columns[1].TextAlign = HorizontalAlignment.Center;
            aeroListView1.Columns[2].TextAlign = HorizontalAlignment.Center;

            SetLastColumnWidth();

            aeroListView1.Layout += delegate { SetLastColumnWidth(); };
            aeroListView1.View = View.Details;
            aeroListView1.HideSelection = false;
            aeroListView1.OwnerDraw = true;
            aeroListView1.GridLines = false;

            aeroListView1.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
            aeroListView1.DrawColumnHeader += (sender1, args) =>
            {
                Brush brush = new SolidBrush(Color.FromArgb(25, 27, 38));
                args.Graphics.FillRectangle(brush, args.Bounds);
                TextRenderer.DrawText(args.Graphics, args.Header.Text, args.Font, args.Bounds, Color.WhiteSmoke);
            };
            aeroListView1.DrawItem += (sender1, args) => args.DrawDefault = true;
            aeroListView1.DrawSubItem += (sender1, args) => args.DrawDefault = true;
        }

        private void exstractOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem70_Click(object sender, EventArgs e)
        {
        }
    }
}