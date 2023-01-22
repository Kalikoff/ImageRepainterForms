using ColorHelper;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageRepainterForms {
    class MultiColorModelProcessImage {
        private List<IColor> listColorPalette;
        private int[,] differenceBetweenColorsIColor;
        private int[] sumDifferenceBetweenColorsIColor;

        public MultiColorModelProcessImage() {

        }


        // 
        public Bitmap ProcessImageToMultiColorModel(List<Color> listColorsPalette, Bitmap sourceImage, string nameColorModel) {
            Bitmap changedImage = (Bitmap)sourceImage.Clone();

            listColorPalette = new List<IColor>();

            foreach (Color color in listColorsPalette) {
                IColor iColor = null;
                RGB rgb = new RGB(color.R, color.G, color.B);

                switch (nameColorModel) {
                    case "RGB": iColor = rgb; break;
                    case "HSL": iColor = ColorHelper.ColorConverter.RgbToHsl(rgb); break;
                    case "HSV": iColor = ColorHelper.ColorConverter.RgbToHsv(rgb); break;
                    case "XYZ": iColor = ColorHelper.ColorConverter.RgbToXyz(rgb); break;
                }

                listColorPalette.Add(iColor);
            }

            for (int i = 0; i < changedImage.Height; i++) {
                for (int j = 0; j < changedImage.Width; j++) {
                    differenceBetweenColorsIColor = new int[3, listColorPalette.Count];
                    sumDifferenceBetweenColorsIColor = new int[listColorPalette.Count];

                    Color pixelColor = changedImage.GetPixel(j, i);

                    for (int k = 0; k < listColorPalette.Count; k++) {
                        GetDifferenceBetweenColorsIColor(pixelColor, k, nameColorModel);

                        sumDifferenceBetweenColorsIColor[k] = differenceBetweenColorsIColor[0, k] + differenceBetweenColorsIColor[1, k] + differenceBetweenColorsIColor[2, k];
                    }

                    int min = sumDifferenceBetweenColorsIColor[0], indexMin = 0;
                    for (int l = 1; l < listColorPalette.Count; l++) {
                        if (sumDifferenceBetweenColorsIColor[l] < min) {
                            min = sumDifferenceBetweenColorsIColor[l];
                            indexMin = l;
                        }
                    }

                    Color replaceableColor = listColorsPalette[indexMin];

                    changedImage.SetPixel(j, i, replaceableColor);
                }
            }

            return changedImage;
        }


        // 
        private void GetDifferenceBetweenColorsIColor(Color pixelColor, int index, string nameColorModel) {
            switch (nameColorModel) {
                case "RGB":
                    RGB pixelColorRGB = new RGB(pixelColor.R, pixelColor.G, pixelColor.B);
                    RGB pixelListColorsRGB = (RGB)listColorPalette[index];

                    differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorRGB.R, pixelListColorsRGB.R);
                    differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorRGB.G, pixelListColorsRGB.G);
                    differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorRGB.B, pixelListColorsRGB.B);
                    break;

                case "HSL":
                    HSL pixelColorHSL = ColorHelper.ColorConverter.RgbToHsl(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    HSL pixelListColorsHSL = (HSL)listColorPalette[index];

                    differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorHSL.H, pixelListColorsHSL.H);
                    differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorHSL.S, pixelListColorsHSL.S);
                    differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorHSL.L, pixelListColorsHSL.L);
                    break;

                case "HSV":
                    HSV pixelColorHSV = ColorHelper.ColorConverter.RgbToHsv(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    HSV pixelListColorsHSV = (HSV)listColorPalette[index];

                    differenceBetweenColorsIColor[0, index] = SubtractFromLargest(pixelColorHSV.H, pixelListColorsHSV.H);
                    differenceBetweenColorsIColor[1, index] = SubtractFromLargest(pixelColorHSV.S, pixelListColorsHSV.S);
                    differenceBetweenColorsIColor[2, index] = SubtractFromLargest(pixelColorHSV.V, pixelListColorsHSV.V);
                    break;

                case "XYZ":
                    XYZ pixelColorXYZ = ColorHelper.ColorConverter.RgbToXyz(new RGB(pixelColor.R, pixelColor.G, pixelColor.B));
                    XYZ pixelListColorsXYZ = (XYZ)listColorPalette[index];

                    differenceBetweenColorsIColor[0, index] = SubtractFromLargest((int)pixelColorXYZ.X, (int)pixelListColorsXYZ.X);
                    differenceBetweenColorsIColor[1, index] = SubtractFromLargest((int)pixelColorXYZ.Y, (int)pixelListColorsXYZ.Y);
                    differenceBetweenColorsIColor[2, index] = SubtractFromLargest((int)pixelColorXYZ.Z, (int)pixelListColorsXYZ.Z);
                    break;
            }
        }


        // Получить результат вычитания наименьшего числа из наибольшего числа
        private int SubtractFromLargest(int a, int b) {
            return Math.Abs(a - b);
        }
    }
}