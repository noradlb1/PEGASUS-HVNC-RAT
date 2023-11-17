using System;
using System.Windows.Forms;
using Microsoft.Win32;
using PEGASUS.IcarusWings;
using static PEGASUS.IcarusWings.RegistrySeeker;

namespace PEGASUS.Design
{
    public partial class FormRegValueEditWord : Form
    {
        private const string DWORD_WARNING =
            "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?";

        private const string QWORD_WARNING =
            "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?";

        private readonly RegValueData _value;

        public FormRegValueEditWord(RegValueData value)
        {
            _value = value;

            InitializeComponent();

            valueNameTxtBox.Text = value.Name;

            if (value.Kind == RegistryValueKind.DWord)
            {
                Text = "Edit DWORD (32-bit) Value";
                valueDataTxtBox.Type = WordTextBox.WordType.DWORD;
                valueDataTxtBox.Text = ByteConverter.ToUInt32(value.Data).ToString("x");
            }
            else
            {
                Text = "Edit QWORD (64-bit) Value";
                valueDataTxtBox.Type = WordTextBox.WordType.QWORD;
                valueDataTxtBox.Text = ByteConverter.ToUInt64(value.Data).ToString("x");
            }
        }

        private void radioHex_CheckboxChanged(object sender, EventArgs e)
        {
            if (valueDataTxtBox.IsHexNumber == radioHexa.Checked)
                return;

            if (valueDataTxtBox.IsConversionValid() || IsOverridePossible())
                valueDataTxtBox.IsHexNumber = radioHexa.Checked;
            else
                radioDecimal.Checked = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (valueDataTxtBox.IsConversionValid() || IsOverridePossible())
            {
                _value.Data = _value.Kind == RegistryValueKind.DWord
                    ? ByteConverter.GetBytes(valueDataTxtBox.UIntValue)
                    : ByteConverter.GetBytes(valueDataTxtBox.ULongValue);
                Tag = _value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }

            Close();
        }

        private DialogResult ShowWarning(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private bool IsOverridePossible()
        {
            var message = _value.Kind == RegistryValueKind.DWord ? DWORD_WARNING : QWORD_WARNING;

            return ShowWarning(message, "Overflow") == DialogResult.Yes;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}