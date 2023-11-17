using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEGASUS.IcarusWings
{
    public static class Methods
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        private const int LVM_FIRST = 0x1000;
        private const int LVM_SETITEMSTATE = LVM_FIRST + 43;

        private const int WM_VSCROLL = 277;
        public static Random Random = new Random();
        private static readonly IntPtr SB_PAGEBOTTOM = new IntPtr(7);

        public static string BytesToString(long byteCount)
        {
            string[] suf = {"B", "KB", "MB", "GB", "TB", "PB", "EB"};
            if (byteCount == 0)
                return "0" + suf[0];
            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return Math.Sign(byteCount) * num + suf[place];
        }

        public static async Task FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
        }

        public static double DiffSeconds(DateTime startTime, DateTime endTime)
        {
            var secondSpan = new TimeSpan(endTime.Ticks - startTime.Ticks);
            return Math.Abs(secondSpan.TotalSeconds);
        }

        public static string GetRandomString(int length)
        {
            var randomName = new StringBuilder(length);
            for (var i = 0; i < length; i++)
                randomName.Append(Alphabet[Random.Next(Alphabet.Length)]);

            return randomName.ToString();
        }

        public static int MakeWin32Long(short wLow, short wHigh)
        {
            return (wLow << 16) | wHigh;
        }

        public static void SetItemState(IntPtr handle, int itemIndex, int mask, int value)
        {
            var lvItem = new NativeMethods.LVITEM
            {
                stateMask = mask,
                state = value
            };

            NativeMethods.SendMessageListViewItem(handle, LVM_SETITEMSTATE, new IntPtr(itemIndex), ref lvItem);
        }

        public static void ScrollToBottom(IntPtr handle)
        {
            NativeMethods.SendMessage(handle, WM_VSCROLL, SB_PAGEBOTTOM, IntPtr.Zero);
        }
    }


    public static class NativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        internal static extern IntPtr SendMessageListViewItem(IntPtr hWnd, uint msg, IntPtr wParam, ref LVITEM lParam);

        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);

        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        internal static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct LVITEM
        {
            public uint mask;
            public int iItem;
            public int iSubItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)] public string pszText;
            public int cchTextMax;
            public int iImage;
            public IntPtr lParam;
            public int iIndent;
            public int iGroupId;
            public uint cColumns;
            public IntPtr puColumns;
            public IntPtr piColFmt;
            public int iGroup;
        }
    }
}