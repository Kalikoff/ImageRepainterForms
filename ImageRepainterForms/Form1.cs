using System;
using System.Windows.Forms;

namespace ImageRepainterForms {
    public partial class Form1 : Form {
        private Logic logic;

        public Form1() {
            InitializeComponent();

            openFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Images";
            saveFileDialogImage.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Results";
            openFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";
            saveFileDialogPalette.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "Palette";

            logic = new Logic(this);
        }


        // Обработка изображения (поиск похожих цветов из палитры в выбранной цветовой модели)
        private void buttonProcessImageToMultiColorModel_Click(object sender, EventArgs e) {
            logic.ProcessImageToMultiColorModel();
        }


        // Загрузка изображения
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.LoadImage();
        }


        // Сохранение изображения
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.SaveProcessImage();
        }


        // Загрузка палитры цветов
        private void paletteOpenToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.LoadPalette();
        }


        // Сохранение палитры
        private void paletteSaveToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.SavePalette();
        }


        // Инверсия цветов изображения
        private void effectsInversionToolStripMenuItem_Click(object sender, EventArgs e) {
            logic.EffectInversion();
        }


        // Добавление нового цвета
        private void buttonAddColor_Click(object sender, EventArgs e) {
            logic.AddNewColorInCustomPalette();
        }


        // Включение/Выключение пользовательской палитры
        private void checkBoxUseCustomListColor_CheckedChanged(object sender, EventArgs e) {
            groupBoxListColors.Enabled = checkBoxUseCustomListColor.Checked;
            tableLayoutPanelPaletteByImage.Enabled = !checkBoxUseCustomListColor.Checked;
        }


        // Выбор создания палитры на основе картинки
        private void checkBoxPaletteByImage_CheckedChanged(object sender, EventArgs e) {
            tableLayoutPanelChunkSizes.Enabled = (sender as CheckBox).Checked;
            checkBoxUseCustomListColor.Enabled = !(sender as CheckBox).Checked;
        }
    }
}