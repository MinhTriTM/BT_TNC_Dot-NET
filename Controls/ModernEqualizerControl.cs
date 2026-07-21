using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET.Controls
{
    public class ModernEqualizerControl : UserControl
    {
        private readonly int[] _frequencies = new int[] { 31, 63, 125, 250, 500, 1000, 2000, 4000, 8000, 16000 };
        private readonly string[] _freqLabels = new string[] { "31", "63", "125", "250", "500", "1k", "2k", "4k", "8k", "16k" };
        private readonly float[] _gains = new float[10]; // -12dB to +12dB

        public event EventHandler GainChanged;

        public float[] Gains => _gains;

        public ModernEqualizerControl()
        {
            DoubleBuffered = true;
            Size = new Size(274, 115);
            BackColor = Color.Transparent;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            UpdateGainFromMouse(e.X, e.Y);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                UpdateGainFromMouse(e.X, e.Y);
            }
        }

        private void UpdateGainFromMouse(int x, int y)
        {
            int colWidth = Width / 10;
            int colIndex = Math.Max(0, Math.Min(9, x / colWidth));

            int top = 22;
            int bottom = Height - 22;
            int trackHeight = bottom - top;

            int clampedY = Math.Max(top, Math.Min(bottom, y));
            float norm = 1.0f - ((float)(clampedY - top) / trackHeight); // 0.0 to 1.0
            float gain = (norm * 24.0f) - 12.0f; // -12dB to +12dB

            _gains[colIndex] = (float)Math.Round(gain, 1);
            Invalidate();
            GainChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int colWidth = Width / 10;
            int top = 22;
            int bottom = Height - 22;
            int trackHeight = bottom - top;
            int centerY = top + trackHeight / 2;

            // Đường trung tính 0dB
            using (Pen zeroPen = new Pen(Color.FromArgb(80, 255, 255, 255), 1))
            {
                zeroPen.DashStyle = DashStyle.Dash;
                g.DrawLine(zeroPen, 0, centerY, Width, centerY);
            }

            for (int i = 0; i < 10; i++)
            {
                int x = i * colWidth + colWidth / 2;

                // Đường ray dọc
                using (Pen trackPen = new Pen(Color.FromArgb(40, 40, 50), 4))
                {
                    g.DrawLine(trackPen, x, top, x, bottom);
                }

                float norm = (_gains[i] + 12.0f) / 24.0f;
                int thumbY = bottom - (int)(norm * trackHeight);

                // Đường gain active từ center đến thumb
                Color activeColor = _gains[i] >= 0 ? Color.FromArgb(56, 189, 248) : Color.FromArgb(244, 63, 94);
                using (Pen activePen = new Pen(activeColor, 3))
                {
                    g.DrawLine(activePen, x, centerY, x, thumbY);
                }

                // Cần gạt Thumb
                using (SolidBrush thumbBrush = new SolidBrush(Color.FromArgb(248, 250, 252)))
                {
                    g.FillEllipse(thumbBrush, x - 5, thumbY - 5, 10, 10);
                }
                using (Pen thumbBorder = new Pen(activeColor, 2))
                {
                    g.DrawEllipse(thumbBorder, x - 5, thumbY - 5, 10, 10);
                }

                // Nhãn tần số Hz bên dưới
                using (Font labelFont = new Font("Segoe UI", 7F, FontStyle.Regular))
                using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(148, 163, 184)))
                {
                    SizeF sz = g.MeasureString(_freqLabels[i], labelFont);
                    g.DrawString(_freqLabels[i], labelFont, textBrush, x - sz.Width / 2, bottom + 4);
                }

                // Nhãn dB bên trên
                string dbText = _gains[i] > 0 ? $"+{_gains[i]:F0}" : $"{_gains[i]:F0}";
                using (Font dbFont = new Font("Segoe UI", 6.8F, FontStyle.Bold))
                using (SolidBrush dbBrush = new SolidBrush(activeColor))
                {
                    SizeF sz = g.MeasureString(dbText, dbFont);
                    g.DrawString(dbText, dbFont, dbBrush, x - sz.Width / 2, 4);
                }
            }
        }
    }
}
