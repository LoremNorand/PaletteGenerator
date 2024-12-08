using PaletteGenerator.Core.Colors;
using PaletteGenerator.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PaletteGenerator.Core.Palettes
{
    internal class BasePalette : IPalette
    {
        private readonly List<FullColor> _colors = new List<FullColor>();
        
        public FullColor this[int index]
        {
            get
            {
                if(index < 0)
                    index = _colors.Count + index; // Поддержка отрицательных индексов
                if(index < 0 || index >= _colors.Count)
                    throw new IndexOutOfRangeException($"Индекс {index} выходит за пределы списка палитры.");
                return _colors[index];
            }
            set
            {
                if(index < 0)
                    index = _colors.Count + index;
                if(index < 0 || index >= _colors.Count)
                    throw new IndexOutOfRangeException($"Индекс {index} выходит за пределы списка палитры.");
                _colors[index] = value;
            }
        }

        public FullColor this[string hex]
        {
            get
            {
                var color = _colors.FirstOrDefault(c => c.HEX.Equals(hex, StringComparison.OrdinalIgnoreCase));
                if(color == null)
                    throw new KeyNotFoundException($"Цвет с HEX \"{hex}\" не найден в палитре.");
                return color;
            }
            set
            {
                var existingColor = _colors.FirstOrDefault(c => c.HEX.Equals(hex, StringComparison.OrdinalIgnoreCase));
                if(existingColor != null)
                {
                    // Заменяем цвет
                    _colors.Remove(existingColor);
                }
                _colors.Add(value); // Добавляем новый цвет
            }
        }

        public bool Contains(string hex)
        {
            return _colors.Any(c => c.HEX.Equals(hex, StringComparison.OrdinalIgnoreCase));
        }

        public void Add(FullColor color)
        {
            if(!Contains(color.HEX))
            {
                _colors.Add(color);
            }
            else
            {
                throw new InvalidOperationException($"Цвет с HEX \"{color.HEX}\" уже существует в палитре.");
            }
        }

        public void Remove(string hex)
        {
            var color = _colors.FirstOrDefault(c => c.HEX.Equals(hex, StringComparison.OrdinalIgnoreCase));
            if(color == null)
                throw new KeyNotFoundException($"Цвет с HEX \"{hex}\" не найден в палитре.");
            _colors.Remove(color);
        }

        public int Count => _colors.Count;
    }

}
