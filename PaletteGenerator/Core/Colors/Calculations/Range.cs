using System;

namespace PaletteGenerator.Core.Colors.Calculations
{
    public static class Range
    {
        public static T Clamp<T>(T min, T max, T value) where T : IComparable<T>
        {
            if(value.CompareTo(min) < 0)
                return min;

            if(value.CompareTo(max) > 0)
                return max;

            return value;
        }

        public static T Cycle<T>(T min, T max, T value) where T : IComparable<T>
        {
            dynamic dynMin = min;
            dynamic dynMax = max;
            dynamic dynValue = value;

            if(value.CompareTo(min) < 0)
                return (T)(dynMax - (dynMin - dynValue));

            if(value.CompareTo(max) > 0)
                return (T)(dynMin + (dynValue - dynMax));

            return value;
        }

        public static bool Out(double min, double max, double value)
        {
            return !((value >= min) && (value <= max));
        }

        public static bool In(double min, double max, double value)
        {
            return (value >= min) && (value <= max);
        }
    }
}
