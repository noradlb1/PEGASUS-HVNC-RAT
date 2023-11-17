using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

public class EmbeddedAssembly
{
    private static Dictionary<string, Assembly> dic;

    public static void Load(string embeddedResource, string fileName)
    {
        if (dic == null)
            dic = new Dictionary<string, Assembly>();
        byte[] numArray = null;
        using (var manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(embeddedResource))
        {
            numArray = manifestResourceStream != null
                ? new byte[(int) manifestResourceStream.Length]
                : throw new Exception(embeddedResource + " is not found in Embedded Resources.");
            manifestResourceStream.Read(numArray, 0, (int) manifestResourceStream.Length);
            try
            {
                var assembly = Assembly.Load(numArray);
                dic.Add(assembly.FullName, assembly);
                return;
            }
            catch
            {
            }
        }

        var flag = false;
        var path = "";
        using (var cryptoServiceProvider = new SHA1CryptoServiceProvider())
        {
            var str1 = BitConverter.ToString(cryptoServiceProvider.ComputeHash(numArray)).Replace("-", string.Empty);
            path = Path.GetTempPath() + fileName;
            if (File.Exists(path))
            {
                var buffer = File.ReadAllBytes(path);
                var str2 = BitConverter.ToString(cryptoServiceProvider.ComputeHash(buffer)).Replace("-", string.Empty);
                flag = str1 == str2;
            }
            else
            {
                flag = false;
            }
        }

        if (!flag)
            File.WriteAllBytes(path, numArray);
        var assembly1 = Assembly.LoadFile(path);
        dic.Add(assembly1.FullName, assembly1);
    }

    public static Assembly Get(string assemblyFullName)
    {
        if (dic == null || dic.Count == 0)
            return null;
        return dic.ContainsKey(assemblyFullName) ? dic[assemblyFullName] : null;
    }
}