using System;
using System.Text;

namespace PEGASUS.Metafora_Dedomenon
{
    public class BytesTools
    {
        private static readonly UTF8Encoding utf8Encode = new UTF8Encoding();

        public static byte[] GetUtf8Bytes(string s)
        {
            return utf8Encode.GetBytes(s);
        }

        public static string GetString(byte[] utf8Bytes)
        {
            return utf8Encode.GetString(utf8Bytes);
        }

        public static string BytesAsString(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(string.Format("{0:D3} ", b));
            return sb.ToString();
        }


        public static string BytesAsHexString(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(string.Format("{0:X2} ", b));
            return sb.ToString();
        }

        /// <summary>
        ///     交换byte数组数据
        ///     可用于高低数据交换
        /// </summary>
        /// <param name="v">要交换的byte数组</param>
        /// <returns>返回交换后的数据</returns>
        public static byte[] SwapBytes(byte[] v)
        {
            var r = new byte[v.Length];
            var j = v.Length - 1;
            for (var i = 0; i < r.Length; i++)
            {
                r[i] = v[j];
                j--;
            }

            return r;
        }

        public static byte[] SwapInt64(long v)
        {
            //byte[] r = new byte[8];
            //r[7] = (byte)v;
            //r[6] = (byte)(v >> 8);
            //r[5] = (byte)(v >> 16);
            //r[4] = (byte)(v >> 24);
            //r[3] = (byte)(v >> 32);
            //r[2] = (byte)(v >> 40);
            //r[1] = (byte)(v >> 48);
            //r[0] = (byte)(v >> 56);            
            return SwapBytes(BitConverter.GetBytes(v));
        }

        public static byte[] SwapInt32(int v)
        {
            var r = new byte[4];
            r[3] = (byte) v;
            r[2] = (byte) (v >> 8);
            r[1] = (byte) (v >> 16);
            r[0] = (byte) (v >> 24);
            return r;
        }


        public static byte[] SwapInt16(short v)
        {
            var r = new byte[2];
            r[1] = (byte) v;
            r[0] = (byte) (v >> 8);
            return r;
        }

        public static byte[] SwapDouble(double v)
        {
            return SwapBytes(BitConverter.GetBytes(v));
        }
    }
}