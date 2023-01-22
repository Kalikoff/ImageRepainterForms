using System.Drawing;

namespace ImageRepainterForms {
    class Effects {
        public Effects() {

        }


        // Эффект инверсии изображения
        public Bitmap ImageColorInversion(Bitmap sourceImage) {
            Bitmap changedImage = (Bitmap)sourceImage.Clone();

            for (int i = 0; i < changedImage.Height; i++) {
                for (int j = 0; j < changedImage.Width; j++) {
                    Color pixelColor = changedImage.GetPixel(j, i);
                    Color replaceableColor = Color.FromArgb(255, 255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                    changedImage.SetPixel(j, i, replaceableColor);
                }
            }
            return changedImage;
        }
    }
}
