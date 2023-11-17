using PEGASUS.IcarusWings;
using System.Drawing;

namespace PEGASUS.Design
{
    partial class FormRegistryEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistryEditor));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.selectedStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tvRegistryDirectory = new IcarusWings.RegistryTreeView();
            this.imageRegistryDirectoryList = new System.Windows.Forms.ImageList(this.components);
            this.lstRegistryValues = new IcarusWings.AeroListView();
            this.hName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageRegistryKeyTypeList = new System.Windows.Forms.ImageList(this.components);
            this.tv_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedItem_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBinaryDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lst_ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.keyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dWORD32bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.qWORD64bitValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.multiStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.expandableStringValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tv_ContextMenuStrip.SuspendLayout();
            this.selectedItem_ContextMenuStrip.SuspendLayout();
            this.lst_ContextMenuStrip.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.statusStrip, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.splitContainer, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 67);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(895, 583);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 561);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(895, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // selectedStripStatusLabel
            // 
            this.selectedStripStatusLabel.Name = "selectedStripStatusLabel";
            this.selectedStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(88, 24);
            this.menuStrip.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.menuStripExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem1,
            this.modifyBinaryDataToolStripMenuItem1,
            this.newToolStripMenuItem2,
            this.deleteToolStripMenuItem2,
            this.renameToolStripMenuItem2});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownOpening += new System.EventHandler(this.editToolStripMenuItem_DropDownOpening);
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.modifyToolStripMenuItem1.Enabled = false;
            this.modifyToolStripMenuItem1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.modifyToolStripMenuItem1.Text = "Modify...";
            this.modifyToolStripMenuItem1.Visible = false;
            this.modifyToolStripMenuItem1.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem1
            // 
            this.modifyBinaryDataToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.modifyBinaryDataToolStripMenuItem1.Enabled = false;
            this.modifyBinaryDataToolStripMenuItem1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBinaryDataToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.modifyBinaryDataToolStripMenuItem1.Name = "modifyBinaryDataToolStripMenuItem1";
            this.modifyBinaryDataToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.modifyBinaryDataToolStripMenuItem1.Text = "Modify Binary Data...";
            this.modifyBinaryDataToolStripMenuItem1.Visible = false;
            this.modifyBinaryDataToolStripMenuItem1.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.newToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem2,
            this.stringValueToolStripMenuItem2,
            this.binaryValueToolStripMenuItem2,
            this.dWORD32bitValueToolStripMenuItem2,
            this.qWORD64bitValueToolStripMenuItem2,
            this.multiStringValueToolStripMenuItem2,
            this.expandableStringValueToolStripMenuItem2});
            this.newToolStripMenuItem2.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.newToolStripMenuItem2.Text = "New";
            // 
            // keyToolStripMenuItem2
            // 
            this.keyToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.keyToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.keyToolStripMenuItem2.Name = "keyToolStripMenuItem2";
            this.keyToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.keyToolStripMenuItem2.Text = "Key";
            this.keyToolStripMenuItem2.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // stringValueToolStripMenuItem2
            // 
            this.stringValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stringValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.stringValueToolStripMenuItem2.Name = "stringValueToolStripMenuItem2";
            this.stringValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.stringValueToolStripMenuItem2.Text = "String Value";
            this.stringValueToolStripMenuItem2.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem2
            // 
            this.binaryValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.binaryValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.binaryValueToolStripMenuItem2.Name = "binaryValueToolStripMenuItem2";
            this.binaryValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.binaryValueToolStripMenuItem2.Text = "Binary Value";
            this.binaryValueToolStripMenuItem2.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem2
            // 
            this.dWORD32bitValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.dWORD32bitValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.dWORD32bitValueToolStripMenuItem2.Name = "dWORD32bitValueToolStripMenuItem2";
            this.dWORD32bitValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.dWORD32bitValueToolStripMenuItem2.Text = "DWORD (32-bit) Value";
            this.dWORD32bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem2
            // 
            this.qWORD64bitValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.qWORD64bitValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.qWORD64bitValueToolStripMenuItem2.Name = "qWORD64bitValueToolStripMenuItem2";
            this.qWORD64bitValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.qWORD64bitValueToolStripMenuItem2.Text = "QWORD (64-bit) Value";
            this.qWORD64bitValueToolStripMenuItem2.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem2
            // 
            this.multiStringValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.multiStringValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.multiStringValueToolStripMenuItem2.Name = "multiStringValueToolStripMenuItem2";
            this.multiStringValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.multiStringValueToolStripMenuItem2.Text = "Multi-String Value";
            this.multiStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem2
            // 
            this.expandableStringValueToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.expandableStringValueToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.expandableStringValueToolStripMenuItem2.Name = "expandableStringValueToolStripMenuItem2";
            this.expandableStringValueToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.expandableStringValueToolStripMenuItem2.Text = "Expandable String Value";
            this.expandableStringValueToolStripMenuItem2.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.deleteToolStripMenuItem2.Enabled = false;
            this.deleteToolStripMenuItem2.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.ShortcutKeyDisplayString = "Del";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.menuStripDelete_Click);
            // 
            // renameToolStripMenuItem2
            // 
            this.renameToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.renameToolStripMenuItem2.Enabled = false;
            this.renameToolStripMenuItem2.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameToolStripMenuItem2.ForeColor = System.Drawing.Color.LightGray;
            this.renameToolStripMenuItem2.Name = "renameToolStripMenuItem2";
            this.renameToolStripMenuItem2.Size = new System.Drawing.Size(188, 22);
            this.renameToolStripMenuItem2.Text = "Rename";
            this.renameToolStripMenuItem2.Click += new System.EventHandler(this.menuStripRename_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.ForeColor = System.Drawing.Color.LightGray;
            this.splitContainer.Location = new System.Drawing.Point(3, 28);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.guna2Panel2);
            this.splitContainer.Panel1.Controls.Add(this.tvRegistryDirectory);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.lstRegistryValues);
            this.splitContainer.Size = new System.Drawing.Size(889, 530);
            this.splitContainer.SplitterDistance = 295;
            this.splitContainer.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Panel2.BorderRadius = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 430);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(295, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 14);
            this.label2.TabIndex = 0;
            // 
            // tvRegistryDirectory
            // 
            this.tvRegistryDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.tvRegistryDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvRegistryDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRegistryDirectory.ForeColor = System.Drawing.Color.LightGray;
            this.tvRegistryDirectory.HideSelection = false;
            this.tvRegistryDirectory.ImageIndex = 0;
            this.tvRegistryDirectory.ImageList = this.imageRegistryDirectoryList;
            this.tvRegistryDirectory.LineColor = System.Drawing.Color.LightGray;
            this.tvRegistryDirectory.Location = new System.Drawing.Point(0, 0);
            this.tvRegistryDirectory.Name = "tvRegistryDirectory";
            this.tvRegistryDirectory.SelectedImageIndex = 0;
            this.tvRegistryDirectory.Size = new System.Drawing.Size(295, 530);
            this.tvRegistryDirectory.TabIndex = 0;
            this.tvRegistryDirectory.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvRegistryDirectory_AfterLabelEdit);
            this.tvRegistryDirectory.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvRegistryDirectory_BeforeExpand);
            this.tvRegistryDirectory.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvRegistryDirectory_BeforeSelect);
            this.tvRegistryDirectory.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvRegistryDirectory_NodeMouseClick);
            this.tvRegistryDirectory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tvRegistryDirectory_KeyUp);
            // 
            // imageRegistryDirectoryList
            // 
            this.imageRegistryDirectoryList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryDirectoryList.ImageStream")));
            this.imageRegistryDirectoryList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryDirectoryList.Images.SetKeyName(0, "registry_editor_48px.png");
            // 
            // lstRegistryValues
            // 
            this.lstRegistryValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.lstRegistryValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRegistryValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hName,
            this.hType,
            this.hValue});
            this.lstRegistryValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRegistryValues.ForeColor = System.Drawing.Color.LightGray;
            this.lstRegistryValues.FullRowSelect = true;
            this.lstRegistryValues.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstRegistryValues.HideSelection = false;
            this.lstRegistryValues.Location = new System.Drawing.Point(0, 0);
            this.lstRegistryValues.Name = "lstRegistryValues";
            this.lstRegistryValues.Size = new System.Drawing.Size(590, 530);
            this.lstRegistryValues.SmallImageList = this.imageRegistryKeyTypeList;
            this.lstRegistryValues.TabIndex = 0;
            this.lstRegistryValues.UseCompatibleStateImageBehavior = false;
            this.lstRegistryValues.View = System.Windows.Forms.View.Details;
            this.lstRegistryValues.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lstRegistryKeys_AfterLabelEdit);
            this.lstRegistryValues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstRegistryKeys_KeyUp);
            this.lstRegistryValues.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstRegistryKeys_MouseClick);
            // 
            // hName
            // 
            this.hName.Text = "Name";
            this.hName.Width = 173;
            // 
            // hType
            // 
            this.hType.Text = "Type";
            this.hType.Width = 104;
            // 
            // hValue
            // 
            this.hValue.Text = "Value";
            this.hValue.Width = 214;
            // 
            // imageRegistryKeyTypeList
            // 
            this.imageRegistryKeyTypeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageRegistryKeyTypeList.ImageStream")));
            this.imageRegistryKeyTypeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageRegistryKeyTypeList.Images.SetKeyName(0, "reg_string.png");
            this.imageRegistryKeyTypeList.Images.SetKeyName(1, "reg_binary.png");
            // 
            // tv_ContextMenuStrip
            // 
            this.tv_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.tv_ContextMenuStrip.Name = "contextMenuStrip";
            this.tv_ContextMenuStrip.Size = new System.Drawing.Size(121, 70);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem,
            this.stringValueToolStripMenuItem,
            this.binaryValueToolStripMenuItem,
            this.dWORD32bitValueToolStripMenuItem,
            this.qWORD64bitValueToolStripMenuItem,
            this.multiStringValueToolStripMenuItem,
            this.expandableStringValueToolStripMenuItem});
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // keyToolStripMenuItem
            // 
            this.keyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.keyToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.keyToolStripMenuItem.Name = "keyToolStripMenuItem";
            this.keyToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.keyToolStripMenuItem.Text = "Key";
            this.keyToolStripMenuItem.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // stringValueToolStripMenuItem
            // 
            this.stringValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stringValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.stringValueToolStripMenuItem.Name = "stringValueToolStripMenuItem";
            this.stringValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.stringValueToolStripMenuItem.Text = "String Value";
            this.stringValueToolStripMenuItem.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem
            // 
            this.binaryValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.binaryValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.binaryValueToolStripMenuItem.Name = "binaryValueToolStripMenuItem";
            this.binaryValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.binaryValueToolStripMenuItem.Text = "Binary Value";
            this.binaryValueToolStripMenuItem.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem
            // 
            this.dWORD32bitValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.dWORD32bitValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dWORD32bitValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.dWORD32bitValueToolStripMenuItem.Name = "dWORD32bitValueToolStripMenuItem";
            this.dWORD32bitValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.dWORD32bitValueToolStripMenuItem.Text = "DWORD (32-bit) Value";
            this.dWORD32bitValueToolStripMenuItem.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem
            // 
            this.qWORD64bitValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.qWORD64bitValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qWORD64bitValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.qWORD64bitValueToolStripMenuItem.Name = "qWORD64bitValueToolStripMenuItem";
            this.qWORD64bitValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.qWORD64bitValueToolStripMenuItem.Text = "QWORD (64-bit) Value";
            this.qWORD64bitValueToolStripMenuItem.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem
            // 
            this.multiStringValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.multiStringValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiStringValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.multiStringValueToolStripMenuItem.Name = "multiStringValueToolStripMenuItem";
            this.multiStringValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.multiStringValueToolStripMenuItem.Text = "Multi-String Value";
            this.multiStringValueToolStripMenuItem.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem
            // 
            this.expandableStringValueToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.expandableStringValueToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandableStringValueToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.expandableStringValueToolStripMenuItem.Name = "expandableStringValueToolStripMenuItem";
            this.expandableStringValueToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.expandableStringValueToolStripMenuItem.Text = "Expandable String Value";
            this.expandableStringValueToolStripMenuItem.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteRegistryKey_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.renameToolStripMenuItem.Enabled = false;
            this.renameToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameRegistryKey_Click);
            // 
            // selectedItem_ContextMenuStrip
            // 
            this.selectedItem_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.modifyBinaryDataToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.renameToolStripMenuItem1});
            this.selectedItem_ContextMenuStrip.Name = "selectedItem_ContextMenuStrip";
            this.selectedItem_ContextMenuStrip.Size = new System.Drawing.Size(189, 92);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.modifyToolStripMenuItem.Enabled = false;
            this.modifyToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifyToolStripMenuItem.Text = "Modify...";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyRegistryValue_Click);
            // 
            // modifyBinaryDataToolStripMenuItem
            // 
            this.modifyBinaryDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.modifyBinaryDataToolStripMenuItem.Enabled = false;
            this.modifyBinaryDataToolStripMenuItem.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyBinaryDataToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.modifyBinaryDataToolStripMenuItem.Name = "modifyBinaryDataToolStripMenuItem";
            this.modifyBinaryDataToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.modifyBinaryDataToolStripMenuItem.Text = "Modify Binary Data...";
            this.modifyBinaryDataToolStripMenuItem.Click += new System.EventHandler(this.modifyBinaryDataRegistryValue_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.deleteToolStripMenuItem1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteRegistryValue_Click);
            // 
            // renameToolStripMenuItem1
            // 
            this.renameToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.renameToolStripMenuItem1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.renameToolStripMenuItem1.Name = "renameToolStripMenuItem1";
            this.renameToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.renameToolStripMenuItem1.Text = "Rename";
            this.renameToolStripMenuItem1.Click += new System.EventHandler(this.renameRegistryValue_Click);
            // 
            // lst_ContextMenuStrip
            // 
            this.lst_ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1});
            this.lst_ContextMenuStrip.Name = "lst_ContextMenuStrip";
            this.lst_ContextMenuStrip.Size = new System.Drawing.Size(100, 26);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.newToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keyToolStripMenuItem1,
            this.stringValueToolStripMenuItem1,
            this.binaryValueToolStripMenuItem1,
            this.dWORD32bitValueToolStripMenuItem1,
            this.qWORD64bitValueToolStripMenuItem1,
            this.multiStringValueToolStripMenuItem1,
            this.expandableStringValueToolStripMenuItem1});
            this.newToolStripMenuItem1.Font = new System.Drawing.Font("Electrolize", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // keyToolStripMenuItem1
            // 
            this.keyToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.keyToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.keyToolStripMenuItem1.Name = "keyToolStripMenuItem1";
            this.keyToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.keyToolStripMenuItem1.Text = "Key";
            this.keyToolStripMenuItem1.Click += new System.EventHandler(this.createNewRegistryKey_Click);
            // 
            // stringValueToolStripMenuItem1
            // 
            this.stringValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.stringValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.stringValueToolStripMenuItem1.Name = "stringValueToolStripMenuItem1";
            this.stringValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.stringValueToolStripMenuItem1.Text = "String Value";
            this.stringValueToolStripMenuItem1.Click += new System.EventHandler(this.createStringRegistryValue_Click);
            // 
            // binaryValueToolStripMenuItem1
            // 
            this.binaryValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.binaryValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.binaryValueToolStripMenuItem1.Name = "binaryValueToolStripMenuItem1";
            this.binaryValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.binaryValueToolStripMenuItem1.Text = "Binary Value";
            this.binaryValueToolStripMenuItem1.Click += new System.EventHandler(this.createBinaryRegistryValue_Click);
            // 
            // dWORD32bitValueToolStripMenuItem1
            // 
            this.dWORD32bitValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.dWORD32bitValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.dWORD32bitValueToolStripMenuItem1.Name = "dWORD32bitValueToolStripMenuItem1";
            this.dWORD32bitValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.dWORD32bitValueToolStripMenuItem1.Text = "DWORD (32-bit) Value";
            this.dWORD32bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createDwordRegistryValue_Click);
            // 
            // qWORD64bitValueToolStripMenuItem1
            // 
            this.qWORD64bitValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.qWORD64bitValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.qWORD64bitValueToolStripMenuItem1.Name = "qWORD64bitValueToolStripMenuItem1";
            this.qWORD64bitValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.qWORD64bitValueToolStripMenuItem1.Text = "QWORD (64-bit) Value";
            this.qWORD64bitValueToolStripMenuItem1.Click += new System.EventHandler(this.createQwordRegistryValue_Click);
            // 
            // multiStringValueToolStripMenuItem1
            // 
            this.multiStringValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.multiStringValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.multiStringValueToolStripMenuItem1.Name = "multiStringValueToolStripMenuItem1";
            this.multiStringValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.multiStringValueToolStripMenuItem1.Text = "Multi-String Value";
            this.multiStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createMultiStringRegistryValue_Click);
            // 
            // expandableStringValueToolStripMenuItem1
            // 
            this.expandableStringValueToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.expandableStringValueToolStripMenuItem1.ForeColor = System.Drawing.Color.LightGray;
            this.expandableStringValueToolStripMenuItem1.Name = "expandableStringValueToolStripMenuItem1";
            this.expandableStringValueToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.expandableStringValueToolStripMenuItem1.Text = "Expandable String Value";
            this.expandableStringValueToolStripMenuItem1.Click += new System.EventHandler(this.createExpandStringRegistryValue_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Separator1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(895, 67);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.guna2Separator1.Location = new System.Drawing.Point(-202, 61);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1299, 10);
            this.guna2Separator1.TabIndex = 13;
            this.guna2Separator1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(388, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Regedit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(854, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
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
            // FormRegistryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(895, 650);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Electrolize", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormRegistryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry Editor []";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistryEditor_FormClosed);
            this.Load += new System.EventHandler(this.FrmRegistryEditor_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tv_ContextMenuStrip.ResumeLayout(false);
            this.selectedItem_ContextMenuStrip.ResumeLayout(false);
            this.lst_ContextMenuStrip.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        public RegistryTreeView tvRegistryDirectory;
        private AeroListView lstRegistryValues;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel selectedStripStatusLabel;
        private System.Windows.Forms.ImageList imageRegistryDirectoryList;
        private System.Windows.Forms.ColumnHeader hName;
        private System.Windows.Forms.ColumnHeader hType;
        private System.Windows.Forms.ColumnHeader hValue;
        private System.Windows.Forms.ImageList imageRegistryKeyTypeList;
        private System.Windows.Forms.ContextMenuStrip tv_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip selectedItem_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip lst_ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyBinaryDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem keyToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem stringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem binaryValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dWORD32bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem qWORD64bitValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem multiStringValueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem expandableStringValueToolStripMenuItem2;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
    }
}