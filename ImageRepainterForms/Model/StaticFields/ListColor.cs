using System.Collections.Generic;
using System.Drawing;

namespace ImageRepainterForms.Model.StaticFields {
    /// <summary>
    /// Класс цветов палитры
    /// </summary>
    class ListColor {
        public static List<Color> s_ListColor { get; set; } // Список цветов палитры

        /// <summary>
        /// Добавить цвета из палитры в список цветов
        /// </summary>
        /// <param name="palette">Палитра</param>
        public static void AddColorsFromPaletteToListColor(Bitmap palette) {
            s_ListColor = new List<Color>();

            for (int i = 0; i < palette.Width; i++) {
                s_ListColor.Add(palette.GetPixel(i, 0));
            }
        }
    }
}