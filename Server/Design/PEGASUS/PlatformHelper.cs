using System;
using System.Management;
using System.Text.RegularExpressions;

public static class PlatformHelper
{
    static PlatformHelper()
    {
        RunningOnMono = Type.GetType("Mono.Runtime") != null;
        Name = "Unknown OS";
        using (var managementObjectSearcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem"))
        {
            using (var enumerator = managementObjectSearcher.Get().GetEnumerator())
            {
                if (enumerator.MoveNext())
                    Name = enumerator.Current["Caption"].ToString();
            }
        }

        Name = Regex.Replace(Name, "^.*(?=Windows)", "").TrimEnd().TrimStart();
        Is64Bit = Environment.Is64BitOperatingSystem;
        FullName = string.Format("{0} {1} Bit", Name, Is64Bit ? 64 : 32);
    }

    public static string FullName { get; }

    public static string Name { get; }

    public static bool Is64Bit { get; }

    public static bool RunningOnMono { get; }

    public static bool Win32NT { get; } = Environment.OSVersion.Platform == PlatformID.Win32NT;

    public static bool XpOrHigher { get; } = Win32NT && Environment.OSVersion.Version.Major >= 5;

    public static bool VistaOrHigher { get; } = Win32NT && Environment.OSVersion.Version.Major >= 6;

    public static bool SevenOrHigher { get; } = Win32NT && Environment.OSVersion.Version >= new Version(6, 1);

    public static bool EightOrHigher { get; } = Win32NT && Environment.OSVersion.Version >= new Version(6, 2, 9200);

    public static bool EightPointOneOrHigher { get; } = Win32NT && Environment.OSVersion.Version >= new Version(6, 3);

    public static bool TenOrHigher { get; } = Win32NT && Environment.OSVersion.Version >= new Version(10, 0);
}