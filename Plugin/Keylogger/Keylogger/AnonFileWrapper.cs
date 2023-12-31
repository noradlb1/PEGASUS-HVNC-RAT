﻿namespace AnonFileAPI
{
    using System;
    using System.IO;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Json;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using System.Xml.XPath;

    public class AnonFileWrapper : IDisposable
    {
        private readonly WebClient _client = null;
        private bool _disposed = false;

        /// <summary>
        ///     Initializes new WebClient.          
        /// </summary>
        public AnonFileWrapper()
        {
            _client = new WebClient();
        }

        /// <summary>
        ///     Downloads the file to the specified path. 
        /// </summary>
        /// <param name="fileUrl"> The URL of the file wanted. </param>
        /// <param name="downloadLocation"> The specified path with file and extension. </param>
        public void DownloadFile(string fileUrl, string downloadLocation)
        {
            _client.DownloadFile(GetDirectDownloadLinkFromLink(fileUrl), downloadLocation);
        }

        /// <summary>
        ///     Downloads the file to the specified path. 
        /// </summary>
        /// <param name="fileUrl"> The URL of the file wanted. </param>
        /// <param name="downloadLocation"> The specified path with file and extension. </param>
        /// <param name="handler"> A progress changed handler that can monitor the progress of the download. </param>
        public void DownloadFileAsync(string fileUrl, string downloadLocation, DownloadProgressChangedEventHandler handler = null)
        {
            _client.DownloadFileAsync(new Uri(GetDirectDownloadLinkFromLink(fileUrl)), downloadLocation);

            if (handler != null)
            {
                _client.DownloadProgressChanged += handler;
            }
        }

        /// <summary>
        ///     Checks if file exists and uploads file. This along with parsing the output of the JSON response.
        /// </summary>
        /// <param name="fileLocation"> The specified path to the file to be uploaded. </param>
        public AnonFile UploadFile(string fileLocation)
        {
            if (!File.Exists(fileLocation))
                throw new AnonFileException($"Invalid file path at {fileLocation}");
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            byte[] response = _client.UploadFile("https://api.anonfile.com/upload", fileLocation);

            return ParseOutput(Encoding.Default.GetString(response));
        }

        /// <summary>
        ///     Checks if file exists and uploads file. This along with parsing the output of the JSON response.
        /// </summary>
        /// <param name="fileLocation"> The specified path to the file to be uploaded. </param>
        /// <param name="handler"> A progress changed handler that can monitor the progress of the upload. </param>
        public AnonFile UploadFileAsync(string fileLocation, UploadProgressChangedEventHandler handler = null)
        {
            string response = null;
            AutoResetEvent waitHandle = new AutoResetEvent(false);

            if (!File.Exists(fileLocation))
                throw new AnonFileException($"Invalid file path at {fileLocation}");

            _client.UploadFileAsync(new Uri("https://api.anonfile.com/upload"), fileLocation);


            if (handler != null)
            {
                _client.UploadProgressChanged += handler;
            }

            _client.UploadFileCompleted += (self, e) =>
            {
                waitHandle.Set();
                response = Encoding.Default.GetString(e.Result);
            };

            waitHandle.WaitOne();
            waitHandle.Dispose();

            return response != null ? ParseOutput(response) : throw new AnonFileException("Failed to grab AnonFile's server response to the upload event!"); ;
        }

        /// <summary>
        /// Sorts through the link's HTML document to find the direct download link (which has a randomly string inserted inside of it).
        /// The ApartmentState was set to STA due to some funky errors with WebBrowser.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="elementname"></param>
        /// <returns></returns>
        public string GetDirectDownloadLinkFromLink(string link, string elementname = "download-url")
        {
            string htmlDoc = _client.DownloadString(link);
            string directDownloadUrl = null;


            //this is only done to set the apartment state to STA and due to the webbrowser throwing errors if it isn't!
            Thread safeThread = new Thread(() =>
            {
                using (WebBrowser browser = new WebBrowser())
                {
                    browser.DocumentText = htmlDoc;
                    browser.ScriptErrorsSuppressed = true;
                    browser.Document.OpenNew(true);
                    browser.Document.Write(htmlDoc);
                    browser.Refresh();
                    directDownloadUrl = browser.Document.GetElementById(elementname).GetAttribute("href");
                }
            })
            { ApartmentState = ApartmentState.STA };

            safeThread.Start();
            safeThread.Join();

            return directDownloadUrl ?? throw new AnonFileException("Failed to locate the direct download link! This could be because the website changed its element id for the download link, if so you can set the second paramater to the correct one!");
        }


        /// <summary>
        ///     Parses the JSON reply and returns AnonFiles with set properties. 
        /// </summary>
        /// <param name="input"></param>
        private AnonFile ParseOutput(string input)
        {
            using (var jsonReader = JsonReaderWriterFactory.CreateJsonReader(Encoding.UTF8.GetBytes(input),
                new System.Xml.XmlDictionaryReaderQuotas()))
            {
                var root = XElement.Load(jsonReader);
                bool status = Convert.ToBoolean(root.XPathSelectElement("//status")?.Value);

                if (!status)
                {
                    string errorMessage = root.XPathSelectElement("//error/message")?.Value;
                    string errorType = root.XPathSelectElement("//error/type")?.Value;
                    uint errorCode = Convert.ToUInt32(root.XPathSelectElement("//error/code")?.Value);
                    return new AnonFile(input, status, errorMessage, errorCode, errorType);
                }
                else
                {
                    string urlfull = root.XPathSelectElement("//url/full")?.Value;
                    string urlshort = root.XPathSelectElement("//url/short")?.Value;
                    uint size = Convert.ToUInt32(root.XPathSelectElement("//metadata/size/bytes")?.Value);
                    return new AnonFile(input, status, urlfull, urlshort, size);
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _client.Dispose();
                }


                this._disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~AnonFileWrapper()
        {
            Dispose(false);
        }
    }
    /// <summary>
    /// Defines the <see cref="AnonFileException" />.
    /// </summary>
    [Serializable]
    internal class AnonFileException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFileException"/> class.
        /// </summary>
        public AnonFileException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFileException"/> class.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        public AnonFileException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFileException"/> class.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="innerException">The innerException<see cref="Exception"/>.</param>
        public AnonFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFileException"/> class.
        /// </summary>
        /// <param name="info">The info<see cref="SerializationInfo"/>.</param>
        /// <param name="context">The context<see cref="StreamingContext"/>.</param>
        protected AnonFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
