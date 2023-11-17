using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace PEGASUS.IcarusWings
{
    internal class DingDing
    {
        public static void Send(string WebHook, string secret, string content)
        {
            var result = "";

            var ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            var shijianchuo = (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000;

            var stringToSign = shijianchuo + "\n" + secret;
            var encoding = new ASCIIEncoding();
            var keyByte = encoding.GetBytes(secret);
            var messageBytes = encoding.GetBytes(stringToSign);
            string sign;
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                var hashmessage = hmacsha256.ComputeHash(messageBytes);
                sign = HttpUtility.UrlEncode(Convert.ToBase64String(hashmessage), Encoding.UTF8);
            }

            var url = WebHook + "&timestamp=" + shijianchuo + "&sign=" + sign;

            var obj = new
            {
                msgtype = "text",
                text = new
                {
                    content
                }
            };

            var json = JsonConvert.SerializeObject(obj);
            Console.WriteLine(url);
            var req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json;charset=utf-8";
            //Console.WriteLine(json);

            var bytes = Encoding.UTF8.GetBytes(json);
            req.ContentLength = bytes.Length;
            using (var requestStream = req.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }

            var resp = (HttpWebResponse)req.GetResponse();
            var stream = resp.GetResponseStream();

            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            //Console.WriteLine(result);

            //Console.ReadKey();
        }
    }
}