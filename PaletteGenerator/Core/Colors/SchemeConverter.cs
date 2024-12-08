using System;
using System.Linq;

namespace PaletteGenerator.Core.Colors
{
    internal static class SchemeConverter
    {
        public static (int H, int S, int B) RgbToHsb((int R, int G, int B) rgb)
        {
            double r = rgb.R / 255d;
            double g = rgb.G / 255d;
            double b = rgb.B / 255d;

            double minValue = new double[] { r, g, b }.Min();
            double maxValue = new double[] { r, g, b }.Max();
            double delta = maxValue - minValue;

            double hue = 0;
            double saturation;
            double brightness = maxValue * 100;

            if(Math.Abs(maxValue - 0) < 0.00001 || Math.Abs(delta - 0) < 0.00001)
            {
                hue = 0;
                saturation = 0;
            }
            else
            {
                if(Math.Abs(minValue - 0) < 0.00001)
                    saturation = 100;
                else
                    saturation = delta / maxValue * 100;

                if(Math.Abs(r - maxValue) < 0.00001)
                    hue = (g - b) / delta;
                else if(Math.Abs(g - maxValue) < 0.00001)
                    hue = 2 + (b - r) / delta;
                else if(Math.Abs(b - maxValue) < 0.00001)
                    hue = 4 + (r - g) / delta;
            }

            hue *= 60;
            if(hue < 0)
            {
                hue += 360;
            }

            return (H: (int)hue, S: (int)saturation, B: (int)brightness);
        }

        public static (int R, int G, int B) HsbToRgb((int H, int S, int B) hsb)
        {
            double red = 0, green = 0, blue = 0;

            double h = hsb.H;
            double s = (double)hsb.S / 100;
            double b = (double)hsb.B/ 100;

            if(Math.Abs(s - 0) < 0.00001)
            {
                red = b;
                green = b;
                blue = b;
            }
            else
            {
                // the color wheel has six sectors.

                double sectorPosition = h / 60;
                int sectorNumber = (int)Math.Floor(sectorPosition);
                double fractionalSector = sectorPosition - sectorNumber;

                double p = b * (1 - s);
                double q = b * (1 - s * fractionalSector);
                double t = b * (1 - s * (1 - fractionalSector));

                // Assign the fractional colors to r, g, and b
                // based on the sector the angle is in.
                switch(sectorNumber)
                {
                    case 0:
                        red = b;
                        green = t;
                        blue = p;
                        break;

                    case 1:
                        red = q;
                        green = b;
                        blue = p;
                        break;

                    case 2:
                        red = p;
                        green = b;
                        blue = t;
                        break;

                    case 3:
                        red = p;
                        green = q;
                        blue = b;
                        break;

                    case 4:
                        red = t;
                        green = p;
                        blue = b;
                        break;

                    case 5:
                        red = b;
                        green = p;
                        blue = q;
                        break;
                }
            }

            int nRed = Convert.ToInt32(red * 255);
            int nGreen = Convert.ToInt32(green * 255);
            int nBlue = Convert.ToInt32(blue * 255);

            return (R: nRed, G: nGreen, B: nBlue);
        }
    }
}
