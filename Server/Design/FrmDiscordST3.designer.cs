
using System.Drawing;

namespace PEGASUS.Design
{
    partial class FrmDiscordST3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiscordST3));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupDisc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtWebHook = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkDisc = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTel = new Guna.UI2.WinForms.Guna2CheckBox();
            this.GroupTel = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTelID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelApi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupDisc.SuspendLayout();
            this.GroupTel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label15);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(792, 72);
            this.guna2Panel1.TabIndex = 138;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(751, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 114;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator1.Location = new System.Drawing.Point(-198, 66);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1189, 11);
            this.guna2Separator1.TabIndex = 13;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightGray;
            this.label15.Location = new System.Drawing.Point(247, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(290, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "DISCORD/TELEGRAM  RECOVERY";
            // 
            // button3
            // 
            this.button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button3.BorderThickness = 1;
            this.button3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.button3.Font = new System.Drawing.Font("Electrolize", 9F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.button3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button3.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(626, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 30);
            this.button3.TabIndex = 149;
            this.button3.Text = "Cancel";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button2.BorderThickness = 1;
            this.button2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.button2.Font = new System.Drawing.Font("Electrolize", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.button2.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(31, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 30);
            this.button2.TabIndex = 148;
            this.button2.Text = "Ok";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 147;
            this.label2.Text = "Input:";
            // 
            // GroupDisc
            // 
            this.GroupDisc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupDisc.Controls.Add(this.txtWebHook);
            this.GroupDisc.Controls.Add(this.label2);
            this.GroupDisc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupDisc.Enabled = false;
            this.GroupDisc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.GroupDisc.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupDisc.ForeColor = System.Drawing.Color.LightGray;
            this.GroupDisc.Location = new System.Drawing.Point(31, 107);
            this.GroupDisc.Name = "GroupDisc";
            this.GroupDisc.Size = new System.Drawing.Size(731, 167);
            this.GroupDisc.TabIndex = 152;
            this.GroupDisc.Text = "Discord Options";
            // 
            // txtWebHook
            // 
            this.txtWebHook.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtWebHook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWebHook.DefaultText = "";
            this.txtWebHook.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtWebHook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtWebHook.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtWebHook.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtWebHook.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWebHook.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtWebHook.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWebHook.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtWebHook.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtWebHook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWebHook.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtWebHook.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWebHook.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtWebHook.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtWebHook.Location = new System.Drawing.Point(14, 90);
            this.txtWebHook.Name = "txtWebHook";
            this.txtWebHook.PasswordChar = '\0';
            this.txtWebHook.PlaceholderText = "WebHook";
            this.txtWebHook.SelectedText = "";
            this.txtWebHook.Size = new System.Drawing.Size(702, 30);
            this.txtWebHook.TabIndex = 151;
            // 
            // chkDisc
            // 
            this.chkDisc.AutoSize = true;
            this.chkDisc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkDisc.CheckedState.BorderRadius = 0;
            this.chkDisc.CheckedState.BorderThickness = 1;
            this.chkDisc.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkDisc.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.chkDisc.Font = new System.Drawing.Font("Electrolize", 8.249999F);
            this.chkDisc.Location = new System.Drawing.Point(31, 83);
            this.chkDisc.Name = "chkDisc";
            this.chkDisc.Size = new System.Drawing.Size(106, 18);
            this.chkDisc.TabIndex = 151;
            this.chkDisc.Text = "Send to Discord";
            this.chkDisc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkDisc.UncheckedState.BorderRadius = 0;
            this.chkDisc.UncheckedState.BorderThickness = 1;
            this.chkDisc.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkDisc.CheckedChanged += new System.EventHandler(this.chkDisc_CheckedChanged);
            // 
            // chkTel
            // 
            this.chkTel.AutoSize = true;
            this.chkTel.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkTel.CheckedState.BorderRadius = 0;
            this.chkTel.CheckedState.BorderThickness = 1;
            this.chkTel.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkTel.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.chkTel.Enabled = false;
            this.chkTel.Font = new System.Drawing.Font("Electrolize", 8.249999F);
            this.chkTel.Location = new System.Drawing.Point(31, 291);
            this.chkTel.Name = "chkTel";
            this.chkTel.Size = new System.Drawing.Size(183, 18);
            this.chkTel.TabIndex = 153;
            this.chkTel.Text = "Send to Telegram (coming soon)";
            this.chkTel.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkTel.UncheckedState.BorderRadius = 0;
            this.chkTel.UncheckedState.BorderThickness = 1;
            this.chkTel.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkTel.CheckedChanged += new System.EventHandler(this.chkTel_CheckedChanged);
            // 
            // GroupTel
            // 
            this.GroupTel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupTel.Controls.Add(this.txtTelID);
            this.GroupTel.Controls.Add(this.txtTelApi);
            this.GroupTel.Controls.Add(this.label1);
            this.GroupTel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupTel.Enabled = false;
            this.GroupTel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.GroupTel.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupTel.ForeColor = System.Drawing.Color.LightGray;
            this.GroupTel.Location = new System.Drawing.Point(31, 315);
            this.GroupTel.Name = "GroupTel";
            this.GroupTel.Size = new System.Drawing.Size(731, 167);
            this.GroupTel.TabIndex = 154;
            this.GroupTel.Text = "Telegram Options";
            // 
            // txtTelID
            // 
            this.txtTelID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtTelID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelID.DefaultText = "";
            this.txtTelID.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTelID.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelID.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTelID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTelID.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelID.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelID.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTelID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTelID.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelID.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelID.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTelID.Location = new System.Drawing.Point(14, 107);
            this.txtTelID.Name = "txtTelID";
            this.txtTelID.PasswordChar = '\0';
            this.txtTelID.PlaceholderText = "TelegramID";
            this.txtTelID.SelectedText = "";
            this.txtTelID.Size = new System.Drawing.Size(702, 30);
            this.txtTelID.TabIndex = 152;
            // 
            // txtTelApi
            // 
            this.txtTelApi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtTelApi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelApi.DefaultText = "";
            this.txtTelApi.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelApi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTelApi.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelApi.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtTelApi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelApi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTelApi.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelApi.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelApi.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTelApi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelApi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTelApi.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTelApi.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtTelApi.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTelApi.Location = new System.Drawing.Point(14, 71);
            this.txtTelApi.Name = "txtTelApi";
            this.txtTelApi.PasswordChar = '\0';
            this.txtTelApi.PlaceholderText = "TelegramAPI";
            this.txtTelApi.SelectedText = "";
            this.txtTelApi.Size = new System.Drawing.Size(702, 30);
            this.txtTelApi.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 147;
            this.label1.Text = "Input:";
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FrmDiscordST3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(792, 596);
            this.Controls.Add(this.GroupTel);
            this.Controls.Add(this.chkTel);
            this.Controls.Add(this.GroupDisc);
            this.Controls.Add(this.chkDisc);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDiscordST3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDiscordST3";
            this.Load += new System.EventHandler(this.FrmDiscordST3_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupDisc.ResumeLayout(false);
            this.GroupDisc.PerformLayout();
            this.GroupTel.ResumeLayout(false);
            this.GroupTel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        public Guna.UI2.WinForms.Guna2GradientButton button3;
        public Guna.UI2.WinForms.Guna2GradientButton button2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GroupBox GroupTel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox chkTel;
        private Guna.UI2.WinForms.Guna2GroupBox GroupDisc;
        private Guna.UI2.WinForms.Guna2CheckBox chkDisc;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        public Guna.UI2.WinForms.Guna2TextBox txtWebHook;
        public Guna.UI2.WinForms.Guna2TextBox txtTelID;
        public Guna.UI2.WinForms.Guna2TextBox txtTelApi;
    }
}