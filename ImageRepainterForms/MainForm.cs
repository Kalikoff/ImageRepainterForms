using System;
using System.Windows.Forms;

namespace ImageRepainterForms {
    public partial class MainForm : Form {
        private Logic logic;

        public MainForm() {
            InitializeComponent();

            openFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Images";
            saveFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Results";
            openFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";
            saveFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";
            comboBoxColorModels.SelectedIndex = 0;

            logic = new Logic(this);
        }

        /// <summary>
        /// Обработка изображения (поиск похожих цветов из палитры в выбранной цветовой модели)
        /// </summary>
        private void buttonProcessImageToMultiColorModel_Click(object sender, EventArgs e) {
            logic.ProcessImageToSelectedColorModel();
        }

        /// <summary>
        /// Загрузка изображения
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.LoadImage();
        }

        /// <summary>
        /// Сохранение изображения
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.SaveProcessImage();
        }

        /// <summary>
        /// Загрузка палитры цветов
        /// </summary>
        private void paletteOpenToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.LoadPalette();
        }

        /// <summary>
        /// Сохранение палитры
        /// </summary>
        private void paletteSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.SavePalette();
        }

        /// <summary>
        /// Инверсия цветов изображения
        /// </summary>
        private void effectsInversionToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.EffectInversion();
        }

        /// <summary>
        /// Добавление нового цвета
        /// </summary>
        private void buttonAddColor_Click(object sender, EventArgs e) {
            logic.AddNewColorInCustomPalette();
        }

        /// <summary>
        /// Включение/Выключение пользовательской палитры
        /// </summary>
        private void checkBoxUseCustomPalette_CheckedChanged(object sender, EventArgs e) {
            groupBoxListColors.Enabled = checkBoxUseCustomPalette.Checked;
        }

        /// <summary>
        /// Выбор создания палитры на основе картинки
        /// </summary>
        private void checkBoxCreatePaletteByImage_CheckedChanged(object sender, EventArgs e) {
            tableLayoutPanelChunkSizes.Enabled = (sender as CheckBox).Checked;
            checkBoxUseCustomPalette.Enabled = !(sender as CheckBox).Checked;
        }

        /// <summary>
        /// Тик таймера для проверки завершения работы потока
        /// </summary>
        private void timerThreadIsAlive_Tick(object sender, EventArgs e) {
            logic.CheckThreadIsAlive();
        }

        /// <summary>
        /// Тик таймера обновление ProgressBar
        /// </summary>
        private void timerProgressBarUpdate_Tick(object sender, EventArgs e) {
            logic.UpdateProgressBar();
        }
    }
}