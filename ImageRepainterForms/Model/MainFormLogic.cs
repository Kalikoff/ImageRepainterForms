using ImageRepainterForms.Model.StaticFields;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using ImageRepainterForms.View;
using System;
using System.IO;

namespace ImageRepainterForms.Model {
    /// <summary>
    /// Вся голика главной формы
    /// </summary>
    class MainFormLogic {
        private Checks checks; // Проверки
        private ImageProcessingInDifferentColorModels imageProcessingInDifferentColorModels; // Класс обработки изображения
        private Effects effects; // Эффекты
        private MainForm mainForm; // Главная форма
        private CustomPaletteForm customPaletteForm; // Форма выбора цветов палитры
        private ImageBasedPaletteForm imageBasedPaletteForm; // Форма настройки палитры на основе изображения

        private Bitmap _processedImage; // Обработанная картинка
        private Bitmap _palette; // Палитра

        private Thread _thread; // Поток обрабоки изображения

        public MainFormLogic(MainForm mainForm) {
            this.mainForm = mainForm;

            checks = new Checks();
            imageProcessingInDifferentColorModels = new ImageProcessingInDifferentColorModels();
            effects = new Effects();
        }

        /// <summary>
        /// Установить пути по умолчанию для диалогов
        /// </summary>
        public void SetPaths() {
            string imagesPath = AppDomain.CurrentDomain.BaseDirectory + "Images";
            string resultsPath = AppDomain.CurrentDomain.BaseDirectory + "Results";
            string palettePath = AppDomain.CurrentDomain.BaseDirectory + "Palette";

            CreateDirectoryIfDoesntExist(imagesPath);
            CreateDirectoryIfDoesntExist(resultsPath);
            CreateDirectoryIfDoesntExist(palettePath);

            mainForm.openFileDialogImage.InitialDirectory = imagesPath;
            mainForm.saveFileDialogImage.InitialDirectory = resultsPath;
            mainForm.openFileDialogPalette.InitialDirectory = palettePath;
            mainForm.saveFileDialogPalette.InitialDirectory = palettePath;
        }

        /// <summary>
        /// Вставка изображения пользователем из буфера обмена
        /// </summary>
        /// <param name="e"></param>
        public void PasteImageFromClipboard(KeyEventArgs e) {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control) {
                if (checks.CheckingIsImageOnTheClipboard()) {
                    return;
                }

                Bitmap imageСlipboard = (Bitmap)Clipboard.GetImage();
                SourceImage.s_sourceImage = (Bitmap)imageСlipboard.Clone();
                SetImageToPictureBox(imageСlipboard);
            }
        }

        /// <summary>
        /// Запуск обработки изображения в потоке
        /// </summary>
        public void ProcessImageToSelectedColorModel() {
            if (checks.CheckingIsEmptyUploadedImage(SourceImage.s_sourceImage) ||
                checks.CheckingListColorForEmptiness(Properties.Resources.infoAddColorsForProcessing) ||
                checks.CheckingComboBoxForExistenceSelectedColorModel(mainForm.comboBoxColorModels)) {
                return;
            }

            if (_thread != null) {
                _thread.Abort();
            }

            _thread = new Thread(ProcessSourceImage);
            _thread.Start();

            mainForm.timerThreadIsAlive.Start();
            mainForm.timerProgressBarUpdate.Start();
        }

        /// <summary>
        /// Загрузка изображения из меню
        /// </summary>
        public void LoadImage() {
            if (mainForm.openFileDialogImage.ShowDialog() == DialogResult.OK) {
                SourceImage.s_sourceImage = new Bitmap(mainForm.openFileDialogImage.FileName);
                SetImageToPictureBox(SourceImage.s_sourceImage);
            }
        }

        /// <summary>
        /// Сохранение изображения из меню
        /// </summary>
        public void SaveProcessImage() {
            if (checks.CheckingIsEmptyСhangedImageToSave(_processedImage)) {
                return;
            }

            if (mainForm.saveFileDialogImage.ShowDialog() == DialogResult.OK) {
                _processedImage.Save(mainForm.saveFileDialogImage.FileName, ImageFormat.Png);
            }
        }

        /// <summary>
        /// Загрузка палитры цветов из меню
        /// </summary>
        public void LoadPaletteFromFile() {
            if (mainForm.openFileDialogPalette.ShowDialog() == DialogResult.OK) {
                _palette = new Bitmap(mainForm.openFileDialogPalette.FileName);
                ListColor.AddColorsFromPaletteToListColor(_palette);
            }
        }

        /// <summary>
        /// Отобразить форму Настраиваемой палитры
        /// </summary>
        public void CustomPalette() {
            if (customPaletteForm == null || customPaletteForm.IsDisposed) {
                customPaletteForm = new CustomPaletteForm();
            }

            customPaletteForm.Show();
        }

        /// <summary>
        /// Отобразить форму Палитра на основе картинки
        /// </summary>
        public void ImageBasedPalette() {
            if (checks.CheckingIsEmptyUploadedImage(SourceImage.s_sourceImage)) {
                return;
            }

            if (imageBasedPaletteForm == null || imageBasedPaletteForm.IsDisposed) {
                imageBasedPaletteForm = new ImageBasedPaletteForm();
            }

            imageBasedPaletteForm.Show();
        }

        /// <summary>
        /// Сохранение палитры из меню
        /// </summary>
        public void SavePalette() {
            if (checks.CheckingListColorForEmptiness(Properties.Resources.infoAddColorsToSavePalette)) {
                return;
            }

            int paletteWidth = ListColor.s_ListColor.Count;
            Bitmap bitmap = new Bitmap(paletteWidth, 1);

            for (int i = 0; i < paletteWidth; i++) {
                bitmap.SetPixel(i, 0, ListColor.s_ListColor[i]);
            }

            if (mainForm.saveFileDialogPalette.ShowDialog() == DialogResult.OK) {
                bitmap.Save(mainForm.saveFileDialogPalette.FileName, ImageFormat.Png);
            }
        }

        /// <summary>
        /// Инверсия цветов изображения из меню
        /// </summary>
        public void EffectInversion() {
            if (checks.CheckingIsEmptyUploadedImage(SourceImage.s_sourceImage)) {
                return;
            }

            _processedImage = effects.ImageColorInversion(SourceImage.s_sourceImage);

            SetImageToPictureBox(_processedImage);
        }

        /// <summary>
        /// Отображение информации о приложении
        /// </summary>
        public void ShowApplicationInfo() {
            MessageBox.Show(Properties.Resources.textGetInfo,
                Properties.Resources.captionApplicationHelp,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Проверка состояния потока
        /// </summary>
        public void CheckThreadIsAlive() {
            if (!_thread.IsAlive) {
                mainForm.timerThreadIsAlive.Stop();
                mainForm.timerProgressBarUpdate.Stop();
                mainForm.buttonProcessImage.Enabled = true;
                mainForm.progressBarImageProcessing.Value = 0;

                MessageBox.Show(Properties.Resources.infoImageFinishedProcessing,
                    Properties.Resources.captionSuccess,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Обновление значения ProgressBar
        /// </summary>
        public void UpdateProgressBar() {
            int max = imageProcessingInDifferentColorModels.GetPercentageOfProcessedPixels();

            if (mainForm.progressBarImageProcessing.Value < max) {
                mainForm.progressBarImageProcessing.Value = max;
            }

            if (mainForm.progressBarImageProcessing.Value == mainForm.progressBarImageProcessing.Maximum) {
                mainForm.progressBarImageProcessing.Value = 0;
            }
        }

        /// <summary>
        /// Обработать изображение (поиск похожих цветов из палитры в выбранной цветовой модели)
        /// </summary>
        private void ProcessSourceImage() {
            mainForm.buttonProcessImage.Enabled = false;

            _processedImage = imageProcessingInDifferentColorModels.ProcessImageInSelectedColorModel(
                    mainForm.comboBoxColorModels.SelectedItem.ToString());

            SetImageToPictureBox(_processedImage);
        }

        /// <summary>
        /// Отображать изображение на форме
        /// </summary>
        /// <param name="bitmap"></param>
        private void SetImageToPictureBox(Bitmap bitmap) {
            mainForm.pictureBoxPreview.Image = new Bitmap(bitmap);
        }

        /// <summary>
        /// Создать каталог, если он не существует
        /// </summary>
        /// <param name="path">Путь к каталогу</param>
        private void CreateDirectoryIfDoesntExist(string path) {
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
        }
    }
}