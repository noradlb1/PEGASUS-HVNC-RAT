using System.IO;
using System.Text.RegularExpressions;
using PEGASUS.Tools.Helper;

namespace PEGASUS.IcarusWings
{
    public static class FormatHelper
    {
        public static string FormatMacAddress(string macAddress)
        {
            return macAddress.Length != 12
                ? "00:00:00:00:00:00"
                : Regex.Replace(macAddress, "(.{2})(.{2})(.{2})(.{2})(.{2})(.{2})", "$1:$2:$3:$4:$5:$6");
        }

        public static string DriveTypeName(DriveType type)
        {
            switch (type)
            {
                case DriveType.Fixed:
                    return "Local Disk";
                case DriveType.Network:
                    return "Network Drive";
                case DriveType.Removable:
                    return "Removable Drive";
                default:
                    return type.ToString();
            }
        }

        public static string GenerateMutex(int length = 18)
        {
            return "KRN_MUTEX_" + FileHelper.GetRandomFilename(length);
        }

        public static bool IsValidVersionNumber(string input)
        {
            var match = Regex.Match(input, @"^[0-9]+\.[0-9]+\.(\*|[0-9]+)\.(\*|[0-9]+)$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}