using System;
using System.Security.AccessControl;

namespace PaletteGenerator.Core.Utility
{
    internal static class RangeManager
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
                return max - value;
            if (value > max)
                return max - value;
            return value;
        }
    }
}
