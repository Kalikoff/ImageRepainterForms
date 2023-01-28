using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace ImageRepainterForms {
    class Logic {
        private Form1 mainForm;

        private Checks checks;
        private MultiColorModelProcessImage multiColorModelProcessImage;
        private Effects effects;

        private int _countColors = 0; // Количество цветов
        private int _indexElement = 0; // 

        private List<Color> _listColorsPalette; // Лист цветов из палитры
        private List<PictureBox> _listPictureBoxs; // Лист PictureBox
        private List<Button> _listButtons; // Лист Button

        private Bitmap _sourceImage; // Загруженная картинка
        private Bitmap _changedImage; // Обработанная картинка
        private Bitmap _palette; // Палитра

        public Logic(Form1 form1) {
            mainForm = form1;

            checks = new Checks();
            multiColorModelProcessImage = new MultiColorModelProcessImage();
            effects = new Effects();
        }

        /// <summary>
        /// Обработка изображения (поиск похожих цветов из палитры в выбранной цветовой модели)
        /// </summary>
        public void ProcessImageToMultiColorModel() {
            if (checks.CheckingIsEmptyUploadedImage(_sourceImage)) { // Проверка пустое ли изображение
                return;
            }

            if (mainForm.checkBoxUseCustomListColor.Checked && checks.CheckingAmountCustomColors(_countColors)) { // Проверка количество своих цветов
                return;
            }

            if (mainForm.checkBoxPaletteByImage.Checked) { // Проверка включена ли создание палитры на основе картинки
                CreatePaletteByImage();
            }

            if (!mainForm.checkBoxUseCustomListColor.Checked && checks.CheckingIsEmptyPaletteImage(_palette, Properties.Resources.infoPaletteNotUploaded)) { // Проверка загружена ли палитра
                return;
            }

            if (checks.CheckingComboBoxForErrors(mainForm.comboBoxColorModels)) { // Проверка ComboBox на существующие цветовые модели
                return;
            }

            GetListColors();

            string selectColorModel = mainForm.comboBoxColorModels.SelectedItem.ToString();
            _changedImage = multiColorModelProcessImage.ProcessImageToMultiColorModel(_listColorsPalette, _sourceImage, selectColorModel);

            SetImageToPictureBox(_changedImage);
        }


        /// <summary>
        /// Загрузка изображения из меню
        /// </summary>
        public void LoadImage() {
            if (mainForm.openFileDialogImage.ShowDialog() == DialogResult.OK) {
                _sourceImage = new Bitmap(mainForm.openFileDialogImage.FileName);
                SetImageToPictureBox(_sourceImage);
            }
        }


        /// <summary>
        /// Сохранение изображения из меню
        /// </summary>
        public void SaveProcessImage() {
            if (checks.CheckingIsEmptyImageToSave(_changedImage)) {
                return;
            }

            if (mainForm.saveFileDialogImage.ShowDialog() == DialogResult.OK) {
                _changedImage.Save(mainForm.saveFileDialogImage.FileName, ImageFormat.Png);
            }
        }


        /// <summary>
        /// Загрузка палитры цветов из меню
        /// </summary>
        public void LoadPalette() {
            if (checks.CheckingCanLoadPaletteFromFile(mainForm.checkBoxPaletteByImage)) {
                return;
            }

            if (mainForm.openFileDialogPalette.ShowDialog() == DialogResult.OK) {
                _palette = new Bitmap(mainForm.openFileDialogPalette.FileName);
            }
        }


        /// <summary>
        /// Сохранение палитры из меню
        /// </summary>
        public void SavePalette() {
            if (checks.CheckingIsEmptyPaletteImage(_palette, Properties.Resources.infoPaletteNotCreated)) {
                return;
            }

            if (mainForm.checkBoxUseCustomListColor.Checked) {
                GetListPictureBoxs();

                if (checks.CheckingListPictureBoxsForEmptiness(_listPictureBoxs)) {
                    return;
                }

                CreatePaletteFromPictureBox();
            }
            else if (mainForm.checkBoxPaletteByImage.Checked) {
                if (mainForm.saveFileDialogPalette.ShowDialog() == DialogResult.OK) {
                    _palette.Save(mainForm.saveFileDialogPalette.FileName, ImageFormat.Png);
                }
            }
        }


        /// <summary>
        /// Инверсия цветов изображения из меню
        /// </summary>
        public void EffectInversion() {
            if (checks.CheckingIsEmptyUploadedImage(_sourceImage)) {
                return;
            }

            _changedImage = effects.ImageColorInversion(_sourceImage);

            SetImageToPictureBox(_changedImage);
        }


        /// <summary>
        /// Добавление нового цвета
        /// </summary>
        public void AddNewColorInCustomPalette() {
            PictureBox pictureBox = new PictureBox {
                BackColor = Color.White,
                Size = new Size(32, 32),
                Anchor = AnchorStyles.None,
                Tag = _indexElement
            };
            pictureBox.Click += pictureBoxSelectColorOnClick;
            mainForm.flowLayoutPanelCustomListColor.Controls.Add(pictureBox);

            Button button = new Button {
                Size = new Size(75, 23),
                Text = Properties.Resources.textDelete,
                Anchor = AnchorStyles.None,
                Tag = _indexElement
            };
            button.Click += buttonDeleteColorOnClick;
            mainForm.flowLayoutPanelCustomListColor.Controls.Add(button);

            int index = 2 + (_countColors * 2);
            mainForm.flowLayoutPanelCustomListColor.SuspendLayout();
            List<Control> list = new List<Control>(mainForm.flowLayoutPanelCustomListColor.Controls.OfType<Control>());
            list.Remove(mainForm.buttonAddColor);
            list.Insert(index, mainForm.buttonAddColor);
            mainForm.flowLayoutPanelCustomListColor.Controls.Clear();
            mainForm.flowLayoutPanelCustomListColor.Controls.AddRange(list.ToArray());
            mainForm.flowLayoutPanelCustomListColor.ResumeLayout();

            _countColors++;
            _indexElement++;
        }


        /// <summary>
        /// Выбор цвета в Списке цветов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxSelectColorOnClick(object sender, EventArgs e) {
            if (mainForm.colorDialogSelectionPictureBox.ShowDialog() == DialogResult.OK) {
                (sender as PictureBox).BackColor = mainForm.colorDialogSelectionPictureBox.Color;
            }
        }


        /// <summary>
        /// Удаление цвета в Списке цветов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteColorOnClick(object sender, EventArgs e) {
            int tag = (int)(sender as Button).Tag;

            GetListPictureBoxs();

            GetListButtons();

            foreach (PictureBox pictureBox in _listPictureBoxs) {
                if ((int)pictureBox.Tag == tag) {
                    mainForm.flowLayoutPanelCustomListColor.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    break;
                }
            }

            foreach (Button button in _listButtons) {
                if ((int)button.Tag == tag) {
                    mainForm.flowLayoutPanelCustomListColor.Controls.Remove(button);
                    button.Dispose();
                    break;
                }
            }

            _countColors--;
        }


        /// <summary>
        /// Получить список цветов для палитры
        /// </summary>
        private void GetListColors() {
            if (mainForm.checkBoxUseCustomListColor.Checked) {
                _listColorsPalette = GetListColorsFromPictureBox();
            }
            else {
                _listColorsPalette = GetListColorsFromSelectedPalette();
            }
        }


        /// <summary>
        /// Получить список цветов из PictureBox
        /// </summary>
        /// <returns></returns>
        private List<Color> GetListColorsFromPictureBox() {
            List<Color> listColors = new List<Color>();

            GetListPictureBoxs();

            foreach (PictureBox pictureBox in _listPictureBoxs) {
                listColors.Add(pictureBox.BackColor);
            }

            return listColors;
        }


        /// <summary>
        /// Получить список цветов из палитры
        /// </summary>
        /// <returns></returns>
        private List<Color> GetListColorsFromSelectedPalette() {
            List<Color> listColors = new List<Color>();

            int width = _palette.Width;

            for (int i = 0; i < width; i++) {
                listColors.Add(_palette.GetPixel(i, 0));
            }

            return listColors;
        }


        /// <summary>
        /// Получить список всех PictureBox
        /// </summary>
        private void GetListPictureBoxs() {
            _listPictureBoxs = new List<PictureBox>();

            foreach (PictureBox control in mainForm.flowLayoutPanelCustomListColor.Controls.OfType<PictureBox>()) {
                _listPictureBoxs.Add(control);
            }
        }


        /// <summary>
        /// Получить список всех Button
        /// </summary>
        private void GetListButtons() {
            _listButtons = new List<Button>();

            foreach (Button control in mainForm.flowLayoutPanelCustomListColor.Controls.OfType<Button>()) {
                _listButtons.Add(control);
            }
        }


        /// <summary>
        /// Установка изображения из Bitmap
        /// </summary>
        /// <param name="bitmap"></param>
        private void SetImageToPictureBox(Bitmap bitmap) {
            mainForm.pictureBoxPreview.Image = new Bitmap(bitmap);
        }


        /// <summary>
        /// Создание палитры на основе картинки
        /// </summary>
        private void CreatePaletteByImage() {
            int amountChunksInWidht = Convert.ToInt32(mainForm.numericUpDownChunkWidth.Text);
            int amountChunksInHeight = Convert.ToInt32(mainForm.numericUpDownChunkHeight.Text);
            int widhtInChunk = _sourceImage.Width / amountChunksInWidht;
            int heightInChunk = _sourceImage.Height / amountChunksInHeight;

            // Масштабирование картинки
            //sourceImage = new Bitmap(sourceImage, new Size(amountChunksInWidht * widhtInChunk, amountChunksInHeight * heightInChunk));

            int paletteLength = amountChunksInWidht * amountChunksInHeight;

            Bitmap bitmap = new Bitmap(paletteLength, 1); // Палитры

            int colorPosX = 0;

            for (int i = 0; i < amountChunksInHeight; i++) {
                for (int j = 0; j < amountChunksInWidht; j++) {
                    Color color = GetAvgColorFromChunk(widhtInChunk, heightInChunk, j, i);

                    if (CheckingColorMatchingInList(color, bitmap, colorPosX)) {
                        bitmap.SetPixel(colorPosX, 0, color);
                        colorPosX++;
                    }
                }
            }

            _palette = new Bitmap(colorPosX, 1);

            for (int i = 0; i < colorPosX; i++) {
                _palette.SetPixel(i, 0, bitmap.GetPixel(i, 0));
            }
        }


        /// <summary>
        /// Получение среднего цвета из чанка
        /// </summary>
        /// <param name="widhtInChunk"></param>
        /// <param name="heightInChunk"></param>
        /// <param name="currentChunkX"></param>
        /// <param name="currentChunkY"></param>
        /// <returns></returns>
        private Color GetAvgColorFromChunk(int widhtInChunk, int heightInChunk, int currentChunkX, int currentChunkY) {
            Color avgColor = Color.White;
            int[] avgColorRGB = { 0, 0, 0 };

            for (int i = 0; i < heightInChunk; i++) {
                for (int j = 0; j < widhtInChunk; j++) {
                    int x = (currentChunkX * widhtInChunk) + j;
                    int y = (currentChunkY * heightInChunk) + i;

                    Color color = _sourceImage.GetPixel(x, y);
                    avgColorRGB[0] += color.R;
                    avgColorRGB[1] += color.G;
                    avgColorRGB[2] += color.B;
                }
            }

            avgColorRGB[0] /= widhtInChunk * heightInChunk;
            avgColorRGB[1] /= widhtInChunk * heightInChunk;
            avgColorRGB[2] /= widhtInChunk * heightInChunk;

            avgColor = Color.FromArgb(255, avgColorRGB[0], avgColorRGB[1], avgColorRGB[2]);

            return avgColor;
        }


        /// <summary>
        /// Проверка на добавление цвета в List, если его ещё там нету
        /// </summary>
        /// <param name="color"></param>
        /// <param name="bitmap"></param>
        /// <param name="colorPosX"></param>
        /// <returns></returns>
        private bool CheckingColorMatchingInList(Color color, Bitmap bitmap, int colorPosX) {
            bool flag = true;

            for (int i = 0; i < colorPosX; i++) {
                Color getColor = bitmap.GetPixel(i, 0);

                if (color == getColor) {
                    flag = false;
                }
            }

            return flag;
        }


        /// <summary>
        /// Создание палитры из Своих цветов
        /// </summary>
        private void CreatePaletteFromPictureBox() {
            int width = _listPictureBoxs.Count;

            Bitmap bitmap = new Bitmap(width, 1);

            for (int x = 0; x < width; x++) {
                Color color = _listPictureBoxs[x].BackColor;

                bitmap.SetPixel(x, 0, color);
            }

            if (mainForm.saveFileDialogPalette.ShowDialog() == DialogResult.OK) {
                bitmap.Save(mainForm.saveFileDialogPalette.FileName, ImageFormat.Png);
            }
        }
    }
}
