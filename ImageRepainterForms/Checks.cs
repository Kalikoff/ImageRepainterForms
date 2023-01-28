using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms {
    class Checks {
        // Проверка пустое ли изображение для обработки
        public bool CheckingIsEmptyUploadedImage(Bitmap sourceImage) {
            if (sourceImage == null) {
                MessageBox.Show(Properties.Resources.infoEmptyUploadedImage);
                return true;
            }

            return false;
        }


        // Проверка пустое ли обработанное изображение
        public bool CheckingIsEmptyImageToSave(Bitmap changedImage) {
            if (changedImage == null) {
                MessageBox.Show(Properties.Resources.infoEmptyImageToSave);
                return true;
            }

            return false;
        }


        // Проверка пустое ли изображение палитры
        public bool CheckingIsEmptyPaletteImage(Bitmap palette, string message) {
            if (palette == null) {
                MessageBox.Show(message);
                return true;
            }

            return false;
        }


        // Проверка количетства пользовательских цветов
        public bool CheckingAmountCustomColors(int countColors) {
            if (countColors <= 0) {
                MessageBox.Show(Properties.Resources.infoAddColorsToReplace);
                return true;
            }

            return false;
        }


        // Проверка listPictureBoxs на пустоту
        public bool CheckingListPictureBoxsForEmptiness(List<PictureBox> listPictureBoxs) {
            if (listPictureBoxs == null || listPictureBoxs.Count <= 0) {
                MessageBox.Show(Properties.Resources.infoAddColors);
                return true;
            }

            return false;
        }


        // Проверка ComboBox на существующие цветовые модели
        public bool CheckingComboBoxForErrors(ComboBox comboBoxColorModels) {
            if (comboBoxColorModels.SelectedIndex < 0) {
                MessageBox.Show(Properties.Resources.infoChooseRightColorModel);
                return true;
            }

            return false;
        }


        // Проверка загрузка палитры из файла при включенной Палитра на основе картинки
        public bool CheckingCanLoadPaletteFromFile(CheckBox checkBoxPaletteByImage) {
            if (checkBoxPaletteByImage.Checked) {
                MessageBox.Show(Properties.Resources.infoTurnOffImageBasedPalette);
                return true;
            }

            return false;
        }
    }
}
