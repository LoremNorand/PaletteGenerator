using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public static class Modifiers
    {
        public static string ParseHexColor(string input)
        {
            input = input.Trim().ToUpper();

            if (!input.StartsWith("#"))
            {
                input = "#" + input;
            }

            if (input.Length != 7 || !Regex.IsMatch(input, @"^#[0-9A-F]{6}$"))
            {
                throw new FormatException("Неверный формат HEX-цвета. Используйте формат #RRGGBB или RRGGBB.");
            }

            return input;
        }

        public static Color BlendColors(Color baseColor, Color blendColor, float factor)
        {
            int r = (int)(baseColor.R + (blendColor.R - baseColor.R) * factor);
            int g = (int)(baseColor.G + (blendColor.G - baseColor.G) * factor);
            int b = (int)(baseColor.B + (blendColor.B - baseColor.B) * factor);

            return Color.FromArgb(r, g, b);
        }

        public static void GenerateShades(Color baseColor, int numShades, bool lighten, Action<Panel, string> addColorPanel)
        {
            for (int i = 0; i < numShades; i++)
            {
                float factor = (float)(i + 1) / numShades;
                Color shadeColor = lighten
                    ? BlendColors(baseColor, Color.White, factor)
                    : BlendColors(baseColor, Color.Black, factor);

                string shadeHex = ColorTranslator.ToHtml(shadeColor);
                Panel colorPanel = new Panel
                {
                    BackColor = shadeColor,
                    Width = 100,
                    Height = 100,
                    Margin = new Padding(5)
                };

                addColorPanel(colorPanel, shadeHex);
            }
        }
        public static void CopyToClipboard(string text)
        {
            try
            {
                Clipboard.SetText(text);
                MessageBox.Show($"Цвет {text} скопирован в буфер обмена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось скопировать в буфер обмена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
