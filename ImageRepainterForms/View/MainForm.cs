using ImageRepainterForms.Model;
using System;
using System.Windows.Forms;

namespace ImageRepainterForms.View {
    public partial class MainForm : Form {
        private MainFormLogic mainFormLogic;

        public MainForm() {
            InitializeComponent();

            openFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Images";
            saveFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Results";
            openFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";
            saveFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";
            comboBoxColorModels.SelectedIndex = 0;

            mainFormLogic = new MainFormLogic(this);
        }

        /// <summary>
        /// Вставка изображения пользователем из буфера обмена
        /// </summary>
        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            mainFormLogic.PasteImageFromClipboard(e);
        }

        /// <summary>
        /// Обработка изображения (поиск похожих цветов из палитры в выбранной цветовой модели)
        /// </summary>
        private void buttonProcessImageToMultiColorModel_Click(object sender, EventArgs e) {
            mainFormLogic.ProcessImageToSelectedColorModel();
        }

        /// <summary>
        /// Загрузка изображения
        /// </summary>
        private void imageLoadToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.LoadImage();
        }

        /// <summary>
        /// Сохранение изображения
        /// </summary>
        private void imageSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.SaveProcessImage();
        }

        /// <summary>
        /// Загрузка палитры из файлов
        /// </summary>
        private void paletteLoadFromFileToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.LoadPaletteFromFile();
        }

        /// <summary>
        /// Создание палитры пользователем
        /// </summary>
        private void paletteSettingToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.CustomPalette();
        }

        /// <summary>
        /// Создание палитры на основе изображения
        /// </summary>
        private void paletteImageBasedToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.ImageBasedPalette();
        }

        /// <summary>
        /// Сохранение палитры
        /// </summary>
        private void paletteSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.SavePalette();
        }

        /// <summary>
        /// Инверсия цветов изображения
        /// </summary>
        private void effectsInversionToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.EffectInversion();
        }

        /// <summary>
        /// Справка по приложению
        /// </summary>
        private void getInfoToolStripMenuItem_Click(object sender, EventArgs e) {
            mainFormLogic.ShowApplicationInfo();
        }

        /// <summary>
        /// Тик таймера для проверки завершения потока
        /// </summary>
        private void timerThreadIsAlive_Tick(object sender, EventArgs e) {
            mainFormLogic.CheckThreadIsAlive();
        }

        /// <summary>
        /// Тик таймера (обновление ProgressBar)
        /// </summary>
        private void timerProgressBarUpdate_Tick(object sender, EventArgs e) {
            mainFormLogic.UpdateProgressBar();
        }
    }
}