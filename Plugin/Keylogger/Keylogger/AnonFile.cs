namespace AnonFileAPI
{
    /// <summary>
    /// Defines the <see cref="AnonFile" />.
    /// </summary>
    public class AnonFile
    {
        /// <summary>
        /// Gets the Response.
        /// </summary>
        public string Response { get; private set; }

        /// <summary>
        /// Gets a value indicating whether Status.
        /// </summary>
        public bool Status { get; private set; }

        /// <summary>
        /// Gets the FullUrl.
        /// </summary>
        public string FullUrl { get; private set; }

        /// <summary>
        /// Gets the ShortUrl.
        /// </summary>
        public string ShortUrl { get; private set; }

        /// <summary>
        /// Gets the Size.
        /// </summary>
        public uint Size { get; private set; }

        /// <summary>
        /// Gets the ErrorCode.
        /// </summary>
        public uint ErrorCode { get; private set; }

        /// <summary>
        /// Gets the ErrorMessage.
        /// </summary>
        public string ErrorMessage { get; private set; }

        /// <summary>
        /// Gets the ErrorType.
        /// </summary>
        public string ErrorType { get; private set; }

        /// <summary>
        /// Defines the <see cref="AnonExceptions" />.
        /// </summary>
        public static class AnonExceptions
        {
            /// <summary>
            /// Defines the ERROR_FILE_NOT_PROVIDED.
            /// </summary>
            public const int ERROR_FILE_NOT_PROVIDED = 10;

            /// <summary>
            /// Defines the ERROR_FILE_EMPTY.
            /// </summary>
            public const int ERROR_FILE_EMPTY = 11;

            /// <summary>
            /// Defines the ERROR_FILE_INVALID.
            /// </summary>
            public const int ERROR_FILE_INVALID = 12;

            /// <summary>
            /// Defines the ERROR_USER_MAX_FILES_PER_HOUR_REACHED.
            /// </summary>
            public const int ERROR_USER_MAX_FILES_PER_HOUR_REACHED = 20;

            /// <summary>
            /// Defines the ERROR_USER_MAX_FILES_PER_DAY_REACHED.
            /// </summary>
            public const int ERROR_USER_MAX_FILES_PER_DAY_REACHED = 21;

            /// <summary>
            /// Defines the ERROR_USER_MAX_BYTES_PER_HOUR_REACHED.
            /// </summary>
            public const int ERROR_USER_MAX_BYTES_PER_HOUR_REACHED = 22;

            /// <summary>
            /// Defines the ERROR_USER_MAX_BYTES_PER_DAY_REACHED.
            /// </summary>
            public const int ERROR_USER_MAX_BYTES_PER_DAY_REACHED = 23;

            /// <summary>
            /// Defines the ERROR_FILE_DISALLOWED_TYPE.
            /// </summary>
            public const int ERROR_FILE_DISALLOWED_TYPE = 30;

            /// <summary>
            /// Defines the ERROR_FILE_SIZE_EXCEEDED.
            /// </summary>
            public const int ERROR_FILE_SIZE_EXCEEDED = 31;

            /// <summary>
            /// Defines the ERROR_FILE_BANNED.
            /// </summary>
            public const int ERROR_FILE_BANNED = 32;

            /// <summary>
            /// Defines the STATUS_ERROR_SYSTEM_FAILURE.
            /// </summary>
            public const int STATUS_ERROR_SYSTEM_FAILURE = 40;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFile"/> class.
        /// </summary>
        /// <param name="response">.</param>
        /// <param name="status">.</param>
        /// <param name="fullurl">.</param>
        /// <param name="shortUrl">.</param>
        /// <param name="size">.</param>
        public AnonFile(string response, bool status, string fullurl, string shortUrl, uint size)
        {
            this.Response = response;
            this.Status = status;
            this.FullUrl = fullurl;
            this.ShortUrl = shortUrl;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnonFile"/> class.
        /// </summary>
        /// <param name="response">.</param>
        /// <param name="status">.</param>
        /// <param name="errorMessage">The errorMessage<see cref="string"/>.</param>
        /// <param name="errorCode">.</param>
        /// <param name="errorType">.</param>
        public AnonFile(string response, bool status, string errorMessage, uint errorCode, string errorType)
        {
            this.Response = response;
            this.Status = status;
            this.ErrorCode = errorCode;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
        }
    }
}
