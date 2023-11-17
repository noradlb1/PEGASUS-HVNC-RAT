using System.Windows.Forms;
using static PEGASUS.IcarusWings.RegistrySeeker;

namespace PEGASUS.IcarusWings
{
    public class RegistryValueLstItem : ListViewItem
    {
        public RegistryValueLstItem(RegValueData value)
        {
            RegName = value.Name;
            Type = value.Kind.RegistryTypeToString();
            Data = RegValueHelper.RegistryValueToString(value);
        }

        private string _type { get; set; }
        private string _data { get; set; }

        public string RegName
        {
            get => Name;
            set
            {
                Name = value;
                Text = RegValueHelper.GetName(value);
            }
        }

        public string Type
        {
            get => _type;
            set
            {
                _type = value;

                if (SubItems.Count < 2)
                    SubItems.Add(_type);
                else
                    SubItems[1].Text = _type;

                ImageIndex = GetRegistryValueImgIndex(_type);
            }
        }

        public string Data
        {
            get => _data;
            set
            {
                _data = value;

                if (SubItems.Count < 3)
                    SubItems.Add(_data);
                else
                    SubItems[2].Text = _data;
            }
        }

        private int GetRegistryValueImgIndex(string type)
        {
            switch (type)
            {
                case "REG_MULTI_SZ":
                case "REG_SZ":
                case "REG_EXPAND_SZ":
                    return 0;
                case "REG_BINARY":
                case "REG_DWORD":
                case "REG_QWORD":
                default:
                    return 1;
            }
        }
    }
}