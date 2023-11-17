using System.Drawing;

namespace PEGASUS.Design
{
    partial class FormMiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiner));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GroupDisc = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtThreads = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboInjection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWallet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPool = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.button2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupDisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
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
            this.guna2Panel1.Size = new System.Drawing.Size(800, 78);
            this.guna2Panel1.TabIndex = 138;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(759, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 29);
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
            this.guna2Separator1.Location = new System.Drawing.Point(-198, 71);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1197, 12);
            this.guna2Separator1.TabIndex = 13;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(352, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 19);
            this.label15.TabIndex = 11;
            this.label15.Text = "MINER";
            // 
            // GroupDisc
            // 
            this.GroupDisc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupDisc.Controls.Add(this.txtThreads);
            this.GroupDisc.Controls.Add(this.comboInjection);
            this.GroupDisc.Controls.Add(this.txtPass);
            this.GroupDisc.Controls.Add(this.txtWallet);
            this.GroupDisc.Controls.Add(this.txtPool);
            this.GroupDisc.Controls.Add(this.label2);
            this.GroupDisc.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.GroupDisc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.GroupDisc.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupDisc.ForeColor = System.Drawing.Color.LightGray;
            this.GroupDisc.Location = new System.Drawing.Point(35, 107);
            this.GroupDisc.Name = "GroupDisc";
            this.GroupDisc.Size = new System.Drawing.Size(731, 289);
            this.GroupDisc.TabIndex = 153;
            this.GroupDisc.Text = "Miner Options";
            // 
            // txtThreads
            // 
            this.txtThreads.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtThreads.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThreads.DefaultText = "";
            this.txtThreads.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtThreads.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtThreads.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtThreads.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtThreads.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtThreads.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtThreads.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtThreads.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtThreads.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtThreads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThreads.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtThreads.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtThreads.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtThreads.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtThreads.Location = new System.Drawing.Point(15, 246);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.PasswordChar = '\0';
            this.txtThreads.PlaceholderText = "Threads";
            this.txtThreads.SelectedText = "";
            this.txtThreads.Size = new System.Drawing.Size(121, 32);
            this.txtThreads.TabIndex = 155;
            // 
            // comboInjection
            // 
            this.comboInjection.BackColor = System.Drawing.Color.Transparent;
            this.comboInjection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.comboInjection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboInjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInjection.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.comboInjection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.comboInjection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.comboInjection.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.comboInjection.FocusedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboInjection.Font = new System.Drawing.Font("Electrolize", 9.749999F);
            this.comboInjection.ForeColor = System.Drawing.Color.LightGray;
            this.comboInjection.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.comboInjection.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.comboInjection.HoverState.ForeColor = System.Drawing.Color.DarkGray;
            this.comboInjection.ItemHeight = 30;
            this.comboInjection.Items.AddRange(new object[] {
            "cryptonight",
            "scrypt",
            "sha256d",
            "keccak",
            "quark",
            "heavy",
            "skein",
            "shavite3",
            "blake",
            "x11"});
            this.comboInjection.Location = new System.Drawing.Point(14, 204);
            this.comboInjection.Name = "comboInjection";
            this.comboInjection.Size = new System.Drawing.Size(122, 36);
            this.comboInjection.TabIndex = 154;
            // 
            // txtPass
            // 
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPass.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPass.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPass.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPass.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtPass.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPass.Location = new System.Drawing.Point(14, 168);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(702, 32);
            this.txtPass.TabIndex = 153;
            // 
            // txtWallet
            // 
            this.txtWallet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtWallet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWallet.DefaultText = "";
            this.txtWallet.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtWallet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtWallet.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtWallet.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtWallet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWallet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtWallet.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWallet.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtWallet.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtWallet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWallet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtWallet.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtWallet.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtWallet.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtWallet.Location = new System.Drawing.Point(14, 132);
            this.txtWallet.Name = "txtWallet";
            this.txtWallet.PasswordChar = '\0';
            this.txtWallet.PlaceholderText = "Wallet";
            this.txtWallet.SelectedText = "";
            this.txtWallet.Size = new System.Drawing.Size(702, 32);
            this.txtWallet.TabIndex = 152;
            // 
            // txtPool
            // 
            this.txtPool.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtPool.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPool.DefaultText = "";
            this.txtPool.DisabledState.BorderColor = System.Drawing.Color.DimGray;
            this.txtPool.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPool.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.txtPool.DisabledState.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPool.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPool.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPool.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPool.FocusedState.ForeColor = System.Drawing.Color.LightGray;
            this.txtPool.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPool.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPool.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPool.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPool.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.txtPool.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPool.Location = new System.Drawing.Point(14, 97);
            this.txtPool.Name = "txtPool";
            this.txtPool.PasswordChar = '\0';
            this.txtPool.PlaceholderText = "Pool:Port";
            this.txtPool.SelectedText = "";
            this.txtPool.Size = new System.Drawing.Size(702, 32);
            this.txtPool.TabIndex = 151;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 147;
            this.label2.Text = "Input:";
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
            this.button3.Location = new System.Drawing.Point(630, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 32);
            this.button3.TabIndex = 155;
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
            this.button2.Location = new System.Drawing.Point(35, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 32);
            this.button2.TabIndex = 154;
            this.button2.Text = "Ok";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FormMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GroupDisc);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Electrolize", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMiner";
            this.Load += new System.EventHandler(this.FormMiner_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupDisc.ResumeLayout(false);
            this.GroupDisc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2GroupBox GroupDisc;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2GradientButton button3;
        public Guna.UI2.WinForms.Guna2GradientButton button2;
        public Guna.UI2.WinForms.Guna2TextBox txtPool;
        public Guna.UI2.WinForms.Guna2ComboBox comboInjection;
        public Guna.UI2.WinForms.Guna2TextBox txtPass;
        public Guna.UI2.WinForms.Guna2TextBox txtWallet;
        public Guna.UI2.WinForms.Guna2TextBox txtThreads;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}