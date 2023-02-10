using System.Drawing;

namespace ImageRepainterForms.Model {
    /// <summary>
    /// Эффекты над изображением
    /// </summary>
    class Effects {
        /// <summary>
        /// Инверсия изображения
        /// </summary>
        /// <param name="sourceImage"></param>
        /// <returns>Обработанное изображение</returns>
        public Bitmap ImageColorInversion(Bitmap sourceImage) {
            Bitmap processedImage = (Bitmap)sourceImage.Clone();

            for (int i = 0; i < processedImage.Height; i++) {
                for (int j = 0; j < processedImage.Width; j++) {
                    Color pixelColor = processedImage.GetPixel(j, i);
                    Color replaceableColor = Color.FromArgb(255, 255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                    processedImage.SetPixel(j, i, replaceableColor);
                }
            }

            return processedImage;
        }
    }
}
