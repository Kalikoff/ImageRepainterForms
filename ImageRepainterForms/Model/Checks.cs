using ImageRepainterForms.Model.StaticFields;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms.Model {
    /// <summary>
    /// Класс со всеми проверками и вызовами окон с ошибками
    /// </summary>
    class Checks {
        /// <summary>
        /// Проверка является ли исходное изображение пустым для обработки
        /// </summary>
        /// <param name="sourceImage">Исходное изображение</param>
        /// <returns></returns>
        public bool CheckingIsEmptyUploadedImage(Bitmap sourceImage) {
            if (sourceImage == null) {
                MessageBox.Show(Properties.Resources.infoUploadSourceImage,
                    Properties.Resources.captionEror,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка является ли обработанное изображение пустым
        /// </summary>
        /// <param name="changedImage">Обработанное изображение</param>
        /// <returns></returns>
        public bool CheckingIsEmptyСhangedImageToSave(Bitmap changedImage) {
            if (changedImage == null) {
                MessageBox.Show(Properties.Resources.infoEmptyImageToSave,
                    Properties.Resources.captionEror,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка количества цветов в палитре
        /// </summary>
        /// <returns></returns>
        public bool CheckingListColorForEmptiness(string message) {
            if (ListColor.s_ListColor == null || ListColor.s_ListColor.Count <= 0) {
                MessageBox.Show(message,
                    Properties.Resources.captionEror,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка существования выбранной цветовой модели
        /// </summary>
        /// <param name="comboBoxColorModels"></param>
        /// <returns></returns>
        public bool CheckingComboBoxForExistenceSelectedColorModel(ComboBox comboBoxColorModels) {
            if (comboBoxColorModels.SelectedIndex < 0) {
                MessageBox.Show(Properties.Resources.infoChooseRightColorModel,
                    Properties.Resources.captionEror,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Проверка наличия изображения в буфере обмена
        /// </summary>
        /// <returns></returns>
        public bool CheckingIsImageOnTheClipboard() {
            if (!Clipboard.ContainsImage()) {
                MessageBox.Show(Properties.Resources.infoNoImageOnClipboard,
                    Properties.Resources.captionEror,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            return false;
        }
    }
}