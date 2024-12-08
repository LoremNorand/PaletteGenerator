using PaletteGenerator.Core.Colors.Calculations;
using System;
using System.Globalization;

namespace PaletteGenerator.Core.Colors
{
    internal class FullColor
    {
        private int _red;
        private int _green;
        private int _blue;

        private int _hue;
        private int _saturation;
        private int _brightness;

        private double _visualLuminance;

        public (int R, int G, int B) RGB
        {
            get => (R: _red, G: _green, B: _blue);
            set
            {
                _red = Range.Clamp(0, 255, value.R);
                _green = Range.Clamp(0, 255, value.G);
                _blue = Range.Clamp(0, 255, value.B);

                (int H, int S, int B) buffer = SchemeConverter.RgbToHsb(value);
                _hue = buffer.H;
                _saturation = buffer.S;
                _brightness = buffer.B;

                _visualLuminance = Colors.Luminance.FromRGB(RGB);
            }
        }

        public (int H, int S, int B) HSB
        {
            get => (H: _hue, S: _saturation, B: _brightness);
            set
            {
                _hue = Range.Cycle(0, 360, value.H);
                _saturation = Range.Clamp(0, 100, value.S);
                _brightness = Range.Clamp(0, 100, value.B);

                (int R, int G, int B) buffer = SchemeConverter.HsbToRgb(value);
                _red = buffer.R;
                _green = buffer.G;
                _blue = buffer.B;

                _visualLuminance = Colors.Luminance.FromRGB(RGB);
            }
        }

        public double Luminance
        {
            get => _visualLuminance; 
        }

        public string HEX
        {
            get => $"#{_red:X2}{_green:X2}{_blue:X2}";
            set
            {
                // Убираем символ #, если он есть
                if(value.StartsWith("#"))
                    value = value.Substring(1);

                // Проверяем, что строка состоит из 6 символов (RRGGBB)
                if(value.Length != 6 || !int.TryParse(value.Substring(0, 2), NumberStyles.HexNumber, null, out int r) ||
                    !int.TryParse(value.Substring(2, 2), NumberStyles.HexNumber, null, out int g) ||
                    !int.TryParse(value.Substring(4, 2), NumberStyles.HexNumber, null, out int b))
                {
                    throw new ArgumentException("Некорректный HEX-формат. Используйте строку вида #RRGGBB.");
                }

                // Обновляем RGB, HSB и визуальную яркость
                RGB = (r, g, b);
            }
        }
    }
}
