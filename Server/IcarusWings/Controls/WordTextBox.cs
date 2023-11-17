using System;
using System.Globalization;
using System.Windows.Forms;

namespace PEGASUS.IcarusWings
{
    public partial class WordTextBox : TextBox
    {
        public enum WordType
        {
            DWORD,
            QWORD
        }

        private bool isHexNumber;
        private WordType type;

        public WordTextBox()
        {
            InitializeComponent();
            base.MaxLength = 8;
        }

        public override int MaxLength
        {
            get => base.MaxLength;
            set { }
        }

        public bool IsHexNumber
        {
            get => isHexNumber;
            set
            {
                if (isHexNumber == value)
                    return;

                if (value)
                {
                    if (Type == WordType.DWORD)
                        Text = UIntValue.ToString("x");
                    else
                        Text = ULongValue.ToString("x");
                }
                else
                {
                    if (Type == WordType.DWORD)
                        Text = UIntValue.ToString();
                    else
                        Text = ULongValue.ToString();
                }

                isHexNumber = value;

                UpdateMaxLength();
            }
        }

        public WordType Type
        {
            get => type;
            set
            {
                if (type == value)
                    return;

                type = value;

                UpdateMaxLength();
            }
        }

        public uint UIntValue
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(Text))
                        return 0;
                    if (IsHexNumber)
                        return uint.Parse(Text, NumberStyles.HexNumber);
                    return uint.Parse(Text);
                }
                catch (Exception)
                {
                    return uint.MaxValue;
                }
            }
        }

        public ulong ULongValue
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(Text))
                        return 0;
                    if (IsHexNumber)
                        return ulong.Parse(Text, NumberStyles.HexNumber);
                    return ulong.Parse(Text);
                }
                catch (Exception)
                {
                    return ulong.MaxValue;
                }
            }
        }

        public bool IsConversionValid()
        {
            if (string.IsNullOrEmpty(Text))
                return true;

            if (!IsHexNumber) return ConvertToHex();
            return true;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !IsValidChar(e.KeyChar);
        }

        private bool IsValidChar(char ch)
        {
            return char.IsControl(ch) ||
                   char.IsDigit(ch) ||
                   IsHexNumber && char.IsLetter(ch) && char.ToLower(ch) <= 'f';
        }

        private void UpdateMaxLength()
        {
            if (Type == WordType.DWORD)
            {
                if (IsHexNumber)
                    base.MaxLength = 8;
                else
                    base.MaxLength = 10;
            }
            else
            {
                if (IsHexNumber)
                    base.MaxLength = 16;
                else
                    base.MaxLength = 20;
            }
        }


        private bool ConvertToHex()
        {
            try
            {
                if (Type == WordType.DWORD)
                    uint.Parse(Text);
                else
                    ulong.Parse(Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}