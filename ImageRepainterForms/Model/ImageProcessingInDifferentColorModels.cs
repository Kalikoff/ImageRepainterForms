using ColorHelper;
using ImageRepainterForms.Model.StaticFields;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageRepainterForms.Model {
    /// <summary>
    /// Обработка изображений в различных цветовых моделях
    /// </summary>
    class ImageProcessingInDifferentColorModels {
        private List<IColor> _listColorPalette; // List цветов выбранной цветовой модели
        private int[,] _differenceBetweenColorsIColor; // Разница по каждому каналу в выбранной цветовой модели
        private int[] _sumDifferenceBetweenColorsIColor; // Сумма разницц по каждому каналу в выбранной цветовой модели
        private int _imageProcessingProgress; // Прогресс обработки изображения (от 0 до 100)

        /// <summary>
        /// Обработка изображения в выбранной цветовой модели
        /// </summary>
        /// <param name="listColorsPalette"></param>
        /// <param name="sourceImage"></param>
        /// <param name="nameColorModel"></param>
        /// <returns>Обработанное изображение</returns>
        public Bitmap ProcessImageInSelectedColorModel(string nameColorModel) {
            Bitmap processedImage = (Bitmap)SourceImage.s_sourceImage.Clone();
            _listColorPalette = new List<IColor>();
            _imageProcessingProgress = 0;

            int numberPixelsInImage = SourceImage.s_sourceImage.Width * SourceImage.s_sourceImage.Height; // Количество пикселей в изображении

            foreach (Color color in ListColor.s_ListColor) {
                IColor iColor = null;
                RGB rgb = new RGB(color.R, color.G, color.B);

                switch (nameColorModel) {
                    case "RGB": iColor = rgb; break;
                    case "HSL": iColor = ColorHelper.ColorConverter.RgbToHsl(rgb); break;
                    case "HSV": iColor = ColorHelper.ColorConverter.RgbToHsv(rgb); break;
                    case "XYZ": iColor = ColorHelper.ColorConverter.RgbToXyz(rgb); break;
                }

                _listColorPalette.Add(iColor);
            }

            for (int i = 0; i < processedImage.Height; i++) {
                for (int j = 0; j < processedImage.Width; j++) {
                    _differenceBetweenColorsIColor = new int[3, _listColorPalette.Count];
                    _sumDifferenceBetweenColorsIColor = new int[_listColorPalette.Count];

                    Color pixelColor = processedImage.GetPixel(j, i);

                    for (int k = 0; k < _listColorPalette.Count; k++) {
                        GetDifferenceBetweenColorsIColor(pixelColor, k, nameColorModel);

                        _sumDifferenceBetweenColorsIColor[k] = _differenceBetweenColorsIColor[0, k] + _differenceBetweenColorsIColor[1, k] + _differenceBetweenColorsIColor[2, k];
                    }

                    int min = _sumDifferenceBetweenColorsIColor[0], indexMin = 0;
                    for (int l = 1; l < _listColorPalette.Count; l++) {
                        if (_sumDifferenceBetweenColorsIColor[l] < min) {
                            min = _sumDifferenceBetweenColorsIColor[l];
                            indexMin = l;
                        }
                    }

                    Color replaceableColor = ListColor.s_ListColor[indexMin];

                    processedImage.SetPixel(j, i, replaceableColor);

                    int numberProcessedPixels = (i + 1) * (j + 1); // Количество обработанных пикселей
                    _imageProcessingProgress = numberProcessedPixels / (numberPixelsInImage / 100);
                }
            }

            return processedImage;
        }

        /// <summary>
        /// Получить количество обработанных пикселей в процентах
        /// </summary>
        /// <returns></returns>
        public int GetPercentageOfProcessedPixels() {
            return _imageProcessingProgress;
        }

        /// <summary>
        /// Получить разницу по каждому каналу между пикселем изображения и цветом из палитры, в выбранной цветовой модели
        /// </summary>
        /// <param name="pixelColor">Цвет пикселя в RGB</param>
        /// <param name="index">Индекс массива</param>
        /// <param name="nameColorModel">Название цветовой модели</param>
        private void GetDifferenceBetweenColorsIColor(Color pixelColor, int index, string nameColorModel) {
            switch (nameColorModel) {
                case "RGB":
                    RGB pixelColorRGB = new RGB(pixelColor.R, pixelColor.G, pixelColor.B);
                    RGB pixelListColorsRGB = (RGB)_listColorPalette[index];

                    _differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorRGB.R, pixelListColorsRGB.R);
                    _differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorRGB.G, pixelListColorsRGB.G);
                    _differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorRGB.B, pixelListColorsRGB.B);
                    break;

                case "HSL":
                    HSL pixelColorHSL = ColorHelper.ColorConverter.RgbToHsl(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    HSL pixelListColorsHSL = (HSL)_listColorPalette[index];

                    _differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorHSL.H, pixelListColorsHSL.H);
                    _differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorHSL.S, pixelListColorsHSL.S);
                    _differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorHSL.L, pixelListColorsHSL.L);
                    break;

                case "HSV":
                    HSV pixelColorHSV = ColorHelper.ColorConverter.RgbToHsv(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    HSV pixelListColorsHSV = (HSV)_listColorPalette[index];

                    _differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorHSV.H, pixelListColorsHSV.H);
                    _differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorHSV.S, pixelListColorsHSV.S);
                    _differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorHSV.V, pixelListColorsHSV.V);
                    break;

                case "XYZ":
                    XYZ pixelColorXYZ = ColorHelper.ColorConverter.RgbToXyz(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    XYZ pixelListColorsXYZ = (XYZ)_listColorPalette[index];

                    _differenceBetweenColorsIColor[0, index] = SubtractFromLargest((int)pixelColorXYZ.X, (int)pixelListColorsXYZ.X);
                    _differenceBetweenColorsIColor[1, index] = SubtractFromLargest((int)pixelColorXYZ.Y, (int)pixelListColorsXYZ.Y);
                    _differenceBetweenColorsIColor[2, index] = SubtractFromLargest((int)pixelColorXYZ.Z, (int)pixelListColorsXYZ.Z);
                    break;
            }
        }

        /// <summary>
        /// Получить результат вычитания наименьшего числа из наибольшего числа
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int SubtractFromLargest(int a, int b) {
            return Math.Abs(a - b);
        }
    }
}