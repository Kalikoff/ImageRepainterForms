using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms {
    class Checks {
        /// <summary>
        /// Проверка пустое ли исходное изображение для обработки
        /// </summary>
        /// <param name="sourceImage">Исходное изображение</param>
        /// <returns></returns>
        public bool CheckingIsEmptyUploadedImage(Bitmap sourceImage) {
            if (sourceImage == null) {
                MessageBox.Show(Properties.Resources.infoEmptyUploadedImage);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка пустое ли обработанное изображение
        /// </summary>
        /// <param name="changedImage">Обработанное изображение</param>
        /// <returns></returns>
        public bool CheckingIsEmptyСhangedImageToSave(Bitmap changedImage) {
            if (changedImage == null) {
                MessageBox.Show(Properties.Resources.infoEmptyImageToSave);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка пустое ли изображение палитры
        /// </summary>
        /// <param name="palette">Палитра</param>
        /// <param name="message">Сообщение об ошибке</param>
        /// <returns></returns>
        public bool CheckingIsEmptyPaletteImage(Bitmap palette, string message) {
            if (palette == null) {
                MessageBox.Show(message);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка количетства пользовательских цветов
        /// </summary>
        /// <param name="countColors">Количетсво цветов в Настраиваемой палитре</param>
        /// <returns></returns>
        public bool CheckingAmountCustomColors(int countColors) {
            if (countColors <= 0) {
                MessageBox.Show(Properties.Resources.infoAddColorsToReplace);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка listPictureBoxs на пустоту
        /// </summary>
        /// <param name="listPictureBoxs"></param>
        /// <returns></returns>
        public bool CheckingListPictureBoxsForEmptiness(List<PictureBox> listPictureBoxs) {
            if (listPictureBoxs == null || listPictureBoxs.Count <= 0) {
                MessageBox.Show(Properties.Resources.infoAddColors);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка ComboBox на существование выбранной цветовой модели
        /// </summary>
        /// <param name="comboBoxColorModels"></param>
        /// <returns></returns>
        public bool CheckingComboBoxForExistenceSelectedColorModel(ComboBox comboBoxColorModels) {
            if (comboBoxColorModels.SelectedIndex < 0) {
                MessageBox.Show(Properties.Resources.infoChooseRightColorModel);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка загрузка палитры из файла при включенной Палитра на основе картинки
        /// </summary>
        /// <param name="checkBoxPaletteByImage"></param>
        /// <returns></returns>
        public bool CheckingCanLoadPaletteFromFile(CheckBox checkBoxPaletteByImage) {
            if (checkBoxPaletteByImage.Checked) {
                MessageBox.Show(Properties.Resources.infoTurnOffImageBasedPalette);
                return true;
            }

            return false;
        }
    }
}
