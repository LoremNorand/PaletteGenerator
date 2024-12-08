using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteGenerator.Core.Colors
{
    internal static class Luminance
    {
        public static double FromRGB((int R, int G, int B) rgb)
        {
            double r = LinearizeColor(rgb.R / 255.0);
            double g = LinearizeColor(rgb.G / 255.0);
            double b = LinearizeColor(rgb.B / 255.0);

            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        }

        public static double FromHSB((int H, int S, int B) hsb)
        {
            (int R, int G, int B) rgb = SchemeConverter.HsbToRgb(hsb);
            return FromRGB(rgb);
        }

        public static double FromFullColor(FullColor color)
        {
            double r = LinearizeColor(color.RGB.R / 255.0);
            double g = LinearizeColor(color.RGB.G / 255.0);
            double b = LinearizeColor(color.RGB.B / 255.0);

            return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        }

        public static double Delta(FullColor firstColor, FullColor secondColor)
        {
            return firstColor.Luminance - secondColor.Luminance;
        }

        public static double Contrast(FullColor firstColor, FullColor secondColor)
        {
            return (firstColor.Luminance + 0.05) / (secondColor.Luminance + 0.05);
        }

        private static double LinearizeColor(double colorValue)
        {
            if (colorValue <= 0.03928)
            {
                return colorValue / 12.92;
            }
            else
            {
                return Math.Pow((colorValue + 0.055) / 1.055, 2.4);
            }
        }
    }
}
