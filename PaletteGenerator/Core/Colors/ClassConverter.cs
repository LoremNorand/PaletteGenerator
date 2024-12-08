using System.Drawing;

namespace PaletteGenerator.Core.Colors
{
    internal static class ClassConverter
    {
        public static FullColor ColorToFullColor(Color color)
        {
            return new FullColor() { RGB = (color.R, color.G, color.B) };

        }

        public static Color FullColorToColor(FullColor color)
        {
            return Color.FromArgb(color.RGB.R, color.RGB.G, color.RGB.B);
        }
    }
}
