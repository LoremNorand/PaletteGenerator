using PaletteGenerator.Core;
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
        public static double darkL;
        public static double midL;

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
            Low(low);
            Mid(mid);
            Top(top);
        }

        private static void Low(FullColor color)
        {
            color.HSB = (0, 100, 100);
            Random random = new Random();

            int hue, saturation, brightness;

            while (!Core.Utility.RangeManager.InRange(0, 0.1, color.Luminance))
            {
                hue = random.Next(180, 330);
                saturation = random.Next(70, 101);
                brightness = random.Next(0, 45);

                color.HSB = (hue, saturation, brightness);
            }
            darkL = color.Luminance;
        }

        private static void Mid(FullColor color)
        {
            Random random = new Random();

            int hue, saturation, brightness;

            while (color.Luminance < (darkL + 0.2))
            {
                hue = random.Next(-10, 200);
                saturation = random.Next(20, 80);
                brightness = random.Next(30, 60);

                color.HSB = (hue, saturation, brightness);
            }
            midL = color.Luminance;
        }

        private static void Top(FullColor color)
        {
            Random random = new Random();

            int hue, saturation, brightness;

            while (Core.Utility.VisualLuminance.Contrast())
            {
                hue = random.Next(20, 180);
                saturation = random.Next(0, 50);
                brightness = random.Next(60, 101);

                color.HSB = (hue, saturation, brightness);
            }
        }
        
    }
}
