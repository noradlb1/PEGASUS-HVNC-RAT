using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal class InputDialog : Form
{
    private const int CS_DROPSHADOW = 0x00020000;
    protected string _txtInput;
    protected bool _txtPaintInvalidated;
    private IContainer components;
    private Guna2BorderlessForm guna2BorderlessForm1;
    private Guna2Panel guna2Panel1;
    private Guna2PictureBox guna2PictureBox1;
    private Guna2Separator guna2Separator1;
    private Guna2ShadowForm guna2ShadowForm1;
    private Label label3;
    protected Label lblMessage;
    private PictureBox pictureBox1;
    protected TextBox txtInput;

    private InputDialog()
    {
        var pl = new Panel();
        pl.Dock = DockStyle.Fill;

        var flp = new FlowLayoutPanel();
        flp.Dock = DockStyle.Fill;

        lblMessage = new Label();
        lblMessage.Font = new Font("Electrolize", 10);
        lblMessage.ForeColor = Color.White;
        lblMessage.AutoSize = true;

        var txtPl = new Panel();
        txtPl.BorderStyle = BorderStyle.None;
        txtPl.Width = 360;
        txtPl.Height = 28;
        txtPl.Padding = new Padding(5);
        txtPl.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
        txtPl.Margin = new Padding(0, 15, 0, 0);
        txtPl.Paint += txtPl_Paint;

        txtInput = new TextBox();
        txtInput.Dock = DockStyle.Fill;
        txtInput.BorderStyle = BorderStyle.None;
        txtInput.Font = new Font("Electrolize", 9);
        txtInput.KeyDown += txtInput_KeyDown;
        txtInput.BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
        txtInput.Multiline = true;
        txtInput.ForeColor = Color.White;
        txtPl.Controls.Add(txtInput);

        var flpButtons = new FlowLayoutPanel();
        flpButtons.Dock = DockStyle.Bottom;
        flpButtons.FlowDirection = FlowDirection.RightToLeft;
        flpButtons.Height = 35;

        var btnCancel = new Button();
        btnCancel.Text = "Cancel";
        btnCancel.ForeColor = Color.White;
        btnCancel.Font = new Font("Electrolize", 8);
        btnCancel.Padding = new Padding(3);
        btnCancel.FlatStyle = FlatStyle.Flat;
        btnCancel.Height = 30;
        btnCancel.Click += btnCancel_Click;

        var btnOK = new Button();
        btnOK.Text = "OK";
        btnOK.ForeColor = Color.White;
        btnOK.Font = new Font("Electrolize", 8);
        btnOK.Padding = new Padding(3);
        btnOK.FlatStyle = FlatStyle.Flat;
        btnOK.Height = 30;
        btnOK.Click += btnOK_Click;

        flpButtons.Controls.Add(btnCancel);
        flpButtons.Controls.Add(btnOK);

        flp.Controls.Add(lblMessage);
        flp.SetFlowBreak(lblMessage, true);
        flp.Controls.Add(txtPl);
        flp.SetFlowBreak(txtPl, true);
        flp.Controls.Add(flpButtons);
        pl.Controls.Add(flp);

        Controls.Add(pl);
        Controls.Add(flpButtons);
        FormBorderStyle = FormBorderStyle.None;
        BackColor = System.Drawing.Color.FromArgb(25, 27, 38);
        StartPosition = FormStartPosition.CenterScreen;
        Padding = new Padding(20);
        Width = 400;
        Height = 200;
    }

    protected override CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            cp.ClassStyle |= CS_DROPSHADOW;
            return cp;
        }
    }

    private void txtInput_KeyDown(object sender, KeyEventArgs e)
    {
        var txt = (TextBox)sender;

        if (e.KeyCode == Keys.Enter)
        {
            _txtInput = txt.Text;
            Dispose();
        }
        else
        {
            if (txt.Text.Length > 60)
            {
                txt.Parent.Height = 80;

                if (!_txtPaintInvalidated)
                {
                    txt.Parent.Invalidate();
                    _txtPaintInvalidated = true;
                }
            }

            if (txt.Text.Length < 60)
            {
                txt.Parent.Height = 28;

                if (_txtPaintInvalidated)
                {
                    txt.Parent.Invalidate();
                    _txtPaintInvalidated = false;
                }
            }
        }
    }

    private void txtPl_Paint(object sender, PaintEventArgs e)
    {
        var pl = (Panel)sender;
        base.OnPaint(e);

        var g = e.Graphics;
        var rect = new Rectangle(new Point(0, 0), new Size(pl.Width - 1, pl.Height - 1));
        var pen = new Pen(Color.FromArgb(54, 193, 214));
        pen.Width = 3;
        g.FillRectangle(new SolidBrush(Color.FromArgb(25, 27, 38)), rect);
        g.DrawRectangle(pen, rect);
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        Dispose();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        _txtInput = txtInput.Text;
        Dispose();
    }

    public static string Show(string message)
    {
        var dialog = new InputDialog();
        dialog.lblMessage.Text = message;
        dialog.ShowDialog();

        return dialog._txtInput;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;
        var rect = new Rectangle(new Point(0, 0), new Size(Width - 1, Height - 1));
        var pen = new Pen(Color.FromArgb(54, 193, 214));

        g.DrawRectangle(pen, rect);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputDialog));
        this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
        this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
        this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.label3 = new System.Windows.Forms.Label();
        this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
        this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
        this.guna2Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        this.SuspendLayout();
        // 
        // guna2Panel1
        // 
        this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
        this.guna2Panel1.Controls.Add(this.guna2Separator1);
        this.guna2Panel1.Controls.Add(this.pictureBox1);
        this.guna2Panel1.Controls.Add(this.label3);
        this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
        this.guna2Panel1.Name = "guna2Panel1";
        this.guna2Panel1.Size = new System.Drawing.Size(284, 67);
        this.guna2Panel1.TabIndex = 13;
        // 
        // guna2PictureBox1
        // 
        this.guna2PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
        this.guna2PictureBox1.Image = global::PEGASUS.Properties.Resources.Close_50px;
        this.guna2PictureBox1.ImageRotate = 0F;
        this.guna2PictureBox1.Location = new System.Drawing.Point(243, 12);
        this.guna2PictureBox1.Name = "guna2PictureBox1";
        this.guna2PictureBox1.Size = new System.Drawing.Size(29, 31);
        this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.guna2PictureBox1.TabIndex = 115;
        this.guna2PictureBox1.TabStop = false;
        this.guna2PictureBox1.UseTransparentBackground = true;
        // 
        // guna2Separator1
        // 
        this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
        this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(59)))));
        this.guna2Separator1.Location = new System.Drawing.Point(-477, 61);
        this.guna2Separator1.Name = "guna2Separator1";
        this.guna2Separator1.Size = new System.Drawing.Size(1238, 10);
        this.guna2Separator1.TabIndex = 15;
        this.guna2Separator1.UseTransparentBackground = true;
        // 
        // pictureBox1
        // 
        this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        this.pictureBox1.Location = new System.Drawing.Point(15, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(40, 42);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 14;
        this.pictureBox1.TabStop = false;
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Electrolize", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.label3.ForeColor = System.Drawing.Color.LightGray;
        this.label3.Location = new System.Drawing.Point(112, 20);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(52, 19);
        this.label3.TabIndex = 11;
        this.label3.Text = "Input";
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
        // InputDialog
        // 
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Controls.Add(this.guna2Panel1);
        this.ForeColor = System.Drawing.Color.LightGray;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Name = "InputDialog";
        this.guna2Panel1.ResumeLayout(false);
        this.guna2Panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        this.ResumeLayout(false);

    }

    private void guna2PictureBox1_Click(object sender, EventArgs e)
    {
        Close();
    }
}