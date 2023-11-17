namespace custom_alert_notifications
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="alert" />.
    /// </summary>
    public partial class alert : Form
    {
        /// <summary>
        /// Defines the AlertType.
        /// </summary>
        public enum AlertType
        {

            /// Defines the success.
            /// </summary>
            success,
            /// <summary>
            /// Defines the info.
            /// </summary>
            info,
            /// <summary>
            /// Defines the warnig.
            /// </summary>
            warnig,
            /// <summary>
            /// Defines the error.
            /// </summary>
            error
        }

        /// <summary>
        /// Defines the interval.
        /// </summary>
        private int interval;

        /// <summary>
        /// Initializes a new instance of the <see cref="alert"/> class.
        /// </summary>
        /// <param name="_message">The _message<see cref="string"/>.</param>
        /// <param name="type">The type<see cref="AlertType"/>.</param>
        public alert(string _message, AlertType type)
        {
            InitializeComponent();
            message.Text = _message;


            switch (type)
            {
                case AlertType.success:
                    BackColor = Color.FromArgb(25, 27, 38);
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.info:
                    BackColor = Color.Gray;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.warnig:
                    BackColor = Color.Crimson;
                    icon.Image = imageList1.Images[1];
                    break;
                case AlertType.error:
                    BackColor = Color.FromArgb(25, 27, 38);
                    icon.Image = imageList1.Images[2];
                    break;
            }
        }

        /// <summary>
        /// Alerts the specified message.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        /// <param name="type">The type.</param>
        public static void Show(string message, AlertType type)
        {
            new alert(message, type).Show();
        }

        /// <summary>
        /// The alert_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void alert_Load(object sender, EventArgs e)
        {
            //set position to top left...
            Top = -1 * Height;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 60;

            show.Start();
        }

        /// <summary>
        /// The bunifuImageButton1_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closealert.Start();
        }

        /// <summary>
        /// The timeout_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void timeout_Tick(object sender, EventArgs e)
        {
            closealert.Start();
        }

        /// <summary>
        /// The show_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void show_Tick(object sender, EventArgs e)
        {
            if (Top < 60)
            {
                Top += interval; // drop the alert
                interval += 2; // double the speed
            }
            else
            {
                show.Stop();
            }
        }

        /// <summary>
        /// The close_Tick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void close_Tick(object sender, EventArgs e)
        {
            if (Opacity > 0)
                Opacity -= 0.2; //reduce opacity to zero
            else
                Close(); //then close
        }
    }
}
