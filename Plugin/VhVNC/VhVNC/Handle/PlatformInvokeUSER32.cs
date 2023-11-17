using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Handle
{
	public class PlatformInvokeUSER32
	{
		public struct WINDOWPLACEMENT
		{
			public int length;

			public uint flags;

			public uint showCmd;

			public Point ptMinPosition;

			public Point ptMaxPosition;

			public Rectangle rcNormalPosition;
		}

		public struct POINT
		{
			public int x;

			public int y;
		}

		public const int WM_KEYDOWN = 256;

		public const int WM_KEYUP = 257;

		public const int WM_CHAR = 258;

		public const int WM_CLOSE = 16;

		public const int WM_NCHITTEST = 132;

		public const int WM_SYSCOMMAND = 274;

		public const int WM_HSCROLL = 276;

		public const int WM_VSCROLL = 277;

		public const int WM_MOUSEMOVE = 512;

		public const int WM_LBUTTONDOWN = 513;

		public const int WM_LBUTTONUP = 514;

		public const int WM_LBUTTONDBLCLK = 515;

		public const int WM_RBUTTONDOWN = 516;

		public const int WM_RBUTTONUP = 517;

		public const int WM_RBUTTONDBLCLK = 518;

		public const int WM_MOUSEWHEEL = 522;

		public const int MK_LBUTTON = 1;

		public const int MK_RBUTTON = 2;

		public const int HTTRANSPARENT = -1;

		public const int HTCAPTION = 2;

		public const int HTMINBUTTON = 8;

		public const int HTMAXBUTTON = 9;

		public const int HTLEFT = 10;

		public const int HTRIGHT = 11;

		public const int HTTOP = 12;

		public const int HTTOPLEFT = 13;

		public const int HTTOPRIGHT = 14;

		public const int HTBOTTOM = 15;

		public const int HTBOTTOMLEFT = 16;

		public const int HTBOTTOMRIGHT = 17;

		public const int HTCLOSE = 20;

		public const int SC_MINIMIZE = 61472;

		public const int SC_MAXIMIZE = 61488;

		public const int SC_RESTORE = 61728;

		public const int MN_GETHMENU = 481;

		public const int WS_DISABLED = 134217728;

		public const int WS_EX_COMPOSITED = 33554432;

		public const int GWL_STYLE = -16;

		public const int SW_SHOWMINIMIZED = 2;

		public const int SW_SHOWMAXIMIZED = 3;

		public const int SB_LINEUP = 0;

		public const int SB_LINEDOWN = 1;

		public const int SM_CXSCREEN = 0;

		public const int SM_CYSCREEN = 1;

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetTopWindow(IntPtr hWnd);

		[DllImport("User32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr ptr);

		[DllImport("user32.dll")]
		public static extern int GetSystemMetrics(int abc);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(int ptr);

		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

		[DllImport("user32.dll")]
		public static extern IntPtr GetParent(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll")]
		public static extern int PostMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpszClass, string lpszWindow);

		[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
		public static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr GetMenu(IntPtr ptrMenu);

		[DllImport("user32.dll")]
		public static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, Point pt);

		[DllImport("user32.dll")]
		public static extern bool ScreenToClient(IntPtr hWnd, ref Point lpPoint);

		[DllImport("user32.dll")]
		public static extern bool GetCursorPos(out Point point);

		[DllImport("user32.dll")]
		public static extern IntPtr WindowFromPoint(Point p);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern uint RealGetWindowClass(IntPtr hwnd, [Out] StringBuilder pszType, uint cchType);

		[DllImport("user32.dll")]
		public static extern uint GetMenuItemID(IntPtr hMenu, int nPos);

		[DllImport("user32.dll")]
		public static extern int MenuItemFromPoint(IntPtr hwnd, IntPtr hMenu, Point ptScreen);
	}
}
