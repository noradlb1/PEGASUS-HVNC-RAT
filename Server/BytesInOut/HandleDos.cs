namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleDos" />.
    /// </summary>
    internal class HandleDos
    {
        /// <summary>
        /// The Add.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void Add(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var DOS = (FormDOS)Application.OpenForms["DOS"];
                if (DOS != null)
                    lock (DOS.sync)
                    {
                        DOS.PlguinClients.Add(client);
                    }
            }
            catch
            {
            }
        }
    }
}
