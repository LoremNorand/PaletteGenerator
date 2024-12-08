using PaletteGenerator.Core.Colors;
using System.IO;

namespace PaletteGenerator.Core
{
    internal static class Logging
    {
        public static void Log(string message, FullColor color)
        {
            int H = color.HSB.H;
            int S = color.HSB.S;
            int Br = color.HSB.B;

            int R = color.RGB.R;
            int G = color.RGB.G;
            int Bl = color.RGB.B;

            double L  = color.Luminance;
            string hex = color.HEX;

            File.AppendAllText("C:/Users/Asus/Desktop/log.txt",
                $"{message, 12} | {hex} | HSB: {H, 3} {S, 3} {Br, 3} | RGB: {R, 3} {G, 3} {Bl, 3} | L: {L.ToString("F2")}\n");
        }
    }
}
