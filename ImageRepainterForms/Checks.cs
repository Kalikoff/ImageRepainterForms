using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms {
    class Checks {
        public Checks() {

        }


        // Проверка пустое ли изображение для обработки
        public bool CheckingIsEmptyUploadedImage(Bitmap sourceImage) {
            if (sourceImage == null) {
                MessageBox.Show("Загрузите изображение!");
                return true;
            }

            return false;
        }


        // Проверка пустое ли обработанное изображение
        public bool CheckingIsEmptyImageToSave(Bitmap changedImage) {
            if (changedImage == null) {
                MessageBox.Show("Вы не обработали изображение!");
                return true;
            }

            return false;
        }


        // Проверка пустое ли изображение палитры
        public bool CheckingIsEmptyPaletteImage(Bitmap palette) {
            if (palette == null) {
                MessageBox.Show("Вы не загрузили палитру!");
                return true;
            }

            return false;
        }

        // Проверка количетства пользовательских цветов
        public bool CheckingAmountCustomColors(int countColors) {
            if (countColors <= 0) {
                MessageBox.Show("Добавьте цвета для замены!");
                return true;
            }

            return false;
        }

        // Проверка listPictureBoxs на пустоту
        public bool CheckingListPictureBoxsForEmptiness(List<PictureBox> listPictureBoxs) {
            if (listPictureBoxs == null || listPictureBoxs.Count <= 0) {
                MessageBox.Show("Добавьте цвета!");
                return true;
            }

            return false;
        }
    }
}
