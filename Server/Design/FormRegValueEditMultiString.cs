using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PEGASUS.IcarusWings;
using static PEGASUS.IcarusWings.RegistrySeeker;

namespace PEGASUS.Design
{
    public partial class FormRegValueEditMultiString : Form
    {
        private readonly RegValueData _value;

        public FormRegValueEditMultiString(RegValueData value)
        {
            _value = value;

            InitializeComponent();

            valueNameTxtBox.Text = value.Name;
            valueDataTxtBox.Text = string.Join("\r\n", ByteConverter.ToStringArray(value.Data));
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _value.Data =
                ByteConverter.GetBytes(
                    valueDataTxtBox.Text.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries));
            Tag = _value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}