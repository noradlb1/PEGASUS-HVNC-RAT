using Guna.UI2.WinForms;
using PEGASUS.Design;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HVNC
{
    public class FrmURL : Form
    {
        private IContainer components;
        public int count;
        public Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2ControlBox guna2ControlBox1;
        private Guna2ControlBox guna2ControlBox2;
        private Guna2DragControl guna2DragControl1;
        private Guna2ShadowForm guna2ShadowForm1;
        private Label label18;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Guna2Button StartHiddenURLbtn;
        public Guna2TextBox Urlbox;

        public FrmURL()
        {
            InitializeComponent();
        }

        private void StartHiddenURLbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Urlbox.Text))
                {
                    var num = (int)MessageBox.Show("URL is not valid!");
                }
                else
                {
                    PEGALISIUS.saveurl = Urlbox.Text;
                    PEGALISIUS.ispressed = true;
                    Close();
                }
            }
            catch (Exception ex)
            {
                var num = (int)MessageBox.Show("An Error Has Occured When Trying To Execute HiddenURL");
                Close();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmURL));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.StartHiddenURLbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Urlbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 40);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(210, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Visit URL (Hidden)";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(480, 4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 33);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(531, 4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 33);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // StartHiddenURLbtn
            // 
            this.StartHiddenURLbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartHiddenURLbtn.Animated = true;
            this.StartHiddenURLbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.StartHiddenURLbtn.BorderThickness = 3;
            this.StartHiddenURLbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartHiddenURLbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartHiddenURLbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartHiddenURLbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartHiddenURLbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.StartHiddenURLbtn.Font = new System.Drawing.Font("Electrolize", 9F);
            this.StartHiddenURLbtn.ForeColor = System.Drawing.Color.White;
            this.StartHiddenURLbtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.StartHiddenURLbtn.Image = ((System.Drawing.Image)(resources.GetObject("StartHiddenURLbtn.Image")));
            this.StartHiddenURLbtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.StartHiddenURLbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.StartHiddenURLbtn.Location = new System.Drawing.Point(71, 150);
            this.StartHiddenURLbtn.Name = "StartHiddenURLbtn";
            this.StartHiddenURLbtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.StartHiddenURLbtn.Size = new System.Drawing.Size(444, 39);
            this.StartHiddenURLbtn.TabIndex = 50;
            this.StartHiddenURLbtn.Text = "Start";
            this.StartHiddenURLbtn.Click += new System.EventHandler(this.StartHiddenURLbtn_Click);
            // 
            // Urlbox
            // 
            this.Urlbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Urlbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
            this.Urlbox.BorderThickness = 3;
            this.Urlbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Urlbox.DefaultText = "Your URL";
            this.Urlbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Urlbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Urlbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Urlbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Urlbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.Urlbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.Urlbox.Font = new System.Drawing.Font("Electrolize", 9F);
            this.Urlbox.ForeColor = System.Drawing.Color.Gainsboro;
            this.Urlbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.Urlbox.Location = new System.Drawing.Point(71, 97);
            this.Urlbox.Name = "Urlbox";
            this.Urlbox.PasswordChar = '\0';
            this.Urlbox.PlaceholderText = "";
            this.Urlbox.SelectedText = "";
            this.Urlbox.SelectionStart = 8;
            this.Urlbox.Size = new System.Drawing.Size(444, 38);
            this.Urlbox.TabIndex = 49;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
            this.guna2BorderlessForm1.BorderRadius = 1;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(38)))), ((int)(((byte)(33)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // FrmURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(579, 250);
            this.Controls.Add(this.StartHiddenURLbtn);
            this.Controls.Add(this.Urlbox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmURL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmURL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}