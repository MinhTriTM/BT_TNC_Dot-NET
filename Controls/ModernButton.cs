using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET.Controls
{
    public class ModernButton : Button
    {
        private int _borderRadius = 12;
        private Color _backgroundColor = Color.FromArgb(79, 70, 229); // Modern Indigo
        private Color _hoverColor = Color.FromArgb(99, 102, 241);
        private Color _clickColor = Color.FromArgb(67, 56, 202);
        private Color _borderColor = Color.FromArgb(129, 140, 248);
        private int _borderSize = 0;
        private bool _isHovered = false;
        private bool _isPressed = false;

        [Category("Cinematic UI"), DefaultValue(12)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color ButtonColor
        {
            get => _backgroundColor;
            set { _backgroundColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color HoverColor
        {
            get => _hoverColor;
            set { _hoverColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color ClickColor
        {
            get => _clickColor;
            set { _clickColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Cinematic UI"), DefaultValue(0)]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; Invalidate(); }
        }

        public ModernButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(140, 42);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
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
            _isPressed = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isPressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isPressed = false;
            Invalidate();
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            Color currentBg = _isPressed ? _clickColor : (_isHovered ? _hoverColor : _backgroundColor);

            if (!Enabled)
            {
                currentBg = Color.FromArgb(55, 65, 81);
            }

            using (GraphicsPath path = GetRoundedPath(rect, _borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(currentBg))
                {
                    g.FillPath(brush, path);
                }

                if (_borderSize > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(_borderColor, _borderSize))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawPath(pen, path);
                    }
                }

                this.Region = new Region(path);

                // Vẽ Text & Image
                Color textColor = Enabled ? ForeColor : Color.FromArgb(156, 163, 175);
                TextRenderer.DrawText(g, Text, Font, rect, textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
