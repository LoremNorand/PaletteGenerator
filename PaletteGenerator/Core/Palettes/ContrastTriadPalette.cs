using PaletteGenerator.Algorithms.Generators;
using PaletteGenerator.Core.Colors;
using System.Collections.Generic;

namespace PaletteGenerator.Core.Palettes
{
    internal class ContrastTriadPalette : BasePalette
    {
        public ContrastTriadPalette()
        {
            List<FullColor> colors = ContrastTriadGenerator.Generate();
            foreach(FullColor color in colors)
            {
                Add(color);
            }
        }
    }
}
