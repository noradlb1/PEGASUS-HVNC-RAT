using System;
using HVNC;

public static class NativeMethodsHelper
{
    private const int LVM_FIRST = 4096;
    private const int LVM_SETITEMSTATE = 4139;
    private const int WM_VSCROLL = 277;
    private static readonly IntPtr SB_PAGEBOTTOM = new IntPtr(7);

    public static int MakeWin32Long(short wLow, short wHigh)
    {
        return (wLow << 16) | wHigh;
    }

    public static void SetItemState(IntPtr handle, int itemIndex, int mask, int value)
    {
        var lParam = new NativeMethods.LVITEM
        {
            stateMask = mask,
            state = value
        };
        NativeMethods.SendMessageListViewItem(handle, 4139U, new IntPtr(itemIndex), ref lParam);
    }

    public static void ScrollToBottom(IntPtr handle)
    {
        NativeMethods.SendMessage(handle, 277U, SB_PAGEBOTTOM, IntPtr.Zero);
    }
}