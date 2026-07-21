using System;
using System.Drawing;
using System.Windows.Forms;
using BT_TNC_Dot_NET.Controls;

namespace BT_TNC_Dot_NET.Helpers
{
    public enum AppThemeMode
    {
        WinUI3Fluent,
        CinematicMidnight,
        CyberpunkNeon,
        EmeraldStudio,
        NordicLight,
        SunsetCrimson
    }

    public class ThemePalette
    {
        public Color FormBg { get; set; }
        public Color HeaderTop { get; set; }
        public Color HeaderBottom { get; set; }
        public Color HeaderBorder { get; set; }
        public Color CardTop { get; set; }
        public Color CardBottom { get; set; }
        public Color CardBorder { get; set; }
        public Color TextPrimary { get; set; }
        public Color TextSecondary { get; set; }
        public Color AccentCyan { get; set; }
        public Color AccentIndigo { get; set; }
        public Color PlayBtnBg { get; set; }
        public Color PlayBtnHover { get; set; }
        public Color PlayBtnBorder { get; set; }
    }

    public static class ThemeManager
    {
        public static ThemePalette GetPalette(AppThemeMode mode)
        {
            switch (mode)
            {
                case AppThemeMode.WinUI3Fluent:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(20, 20, 24),
                        HeaderTop = Color.FromArgb(32, 32, 38),
                        HeaderBottom = Color.FromArgb(20, 20, 24),
                        HeaderBorder = Color.FromArgb(0, 120, 212),
                        CardTop = Color.FromArgb(36, 36, 44),
                        CardBottom = Color.FromArgb(28, 28, 34),
                        CardBorder = Color.FromArgb(60, 60, 72),
                        TextPrimary = Color.FromArgb(255, 255, 255),
                        TextSecondary = Color.FromArgb(180, 185, 200),
                        AccentCyan = Color.FromArgb(0, 120, 212),
                        AccentIndigo = Color.FromArgb(135, 100, 255),
                        PlayBtnBg = Color.FromArgb(0, 120, 212),
                        PlayBtnHover = Color.FromArgb(26, 140, 230),
                        PlayBtnBorder = Color.FromArgb(100, 180, 255)
                    };

                case AppThemeMode.CyberpunkNeon:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(13, 2, 33),
                        HeaderTop = Color.FromArgb(45, 0, 75),
                        HeaderBottom = Color.FromArgb(19, 0, 40),
                        HeaderBorder = Color.FromArgb(247, 37, 133),
                        CardTop = Color.FromArgb(28, 10, 56),
                        CardBottom = Color.FromArgb(20, 5, 42),
                        CardBorder = Color.FromArgb(114, 9, 183),
                        TextPrimary = Color.FromArgb(247, 247, 249),
                        TextSecondary = Color.FromArgb(224, 170, 255),
                        AccentCyan = Color.FromArgb(0, 245, 212),
                        AccentIndigo = Color.FromArgb(247, 37, 133),
                        PlayBtnBg = Color.FromArgb(114, 9, 183),
                        PlayBtnHover = Color.FromArgb(141, 9, 210),
                        PlayBtnBorder = Color.FromArgb(0, 245, 212)
                    };

                case AppThemeMode.EmeraldStudio:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(6, 78, 59),
                        HeaderTop = Color.FromArgb(4, 120, 87),
                        HeaderBottom = Color.FromArgb(6, 78, 59),
                        HeaderBorder = Color.FromArgb(52, 211, 153),
                        CardTop = Color.FromArgb(16, 90, 72),
                        CardBottom = Color.FromArgb(10, 68, 54),
                        CardBorder = Color.FromArgb(16, 185, 129),
                        TextPrimary = Color.FromArgb(240, 253, 250),
                        TextSecondary = Color.FromArgb(153, 246, 228),
                        AccentCyan = Color.FromArgb(45, 212, 191),
                        AccentIndigo = Color.FromArgb(52, 211, 153),
                        PlayBtnBg = Color.FromArgb(5, 150, 105),
                        PlayBtnHover = Color.FromArgb(16, 185, 129),
                        PlayBtnBorder = Color.FromArgb(110, 231, 183)
                    };

                case AppThemeMode.NordicLight:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(241, 245, 249),
                        HeaderTop = Color.FromArgb(255, 255, 255),
                        HeaderBottom = Color.FromArgb(226, 232, 240),
                        HeaderBorder = Color.FromArgb(203, 213, 225),
                        CardTop = Color.FromArgb(255, 255, 255),
                        CardBottom = Color.FromArgb(248, 250, 252),
                        CardBorder = Color.FromArgb(203, 213, 225),
                        TextPrimary = Color.FromArgb(15, 23, 42),
                        TextSecondary = Color.FromArgb(71, 85, 105),
                        AccentCyan = Color.FromArgb(2, 132, 199),
                        AccentIndigo = Color.FromArgb(79, 70, 229),
                        PlayBtnBg = Color.FromArgb(79, 70, 229),
                        PlayBtnHover = Color.FromArgb(99, 102, 241),
                        PlayBtnBorder = Color.FromArgb(129, 140, 248)
                    };

                case AppThemeMode.SunsetCrimson:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(26, 9, 13),
                        HeaderTop = Color.FromArgb(76, 5, 25),
                        HeaderBottom = Color.FromArgb(35, 6, 17),
                        HeaderBorder = Color.FromArgb(251, 113, 133),
                        CardTop = Color.FromArgb(45, 12, 22),
                        CardBottom = Color.FromArgb(30, 8, 15),
                        CardBorder = Color.FromArgb(225, 29, 72),
                        TextPrimary = Color.FromArgb(255, 241, 242),
                        TextSecondary = Color.FromArgb(254, 205, 211),
                        AccentCyan = Color.FromArgb(251, 146, 60),
                        AccentIndigo = Color.FromArgb(244, 63, 94),
                        PlayBtnBg = Color.FromArgb(225, 29, 72),
                        PlayBtnHover = Color.FromArgb(244, 63, 94),
                        PlayBtnBorder = Color.FromArgb(251, 113, 133)
                    };

                case AppThemeMode.CinematicMidnight:
                default:
                    return new ThemePalette
                    {
                        FormBg = Color.FromArgb(11, 15, 25),
                        HeaderTop = Color.FromArgb(30, 27, 75),
                        HeaderBottom = Color.FromArgb(15, 23, 42),
                        HeaderBorder = Color.FromArgb(99, 102, 241),
                        CardTop = Color.FromArgb(22, 30, 46),
                        CardBottom = Color.FromArgb(22, 30, 46),
                        CardBorder = Color.FromArgb(51, 65, 85),
                        TextPrimary = Color.FromArgb(248, 250, 252),
                        TextSecondary = Color.FromArgb(148, 163, 184),
                        AccentCyan = Color.FromArgb(6, 182, 212),
                        AccentIndigo = Color.FromArgb(129, 140, 248),
                        PlayBtnBg = Color.FromArgb(79, 70, 229),
                        PlayBtnHover = Color.FromArgb(99, 102, 241),
                        PlayBtnBorder = Color.FromArgb(167, 139, 250)
                    };
            }
        }
    }
}
