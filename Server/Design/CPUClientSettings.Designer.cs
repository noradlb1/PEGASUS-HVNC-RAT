﻿
using System.Drawing;

namespace PEGASUS.Design
{
    partial class CPUClientSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPUClientSettings));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.metroSetButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.metroSetButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.metroSetTextBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroSetComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.metroSetButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroSetTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroSetTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroSetTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(337, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "CPU SETTINGS";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 67);
            this.guna2Panel1.TabIndex = 17;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator1.Location = new System.Drawing.Point(-250, 61);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1300, 10);
            this.guna2Separator1.TabIndex = 13;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(759, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // metroSetButton3
            // 
            this.metroSetButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton3.BorderThickness = 1;
            this.metroSetButton3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.metroSetButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetButton3.Font = new System.Drawing.Font("Electrolize", 9F);
            this.metroSetButton3.ForeColor = System.Drawing.Color.White;
            this.metroSetButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.metroSetButton3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton3.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.metroSetButton3.Location = new System.Drawing.Point(12, 402);
            this.metroSetButton3.Name = "metroSetButton3";
            this.metroSetButton3.Size = new System.Drawing.Size(200, 32);
            this.metroSetButton3.TabIndex = 18;
            this.metroSetButton3.Text = "Ok";
            this.metroSetButton3.Click += new System.EventHandler(this.metroSetButton3_Click);
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton1.BorderThickness = 1;
            this.metroSetButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.metroSetButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetButton1.Font = new System.Drawing.Font("Electrolize", 9F);
            this.metroSetButton1.ForeColor = System.Drawing.Color.White;
            this.metroSetButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.metroSetButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton1.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.metroSetButton1.Location = new System.Drawing.Point(588, 402);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.Size = new System.Drawing.Size(200, 32);
            this.metroSetButton1.TabIndex = 19;
            this.metroSetButton1.Text = "Cancel";
            this.metroSetButton1.Click += new System.EventHandler(this.metroSetButton1_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox3.Controls.Add(this.metroSetTextBox2);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.Controls.Add(this.metroSetComboBox1);
            this.guna2GroupBox3.Controls.Add(this.label8);
            this.guna2GroupBox3.Controls.Add(this.metroSetButton2);
            this.guna2GroupBox3.Controls.Add(this.label7);
            this.guna2GroupBox3.Controls.Add(this.label6);
            this.guna2GroupBox3.Controls.Add(this.metroSetTextBox4);
            this.guna2GroupBox3.Controls.Add(this.metroSetTextBox1);
            this.guna2GroupBox3.Controls.Add(this.metroSetTextBox3);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox3.Location = new System.Drawing.Point(0, 66);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(800, 318);
            this.guna2GroupBox3.TabIndex = 164;
            this.guna2GroupBox3.Text = "CPU Settings";
            // 
            // metroSetTextBox2
            // 
            this.metroSetTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroSetTextBox2.ForeColor = System.Drawing.Color.LightGray;
            this.metroSetTextBox2.Location = new System.Drawing.Point(133, 156);
            this.metroSetTextBox2.Multiline = true;
            this.metroSetTextBox2.Name = "metroSetTextBox2";
            this.metroSetTextBox2.Size = new System.Drawing.Size(599, 140);
            this.metroSetTextBox2.TabIndex = 175;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label5.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 169;
            this.label5.Text = "Archive password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 14);
            this.label2.TabIndex = 168;
            this.label2.Text = "Install Patch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 14);
            this.label4.TabIndex = 167;
            this.label4.Text = "Start parameters:";
            // 
            // metroSetComboBox1
            // 
            this.metroSetComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.metroSetComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.metroSetComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.metroSetComboBox1.ForeColor = System.Drawing.Color.LightGray;
            this.metroSetComboBox1.ItemHeight = 30;
            this.metroSetComboBox1.Items.AddRange(new object[] {
            "C:/Users/AppData/Local",
            "C:/Users/AppData/Local/Temp",
            "C:/Users/AppData/Roaming"});
            this.metroSetComboBox1.Location = new System.Drawing.Point(133, 114);
            this.metroSetComboBox1.Name = "metroSetComboBox1";
            this.metroSetComboBox1.Size = new System.Drawing.Size(140, 36);
            this.metroSetComboBox1.TabIndex = 166;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label8.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(737, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 14);
            this.label8.TabIndex = 174;
            this.label8.Text = ".exe";
            // 
            // metroSetButton2
            // 
            this.metroSetButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton2.BorderThickness = 1;
            this.metroSetButton2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.metroSetButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.metroSetButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.metroSetButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetButton2.Font = new System.Drawing.Font("Electrolize", 9F);
            this.metroSetButton2.ForeColor = System.Drawing.Color.White;
            this.metroSetButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.metroSetButton2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetButton2.HoverState.ForeColor = System.Drawing.Color.LightGray;
            this.metroSetButton2.Location = new System.Drawing.Point(133, 61);
            this.metroSetButton2.Name = "metroSetButton2";
            this.metroSetButton2.Size = new System.Drawing.Size(599, 21);
            this.metroSetButton2.TabIndex = 173;
            this.metroSetButton2.Text = "Browse";
            this.metroSetButton2.Click += new System.EventHandler(this.metroSetButton2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label7.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 14);
            this.label7.TabIndex = 172;
            this.label7.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label6.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 14);
            this.label6.TabIndex = 171;
            this.label6.Text = "/";
            // 
            // metroSetTextBox4
            // 
            this.metroSetTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroSetTextBox4.DefaultText = "Miner name in archive ";
            this.metroSetTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox4.Location = new System.Drawing.Point(533, 123);
            this.metroSetTextBox4.Name = "metroSetTextBox4";
            this.metroSetTextBox4.PasswordChar = '\0';
            this.metroSetTextBox4.PlaceholderText = "Miner name in archive ";
            this.metroSetTextBox4.SelectedText = "";
            this.metroSetTextBox4.SelectionStart = 22;
            this.metroSetTextBox4.Size = new System.Drawing.Size(199, 21);
            this.metroSetTextBox4.TabIndex = 170;
            // 
            // metroSetTextBox1
            // 
            this.metroSetTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroSetTextBox1.DefaultText = "password";
            this.metroSetTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox1.Location = new System.Drawing.Point(133, 88);
            this.metroSetTextBox1.Name = "metroSetTextBox1";
            this.metroSetTextBox1.PasswordChar = '\0';
            this.metroSetTextBox1.PlaceholderText = "password";
            this.metroSetTextBox1.SelectedText = "";
            this.metroSetTextBox1.SelectionStart = 8;
            this.metroSetTextBox1.Size = new System.Drawing.Size(599, 21);
            this.metroSetTextBox1.TabIndex = 164;
            // 
            // metroSetTextBox3
            // 
            this.metroSetTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metroSetTextBox3.DefaultText = "";
            this.metroSetTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.metroSetTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.metroSetTextBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.metroSetTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.metroSetTextBox3.Location = new System.Drawing.Point(299, 123);
            this.metroSetTextBox3.Name = "metroSetTextBox3";
            this.metroSetTextBox3.PasswordChar = '\0';
            this.metroSetTextBox3.PlaceholderText = "";
            this.metroSetTextBox3.SelectedText = "";
            this.metroSetTextBox3.Size = new System.Drawing.Size(211, 21);
            this.metroSetTextBox3.TabIndex = 163;
            // 
            // CPUClientSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroSetButton1);
            this.Controls.Add(this.metroSetButton3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GroupBox3);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CPUClientSettings";
            this.Text = "CPUClientSettings";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton metroSetButton1;
        private Guna.UI2.WinForms.Guna2GradientButton metroSetButton3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public Guna.UI2.WinForms.Guna2ComboBox metroSetComboBox1;
        public Guna.UI2.WinForms.Guna2TextBox metroSetTextBox4;
        public Guna.UI2.WinForms.Guna2TextBox metroSetTextBox1;
        public Guna.UI2.WinForms.Guna2TextBox metroSetTextBox3;
        public Guna.UI2.WinForms.Guna2GradientButton metroSetButton2;
        public System.Windows.Forms.TextBox metroSetTextBox2;
    }
}