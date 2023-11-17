namespace PEGASUS.BytesInOut
{
    using PEGASUS.Diadyktio;
    using System.Drawing;

    /// <summary>
    /// Defines the <see cref="HandleReportWindow" />.
    /// </summary>
    public class HandleReportWindow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleReportWindow"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        public HandleReportWindow(Clients client, string title)
        {
            new HandleLogs().Addmsg($"Client {client.Ip} opened [{title}]", Color.Blue);
            if (Properties.Settings.Default.Notification)
            {
                Program.form1.notifyIcon1.BalloonTipText = $"Client {client.Ip} opened [{title}]";
                Program.form1.notifyIcon1.ShowBalloonTip(100);
            }
        }
    }
}
