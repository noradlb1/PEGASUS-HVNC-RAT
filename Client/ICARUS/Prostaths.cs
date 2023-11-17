using System;
using System.Management;
using System.Threading;

namespace Peg.ICARUS
{
    internal class Prostaths
    {
        public static void Trexa()
        {
            if (isVM_by_wim_temper()) Environment.FailFast(null);
            Thread.Sleep(1000);
        }

        public static bool isVM_by_wim_temper()
        {
            //SelectQuery selectQuery = new SelectQuery("Select * from Win32_Fan");
            var selectQuery = new SelectQuery("Select * from Win32_CacheMemory");
            //SelectQuery selectQuery = new SelectQuery("Select * from CIM_Memory");
            var searcher = new ManagementObjectSearcher(selectQuery);
            var i = 0;
            foreach (ManagementObject DeviceID in searcher.Get()) i++;
            if (i == 0)
                return true;
            return false;
        }
    }
}