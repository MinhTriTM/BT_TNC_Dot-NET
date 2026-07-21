using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET.Controls
{
    public class ModernTrackBar : Control
    {
        private int _minimum = -10;
        private int _maximum = 10;
        private int _value = 0;
        private int _largeChange = 2;

        private Color _trackColor = Color.FromArgb(30, 41, 59);
        private Color _progressColor = Color.FromArgb(6, 182, 212);
        private Color _thumbColor = Color.FromArgb(248, 250, 252);
        private Color _thumbHoverColor = Color.FromArgb(165, 243, 252);

        private bool _isDragging = false;
        private bool _isHovered = false;

        public event EventHandler ValueChanged;
        public event EventHandler Scroll;

        [Category("Cinematic UI"), DefaultValue(-10)]
        public int Minimum
        {
            get => _minimum;
            set { _minimum = value; if (_value < _minimum) Value = _minimum; Invalidate(); }
        }

        [Category("Cinematic UI"), DefaultValue(10)]
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; if (_value > _maximum) Value = _maximum; Invalidate(); }
        }

        [Category("Cinematic UI"), DefaultValue(0)]
        public int Value
        {
            get => _value;
            set
            {
                int val = Math.Max(_minimum, Math.Min(_maximum, value));
                if (_value != val)
                {
                    _value = val;
                    ValueChanged?.Invoke(this, EventArgs.Empty);
                    Scroll?.Invoke(this, EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        [Category("Cinematic UI"), DefaultValue(2)]
        public int LargeChange
        {
            get => _largeChange;
            set => _largeChange = Math.Max(1, value);
        }

        [Category("Cinematic UI")]
        public Color TrackColor
        {
            get => _trackColor;
            set { _trackColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color ProgressColor
        {
            get => _progressColor;
            set { _progressColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color ThumbColor
        {
            get => _thumbColor;
            set { _thumbColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color ThumbHoverColor
        {
            get => _thumbHoverColor;
            set { _thumbHoverColor = value; Invalidate(); }
        }

        public ModernTrackBar()
        {
            SetStyle(ControlStyles.UserPaint | 
                     ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(200, 26);
            BackColor = Color.Transparent;
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovered = false;
            _isDragging = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = true;
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_isDragging && e.Button == MouseButtons.Left)
            {
                UpdateValueFromMouse(e.X);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _isDragging = false;
            Invalidate();
        }

        private void UpdateValueFromMouse(int mouseX)
        {
            int margin = 10;
            int trackWidth = Width - (margin * 2);
            if (trackWidth <= 0) return;

            float relativeX = Math.Max(0, Math.Min(trackWidth, mouseX - margin));
            float pct = relativeX / trackWidth;
            int newValue = (int)Math.Round(_minimum + (pct * (_maximum - _minimum)));
            Value = newValue;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int margin = 10;
            int trackHeight = 6;
            int trackY = (Height - trackHeight) / 2;
            int trackWidth = Width - (margin * 2);

            if (trackWidth <= 0) return;

            // 1. Vẽ Thanh Ray Nền
            Rectangle trackRect = new Rectangle(margin, trackY, trackWidth, trackHeight);
            using (GraphicsPath trackPath = GetRoundedPath(trackRect, trackHeight))
            {
                using (SolidBrush brush = new SolidBrush(_trackColor))
                {
                    g.FillPath(brush, trackPath);
                }
            }

            // 2. Tính vị trí Thumb
            float pct = (_maximum == _minimum) ? 0 : (float)(_value - _minimum) / (_maximum - _minimum);
            int thumbX = margin + (int)(pct * trackWidth);
            int thumbRadius = _isDragging ? 16 : (_isHovered ? 14 : 12);
            int thumbY = (Height - thumbRadius) / 2;

            // 3. Vẽ Dải Tiến Trình (Progress Fill)
            int progressWidth = thumbX - margin;
            if (progressWidth > 0)
            {
                Rectangle progressRect = new Rectangle(margin, trackY, progressWidth, trackHeight);
                using (GraphicsPath progressPath = GetRoundedPath(progressRect, trackHeight))
                {
                    using (SolidBrush brush = new SolidBrush(_progressColor))
                    {
                        g.FillPath(brush, progressPath);
                    }
                }
            }

            // 4. Vẽ Thumb Knob
            Rectangle thumbRect = new Rectangle(thumbX - (thumbRadius / 2), thumbY, thumbRadius, thumbRadius);
            Color currentThumbColor = (_isDragging || _isHovered) ? _thumbHoverColor : _thumbColor;

            using (SolidBrush thumbBrush = new SolidBrush(currentThumbColor))
            {
                g.FillEllipse(thumbBrush, thumbRect);
            }

            using (Pen pen = new Pen(_progressColor, 2))
            {
                g.DrawEllipse(pen, thumbRect);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = Math.Min(radius, Math.Min(rect.Width, rect.Height));
            if (r <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
