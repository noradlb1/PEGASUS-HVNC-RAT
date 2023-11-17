using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Handle
{
	public class PlatformInvokeGDI32
	{
		public struct RGBQUAD
		{
			public int rgbBlue;

			public int rgbGreen;

			public int rgbRed;

			public int rgbReserved;
		}

		public struct BITMAPINFOHEADER
		{
			public uint biSize;

			public int biWidth;

			public int biHeight;

			public ushort biPlanes;

			public ushort biBitCount;

			public uint biCompression;

			public uint biSizeImage;

			public int biXPelsPerMeter;

			public int biYPelsPerMeter;

			public uint biClrUsed;

			public uint biClrImportant;
		}

		public struct BITMAPINFO
		{
			public BITMAPINFOHEADER bmiHeader;

			public RGBQUAD bmiColors;
		}

		public const int DIB_RGB_COLORS = 0;

		public const int SRCCOPY = 13369376;

		public const int SRCAND = 8913094;

		public const int BI_RGB = 0;

		public const int GDI_ERROR = -1;

		public const int HALFTONE = 4;

		[DllImport("gdi32.dll")]
		public static extern int StretchDIBits(IntPtr hdc, int XDest, int YDest, int nDestWidth, int nDestHeight, int XSrc, int YSrc, int nSrcWidth, int nSrcHeight, byte[] lpBits, [In] ref BITMAPINFO lpBitsInfo, uint iUsage, uint dwRop);

		[DllImport("gdi32.dll")]
		public static extern IntPtr DeleteDC(IntPtr hDc);

		[DllImport("gdi32.dll")]
		public static extern IntPtr DeleteObject(IntPtr hDc);

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, int RasterOp);

		[DllImport("GDI32.DLL", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern bool StretchBlt(IntPtr hdcDest, int nXDest, int nYDest, int nDestWidth, int nDestHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int nSrcWidth, int nSrcHeight, int dwRop);

		[DllImport("gdi32.dll")]
		public static extern int SetStretchBltMode(IntPtr hdc, int iStretchMode);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hdc);

		[DllImport("gdi32.dll")]
		public static extern int GetDIBits([In] IntPtr hdc, [In] IntPtr hbmp, uint uStartScan, uint cScanLines, [Out] IntPtr lpvBits, ref BITMAPINFO lpbi, uint uUsage);

		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
	}
}
