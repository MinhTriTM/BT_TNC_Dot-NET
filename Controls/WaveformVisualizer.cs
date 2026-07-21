using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BT_TNC_Dot_NET.Controls
{
    public class WaveformVisualizer : Control
    {
        private bool _isPlaying = false;
        private readonly Timer _animTimer;
        private readonly float[] _barHeights;
        private readonly Random _random = new Random();

        private Color _barColorStart = Color.FromArgb(6, 182, 212);
        private Color _barColorEnd = Color.FromArgb(168, 85, 247);

        [Category("Cinematic UI")]
        public bool IsPlaying
        {
            get => _isPlaying;
            set
            {
                _isPlaying = value;
                if (_isPlaying) _animTimer.Start();
                else { _animTimer.Stop(); ResetHeights(); }
                Invalidate();
            }
        }

        [Category("Cinematic UI")]
        public Color BarColorStart
        {
            get => _barColorStart;
            set { _barColorStart = value; Invalidate(); }
        }

        [Category("Cinematic UI")]
        public Color BarColorEnd
        {
            get => _barColorEnd;
            set { _barColorEnd = value; Invalidate(); }
        }

        public WaveformVisualizer()
        {
            SetStyle(ControlStyles.UserPaint | 
                     ControlStyles.AllPaintingInWmPaint | 
                     ControlStyles.OptimizedDoubleBuffer | 
                     ControlStyles.ResizeRedraw | 
                     ControlStyles.SupportsTransparentBackColor, true);

            Size = new Size(300, 36);
            BackColor = Color.Transparent;

            _barHeights = new float[24];
            ResetHeights();

            _animTimer = new Timer();
            _animTimer.Interval = 50; // 20 FPS
            _animTimer.Tick += AnimTimer_Tick;
        }

        private void ResetHeights()
        {
            for (int i = 0; i < _barHeights.Length; i++)
            {
                _barHeights[i] = 4f;
            }
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (!_isPlaying) return;

            for (int i = 0; i < _barHeights.Length; i++)
            {
                float target = _random.Next(6, Height - 6);
                _barHeights[i] += (target - _barHeights[i]) * 0.4f;
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int barCount = _barHeights.Length;
            float totalGap = 4f * (barCount - 1);
            float barWidth = (Width - totalGap) / barCount;
            if (barWidth <= 1) barWidth = 2;

            for (int i = 0; i < barCount; i++)
            {
                float x = i * (barWidth + 4f);
                float h = _isPlaying ? _barHeights[i] : 4f;
                float y = (Height - h) / 2f;

                RectangleF rect = new RectangleF(x, y, barWidth, h);
                if (rect.Height <= 0) continue;

                using (LinearGradientBrush brush = new LinearGradientBrush(rect, _barColorStart, _barColorEnd, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(brush, rect);
                }
            }
        }
    }
}
