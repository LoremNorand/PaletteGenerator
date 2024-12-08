using PaletteGenerator.Core.Colors;
using PaletteGenerator.Core.Colors.Calculations;
using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteGenerator.Algorithms
{
    internal class Temp
    {
        public static FullColor low;
        public static FullColor mid;
        public static FullColor top;

        public static void Method()
        {
            Bitmap bitmap = new Bitmap(360, 100);

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    int n = Convert.ToInt32(Luminance.FromHSB((i, j, 100)));
                    bitmap.SetPixel(i, j, Color.FromArgb(n, n, n));
                }
            }

            Clipboard.SetImage(bitmap);
        }

        public static void TestRandom(FullColor low, FullColor mid, FullColor top)
        {
            Low(low);
            Mid(mid);
            Top(top);
        }

        private static void Low(FullColor color)
        {
            color.HSB = (0, 100, 100);
            Random random = new Random();

            int hue, saturation, brightness;

            while (!Range.In(0, 0.005, color.Luminance))
            {
                hue = random.Next(180, 330);
                saturation = random.Next(85, 101);
                brightness = random.Next(0, 25);

                color.HSB = (hue, saturation, brightness);
            }
            low = color;
        }

        private static void Mid(FullColor color)
        {
            Random random = new Random();

            int hue, saturation, brightness;
            while (!Range.In(4.3, 4.5, Luminance.Contrast(color, low)))
            {
                hue = random.Next(-10, 200);
                saturation = random.Next(20, 80);
                brightness = random.Next(30, 60);

                color.HSB = (hue, saturation, brightness);
            }
            mid = color;
        }

        private static void Top(FullColor color)
        {
            Random random = new Random();

            int hue, saturation, brightness;

            while (Luminance.Contrast(color, mid) < (4.30 - low.Luminance))
            {
                hue = random.Next(20, 180);
                saturation = random.Next(0, 50);
                brightness = random.Next(85, 101);

                color.HSB = (hue, saturation, brightness);
            }
            top = color;
        }
        
    }
}
