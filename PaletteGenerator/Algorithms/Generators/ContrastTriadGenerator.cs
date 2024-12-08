using PaletteGenerator.Core.Colors;
using PaletteGenerator.Core.Colors.Calculations;
using System;
using System.Collections.Generic;

namespace PaletteGenerator.Algorithms.Generators
{
    internal static class ContrastTriadGenerator
    {
        private static FullColor dark;
        private static FullColor mid;
        private static FullColor light;

        private static Random random = new Random();

        private static readonly int MaxAttempts = 16;

        public static List<FullColor> Generate()
        {
            Dark();
            Mid();
            Light();

            List<FullColor> palette = new List<FullColor>();
            palette.Add(new FullColor() { RGB = dark.RGB });
            palette.Add(new FullColor() { RGB = mid.RGB });
            palette.Add(new FullColor() { RGB = light.RGB });

            return palette;
        }

        private static void Dark()
        {
            dark = new FullColor() { HSB = (0, 0, 100) };
            int H = 0;
            int S = 0;
            int B = 0;

            while(Range.Out(0.00001, 0.005, dark.Luminance))
            {
                H = random.Next(0, 361);
                S = random.Next(85, 101);
                B = random.Next(0, 11);

                dark.HSB = (H, S, B);
            }
        }

        private static void Mid()
        {
            mid = new FullColor() { HSB = dark.HSB };
            int H = 0;
            int S = 0;
            int B = 0;

            int tryCounter = 0;
            while(Range.Out(4.5, 4.7, Luminance.Contrast(mid, dark)))
            {
                H = random.Next(0, 360);
                S = random.Next(20, 100);
                B = random.Next(40, 55);

                mid.HSB = (H: H, S: S, B: B);

                tryCounter++;

                if(tryCounter >= MaxAttempts)
                {
                    Dark();
                    tryCounter = 0;
                }
            }
        }

        private static void Light()
        {
            light = new FullColor() { HSB = mid.HSB };
            int H = 0;
            int S = 0;
            int B = 0;

            int tryCounter = 0;
            while(Range.Out(4.5, 5.0, Luminance.Contrast(light, mid)))
            {
                H = random.Next(0, 360);
                S = random.Next(0, 50);
                B = random.Next(85, 101);

                light.HSB = (H: H, S: S, B: B);

                tryCounter++;

                if(tryCounter >= MaxAttempts)
                {
                    Mid();
                    tryCounter = 0;
                }
            }
        }
    }

}
