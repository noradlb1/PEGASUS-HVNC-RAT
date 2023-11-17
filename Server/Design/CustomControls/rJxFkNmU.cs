#region Globals

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class LoyalListViewItem
{
    protected Guid uniqueId;

    public LoyalListViewItem()
    {
        uniqueId = Guid.NewGuid();
    }

    public LoyalListViewItem(string text)
    {
        uniqueId = Guid.NewGuid();
        Text = text;
    }

    public LoyalListViewItem(string text, List<LoyalListViewSubItem> subitems)
    {
        uniqueId = Guid.NewGuid();
        Text = text;
        SubItems = subitems;
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public List<LoyalListViewSubItem> SubItems { get; set; } = new();

    public string Text { get; set; }

    public override bool Equals(object obj)
    {
        if (obj.GetType() == typeof(LoyalListViewItem))
            return ((LoyalListViewItem)obj).uniqueId == uniqueId;
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return Text;
    }
}

public class LoyalListViewSubItem
{
    public LoyalListViewSubItem()
    {
    }

    public LoyalListViewSubItem(string text)
    {
        Text = text;
    }

    public string Text { get; set; }

    public override string ToString()
    {
        return Text;
    }
}

public class LoyalListViewColumnHeader
{
    public LoyalListViewColumnHeader()
    {
    }

    public LoyalListViewColumnHeader(string text)
    {
        Text = text;
    }

    public LoyalListViewColumnHeader(string text, int width)
    {
        Text = text;
        Width = width;
    }

    public string Text { get; set; }

    public int Width { get; set; } = 60;

    public override string ToString()
    {
        return Text;
    }
}

#endregion

#region Scrollbar

[DefaultEvent("Scroll")]
internal class LoyalScrollBar : Control
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        {
            g.Clear(_backColor);
            var gp1 = DrawArrow(4, 6, false);
            var gp2 = DrawArrow(4, Height - 10, true);
            g.FillPath(new SolidBrush(_arrowColor), gp1);
            g.FillPath(new SolidBrush(_arrowColor), gp2);
            if (_showThumb)
            {
                g.FillRectangle(new SolidBrush(_scrollColor), Thumb);
                g.DrawRectangle(new Pen(_borderColor), Thumb);
                int y;
                var ly = Thumb.Y + Thumb.Height / 2 - 3;
                for (var i = 0; i < 3; i++)
                {
                    y = ly + i * 3;
                    g.DrawLine(new Pen(_borderColor), Thumb.X + 5, y, Thumb.Right - 5, y);
                }
            }

            g.DrawRectangle(new Pen(_borderColor), 0, 0, Width - 1, Height - 1);
            g.FillRectangle(new SolidBrush(Parent.BackColor), Width - 1, Height - 1, 1, 1);
            g.FillRectangle(new SolidBrush(Parent.BackColor), Width - 1, 0, 1, 1);
        }
    }

    #region Declarations

    public delegate void ScrollEventHandler(object sender);

    public event ScrollEventHandler Scroll;
    private readonly int buttonSize = 16;
    private readonly int thumbSize = 24;
    private Rectangle TSA;
    private Rectangle BSA;
    private Rectangle Shaft;
    private Rectangle Thumb;
    private bool _showThumb;
    private bool _thumbDown;
    private int I1;

    #endregion

    #region Properties

    private int _minimum;

    public int Minimum
    {
        get => _minimum;
        set
        {
            if (value < 0)
                throw new Exception("Property value is not valid.");

            _minimum = value;
            if (value > _value)
                _value = value;
            if (value > _maximum)
                _maximum = value;

            InvalidateLayout();
        }
    }

    private int _maximum = 100;

    public int Maximum
    {
        get => _maximum;
        set
        {
            if (value < 1)
                value = 1;

            _maximum = value;
            if (value < _value)
                _value = value;
            if (value < _minimum)
                _minimum = value;

            InvalidateLayout();
        }
    }

    private int _value;

    public int Value
    {
        get
        {
            if (!_showThumb)
                return _minimum;
            return _value;
        }
        set
        {
            if (value == _value)
                return;

            if (value > _maximum || value < _minimum)
                throw new Exception("Property value is not valid.");

            _value = value;
            InvalidatePosition();

            if (Scroll != null)
                Scroll.Invoke(this);
        }
    }

    public double Percent
    {
        get
        {
            if (!_showThumb)
                return 0;
            return GetProgress();
        }
    }

    private int _smallChange = 1;

    public int SmallChange
    {
        get => _smallChange;
        set
        {
            if (value < 1)
                throw new Exception("Property value is not valid.");

            _smallChange = value;
        }
    }

    private int _largeChange = 10;

    public int LargeChange
    {
        get => _largeChange;
        set
        {
            if (value < 1)
                throw new Exception("Property value is not valid.");

            _largeChange = value;
        }
    }

    private Color _backColor = Color.FromArgb(31, 31, 31);

    [Category("Colors")]
    public override Color BackColor
    {
        get => _backColor;
        set
        {
            _backColor = value;
            Invalidate();
        }
    }

    private Color _arrowColor = Color.FromArgb(51, 51, 51);

    [Category("Colors")]
    public Color ArrowColor
    {
        get => _arrowColor;
        set
        {
            _arrowColor = value;
            Invalidate();
        }
    }

    private Color _scrollColor = Color.FromArgb(41, 41, 41);

    [Category("Colors")]
    public Color ScrollColor
    {
        get => _scrollColor;
        set
        {
            _scrollColor = value;
            Invalidate();
        }
    }

    private Color _borderColor = Color.FromArgb(18, 18, 18);

    [Category("Colors")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Methods

    private void InvalidateLayout()
    {
        TSA = new Rectangle(0, 0, Width, buttonSize);
        BSA = new Rectangle(0, Height - buttonSize, Width, buttonSize);
        Shaft = new Rectangle(0, TSA.Bottom + 1, Width, Height - buttonSize * 2 - 1);
        _showThumb = _maximum - _minimum > Shaft.Height;
        if (_showThumb)
            Thumb = new Rectangle(1, 0, Width - 3, thumbSize);
        if (Scroll != null)
            Scroll.Invoke(this);
        InvalidatePosition();
    }

    private void InvalidatePosition()
    {
        Thumb.Y = Convert.ToInt32(GetProgress() * (Shaft.Height - thumbSize)) + TSA.Height;
        Invalidate();
    }

    private double GetProgress()
    {
        return (_value - _minimum) / (double)(_maximum - _minimum);
    }

    private GraphicsPath DrawArrow(int x, int y, bool flip)
    {
        var gp = new GraphicsPath();
        var W = 9;
        var H = 5;
        if (flip)
        {
            gp.AddLine(x + 1, y, x + W + 1, y);
            gp.AddLine(x + W, y, x + H, y + H - 1);
        }
        else
        {
            gp.AddLine(x, y + H, x + W, y + H);
            gp.AddLine(x + W, y + H, x + H, y);
        }

        gp.CloseFigure();
        return gp;
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        InvalidateLayout();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left && _showThumb)
        {
            if (TSA.Contains(e.Location))
            {
                I1 = _value - _smallChange;
            }
            else if (BSA.Contains(e.Location))
            {
                I1 = _value + _smallChange;
            }
            else if (Thumb.Contains(e.Location))
            {
                _thumbDown = true;
                base.OnMouseDown(e);
                return;
            }
            else if (e.Y < Thumb.Y)
            {
                I1 = _value - _largeChange;
            }
            else
            {
                I1 = _value + _largeChange;
            }

            _value = Math.Min(Math.Max(I1, _minimum), _maximum);
            InvalidatePosition();
        }

        base.OnMouseDown(e);
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        if (_thumbDown && _showThumb)
        {
            var ThumbPosition = e.Y - TSA.Height - thumbSize / 2;
            var ThumbBounds = Shaft.Height - thumbSize;

            I1 = Convert.ToInt32(ThumbPosition / (double)ThumbBounds * (_maximum - _minimum)) + _minimum;

            _value = Math.Min(Math.Max(I1, _minimum), _maximum);
            InvalidatePosition();
        }

        base.OnMouseMove(e);
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        _thumbDown = false;
        base.OnMouseUp(e);
    }

    public LoyalScrollBar()
    {
        SetStyle(ControlStyles.Selectable, false);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        Width = 19;
    }

    #endregion
}

#endregion

#region ListView

internal class LoyalListView : Control
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.Clear(_backColor);
        int startIndex;
        var offset = Convert.ToInt32(_VS.Percent * (_VS.Maximum - (Height - _itemHeight * 2)));
        if (offset == 0)
            startIndex = 0;
        else
            startIndex = offset / _itemHeight;
        var endIndex = Math.Min(startIndex + Height / _itemHeight, _items.Count);
        for (var i = startIndex; i < endIndex; i++)
        {
            var ci = _items[i];
            var r = new Rectangle(0, 24 + i * 24 - offset, Width, 24);
            var h = Convert.ToInt32(g.MeasureString(ci.Text, Font).Height);
            var y = r.Y + Convert.ToInt32(24 / 2 - h / 2);
            if (_selectedItems.Contains(ci))
                g.FillRectangle(new SolidBrush(_selectedItemColor), r);
            else
                g.FillRectangle(new SolidBrush(_itemColor), r);
            g.DrawRectangle(new Pen(_borderColor), r);
            if (_columns.Count > 0)
            {
                r.Width = _columns[0].Width;
                g.SetClip(r);
            }

            g.DrawString(ci.Text, Font, new SolidBrush(_foreColor), 4, y + 1);
            if (ci.SubItems.Count > 0)
                for (var i2 = 0; i2 < Math.Min(ci.SubItems.Count, _columns.Count); i2++)
                {
                    var x = _columnOffsets[i2 + 1];
                    r.X = x;
                    r.Width = _columns[i2].Width;
                    g.SetClip(r);
                    g.DrawString(ci.SubItems[i2].Text, Font, new SolidBrush(_foreColor), x + 1, y + 1);
                }

            g.ResetClip();
        }

        var r2 = new Rectangle(0, 0, Width, 24);
        g.FillRectangle(new SolidBrush(_headerColor), r2);
        var lh = Math.Min(_VS.Maximum + _itemHeight - offset + 2, Height);
        LoyalListViewColumnHeader cc;
        for (var i = 0; i < _columns.Count; i++)
        {
            cc = _columns[i];
            var h = Convert.ToInt32(g.MeasureString(cc.Text, Font).Height);
            var y = Convert.ToInt32(24 / 2 - h / 2);
            var x = _columnOffsets[i];
            g.DrawString(cc.Text, new Font(Font.FontFamily, Font.Size, FontStyle.Bold), new SolidBrush(_foreColor),
                x + 1, y + 1);
            g.DrawLine(new Pen(_borderColor), x - 3, 0, x - 3, lh);
        }

        g.DrawRectangle(new Pen(_borderColor), 0, 0, Width - 1, Height - 1);
        g.DrawLine(new Pen(Color.FromArgb(30, Color.White)), 0, 1, Width, 1);
        g.DrawLine(new Pen(Color.FromArgb(70, Color.Black)), 0, 23, Width, 23);
        g.DrawLine(new Pen(_borderColor), 0, 24, Width, 24);
        g.FillRectangle(new SolidBrush(_backColor), Width - 19, 0, Width, Height);
        g.FillRectangle(new SolidBrush(Parent.BackColor), 0, 0, 1, 1);
        g.FillRectangle(new SolidBrush(Parent.BackColor), 0, Height - 1, 1, 1);
    }

    #region Declarations

    private int[] _columnOffsets;
    private readonly LoyalScrollBar _VS;
    private bool _down;
    private int _itemHeight = 24;

    #endregion

    #region Properties

    private List<LoyalListViewItem> _items = new();

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Category("Content")]
    public LoyalListViewItem[] Items
    {
        get => _items.ToArray();
        set
        {
            _items = new List<LoyalListViewItem>(value);
            InvalidateScroll();
        }
    }

    private readonly List<LoyalListViewItem> _selectedItems = new();

    [Category("Content")] public LoyalListViewItem[] SelectedItems => _selectedItems.ToArray();

    private List<LoyalListViewColumnHeader> _columns = new();

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Category("Content")]
    public LoyalListViewColumnHeader[] Columns
    {
        get => _columns.ToArray();
        set
        {
            _columns = new List<LoyalListViewColumnHeader>(value);
            InvalidateColumns();
        }
    }

    private bool _multiSelect = true;

    public bool Multiselect
    {
        get => _multiSelect;
        set
        {
            _multiSelect = value;
            if (_selectedItems.Count > 1)
                _selectedItems.RemoveRange(1, _selectedItems.Count);
            Invalidate();
        }
    }

    public override Font Font
    {
        get => base.Font;
        set
        {
            _itemHeight = Convert.ToInt32(Graphics.FromHwnd(Handle).MeasureString("@", Font).Height) + 6;
            if (_VS != null)
            {
                _VS.SmallChange = _itemHeight;
                _VS.LargeChange = _itemHeight;
            }

            base.Font = value;
            InvalidateLayout();
        }
    }

    private Color _headerColor = Color.FromArgb(102, 51, 153);

    [Category("Colors")]
    public Color HeaderColor
    {
        get => _headerColor;
        set
        {
            _headerColor = value;
            _VS.ScrollColor = _headerColor;
            _VS.ArrowColor = _headerColor;
            Invalidate();
        }
    }

    private Color _backColor = Color.FromArgb(40, 40, 40);

    [Category("Colors")]
    public override Color BackColor
    {
        get => _backColor;
        set
        {
            _backColor = value;
            Invalidate();
        }
    }

    private Color _borderColor = Color.FromArgb(18, 18, 18);

    [Category("Colors")]
    public Color BorderColor
    {
        get => _borderColor;
        set
        {
            _borderColor = value;
            _VS.BorderColor = _borderColor;
            Invalidate();
        }
    }

    private Color _itemColor = Color.FromArgb(50, 50, 50);

    [Category("Colors")]
    public Color ItemColor
    {
        get => _itemColor;
        set
        {
            _itemColor = value;
            Invalidate();
        }
    }

    private Color _selectedItemColor = Color.FromArgb(65, 65, 65);

    [Category("Colors")]
    public Color SelectedItemColor
    {
        get => _selectedItemColor;
        set
        {
            _selectedItemColor = value;
            Invalidate();
        }
    }

    private Color _scrollBarBackColor = Color.FromArgb(31, 31, 31);

    [Category("Colors")]
    public Color ScrollBarBackColor
    {
        get => _scrollBarBackColor;
        set
        {
            _scrollBarBackColor = value;
            _VS.BackColor = _scrollBarBackColor;
            Invalidate();
        }
    }

    private Color _foreColor = Color.White;

    [Category("Colors")]
    public override Color ForeColor
    {
        get => _foreColor;
        set
        {
            _foreColor = value;
            Invalidate();
        }
    }

    #endregion

    #region Methods

    private void InvalidateScroll()
    {
        _VS.Maximum = _items.Count * 24;
        Invalidate();
    }

    private void InvalidateColumns()
    {
        var width = 3;
        _columnOffsets = new int[_columns.Count];
        for (var i = 0; i < _columns.Count; i++)
        {
            _columnOffsets[i] = width;
            width += Columns[i].Width;
        }

        Invalidate();
    }

    private void InvalidateLayout()
    {
        _VS.Location = new Point(Width - _VS.Width, 0);
        _VS.Size = new Size(19, Height);
        InvalidateScroll();
    }

    private void HandleScroll(object sender)
    {
        Invalidate();
    }

    public LoyalListView()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        _VS = new LoyalScrollBar();
        _VS.LargeChange = _itemHeight;
        _VS.SmallChange = _itemHeight;
        _VS.Scroll += HandleScroll;
        _VS.MouseDown += _VS_MouseDown;
        _VS.MouseMove += _VS_MouseMove;
        _VS.MouseUp += _VS_MouseUp;
        _VS.ScrollColor = _headerColor;
        _VS.BorderColor = _borderColor;
        _VS.ArrowColor = _headerColor;
        _VS.BackColor = _scrollBarBackColor;
        Size = new Size(150, 75);
        Font = new Font("Segoe UI", 8.25f);
        Controls.Add(_VS);
        InvalidateLayout();
    }

    private void _VS_MouseUp(object sender, MouseEventArgs e)
    {
        _down = false;
    }

    private void _VS_MouseMove(object sender, MouseEventArgs e)
    {
        if (_down)
            Invalidate();
    }

    private void _VS_MouseDown(object sender, MouseEventArgs e)
    {
        _down = true;
        Focus();
    }

    protected override void OnMouseWheel(MouseEventArgs e)
    {
        var move = -(e.Delta * SystemInformation.MouseWheelScrollLines / 120 * (24 / 2));
        var value = Math.Max(Math.Min(_VS.Value + move, _VS.Maximum), _VS.Minimum);
        _VS.Value = value;
        base.OnMouseWheel(e);
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        Focus();
        if (e.Button == MouseButtons.Left)
        {
            var offset = Convert.ToInt32(_VS.Percent * (_VS.Maximum - (Height - 24 * 2)));
            var index = (e.Y + offset - 24) / 24;
            if (index > _items.Count - 1) index = -1;
            if (index > -1)
            {
                if (ModifierKeys == Keys.Control && _multiSelect)
                {
                    if (_selectedItems.Contains(_items[index]))
                        _selectedItems.Remove(_items[index]);
                    else
                        _selectedItems.Add(_items[index]);
                }
                else
                {
                    _selectedItems.Clear();
                    _selectedItems.Add(_items[index]);
                }
            }

            Invalidate();
        }

        base.OnMouseDown(e);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        InvalidateLayout();
        base.OnSizeChanged(e);
    }

    #endregion

    #region Helpers

    public void AddItem(string text, string[] subitems)
    {
        var items = new List<LoyalListViewSubItem>();
        foreach (var item in subitems)
        {
            var si = new LoyalListViewSubItem(item);
            items.Add(si);
        }

        var lvi = new LoyalListViewItem(text, items);
        _items.Add(lvi);
        InvalidateScroll();
    }

    public void RemoveItemAt(int index)
    {
        _items.RemoveAt(index);
        InvalidateScroll();
    }

    public void RemoveItem(LoyalListViewItem lvi)
    {
        _items.Remove(lvi);
        InvalidateScroll();
    }

    public void RemoveItems(LoyalListViewItem[] lvis)
    {
        foreach (var lvi in lvis)
            _items.Remove(lvi);
        InvalidateScroll();
    }

    #endregion
}

#endregion