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
    /// Defines the <see cref="HandleProcessManager" />.
    /// </summary>
    public class HandleProcessManager
    {
        /// <summary>
        /// The GetProcess.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void GetProcess(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var PM = (FormProcessManager)Application.OpenForms[
                    "processManager:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                if (PM != null)
                {
                    if (PM.Client == null)
                    {
                        PM.Client = client;
                        PM.listView1.Enabled = true;
                        PM.timer1.Enabled = true;
                    }

                    PM.listView1.Items.Clear();
                    PM.imageList1.Images.Clear();
                    var processLists = unpack_msgpack.ForcePathObject("Message").AsString;
                    var _NextProc = processLists.Split(new[] { "-=>" }, StringSplitOptions.None);
                    for (var i = 0; i < _NextProc.Length; i++)
                    {
                        if (_NextProc[i].Length > 0)
                        {
                            var lv = new ListViewItem
                            {
                                Text = Path.GetFileName(_NextProc[i])
                            };
                            lv.SubItems.Add(_NextProc[i + 1]);
                            lv.ToolTipText = _NextProc[i];
                            var im = Image.FromStream(new MemoryStream(Convert.FromBase64String(_NextProc[i + 2])));
                            PM.imageList1.Images.Add(_NextProc[i + 1], im);
                            lv.ImageKey = _NextProc[i + 1];
                            PM.listView1.Items.Add(lv);
                        }

                        i += 2;
                    }
                }
            }
            catch
            {
            }
        }
    }
}
