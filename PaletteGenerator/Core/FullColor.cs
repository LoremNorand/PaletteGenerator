using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaletteGenerator.Core
{
    internal class FullColor
    {
        private int _red;
        private int _green;
        private int _blue;

        private int _hue;
        private int _saturation;
        private int _brightness;

        public (int R, int G, int B) RGB
        {
            get => (R: _red, G: _green, B: _blue);
            set
            {
                _red = value.R;
                _green = value.G;
                _blue = value.B;

                (int H, int S, int B) buffer = Utility.ColorSchemeConverter.RgbToHsb(value);
                _hue = buffer.H;
                _saturation = buffer.S;
                _brightness = buffer.B;
            }
        }

        public (int H, int S, int B) HSB
        {
            get => (H: _hue, S: _saturation, B: _brightness);
            set
            {
                _hue = value.H;
                _saturation = value.S;
                _brightness = value.B;

                (int R, int G, int B) buffer = Utility.ColorSchemeConverter.HsbToRgb(value);
                _red = buffer.R;
                _green = buffer.G;
                _blue = buffer.B;
            }
        }
    }
}
