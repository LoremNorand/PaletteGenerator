using PaletteGenerator.Core;
using PaletteGenerator.Core.Utility;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteGenerator.Algorithms
{
    internal class Temp
    {
        private static readonly Random Random = new Random();

        // Константы для диапазонов
        private const double LowLuminanceMin = 0.0001;
        private const double LowLuminanceMax = 0.02;

        private const double MidContrastMin = 4.5;
        private const double MidContrastMax = 5.0;

        private const double TopContrastMin = 4.5;
        private const double TopContrastMax = 5.0;

        private const int MaxAttempts = 32;

        public static FullColor low;
        public static FullColor mid;

        // Устаревший метод, без изменений
        public static void Method()
        {
            Bitmap bitmap = new Bitmap(360, 100);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int n = Convert.ToInt32(Core.Utility.VisualLuminance.FromHSB((i, j, 100)));
                    bitmap.SetPixel(i, j, Color.FromArgb(n, n, n));
                }
            }

            Clipboard.SetImage(bitmap);
        }

        public static void TestRandom(FullColor low, FullColor mid, FullColor top)
        {
            GenerateLowColor(low);
            GenerateMidColor(mid);
            GenerateTopColor(top);
        }

        // Генерация Low
        public static void GenerateLowColor(FullColor color)
        {
            color.RGB = (255, 255, 255);
            while (!Core.Utility.RangeManager.InRange(LowLuminanceMin, LowLuminanceMax, color.Luminance))
            {
                color.HSB = GenerateRandomHSB(0, 360, 70, 100, 0, 20);
            }
            low = color;
        }

        // 180 330

        // Генерация Mid
        public static void GenerateMidColor(FullColor color)
        {
            color.RGB = (0, 0, 0);
            int attempts = 0;
            while (!RangeManager.InRange(MidContrastMin, MidContrastMax, VisualLuminance.Contrast(color, low)))
            {
                if (++attempts > MaxAttempts)
                {
                    GenerateLowColor(low);
                }

                color.HSB = GenerateRandomHSB(0, 360, 30, 80, 30, 90);
            }
            mid = color;
        }

        // -10 200

        // Генерация Top
        public static void GenerateTopColor(FullColor color)
        {
            color.RGB = (128, 128, 128);
            int attempts = 0;
            while (!RangeManager.InRange(TopContrastMin, TopContrastMax, VisualLuminance.Contrast(color, mid)))
            {
                if (++attempts > MaxAttempts)
                {
                    GenerateMidColor(mid);
                }

                color.HSB = GenerateRandomHSB(0, 360, 0, 30, 95, 100);
            }
        }

        // 40 180

        // Универсальный метод для генерации HSB
        private static (int, int, int) GenerateRandomHSB(int hueMin, int hueMax, int saturationMin, int saturationMax, int brightnessMin, int brightnessMax)
        {
            int hue = Random.Next(hueMin, hueMax + 1);
            int saturation = Random.Next(saturationMin, saturationMax + 1);
            int brightness = Random.Next(brightnessMin, brightnessMax + 1);

            return (hue, saturation, brightness);
        }
    }
}
