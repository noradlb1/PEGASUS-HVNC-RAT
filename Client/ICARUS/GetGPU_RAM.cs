using System;
using System.Management;

namespace Peg.ICARUS
{
    internal class GetGPU_RAM
    {
        private static readonly string[] SizeSuffixes =
        {
            "bytes",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"
        };

        public static string SYP()
        {
            var GPURAM = "";
            var myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get()) GPURAM = Convert.ToString(obj["AdapterRAM"]);


            return GPURAM;
        }

        private static int GetVideoMemory()
        {
            var vram = 0;

            foreach (ManagementObject mo in new ManagementObjectSearcher("select AdapterRAM from Win32_VideoController")
                         .Get())
            {
                var ram = mo.Properties["AdapterRAM"].Value as uint?;
                if (ram.HasValue) vram = (int)(ram / 1048576); //convert to MB
            }

            return vram;
        }

        public static string Get() // GetGPU_RAM.Get()
        {
            try
            {
                var p = GetVideoMemory();
                var ram = SizeSuffix((long)Convert.ToDouble(p));
                return ram;
            }
            catch
            {
                return "N/A";
            }
        }

        private static string SizeSuffix(long value)
        {
            var flag = value < 0L;
            string result;
            if (flag)
            {
                result = "-" + SizeSuffix(-value);
            }
            else
            {
                var flag2 = value == 0L;
                if (flag2)
                {
                    result = "0";
                }
                else
                {
                    var mag = (int)Math.Log(value, 1024.0);
                    decimal adjustedSize = value / (1L << (mag * 10));
                    result = string.Format("{0:n0}", adjustedSize, SizeSuffixes[mag]);
                }
            }

            return result;
        }
    }
}