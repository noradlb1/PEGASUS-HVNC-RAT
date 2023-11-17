using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PEGASUS.IcarusWings.HexEditor
{
    public class Caret
    {
        #region Constructor

        public Caret(HexEditor editor)
        {
            _editor = editor;
            Focused = false;
            _startIndex = 0;
            CurrentIndex = 0;
            _isCaretHidden = true;
            _location = new Point(0, 0);
        }

        #endregion

        #region Field

        /// <summary>
        ///     Contains the start index
        ///     where the caret started
        /// </summary>
        private int _startIndex;


        /// <summary>
        ///     Tells if the caret is
        ///     currently hidden or
        ///     not (out of view)
        /// </summary>
        private bool _isCaretHidden;

        /// <summary>
        ///     Holds the actual position
        ///     of the caret
        /// </summary>
        private Point _location;

        private readonly HexEditor _editor;

        #endregion

        #region Properties

        public int SelectionStart
        {
            get
            {
                if (CurrentIndex < _startIndex)
                    return CurrentIndex;
                return _startIndex;
            }
        }

        public int SelectionLength
        {
            get
            {
                if (CurrentIndex < _startIndex)
                    return _startIndex - CurrentIndex;
                return CurrentIndex - _startIndex;
            }
        }

        /// <summary>
        ///     Tells if the given caret
        ///     is active in the controller
        ///     (control is in focus)
        /// </summary>
        public bool Focused { get; private set; }

        /// <summary>
        ///     Contains the end index
        ///     where the caret is
        ///     currently located
        /// </summary>
        public int CurrentIndex { get; private set; }

        public Point Location => _location;

        #endregion

        #region EventHandlers

        public event EventHandler SelectionStartChanged;

        public event EventHandler SelectionLengthChanged;

        #endregion

        #region Methods

        #region Caret

        private bool Create(IntPtr hWHandler)
        {
            if (!Focused)
            {
                Focused = true;
                return CreateCaret(hWHandler, IntPtr.Zero, 0, (int) _editor.CharSize.Height - 2);
            }

            return false;
        }

        private bool Show(IntPtr hWnd)
        {
            if (Focused)
            {
                _isCaretHidden = false;
                return ShowCaret(hWnd);
            }

            return false;
        }

        public bool Hide(IntPtr hWnd)
        {
            if (Focused && !_isCaretHidden)
            {
                _isCaretHidden = true;
                return HideCaret(hWnd);
            }

            return false;
        }

        public bool Destroy()
        {
            if (Focused)
            {
                Focused = false;
                DeSelect();
                DestroyCaret();
            }

            return false;
        }

        #endregion

        public void SetStartIndex(int index)
        {
            _startIndex = index;
            CurrentIndex = _startIndex;

            if (SelectionStartChanged != null)
                SelectionStartChanged(this, EventArgs.Empty);

            if (SelectionLengthChanged != null)
                SelectionLengthChanged(this, EventArgs.Empty);
        }

        public void SetEndIndex(int index)
        {
            CurrentIndex = index;

            if (SelectionStartChanged != null)
                SelectionStartChanged(this, EventArgs.Empty);

            if (SelectionLengthChanged != null)
                SelectionLengthChanged(this, EventArgs.Empty);
        }

        public void SetCaretLocation(Point start)
        {
            Create(_editor.Handle);
            _location = start;
            SetCaretPos(_location.X, _location.Y);
            Show(_editor.Handle);
        }

        public bool IsSelected(int byteIndex)
        {
            return SelectionStart <= byteIndex && byteIndex < SelectionStart + SelectionLength;
        }

        private void DeSelect()
        {
            if (CurrentIndex < _startIndex)
                _startIndex = CurrentIndex;
            else
                CurrentIndex = _startIndex;

            if (SelectionStartChanged != null)
                SelectionStartChanged(this, EventArgs.Empty);

            if (SelectionLengthChanged != null)
                SelectionLengthChanged(this, EventArgs.Empty);
        }

        #endregion

        #region Caret import

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DestroyCaret();

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetCaretPos(int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowCaret(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool HideCaret(IntPtr hWnd);

        #endregion
    }
}