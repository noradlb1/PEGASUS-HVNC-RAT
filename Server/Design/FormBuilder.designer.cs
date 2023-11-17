using System;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace PEGASUS.Design
{
    partial class FormBuilder
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
            Guna.UI2.AnimatorNS.Animation animation3 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuilder));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxIP = new System.Windows.Forms.ListBox();
            this.guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPort = new System.Windows.Forms.ListBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddIP = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClone = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRemoveIP = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddPort = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRemovePort = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnIcon = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnStatic = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEx = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnLocal = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.textIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator7 = new Guna.UI2.WinForms.Guna2Separator();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRandom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Separator6 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox5 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtIcon = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtFileVersion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductVersion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOriginalFilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCompany = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCopyright = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrademarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIcon = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnAssembly = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtPaste_bin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMutex = new Guna.UI2.WinForms.Guna2TextBox();
            this.textFilename = new Guna.UI2.WinForms.Guna2TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.comboBoxFolder = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.chkPaste_bin = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chkUSB = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkKillWD = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkExclude = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAntiK = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUac = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkBsod = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAnti = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAntiProcess = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chkRename = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkCert = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkVBS = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkPowershell = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chVRunPe = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkObfu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnShellcode = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuild = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2TextBox1 = new System.Windows.Forms.RichTextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Transition2 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2Transition3 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Transition4 = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.guna2ContextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2TabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.guna2GroupBox5.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label17, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label17.Location = new System.Drawing.Point(269, 88);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 15);
            this.label17.TabIndex = 109;
            this.label17.Text = "Group:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.guna2Transition4.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label16, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label16.Location = new System.Drawing.Point(394, 153);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 15);
            this.label16.TabIndex = 107;
            this.label16.Text = "Sleep (s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(269, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 103;
            this.label5.Text = "Mutex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(269, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "File path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(269, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "File name:";
            // 
            // picIcon
            // 
            this.guna2Transition3.SetDecoration(this.picIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.picIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.picIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.picIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.picIcon.ErrorImage = null;
            this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(215, 50);
            this.picIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(67, 61);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 91;
            this.picIcon.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Location = new System.Drawing.Point(15, 212);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 15);
            this.label14.TabIndex = 82;
            this.label14.Text = "Product Version:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Location = new System.Drawing.Point(15, 238);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 15);
            this.label13.TabIndex = 81;
            this.label13.Text = "File Version:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label12, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label12.Location = new System.Drawing.Point(15, 186);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 80;
            this.label12.Text = "Original Filename:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label11, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label11.Location = new System.Drawing.Point(15, 160);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Trademarks:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Location = new System.Drawing.Point(15, 134);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Copyright:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(15, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 77;
            this.label9.Text = "Company:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 75;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(15, 56);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 73;
            this.label8.Text = "Product:";
            // 
            // listBoxIP
            // 
            this.listBoxIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxIP.ContextMenuStrip = this.guna2ContextMenuStrip2;
            this.guna2Transition4.SetDecoration(this.listBoxIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.listBoxIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listBoxIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listBoxIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listBoxIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.listBoxIP.FormattingEnabled = true;
            this.listBoxIP.ItemHeight = 15;
            this.listBoxIP.Location = new System.Drawing.Point(86, 160);
            this.listBoxIP.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIP.Name = "listBoxIP";
            this.listBoxIP.Size = new System.Drawing.Size(290, 90);
            this.listBoxIP.TabIndex = 70;
            // 
            // guna2ContextMenuStrip2
            // 
            this.guna2ContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2Transition1.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2ContextMenuStrip2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ContextMenuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(29, 29);
            this.guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem70});
            this.guna2ContextMenuStrip2.Margin = new System.Windows.Forms.Padding(3);
            this.guna2ContextMenuStrip2.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip2.Size = new System.Drawing.Size(142, 40);
            // 
            // toolStripMenuItem70
            // 
            this.toolStripMenuItem70.ForeColor = System.Drawing.Color.LightGray;
            this.toolStripMenuItem70.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem70.Image")));
            this.toolStripMenuItem70.Name = "toolStripMenuItem70";
            this.toolStripMenuItem70.Size = new System.Drawing.Size(141, 36);
            this.toolStripMenuItem70.Text = "      Delete";
            this.toolStripMenuItem70.Click += new System.EventHandler(this.toolStripMenuItem70_Click);
            // 
            // listBoxPort
            // 
            this.listBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.listBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPort.ContextMenuStrip = this.guna2ContextMenuStrip2;
            this.guna2Transition4.SetDecoration(this.listBoxPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.listBoxPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.listBoxPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.listBoxPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.listBoxPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.listBoxPort.FormattingEnabled = true;
            this.listBoxPort.ItemHeight = 15;
            this.listBoxPort.Location = new System.Drawing.Point(376, 160);
            this.listBoxPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.listBoxPort.Name = "listBoxPort";
            this.listBoxPort.Size = new System.Drawing.Size(312, 90);
            this.listBoxPort.TabIndex = 65;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(868, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 113;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnAddIP
            // 
            this.btnAddIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAddIP.BorderThickness = 1;
            this.btnAddIP.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnAddIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnAddIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAddIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnAddIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddIP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIP.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddIP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAddIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddIP.ForeColor = System.Drawing.Color.White;
            this.btnAddIP.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAddIP.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAddIP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddIP.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddIP.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAddIP.Location = new System.Drawing.Point(587, 101);
            this.btnAddIP.Name = "btnAddIP";
            this.btnAddIP.Size = new System.Drawing.Size(101, 29);
            this.btnAddIP.TabIndex = 114;
            this.btnAddIP.Text = "Add IP/PORT";
            this.guna2HtmlToolTip1.SetToolTip(this.btnAddIP, "Add IP/Port to the list!");
            this.btnAddIP.Click += new System.EventHandler(this.BtnAddIP_Click);
            // 
            // btnClone
            // 
            this.btnClone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnClone.BorderThickness = 1;
            this.btnClone.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnClone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnClone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnClone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnClone, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnClone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnClone.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnClone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnClone.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnClone.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnClone.Enabled = false;
            this.btnClone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnClone.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnClone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClone.ForeColor = System.Drawing.Color.White;
            this.btnClone.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnClone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnClone.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnClone.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnClone.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnClone.Location = new System.Drawing.Point(120, 369);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(143, 30);
            this.btnClone.TabIndex = 115;
            this.btnClone.Text = "Clone";
            this.guna2HtmlToolTip1.SetToolTip(this.btnClone, "Clone assembly info from other exe!");
            this.btnClone.Click += new System.EventHandler(this.BtnClone_Click);
            // 
            // btnRemoveIP
            // 
            this.btnRemoveIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRemoveIP.BorderThickness = 1;
            this.btnRemoveIP.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnRemoveIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnRemoveIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRemoveIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnRemoveIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemoveIP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveIP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveIP.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemoveIP.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemoveIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemoveIP.ForeColor = System.Drawing.Color.White;
            this.btnRemoveIP.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRemoveIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemoveIP.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemoveIP.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemoveIP.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemoveIP.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemoveIP.Location = new System.Drawing.Point(546, 387);
            this.btnRemoveIP.Name = "btnRemoveIP";
            this.btnRemoveIP.Size = new System.Drawing.Size(101, 21);
            this.btnRemoveIP.TabIndex = 116;
            this.btnRemoveIP.Text = "Remove IP/PORT";
            this.btnRemoveIP.Visible = false;
            this.btnRemoveIP.Click += new System.EventHandler(this.BtnRemoveIP_Click);
            // 
            // btnAddPort
            // 
            this.btnAddPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAddPort.BorderThickness = 1;
            this.btnAddPort.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnAddPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnAddPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAddPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnAddPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddPort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPort.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddPort.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAddPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddPort.ForeColor = System.Drawing.Color.White;
            this.btnAddPort.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAddPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAddPort.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnAddPort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddPort.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAddPort.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnAddPort.Location = new System.Drawing.Point(148, 378);
            this.btnAddPort.Name = "btnAddPort";
            this.btnAddPort.Size = new System.Drawing.Size(193, 30);
            this.btnAddPort.TabIndex = 120;
            this.btnAddPort.Text = "Add Port";
            this.btnAddPort.Visible = false;
            this.btnAddPort.Click += new System.EventHandler(this.BtnAddPort_Click);
            // 
            // btnRemovePort
            // 
            this.btnRemovePort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRemovePort.BorderThickness = 1;
            this.btnRemovePort.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnRemovePort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnRemovePort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRemovePort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnRemovePort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemovePort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePort.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemovePort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemovePort.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemovePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRemovePort.ForeColor = System.Drawing.Color.White;
            this.btnRemovePort.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRemovePort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemovePort.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRemovePort.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemovePort.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRemovePort.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRemovePort.Location = new System.Drawing.Point(347, 378);
            this.btnRemovePort.Name = "btnRemovePort";
            this.btnRemovePort.Size = new System.Drawing.Size(193, 30);
            this.btnRemovePort.TabIndex = 121;
            this.btnRemovePort.Text = "Remove Port";
            this.btnRemovePort.Visible = false;
            this.btnRemovePort.Click += new System.EventHandler(this.BtnRemovePort_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnIcon.BorderThickness = 1;
            this.btnIcon.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnIcon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnIcon.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnIcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnIcon.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnIcon.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnIcon.Enabled = false;
            this.btnIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnIcon.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnIcon.ForeColor = System.Drawing.Color.White;
            this.btnIcon.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnIcon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnIcon.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnIcon.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnIcon.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnIcon.Location = new System.Drawing.Point(634, 369);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(143, 30);
            this.btnIcon.TabIndex = 124;
            this.btnIcon.Text = "Choose Icon";
            this.guna2HtmlToolTip1.SetToolTip(this.btnIcon, "Browse for your custom icon!");
            this.btnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tabPage1);
            this.guna2TabControl1.Controls.Add(this.tabPage2);
            this.guna2TabControl1.Controls.Add(this.tabPage3);
            this.guna2TabControl1.Controls.Add(this.tabPage4);
            this.guna2TabControl1.Controls.Add(this.tabPage6);
            this.guna2Transition2.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2TabControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(3, 73);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1088, 513);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.LightGray;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 135;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.guna2Separator4);
            this.tabPage1.Controls.Add(this.guna2GroupBox1);
            this.tabPage1.Controls.Add(this.btnAddPort);
            this.tabPage1.Controls.Add(this.btnRemoveIP);
            this.tabPage1.Controls.Add(this.btnRemovePort);
            this.guna2Transition2.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.tabPage1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 465);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Host/Port";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator4.Location = new System.Drawing.Point(-162, -3);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator4.TabIndex = 127;
            this.guna2Separator4.UseTransparentBackground = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox1.Controls.Add(this.btnSave);
            this.guna2GroupBox1.Controls.Add(this.guna2GradientButton1);
            this.guna2GroupBox1.Controls.Add(this.btnStatic);
            this.guna2GroupBox1.Controls.Add(this.btnEx);
            this.guna2GroupBox1.Controls.Add(this.btnLocal);
            this.guna2GroupBox1.Controls.Add(this.guna2VSeparator1);
            this.guna2GroupBox1.Controls.Add(this.label21);
            this.guna2GroupBox1.Controls.Add(this.label20);
            this.guna2GroupBox1.Controls.Add(this.textPort);
            this.guna2GroupBox1.Controls.Add(this.textIP);
            this.guna2GroupBox1.Controls.Add(this.btnAddIP);
            this.guna2GroupBox1.Controls.Add(this.listBoxPort);
            this.guna2GroupBox1.Controls.Add(this.listBoxIP);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator7);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition2.SetDecoration(this.guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GroupBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox1.Location = new System.Drawing.Point(61, 47);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(771, 377);
            this.guna2GroupBox1.TabIndex = 123;
            this.guna2GroupBox1.Text = "Set IP/PORT";
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnSave.BorderThickness = 1;
            this.btnSave.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(650, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 29);
            this.btnSave.TabIndex = 159;
            this.btnSave.Text = "Save";
            this.guna2HtmlToolTip1.SetToolTip(this.btnSave, "Save IP/Port to the list!");
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton1.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.Location = new System.Drawing.Point(586, 254);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(101, 29);
            this.guna2GradientButton1.TabIndex = 158;
            this.guna2GradientButton1.Text = "Default Port";
            this.guna2HtmlToolTip1.SetToolTip(this.guna2GradientButton1, "Add IP/Port to the list!");
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnStatic
            // 
            this.btnStatic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnStatic.BorderThickness = 1;
            this.btnStatic.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnStatic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnStatic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnStatic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnStatic, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnStatic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatic.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnStatic.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnStatic.ForeColor = System.Drawing.Color.White;
            this.btnStatic.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnStatic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnStatic.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnStatic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnStatic.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnStatic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnStatic.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatic.Location = new System.Drawing.Point(420, 254);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(101, 29);
            this.btnStatic.TabIndex = 157;
            this.btnStatic.Text = "Add Static";
            this.guna2HtmlToolTip1.SetToolTip(this.btnStatic, "Add IP/Port to the list!");
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnEx
            // 
            this.btnEx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnEx.BorderThickness = 1;
            this.btnEx.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnEx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnEx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnEx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnEx, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnEx.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEx.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnEx.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnEx.ForeColor = System.Drawing.Color.White;
            this.btnEx.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnEx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnEx.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnEx.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnEx.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnEx.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnEx.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEx.Location = new System.Drawing.Point(254, 254);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(101, 29);
            this.btnEx.TabIndex = 156;
            this.btnEx.Text = "External Ip";
            this.guna2HtmlToolTip1.SetToolTip(this.btnEx, "Add IP/Port to the list!");
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnLocal.BorderThickness = 1;
            this.btnLocal.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnLocal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnLocal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnLocal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnLocal, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLocal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocal.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnLocal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLocal.ForeColor = System.Drawing.Color.White;
            this.btnLocal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnLocal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnLocal.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnLocal.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnLocal.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnLocal.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnLocal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocal.Location = new System.Drawing.Point(88, 254);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(101, 29);
            this.btnLocal.TabIndex = 155;
            this.btnLocal.Text = "Add Local ";
            this.guna2HtmlToolTip1.SetToolTip(this.btnLocal, "Add IP/Port to the list!");
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2VSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(368, 143);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 15);
            this.guna2VSeparator1.TabIndex = 154;
            this.guna2VSeparator1.UseTransparentBackground = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.label21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label21, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label21.ForeColor = System.Drawing.Color.LightGray;
            this.label21.Location = new System.Drawing.Point(374, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(316, 15);
            this.label21.TabIndex = 152;
            this.label21.Text = "PORT                                                                             " +
    "               ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label20, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label20.ForeColor = System.Drawing.Color.LightGray;
            this.label20.Location = new System.Drawing.Point(85, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(288, 15);
            this.label20.TabIndex = 151;
            this.label20.Text = "IP                                                                               " +
    "           ";
            // 
            // textPort
            // 
            this.textPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.textPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.textPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.textPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.textPort, Guna.UI2.AnimatorNS.DecorationType.None);
            this.textPort.DefaultText = "";
            this.textPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.textPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textPort.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textPort.Location = new System.Drawing.Point(350, 108);
            this.textPort.Name = "textPort";
            this.textPort.PasswordChar = '\0';
            this.textPort.PlaceholderText = "PORT";
            this.textPort.SelectedText = "";
            this.textPort.Size = new System.Drawing.Size(231, 21);
            this.textPort.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textPort.TabIndex = 150;
            // 
            // textIP
            // 
            this.textIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.textIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.textIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.textIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.textIP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.textIP.DefaultText = "";
            this.textIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.textIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textIP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textIP.Location = new System.Drawing.Point(84, 108);
            this.textIP.Name = "textIP";
            this.textIP.PasswordChar = '\0';
            this.textIP.PlaceholderText = "IP";
            this.textIP.SelectedText = "";
            this.textIP.Size = new System.Drawing.Size(260, 21);
            this.textIP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textIP.TabIndex = 149;
            // 
            // guna2Separator7
            // 
            this.guna2Separator7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator7.Location = new System.Drawing.Point(87, 138);
            this.guna2Separator7.Name = "guna2Separator7";
            this.guna2Separator7.Size = new System.Drawing.Size(601, 10);
            this.guna2Separator7.TabIndex = 153;
            this.guna2Separator7.UseTransparentBackground = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Controls.Add(this.guna2Separator6);
            this.tabPage2.Controls.Add(this.guna2GroupBox5);
            this.tabPage2.Controls.Add(this.guna2GroupBox4);
            this.tabPage2.Controls.Add(this.btnIcon);
            this.tabPage2.Controls.Add(this.chkIcon);
            this.tabPage2.Controls.Add(this.btnAssembly);
            this.tabPage2.Controls.Add(this.btnClone);
            this.guna2Transition2.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.tabPage2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1080, 465);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Assembly";
            // 
            // btnRandom
            // 
            this.btnRandom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnRandom.BorderThickness = 1;
            this.btnRandom.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnRandom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnRandom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnRandom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnRandom, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRandom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRandom.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRandom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRandom.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRandom.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnRandom.Enabled = false;
            this.btnRandom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRandom.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnRandom.ForeColor = System.Drawing.Color.White;
            this.btnRandom.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnRandom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRandom.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnRandom.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnRandom.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnRandom.Location = new System.Drawing.Point(295, 369);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(143, 30);
            this.btnRandom.TabIndex = 138;
            this.btnRandom.Text = "Random";
            this.guna2HtmlToolTip1.SetToolTip(this.btnRandom, "Clone assembly info from other exe!");
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // guna2Separator6
            // 
            this.guna2Separator6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator6.Location = new System.Drawing.Point(-162, -3);
            this.guna2Separator6.Name = "guna2Separator6";
            this.guna2Separator6.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator6.TabIndex = 137;
            this.guna2Separator6.UseTransparentBackground = true;
            // 
            // guna2GroupBox5
            // 
            this.guna2GroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox5.Controls.Add(this.txtIcon);
            this.guna2GroupBox5.Controls.Add(this.picIcon);
            this.guna2GroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition2.SetDecoration(this.guna2GroupBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2GroupBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GroupBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GroupBox5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox5.Enabled = false;
            this.guna2GroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox5.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox5.Location = new System.Drawing.Point(462, 100);
            this.guna2GroupBox5.Name = "guna2GroupBox5";
            this.guna2GroupBox5.Size = new System.Drawing.Size(315, 263);
            this.guna2GroupBox5.TabIndex = 136;
            this.guna2GroupBox5.Text = "Icon Options";
            // 
            // txtIcon
            // 
            this.txtIcon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtIcon.DefaultText = "";
            this.txtIcon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtIcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtIcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtIcon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtIcon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIcon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtIcon.Location = new System.Drawing.Point(15, 50);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.PasswordChar = '\0';
            this.txtIcon.PlaceholderText = "";
            this.txtIcon.SelectedText = "";
            this.txtIcon.Size = new System.Drawing.Size(176, 21);
            this.txtIcon.TabIndex = 148;
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox4.Controls.Add(this.txtFileVersion);
            this.guna2GroupBox4.Controls.Add(this.label8);
            this.guna2GroupBox4.Controls.Add(this.txtProductVersion);
            this.guna2GroupBox4.Controls.Add(this.label14);
            this.guna2GroupBox4.Controls.Add(this.txtOriginalFilename);
            this.guna2GroupBox4.Controls.Add(this.label13);
            this.guna2GroupBox4.Controls.Add(this.txtCompany);
            this.guna2GroupBox4.Controls.Add(this.label12);
            this.guna2GroupBox4.Controls.Add(this.txtCopyright);
            this.guna2GroupBox4.Controls.Add(this.label7);
            this.guna2GroupBox4.Controls.Add(this.txtTrademarks);
            this.guna2GroupBox4.Controls.Add(this.label11);
            this.guna2GroupBox4.Controls.Add(this.txtDescription);
            this.guna2GroupBox4.Controls.Add(this.label9);
            this.guna2GroupBox4.Controls.Add(this.txtProduct);
            this.guna2GroupBox4.Controls.Add(this.label10);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition2.SetDecoration(this.guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GroupBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox4.Enabled = false;
            this.guna2GroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox4.Location = new System.Drawing.Point(120, 100);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(318, 263);
            this.guna2GroupBox4.TabIndex = 135;
            this.guna2GroupBox4.Text = "Assembly Options";
            // 
            // txtFileVersion
            // 
            this.txtFileVersion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtFileVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtFileVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtFileVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtFileVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtFileVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtFileVersion.DefaultText = "0.0.0.0";
            this.txtFileVersion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtFileVersion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtFileVersion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtFileVersion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtFileVersion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtFileVersion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtFileVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileVersion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtFileVersion.Location = new System.Drawing.Point(124, 232);
            this.txtFileVersion.Name = "txtFileVersion";
            this.txtFileVersion.PasswordChar = '\0';
            this.txtFileVersion.PlaceholderText = "Username";
            this.txtFileVersion.SelectedText = "";
            this.txtFileVersion.SelectionStart = 7;
            this.txtFileVersion.Size = new System.Drawing.Size(176, 21);
            this.txtFileVersion.TabIndex = 154;
            // 
            // txtProductVersion
            // 
            this.txtProductVersion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProductVersion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtProductVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtProductVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtProductVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtProductVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtProductVersion.DefaultText = "0.0.0.0";
            this.txtProductVersion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtProductVersion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtProductVersion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProductVersion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProductVersion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtProductVersion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtProductVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductVersion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtProductVersion.Location = new System.Drawing.Point(124, 206);
            this.txtProductVersion.Name = "txtProductVersion";
            this.txtProductVersion.PasswordChar = '\0';
            this.txtProductVersion.PlaceholderText = "Username";
            this.txtProductVersion.SelectedText = "";
            this.txtProductVersion.SelectionStart = 7;
            this.txtProductVersion.Size = new System.Drawing.Size(176, 21);
            this.txtProductVersion.TabIndex = 153;
            // 
            // txtOriginalFilename
            // 
            this.txtOriginalFilename.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtOriginalFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtOriginalFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtOriginalFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtOriginalFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtOriginalFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtOriginalFilename.DefaultText = "";
            this.txtOriginalFilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtOriginalFilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtOriginalFilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtOriginalFilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtOriginalFilename.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtOriginalFilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtOriginalFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalFilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtOriginalFilename.Location = new System.Drawing.Point(124, 180);
            this.txtOriginalFilename.Name = "txtOriginalFilename";
            this.txtOriginalFilename.PasswordChar = '\0';
            this.txtOriginalFilename.PlaceholderText = "";
            this.txtOriginalFilename.SelectedText = "";
            this.txtOriginalFilename.Size = new System.Drawing.Size(176, 21);
            this.txtOriginalFilename.TabIndex = 152;
            // 
            // txtCompany
            // 
            this.txtCompany.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtCompany, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCompany.DefaultText = "";
            this.txtCompany.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtCompany.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtCompany.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCompany.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCompany.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtCompany.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtCompany.Location = new System.Drawing.Point(124, 102);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.PasswordChar = '\0';
            this.txtCompany.PlaceholderText = "";
            this.txtCompany.SelectedText = "";
            this.txtCompany.Size = new System.Drawing.Size(176, 21);
            this.txtCompany.TabIndex = 151;
            // 
            // txtCopyright
            // 
            this.txtCopyright.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCopyright.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtCopyright, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtCopyright, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtCopyright, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtCopyright, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtCopyright.DefaultText = "";
            this.txtCopyright.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtCopyright.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtCopyright.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCopyright.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtCopyright.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtCopyright.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCopyright.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtCopyright.Location = new System.Drawing.Point(124, 128);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.PasswordChar = '\0';
            this.txtCopyright.PlaceholderText = "";
            this.txtCopyright.SelectedText = "";
            this.txtCopyright.Size = new System.Drawing.Size(176, 21);
            this.txtCopyright.TabIndex = 150;
            // 
            // txtTrademarks
            // 
            this.txtTrademarks.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtTrademarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtTrademarks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtTrademarks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtTrademarks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtTrademarks, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtTrademarks.DefaultText = "";
            this.txtTrademarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtTrademarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTrademarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtTrademarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtTrademarks.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtTrademarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTrademarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrademarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtTrademarks.Location = new System.Drawing.Point(124, 154);
            this.txtTrademarks.Name = "txtTrademarks";
            this.txtTrademarks.PasswordChar = '\0';
            this.txtTrademarks.PlaceholderText = "";
            this.txtTrademarks.SelectedText = "";
            this.txtTrademarks.Size = new System.Drawing.Size(176, 21);
            this.txtTrademarks.TabIndex = 149;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtDescription, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtDescription.Location = new System.Drawing.Point(124, 76);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(176, 21);
            this.txtDescription.TabIndex = 148;
            // 
            // txtProduct
            // 
            this.txtProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtProduct, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtProduct, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtProduct, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtProduct, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtProduct.DefaultText = "";
            this.txtProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtProduct.Location = new System.Drawing.Point(124, 50);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.PasswordChar = '\0';
            this.txtProduct.PlaceholderText = "";
            this.txtProduct.SelectedText = "";
            this.txtProduct.Size = new System.Drawing.Size(176, 21);
            this.txtProduct.TabIndex = 147;
            // 
            // chkIcon
            // 
            this.chkIcon.AutoSize = true;
            this.chkIcon.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkIcon.CheckedState.BorderRadius = 0;
            this.chkIcon.CheckedState.BorderThickness = 1;
            this.chkIcon.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkIcon.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkIcon.Location = new System.Drawing.Point(458, 76);
            this.chkIcon.Name = "chkIcon";
            this.chkIcon.Size = new System.Drawing.Size(87, 17);
            this.chkIcon.TabIndex = 134;
            this.chkIcon.Text = "Change Icon";
            this.guna2HtmlToolTip1.SetToolTip(this.chkIcon, "Enable/Disable   Change icon of your exe!");
            this.chkIcon.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkIcon.UncheckedState.BorderRadius = 0;
            this.chkIcon.UncheckedState.BorderThickness = 1;
            this.chkIcon.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkIcon.CheckedChanged += new System.EventHandler(this.ChkIcon_CheckedChanged);
            // 
            // btnAssembly
            // 
            this.btnAssembly.AutoSize = true;
            this.btnAssembly.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAssembly.CheckedState.BorderRadius = 0;
            this.btnAssembly.CheckedState.BorderThickness = 1;
            this.btnAssembly.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAssembly.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.btnAssembly, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAssembly, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.btnAssembly, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnAssembly, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.btnAssembly.Location = new System.Drawing.Point(120, 76);
            this.btnAssembly.Name = "btnAssembly";
            this.btnAssembly.Size = new System.Drawing.Size(70, 17);
            this.btnAssembly.TabIndex = 133;
            this.btnAssembly.Text = "Assembly";
            this.guna2HtmlToolTip1.SetToolTip(this.btnAssembly, "Enable/Disable  Change assembly info or your exe!");
            this.btnAssembly.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnAssembly.UncheckedState.BorderRadius = 0;
            this.btnAssembly.UncheckedState.BorderThickness = 1;
            this.btnAssembly.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnAssembly.CheckedChanged += new System.EventHandler(this.BtnAssembly_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage3.Controls.Add(this.guna2Separator5);
            this.tabPage3.Controls.Add(this.guna2GroupBox3);
            this.tabPage3.Controls.Add(this.chkPaste_bin);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.guna2Transition2.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.tabPage3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1080, 465);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Installation";
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator5.Location = new System.Drawing.Point(-162, -3);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator5.TabIndex = 140;
            this.guna2Separator5.UseTransparentBackground = true;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox3.Controls.Add(this.guna2GradientButton2);
            this.guna2GroupBox3.Controls.Add(this.txtPaste_bin);
            this.guna2GroupBox3.Controls.Add(this.txtMutex);
            this.guna2GroupBox3.Controls.Add(this.textFilename);
            this.guna2GroupBox3.Controls.Add(this.label19);
            this.guna2GroupBox3.Controls.Add(this.label18);
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.Controls.Add(this.comboBoxFolder);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.numDelay);
            this.guna2GroupBox3.Controls.Add(this.label5);
            this.guna2GroupBox3.Controls.Add(this.txtGroup);
            this.guna2GroupBox3.Controls.Add(this.label3);
            this.guna2GroupBox3.Controls.Add(this.label4);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition2.SetDecoration(this.guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GroupBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox3.Enabled = false;
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox3.Location = new System.Drawing.Point(53, 67);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(793, 332);
            this.guna2GroupBox3.TabIndex = 139;
            this.guna2GroupBox3.Text = "Installation";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton2.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton2.Location = new System.Drawing.Point(517, 113);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(101, 21);
            this.guna2GradientButton2.TabIndex = 152;
            this.guna2GradientButton2.Text = "Random";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // txtPaste_bin
            // 
            this.txtPaste_bin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtPaste_bin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtPaste_bin.DefaultText = "";
            this.txtPaste_bin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtPaste_bin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPaste_bin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtPaste_bin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtPaste_bin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtPaste_bin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPaste_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaste_bin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtPaste_bin.Location = new System.Drawing.Point(274, 271);
            this.txtPaste_bin.Name = "txtPaste_bin";
            this.txtPaste_bin.PasswordChar = '\0';
            this.txtPaste_bin.PlaceholderText = "";
            this.txtPaste_bin.SelectedText = "";
            this.txtPaste_bin.Size = new System.Drawing.Size(176, 21);
            this.txtPaste_bin.TabIndex = 151;
            this.txtPaste_bin.Visible = false;
            // 
            // txtMutex
            // 
            this.txtMutex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtMutex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.txtMutex, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtMutex, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtMutex, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtMutex, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtMutex.DefaultText = "PEGASUSMutex_αβγδεζηθικλμνξοπρστ";
            this.txtMutex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.txtMutex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtMutex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtMutex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.txtMutex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtMutex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtMutex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMutex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.txtMutex.Location = new System.Drawing.Point(333, 113);
            this.txtMutex.Name = "txtMutex";
            this.txtMutex.PasswordChar = '\0';
            this.txtMutex.PlaceholderText = "";
            this.txtMutex.SelectedText = "";
            this.txtMutex.SelectionStart = 30;
            this.txtMutex.Size = new System.Drawing.Size(176, 21);
            this.txtMutex.TabIndex = 150;
            this.guna2HtmlToolTip1.SetToolTip(this.txtMutex, "Add a random mutex here!");
            // 
            // textFilename
            // 
            this.textFilename.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition4.SetDecoration(this.textFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.textFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.textFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.textFilename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.textFilename.DefaultText = "PEGASUS";
            this.textFilename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.textFilename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textFilename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textFilename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.textFilename.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.textFilename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFilename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.textFilename.Location = new System.Drawing.Point(333, 173);
            this.textFilename.Name = "textFilename";
            this.textFilename.PasswordChar = '\0';
            this.textFilename.PlaceholderText = "";
            this.textFilename.SelectedText = "";
            this.textFilename.SelectionStart = 5;
            this.textFilename.Size = new System.Drawing.Size(176, 21);
            this.textFilename.TabIndex = 149;
            this.guna2HtmlToolTip1.SetToolTip(this.textFilename, "Give your payload a custom exe name!");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label19, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label19.Location = new System.Drawing.Point(514, 179);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 15);
            this.label19.TabIndex = 140;
            this.label19.Text = ".exe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label18, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label18.Location = new System.Drawing.Point(271, 253);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 15);
            this.label18.TabIndex = 139;
            this.label18.Text = "Pastebin:";
            this.label18.Visible = false;
            // 
            // comboBoxFolder
            // 
            this.comboBoxFolder.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.comboBoxFolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.comboBoxFolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.comboBoxFolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.comboBoxFolder, Guna.UI2.AnimatorNS.DecorationType.None);
            this.comboBoxFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.comboBoxFolder.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFolder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F);
            this.comboBoxFolder.ForeColor = System.Drawing.Color.LightGray;
            this.comboBoxFolder.ItemHeight = 30;
            this.comboBoxFolder.Items.AddRange(new object[] {
            "%AppData%",
            "%Temp%"});
            this.comboBoxFolder.Location = new System.Drawing.Point(333, 206);
            this.comboBoxFolder.Name = "comboBoxFolder";
            this.comboBoxFolder.Size = new System.Drawing.Size(140, 36);
            this.comboBoxFolder.TabIndex = 138;
            this.guna2HtmlToolTip1.SetToolTip(this.comboBoxFolder, "Select the path for your payload installation!");
            // 
            // numDelay
            // 
            this.numDelay.BackColor = System.Drawing.Color.Transparent;
            this.numDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.numDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition3.SetDecoration(this.numDelay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.numDelay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.numDelay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.numDelay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.numDelay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.numDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDelay.ForeColor = System.Drawing.Color.LightGray;
            this.numDelay.Location = new System.Drawing.Point(333, 142);
            this.numDelay.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(56, 25);
            this.numDelay.TabIndex = 137;
            this.guna2HtmlToolTip1.SetToolTip(this.numDelay, "Delay for the execution of your payload!");
            this.numDelay.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.numDelay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtGroup
            // 
            this.txtGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2Transition4.SetDecoration(this.txtGroup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.txtGroup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.txtGroup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.txtGroup, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtGroup.ForeColor = System.Drawing.Color.LightGray;
            this.txtGroup.Location = new System.Drawing.Point(333, 86);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(2);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(110, 21);
            this.txtGroup.TabIndex = 110;
            this.txtGroup.Text = "Default";
            this.guna2HtmlToolTip1.SetToolTip(this.txtGroup, "Give your client a group name!");
            // 
            // chkPaste_bin
            // 
            this.chkPaste_bin.AutoSize = true;
            this.chkPaste_bin.BackColor = System.Drawing.Color.Transparent;
            this.chkPaste_bin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkPaste_bin.CheckedState.BorderRadius = 0;
            this.chkPaste_bin.CheckedState.BorderThickness = 1;
            this.chkPaste_bin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkPaste_bin.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkPaste_bin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkPaste_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkPaste_bin.Location = new System.Drawing.Point(167, 45);
            this.chkPaste_bin.Name = "chkPaste_bin";
            this.chkPaste_bin.Size = new System.Drawing.Size(87, 17);
            this.chkPaste_bin.TabIndex = 136;
            this.chkPaste_bin.Text = "Get ip by link";
            this.chkPaste_bin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkPaste_bin.UncheckedState.BorderRadius = 0;
            this.chkPaste_bin.UncheckedState.BorderThickness = 1;
            this.chkPaste_bin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkPaste_bin.UseVisualStyleBackColor = false;
            this.chkPaste_bin.Visible = false;
            this.chkPaste_bin.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 1;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.checkBox1.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.checkBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.checkBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.checkBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.checkBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.checkBox1.Location = new System.Drawing.Point(57, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 135;
            this.checkBox1.Text = "Installation OFF";
            this.guna2HtmlToolTip1.SetToolTip(this.checkBox1, "Enable/Disable  Installation of your payload!");
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 1;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage4.Controls.Add(this.guna2Separator3);
            this.tabPage4.Controls.Add(this.guna2GroupBox2);
            this.guna2Transition2.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.tabPage4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1080, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Extras";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator3.Location = new System.Drawing.Point(-162, -3);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator3.TabIndex = 127;
            this.guna2Separator3.UseTransparentBackground = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GroupBox2.Controls.Add(this.chkUSB);
            this.guna2GroupBox2.Controls.Add(this.chkKillWD);
            this.guna2GroupBox2.Controls.Add(this.chkExclude);
            this.guna2GroupBox2.Controls.Add(this.chkAntiK);
            this.guna2GroupBox2.Controls.Add(this.chkUac);
            this.guna2GroupBox2.Controls.Add(this.chkBsod);
            this.guna2GroupBox2.Controls.Add(this.chkAnti);
            this.guna2GroupBox2.Controls.Add(this.chkAntiProcess);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition2.SetDecoration(this.guna2GroupBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2GroupBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GroupBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GroupBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.guna2GroupBox2.Location = new System.Drawing.Point(61, 88);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(779, 306);
            this.guna2GroupBox2.TabIndex = 124;
            this.guna2GroupBox2.Text = "Extras";
            // 
            // chkUSB
            // 
            this.chkUSB.AutoSize = true;
            this.chkUSB.BackColor = System.Drawing.Color.Transparent;
            this.chkUSB.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkUSB.CheckedState.BorderRadius = 0;
            this.chkUSB.CheckedState.BorderThickness = 1;
            this.chkUSB.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkUSB.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkUSB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkUSB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkUSB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkUSB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkUSB.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUSB.Location = new System.Drawing.Point(456, 144);
            this.chkUSB.Name = "chkUSB";
            this.chkUSB.Size = new System.Drawing.Size(87, 18);
            this.chkUSB.TabIndex = 127;
            this.chkUSB.Text = "USB Spread";
            this.guna2HtmlToolTip1.SetToolTip(this.chkUSB, "Spread your payload on all disks!");
            this.chkUSB.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkUSB.UncheckedState.BorderRadius = 0;
            this.chkUSB.UncheckedState.BorderThickness = 1;
            this.chkUSB.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkUSB.UseVisualStyleBackColor = false;
            // 
            // chkKillWD
            // 
            this.chkKillWD.AutoSize = true;
            this.chkKillWD.BackColor = System.Drawing.Color.Transparent;
            this.chkKillWD.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkKillWD.CheckedState.BorderRadius = 0;
            this.chkKillWD.CheckedState.BorderThickness = 1;
            this.chkKillWD.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkKillWD.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkKillWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkKillWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkKillWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkKillWD, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkKillWD.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKillWD.Location = new System.Drawing.Point(298, 185);
            this.chkKillWD.Name = "chkKillWD";
            this.chkKillWD.Size = new System.Drawing.Size(138, 18);
            this.chkKillWD.TabIndex = 126;
            this.chkKillWD.Text = "Kill Windows Defender";
            this.guna2HtmlToolTip1.SetToolTip(this.chkKillWD, "Kill Windows defender on execution!");
            this.chkKillWD.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkKillWD.UncheckedState.BorderRadius = 0;
            this.chkKillWD.UncheckedState.BorderThickness = 1;
            this.chkKillWD.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkKillWD.UseVisualStyleBackColor = false;
            // 
            // chkExclude
            // 
            this.chkExclude.AutoSize = true;
            this.chkExclude.BackColor = System.Drawing.Color.Transparent;
            this.chkExclude.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkExclude.CheckedState.BorderRadius = 0;
            this.chkExclude.CheckedState.BorderThickness = 1;
            this.chkExclude.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkExclude.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkExclude, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkExclude, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkExclude, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkExclude, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkExclude.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExclude.Location = new System.Drawing.Point(122, 185);
            this.chkExclude.Name = "chkExclude";
            this.chkExclude.Size = new System.Drawing.Size(115, 18);
            this.chkExclude.TabIndex = 125;
            this.chkExclude.Text = "Exclude From WD";
            this.guna2HtmlToolTip1.SetToolTip(this.chkExclude, "Add Pegasus Payload to Windows exclude list!");
            this.chkExclude.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkExclude.UncheckedState.BorderRadius = 0;
            this.chkExclude.UncheckedState.BorderThickness = 1;
            this.chkExclude.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkExclude.UseVisualStyleBackColor = false;
            // 
            // chkAntiK
            // 
            this.chkAntiK.AutoSize = true;
            this.chkAntiK.BackColor = System.Drawing.Color.Transparent;
            this.chkAntiK.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAntiK.CheckedState.BorderRadius = 0;
            this.chkAntiK.CheckedState.BorderThickness = 1;
            this.chkAntiK.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAntiK.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkAntiK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkAntiK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkAntiK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkAntiK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkAntiK.Enabled = false;
            this.chkAntiK.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAntiK.Location = new System.Drawing.Point(573, 185);
            this.chkAntiK.Name = "chkAntiK";
            this.chkAntiK.Size = new System.Drawing.Size(84, 18);
            this.chkAntiK.TabIndex = 124;
            this.chkAntiK.Text = "Watch Dog ";
            this.guna2HtmlToolTip1.SetToolTip(this.chkAntiK, "If payload is killed with task manager ,run it again!");
            this.chkAntiK.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAntiK.UncheckedState.BorderRadius = 0;
            this.chkAntiK.UncheckedState.BorderThickness = 1;
            this.chkAntiK.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAntiK.UseVisualStyleBackColor = false;
            // 
            // chkUac
            // 
            this.chkUac.AutoSize = true;
            this.chkUac.BackColor = System.Drawing.Color.Transparent;
            this.chkUac.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkUac.CheckedState.BorderRadius = 0;
            this.chkUac.CheckedState.BorderThickness = 1;
            this.chkUac.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkUac.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkUac, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkUac, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkUac, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkUac, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkUac.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUac.Location = new System.Drawing.Point(457, 185);
            this.chkUac.Name = "chkUac";
            this.chkUac.Size = new System.Drawing.Size(84, 18);
            this.chkUac.TabIndex = 123;
            this.chkUac.Text = "Take Admin";
            this.guna2HtmlToolTip1.SetToolTip(this.chkUac, "Take admin priviliges on execution!");
            this.chkUac.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkUac.UncheckedState.BorderRadius = 0;
            this.chkUac.UncheckedState.BorderThickness = 1;
            this.chkUac.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkUac.UseVisualStyleBackColor = false;
            // 
            // chkBsod
            // 
            this.chkBsod.AutoSize = true;
            this.chkBsod.BackColor = System.Drawing.Color.Transparent;
            this.chkBsod.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkBsod.CheckedState.BorderRadius = 0;
            this.chkBsod.CheckedState.BorderThickness = 1;
            this.chkBsod.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkBsod.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkBsod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkBsod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkBsod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkBsod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkBsod.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBsod.Location = new System.Drawing.Point(297, 144);
            this.chkBsod.Name = "chkBsod";
            this.chkBsod.Size = new System.Drawing.Size(121, 18);
            this.chkBsod.TabIndex = 122;
            this.chkBsod.Text = "Blue Screen Error!";
            this.guna2HtmlToolTip1.SetToolTip(this.chkBsod, "Blue screen error if payload killed!");
            this.chkBsod.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkBsod.UncheckedState.BorderRadius = 0;
            this.chkBsod.UncheckedState.BorderThickness = 1;
            this.chkBsod.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkBsod.UseVisualStyleBackColor = false;
            // 
            // chkAnti
            // 
            this.chkAnti.AutoSize = true;
            this.chkAnti.BackColor = System.Drawing.Color.Transparent;
            this.chkAnti.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAnti.CheckedState.BorderRadius = 0;
            this.chkAnti.CheckedState.BorderThickness = 1;
            this.chkAnti.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAnti.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkAnti, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkAnti, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkAnti, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkAnti, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkAnti.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnti.Location = new System.Drawing.Point(121, 144);
            this.chkAnti.Name = "chkAnti";
            this.chkAnti.Size = new System.Drawing.Size(79, 18);
            this.chkAnti.TabIndex = 120;
            this.chkAnti.Text = "Anti debug";
            this.guna2HtmlToolTip1.SetToolTip(this.chkAnti, "Don\'t run if debug tools are in the system!");
            this.chkAnti.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAnti.UncheckedState.BorderRadius = 0;
            this.chkAnti.UncheckedState.BorderThickness = 1;
            this.chkAnti.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAnti.UseVisualStyleBackColor = false;
            // 
            // chkAntiProcess
            // 
            this.chkAntiProcess.AutoSize = true;
            this.chkAntiProcess.BackColor = System.Drawing.Color.Transparent;
            this.chkAntiProcess.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAntiProcess.CheckedState.BorderRadius = 0;
            this.chkAntiProcess.CheckedState.BorderThickness = 1;
            this.chkAntiProcess.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAntiProcess.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkAntiProcess, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkAntiProcess, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkAntiProcess, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkAntiProcess, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkAntiProcess.Font = new System.Drawing.Font("Electrolize", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAntiProcess.Location = new System.Drawing.Point(572, 144);
            this.chkAntiProcess.Name = "chkAntiProcess";
            this.chkAntiProcess.Size = new System.Drawing.Size(85, 18);
            this.chkAntiProcess.TabIndex = 121;
            this.chkAntiProcess.Text = "kill taskmgr";
            this.guna2HtmlToolTip1.SetToolTip(this.chkAntiProcess, "Kill task manager on execution!");
            this.chkAntiProcess.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkAntiProcess.UncheckedState.BorderRadius = 0;
            this.chkAntiProcess.UncheckedState.BorderThickness = 1;
            this.chkAntiProcess.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkAntiProcess.UseVisualStyleBackColor = false;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tabPage6.Controls.Add(this.guna2GradientButton3);
            this.tabPage6.Controls.Add(this.chkRename);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.chkCert);
            this.tabPage6.Controls.Add(this.chkVBS);
            this.tabPage6.Controls.Add(this.chkPowershell);
            this.tabPage6.Controls.Add(this.chVRunPe);
            this.tabPage6.Controls.Add(this.chkObfu);
            this.tabPage6.Controls.Add(this.guna2Separator2);
            this.tabPage6.Controls.Add(this.btnShellcode);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.btnBuild);
            this.tabPage6.Controls.Add(this.guna2PictureBox3);
            this.tabPage6.Controls.Add(this.guna2PictureBox4);
            this.tabPage6.Controls.Add(this.guna2TextBox1);
            this.tabPage6.Controls.Add(this.guna2PictureBox2);
            this.tabPage6.Controls.Add(this.richTextBox2);
            this.guna2Transition2.SetDecoration(this.tabPage6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.tabPage6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.tabPage6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.tabPage6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1080, 465);
            this.tabPage6.TabIndex = 4;
            this.tabPage6.Text = "Code Obfuscation";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2GradientButton3.BorderThickness = 1;
            this.guna2GradientButton3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2GradientButton3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton3.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2GradientButton3.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2GradientButton3.Location = new System.Drawing.Point(329, 419);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(244, 30);
            this.guna2GradientButton3.TabIndex = 135;
            this.guna2GradientButton3.Text = "Detection Rate";
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // chkRename
            // 
            this.chkRename.AutoSize = true;
            this.chkRename.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkRename.CheckedState.BorderRadius = 0;
            this.chkRename.CheckedState.BorderThickness = 1;
            this.chkRename.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkRename.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkRename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkRename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkRename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkRename, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkRename.Location = new System.Drawing.Point(458, 363);
            this.chkRename.Name = "chkRename";
            this.chkRename.Size = new System.Drawing.Size(115, 17);
            this.chkRename.TabIndex = 134;
            this.chkRename.Text = "Rename Functions";
            this.guna2HtmlToolTip1.SetToolTip(this.chkRename, "Obfuscate Payload!Don\'t check this if you use a crypter!");
            this.chkRename.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkRename.UncheckedState.BorderRadius = 0;
            this.chkRename.UncheckedState.BorderThickness = 1;
            this.chkRename.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.guna2Transition4.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(615, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 133;
            this.label2.Text = "Be informed that we can terminate your  license if\r\n we get reports or notice any" +
    " ilegal activity!\r\n\r\n";
            // 
            // chkCert
            // 
            this.chkCert.AutoSize = true;
            this.chkCert.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkCert.CheckedState.BorderRadius = 0;
            this.chkCert.CheckedState.BorderThickness = 1;
            this.chkCert.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkCert.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkCert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkCert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkCert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkCert, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkCert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkCert.Location = new System.Drawing.Point(98, 416);
            this.chkCert.Name = "chkCert";
            this.chkCert.Size = new System.Drawing.Size(84, 17);
            this.chkCert.TabIndex = 131;
            this.chkCert.Text = "Cert Installer";
            this.guna2HtmlToolTip1.SetToolTip(this.chkCert, "Obfuscate Payload!");
            this.chkCert.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkCert.UncheckedState.BorderRadius = 0;
            this.chkCert.UncheckedState.BorderThickness = 1;
            this.chkCert.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkCert.Visible = false;
            // 
            // chkVBS
            // 
            this.chkVBS.AutoSize = true;
            this.chkVBS.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkVBS.CheckedState.BorderRadius = 0;
            this.chkVBS.CheckedState.BorderThickness = 1;
            this.chkVBS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkVBS.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.guna2Transition2.SetDecoration(this.chkVBS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkVBS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkVBS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkVBS, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkVBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkVBS.Location = new System.Drawing.Point(99, 439);
            this.chkVBS.Name = "chkVBS";
            this.chkVBS.Size = new System.Drawing.Size(83, 17);
            this.chkVBS.TabIndex = 130;
            this.chkVBS.Text = "VBS Loader";
            this.guna2HtmlToolTip1.SetToolTip(this.chkVBS, "Obfuscate Payload!");
            this.chkVBS.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkVBS.UncheckedState.BorderRadius = 0;
            this.chkVBS.UncheckedState.BorderThickness = 1;
            this.chkVBS.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkVBS.Visible = false;
            // 
            // chkPowershell
            // 
            this.chkPowershell.AutoSize = true;
            this.chkPowershell.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkPowershell.CheckedState.BorderRadius = 0;
            this.chkPowershell.CheckedState.BorderThickness = 1;
            this.chkPowershell.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkPowershell.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.guna2Transition2.SetDecoration(this.chkPowershell, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkPowershell, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkPowershell, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkPowershell, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkPowershell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkPowershell.Location = new System.Drawing.Point(98, 393);
            this.chkPowershell.Name = "chkPowershell";
            this.chkPowershell.Size = new System.Drawing.Size(113, 17);
            this.chkPowershell.TabIndex = 129;
            this.chkPowershell.Text = "Powershell Loader";
            this.guna2HtmlToolTip1.SetToolTip(this.chkPowershell, "Obfuscate Payload!");
            this.chkPowershell.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chkPowershell.UncheckedState.BorderRadius = 0;
            this.chkPowershell.UncheckedState.BorderThickness = 1;
            this.chkPowershell.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkPowershell.Visible = false;
            // 
            // chVRunPe
            // 
            this.chVRunPe.AutoSize = true;
            this.chVRunPe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chVRunPe.CheckedState.BorderRadius = 0;
            this.chVRunPe.CheckedState.BorderThickness = 1;
            this.chVRunPe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chVRunPe.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chVRunPe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chVRunPe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chVRunPe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chVRunPe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chVRunPe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chVRunPe.Location = new System.Drawing.Point(188, 416);
            this.chVRunPe.Name = "chVRunPe";
            this.chVRunPe.Size = new System.Drawing.Size(114, 17);
            this.chVRunPe.TabIndex = 123;
            this.chVRunPe.Text = "PEGASUS RunPE";
            this.guna2HtmlToolTip1.SetToolTip(this.chVRunPe, "Encrypt Payload and run via RunPe!");
            this.chVRunPe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.chVRunPe.UncheckedState.BorderRadius = 0;
            this.chVRunPe.UncheckedState.BorderThickness = 1;
            this.chVRunPe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chVRunPe.Visible = false;
            this.chVRunPe.CheckedChanged += new System.EventHandler(this.chVRunPe_CheckedChanged);
            // 
            // chkObfu
            // 
            this.chkObfu.AutoSize = true;
            this.chkObfu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkObfu.CheckedState.BorderRadius = 0;
            this.chkObfu.CheckedState.BorderThickness = 1;
            this.chkObfu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.chkObfu.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2Transition2.SetDecoration(this.chkObfu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.chkObfu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.chkObfu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.chkObfu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chkObfu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.chkObfu.Location = new System.Drawing.Point(329, 363);
            this.chkObfu.Name = "chkObfu";
            this.chkObfu.Size = new System.Drawing.Size(103, 17);
            this.chkObfu.TabIndex = 119;
            this.chkObfu.Text = "Encrypt Payload";
            this.guna2HtmlToolTip1.SetToolTip(this.chkObfu, "Obfuscate Payload!Don\'t check this if you use a crypter!");
            this.chkObfu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.chkObfu.UncheckedState.BorderRadius = 0;
            this.chkObfu.UncheckedState.BorderThickness = 1;
            this.chkObfu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2Separator2.Location = new System.Drawing.Point(-147, -3);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1405, 10);
            this.guna2Separator2.TabIndex = 126;
            this.guna2Separator2.UseTransparentBackground = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2Transition2.SetDecoration(this.richTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.richTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.richTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.richTextBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.richTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.richTextBox2.Location = new System.Drawing.Point(578, 320);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 96);
            this.richTextBox2.TabIndex = 125;
            this.richTextBox2.Text = "";
            // 
            // btnShellcode
            // 
            this.btnShellcode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnShellcode.BorderThickness = 1;
            this.btnShellcode.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnShellcode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnShellcode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnShellcode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnShellcode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnShellcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnShellcode.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnShellcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnShellcode.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnShellcode.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnShellcode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnShellcode.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnShellcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnShellcode.ForeColor = System.Drawing.Color.White;
            this.btnShellcode.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnShellcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnShellcode.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnShellcode.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnShellcode.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnShellcode.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnShellcode.Location = new System.Drawing.Point(609, 416);
            this.btnShellcode.Name = "btnShellcode";
            this.btnShellcode.Size = new System.Drawing.Size(244, 30);
            this.btnShellcode.TabIndex = 124;
            this.btnShellcode.Text = "Build As ShellCode";
            this.btnShellcode.Visible = false;
            this.btnShellcode.Click += new System.EventHandler(this.btnShelocode_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.guna2Transition4.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(50, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 39);
            this.label6.TabIndex = 120;
            this.label6.Text = "Please do not use this software to attack people \r\nand steal they passwords and m" +
    "oney.\r\n\r\n";
            // 
            // btnBuild
            // 
            this.btnBuild.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.btnBuild.BorderThickness = 1;
            this.btnBuild.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Transition4.SetDecoration(this.btnBuild, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.btnBuild, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnBuild, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.btnBuild, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnBuild.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBuild.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBuild.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBuild.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBuild.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnBuild.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBuild.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnBuild.ForeColor = System.Drawing.Color.White;
            this.btnBuild.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnBuild.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnBuild.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.btnBuild.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBuild.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btnBuild.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.btnBuild.Location = new System.Drawing.Point(329, 385);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(244, 30);
            this.btnBuild.TabIndex = 118;
            this.btnBuild.Text = "Build";
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(430, 168);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox3.TabIndex = 122;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            this.guna2PictureBox3.Visible = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2Transition4.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(305, -3);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(300, 155);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 127;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2Transition2.SetDecoration(this.guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2TextBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.Location = new System.Drawing.Point(222, 224);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Size = new System.Drawing.Size(475, 133);
            this.guna2TextBox1.TabIndex = 132;
            this.guna2TextBox1.Text = "";
            this.guna2TextBox1.Visible = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2PictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(409, 153);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(92, 76);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 121;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.label15);
            this.guna2Transition4.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(909, 67);
            this.guna2Panel1.TabIndex = 136;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition4.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.guna2Separator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator1.Location = new System.Drawing.Point(-198, 61);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1306, 10);
            this.guna2Separator1.TabIndex = 13;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.guna2Transition3.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.guna2Transition4.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition2.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this.label15, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(412, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "BUILDER";
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation3;
            // 
            // guna2Transition2
            // 
            this.guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            this.guna2Transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition2.DefaultAnimation = animation2;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.LightGray;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2HtmlToolTip1.ToolTipTitle = "PEGASUS";
            // 
            // guna2Transition3
            // 
            this.guna2Transition3.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.guna2Transition3.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.guna2Transition3.DefaultAnimation = animation4;
            // 
            // guna2Transition4
            // 
            this.guna2Transition4.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Mosaic;
            this.guna2Transition4.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition4.DefaultAnimation = animation1;
            // 
            // FormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(909, 586);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.guna2Panel1);
            this.guna2Transition2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition4.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition3.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Builder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBuilder_FormClosed);
            this.Load += new System.EventHandler(this.Builder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.guna2ContextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2TabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.guna2GroupBox5.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.guna2GroupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxIP;
        private System.Windows.Forms.ListBox listBoxPort;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddIP;
        private Guna.UI2.WinForms.Guna2GradientButton btnClone;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveIP;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddPort;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemovePort;
        private Guna.UI2.WinForms.Guna2GradientButton btnIcon;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private Guna.UI2.WinForms.Guna2GradientButton btnBuild;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2CheckBox chkObfu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CheckBox chkBsod;
        private Guna.UI2.WinForms.Guna2CheckBox chkAntiProcess;
        private Guna.UI2.WinForms.Guna2CheckBox chkAnti;
        private Guna.UI2.WinForms.Guna2CheckBox chkIcon;
        private Guna.UI2.WinForms.Guna2CheckBox btnAssembly;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxFolder;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDelay;
        private Guna.UI2.WinForms.Guna2CheckBox chkPaste_bin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition2;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CheckBox chVRunPe;
        private Guna.UI2.WinForms.Guna2GradientButton btnShellcode;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox5;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator6;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2TextBox txtIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtFileVersion;
        private Guna.UI2.WinForms.Guna2TextBox txtProductVersion;
        private Guna.UI2.WinForms.Guna2TextBox txtOriginalFilename;
        private Guna.UI2.WinForms.Guna2TextBox txtCompany;
        private Guna.UI2.WinForms.Guna2TextBox txtCopyright;
        private Guna.UI2.WinForms.Guna2TextBox txtTrademarks;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtPaste_bin;
        private Guna.UI2.WinForms.Guna2TextBox txtMutex;
        private Guna.UI2.WinForms.Guna2TextBox textFilename;
        private Guna.UI2.WinForms.Guna2TextBox textPort;
        private Guna.UI2.WinForms.Guna2TextBox textIP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator7;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem70;
        private Guna.UI2.WinForms.Guna2CheckBox chkExclude;
        private Guna.UI2.WinForms.Guna2CheckBox chkAntiK;
        private Guna.UI2.WinForms.Guna2CheckBox chkUac;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2CheckBox chkPowershell;
        private Guna.UI2.WinForms.Guna2GradientButton btnStatic;
        private Guna.UI2.WinForms.Guna2GradientButton btnEx;
        private Guna.UI2.WinForms.Guna2GradientButton btnLocal;
        private Guna.UI2.WinForms.Guna2CheckBox chkVBS;
        private Guna.UI2.WinForms.Guna2CheckBox chkCert;
        private Guna.UI2.WinForms.Guna2CheckBox chkKillWD;
        private Guna.UI2.WinForms.Guna2CheckBox chkUSB;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton btnRandom;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private System.Windows.Forms.RichTextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition4;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox chkRename;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
    }
}
