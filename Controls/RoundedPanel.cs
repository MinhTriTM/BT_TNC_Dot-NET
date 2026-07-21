using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET.Controls
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 16;
        private Color _borderColor = Color.FromArgb(45, 55, 72);
        private int _borderWidth = 1;
        private Color _gradientTopColor = Color.FromArgb(22, 30, 46);
        private Color _gradientBottomColor = Color.FromArgb(22, 30, 46);
        private float _gradientAngle = 90F;

        [Category("Cinematic UI"), DefaultValue(16)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = Math.Max(1, value); Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Cinematic UI"), DefaultValue(1)]
        public int BorderWidth
        {
            get => _borderWidth;
            set { _borderWidth = Math.Max(0, value); Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color GradientTopColor
        {
            get => _gradientTopColor;
            set { _gradientTopColor = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color GradientBottomColor
        {
            get => _gradientBottomColor;
            set { _gradientBottomColor = value; Invalidate(); }
        }

        [Category("Cinematic UI"), DefaultValue(90F)]
        public float GradientAngle
        {
            get => _gradientAngle;
            set { _gradientAngle = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | 
                     ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            Padding = new Padding(12);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            if (rect.Width <= 0 || rect.Height <= 0) return;

            using (GraphicsPath path = GetRoundedPath(rect, _borderRadius))
            {
                if (_gradientTopColor != _gradientBottomColor)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, _gradientTopColor, _gradientBottomColor, _gradientAngle))
                    {
                        g.FillPath(brush, path);
                    }
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(_gradientTopColor))
                    {
                        g.FillPath(brush, path);
                    }
                }

                if (_borderWidth > 0 && _borderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(_borderColor, _borderWidth))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawPath(pen, path);
                    }
                }

                this.Region = new Region(path);
            }
        }
    }
}
