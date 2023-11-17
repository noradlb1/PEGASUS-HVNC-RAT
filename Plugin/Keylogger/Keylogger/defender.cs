using System;
using System.Collections.Specialized;
using System.Net;

/// <summary>
/// Defines the <see cref="defender" />.
/// </summary>
public class defender : IDisposable
{
    /// <summary>
    /// Defines the dWebClient.
    /// </summary>
    private readonly WebClient dWebClient;

    /// <summary>
    /// Defines the discordValues.
    /// </summary>
    private static NameValueCollection discordValues = new NameValueCollection();

    /// <summary>
    /// Gets or sets the WebHook.
    /// </summary>
    public string WebHook { get; set; }

    /// <summary>
    /// Gets or sets the UserName.
    /// </summary>
    public string UserName { get; set; }

    /// <summary>
    /// Gets or sets the ProfilePicture.
    /// </summary>
    public string ProfilePicture { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="defender"/> class.
    /// </summary>
    public defender()
    {
        dWebClient = new WebClient();
    }

    /// <summary>
    /// The SendMessage.
    /// </summary>
    /// <param name="msgSend">The msgSend<see cref="string"/>.</param>
    public void SendMessage(string msgSend)
    {
        discordValues.Add("username", UserName);
        discordValues.Add("avatar_url", ProfilePicture);
        discordValues.Add("content", msgSend);

        dWebClient.UploadValues(WebHook, discordValues);
    }

    /// <summary>
    /// The Dispose.
    /// </summary>
    public void Dispose()
    {
        dWebClient.Dispose();
    }
}
