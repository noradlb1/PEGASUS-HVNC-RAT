namespace PEGASUS.BytesInOut
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleLogs" />.
    /// </summary>
    public class HandleLogs
    {
        /// <summary>
        /// The Addmsg.
        /// </summary>
        /// <param name="Msg">The Msg<see cref="string"/>.</param>
        /// <param name="color">The color<see cref="Color"/>.</param>
        public void Addmsg(string Msg, Color color)
        {
            try
            {
                var LV = new ListViewItem();
                LV.Text = DateTime.Now.ToLongTimeString();
                LV.SubItems.Add(Msg);
                LV.ForeColor = Color.White;

                if (Program.form1.InvokeRequired)
                    Program.form1.Invoke((MethodInvoker)(() =>
                   {
                       lock (Settings.LockListviewLogs)
                       {
                           Program.form1.listView2.Items.Insert(0, LV);
                       }
                   }));
                else
                    lock (Settings.LockListviewLogs)
                    {
                        Program.form1.listView2.Items.Insert(0, LV);
                    }
            }
            catch
            {
            }
        }
    }
}
