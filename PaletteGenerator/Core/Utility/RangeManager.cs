using System;
using System.Runtime.InteropServices;

namespace PaletteGenerator.Core.Utility
{
    public static class RangeManager
    {
        public static int Clamp(int min, int max, int value)
        {
            return Math.Min(Math.Max(min, value), max);
        }

        public static double Clamp(double min, double max, double value)
        {
            return Math.Min(Math.Max(min, value), max);
        }

        public static int Cycle(int min, int max, int value)
        {
            if (value < min)
                return max - (min - value);

            if (value > max)
                return min + (value - max);

            return value;
        }

        public static bool InRange(double min, double max, double value)
        {
            return ((value >= min) && (value <= max));
        }
    }
}
