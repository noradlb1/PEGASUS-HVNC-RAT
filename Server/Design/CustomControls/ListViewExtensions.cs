using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PEGASUS.Forms.CustomControls
{
    public static class ListViewExtensions
    {
        // Make the ListView's column headers.
        // The ParamArray entries should alternate between
        // strings and HorizontalAlignment values.
        public static void MakeColumnHeaders(
            this ListView lvw, params object[] header_info)
        {
            // Remove any existing headers.
            lvw.Columns.Clear();

            // Make the column headers.
            for (var i = header_info.GetLowerBound(0);
                 i <= header_info.GetUpperBound(0);
                 i += 3)
                lvw.Columns.Add(
                    (string) header_info[i],
                    (int) header_info[i + 1],
                    (HorizontalAlignment) header_info[i + 2]);
        }

        // Add a row to the ListView.
        public static void AddRow(this ListView lvw,
            string item_title, params string[] subitem_titles)
        {
            // Make the item.
            var new_item = lvw.Items.Add(item_title, 1);

            // Make the sub-items.
            for (var i = subitem_titles.GetLowerBound(0);
                 i <= subitem_titles.GetUpperBound(0);
                 i++)
                new_item.SubItems.Add(subitem_titles[i]);
        }

        // Make the ListView display sub-item icons.
        public static void ShowSubItemIcons(this ListView lvw, bool show)
        {
            // Get the current style.
            var style = SendMessage(lvw.Handle,
                LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0);

            // Show or hide sub-item icons.
            if (show) style |= LVS_EX_SUBITEMIMAGES;
            else style &= ~LVS_EX_SUBITEMIMAGES;

            SendMessage(lvw.Handle,
                LVM_SETEXTENDEDLISTVIEWSTYLE, 0, style);
        }

        // Add an icon to a subitem.
        public static void AddIconToSubitem(this ListView lvw, int row, int col, int icon_num)
        {
            var lvi = new LV_ITEM();
            lvi.iItem = row; // Row.
            lvi.iSubItem = col; // Column.
            lvi.uiMask = LVIF_IMAGE; // We're setting the image.
            lvi.iImage = icon_num; // The image index in the ImageList.

            // Send the LVM_SETITEM message.
            SendMessage(lvw.Handle, LVM_SETITEM, 0, ref lvi);
        }

        #region "API Stuff"

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, ref LV_ITEM item_info);

        private struct LV_ITEM
        {
            public uint uiMask;
            public int iItem;
            public int iSubItem;
            public uint uiState;
            public uint uiStateMask;
            public string pszText;
            public int cchTextMax;
            public int iImage;
            public IntPtr lParam;
        }

        public const int LVM_FIRST = 0x1000;
        public const int LVM_SETITEM = LVM_FIRST + 6;
        public const int LVIF_IMAGE = 0x2;

        public const int LVW_FIRST = 0x1000;
        public const int LVM_SETEXTENDEDLISTVIEWSTYLE = LVW_FIRST + 54;
        public const int LVM_GETEXTENDEDLISTVIEWSTYLE = LVW_FIRST + 55;

        public const int LVS_EX_SUBITEMIMAGES = 0x2;

        #endregion "API Stuff"
    }
}