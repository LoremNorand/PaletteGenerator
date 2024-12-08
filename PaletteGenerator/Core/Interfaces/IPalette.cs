using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaletteGenerator.Core.Colors;

namespace PaletteGenerator.Core.Interfaces
{
    internal interface IPalette
    {
        FullColor this[int index] { get; set; } // Индексация по позиции
        FullColor this[string hex] { get; set; } // Индексация по HEX

        bool Contains(string hex); // Проверка, есть ли цвет
        void Add(FullColor color); // Добавить цвет
        void Remove(string hex); // Удалить цвет по HEX
        int Count { get; } // Количество цветов в палитре
    }
}

