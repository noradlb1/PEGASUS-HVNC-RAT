using System.Drawing;
using System.Windows.Forms;

namespace PEGASUS.Design.CustomControls
{
    internal class TabControlEx : TabControl
    {
        private Color active_color1 = Color.FromArgb(80, 80, 80);
        private Color active_color2 = Color.FromArgb(40, 40, 40);
        private int angle = 90;
        private int color1Transparent = 220;
        private int color2Transparent = 220;
        public Color forecolor = Color.White;
        private Color nonactive_color1 = Color.FromArgb(60, 60, 60);
        private Color nonactive_color2 = System.Drawing.Color.FromArgb(25, 27, 38);

        public TabControlEx()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Padding = new Point(22, 4);
            Alignment = TabAlignment.Bottom;
        }

        public Color ActiveTabStartColor
        {
            get => active_color1;
            set
            {
                active_color1 = value;
                Invalidate();
            }
        }

        public Color ActiveTabEndColor
        {
            get => active_color2;
            set
            {
                active_color2 = value;
                Invalidate();
            }
        }

        public Color NonActiveTabStartColor
        {
            get => nonactive_color1;
            set
            {
                nonactive_color1 = value;
                Invalidate();
            }
        }

        public Color NonActiveTabEndColor
        {
            get => nonactive_color2;
            set
            {
                nonactive_color2 = value;
                Invalidate();
            }
        }

        public int Transparent1
        {
            get => color1Transparent;
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                {
                    Invalidate();
                }
            }
        }

        public int Transparent2
        {
            get => color2Transparent;
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                {
                    Invalidate();
                }
            }
        }

        public int GradientAngle
        {
            get => angle;
            set
            {
                angle = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => forecolor;
            set
            {
                forecolor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var rc = pe.ClipRectangle;
            var br = new SolidBrush(Color.FromArgb(25, 27, 38));
            pe.Graphics.FillRectangle(br, rc);
            base.OnPaint(pe);
        }

        //method for drawing tab items 
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            var rc = GetTabRect(e.Index);
/*kki
            if (this.SelectedTab == this.TabPages[e.Index])
            {
                Color c1 = Color.FromArgb(color1Transparent, active_color1);
                Color c2 = Color.FromArgb(color2Transparent, active_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
            else
            {
                Color c1 = Color.FromArgb(color1Transparent, nonactive_color1);
                Color c2 = Color.FromArgb(color2Transparent, nonactive_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
*/
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(54, 193, 214)), rc);
            TabPages[e.Index].BorderStyle = BorderStyle.None;
            TabPages[e.Index].ForeColor = SystemColors.ControlText;

            var paddedBounds = new Rectangle(e.Bounds.Left + 15, e.Bounds.Top + 5, e.Bounds.Width, e.Bounds.Height);

            e.Graphics.DrawString(TabPages[e.Index].Text, Font, new SolidBrush(forecolor), paddedBounds);

            var r = GetTabRect(TabPages.Count - 1);
            var tf = new RectangleF(r.X + r.Width, r.Y - 5, Width - (r.X + r.Width), r.Height + 7);
            Brush b = new SolidBrush(Color.FromArgb(54, 193, 214));
            e.Graphics.FillRectangle(b, tf);

            var tf1 = new RectangleF(Width - 4, 1, 1, Height - r.Height - 8);
            var tf2 = new RectangleF(r.X + r.Width, r.Y - 5, Width - (r.X + r.Width), 4);
            Brush b2 = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(b2, tf1);
            e.Graphics.FillRectangle(b2, tf2);

            e.DrawFocusRectangle();
        }
    }
}