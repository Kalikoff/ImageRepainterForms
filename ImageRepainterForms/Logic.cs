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

        private int countColors = 0;
        private int indexElement = 0;

        private List<Color> listColorsPalette; // Лист цветов из палитры
        private List<PictureBox> listPictureBoxs; // Лист PictureBox
        private List<Button> listButtons; // Лист Button

        private Bitmap sourceImage; // Загруженная картинка
        private Bitmap changedImage; // Обработанная картинка
        private Bitmap palette; // Палитра

        public Logic(Form1 form1) {
            mainForm = form1;

            checks = new Checks();
            multiColorModelProcessImage = new MultiColorModelProcessImage();
            effects = new Effects();
        }

        // Обработка изображения (поиск похожих цветов из палитры в выбранной цветовой модели)
        public void ProcessImageToMultiColorModel() {
            if (checks.CheckingIsEmptyUploadedImage(sourceImage)) { // Проверка пустое ли изображение
                return;
            }

            if (mainForm.checkBoxUseCustomListColor.Checked && checks.CheckingAmountCustomColors(countColors)) { // Проверка количество своих цветов
                return;
            }

            if (mainForm.checkBoxPaletteByImage.Checked) { // Проверка включена ли создание палитры на основе картинки
                CreatePaletteByImage();
            }

            if (!mainForm.checkBoxUseCustomListColor.Checked && checks.CheckingIsEmptyPaletteImage(palette)) { // Проверка загружена ли палитра
                return;
            }

            GetListColors();

            string selectColorModel = mainForm.comboBoxColorModels.SelectedItem.ToString();
            changedImage = multiColorModelProcessImage.ProcessImageToMultiColorModel(listColorsPalette, sourceImage, selectColorModel);

            SetImageToPictureBox(changedImage);
        }


        // Загрузка изображения
        public void LoadImage() {
            if (mainForm.openFileDialogImage.ShowDialog() == DialogResult.OK) {
                sourceImage = new Bitmap(mainForm.openFileDialogImage.FileName);
                SetImageToPictureBox(sourceImage);
            }
        }


        // Сохранение изображения
        public void SaveProcessImage() {
            if (checks.CheckingIsEmptyImageToSave(changedImage)) {
                return;
            }

            if (mainForm.saveFileDialogImage.ShowDialog() == DialogResult.OK) {
                changedImage.Save(mainForm.saveFileDialogImage.FileName, ImageFormat.Png);
            }
        }


        // Загрузка палитры цветов
        public void LoadPalette() {
            if (mainForm.openFileDialogPalette.ShowDialog() == DialogResult.OK) {
                palette = new Bitmap(mainForm.openFileDialogPalette.FileName);
            }
        }


        // Сохранение палитры
        public void SavePalette() {
            if (mainForm.checkBoxUseCustomListColor.Checked) {
                GetListPictureBoxs();

                if (checks.CheckingListPictureBoxsForEmptiness(listPictureBoxs)) {
                    return;
                }

                CreatePaletteFromPictureBox();
            }
            else if (mainForm.checkBoxPaletteByImage.Checked) {
                if (mainForm.saveFileDialogPalette.ShowDialog() == DialogResult.OK) {
                    palette.Save(mainForm.saveFileDialogPalette.FileName, ImageFormat.Png);
                }
            }
        }


        // Инверсия цветов изображения
        public void EffectInversion() {
            if (checks.CheckingIsEmptyUploadedImage(sourceImage)) {
                return;
            }

            changedImage = effects.ImageColorInversion(sourceImage);

            SetImageToPictureBox(changedImage);
        }


        // Добавление нового цвета
        public void AddNewColorInCustomPalette() {
            PictureBox pictureBox = new PictureBox {
                BackColor = Color.White,
                Size = new Size(32, 32),
                Anchor = AnchorStyles.None,
                Tag = indexElement
            };
            pictureBox.Click += pictureBoxSelectColorOnClick;
            mainForm.flowLayoutPanel1.Controls.Add(pictureBox);

            Button button = new Button {
                Size = new Size(75, 23),
                Text = "Удалить",
                Anchor = AnchorStyles.None,
                Tag = indexElement
            };
            button.Click += buttonDeleteColorOnClick;
            mainForm.flowLayoutPanel1.Controls.Add(button);

            int index = 2 + (countColors * 2);
            mainForm.flowLayoutPanel1.SuspendLayout();
            List<Control> list = new List<Control>(mainForm.flowLayoutPanel1.Controls.OfType<Control>());
            list.Remove(mainForm.buttonAddColor);
            list.Insert(index, mainForm.buttonAddColor);
            mainForm.flowLayoutPanel1.Controls.Clear();
            mainForm.flowLayoutPanel1.Controls.AddRange(list.ToArray());
            mainForm.flowLayoutPanel1.ResumeLayout();

            countColors++;
            indexElement++;
        }


        // Выбор цвета
        private void pictureBoxSelectColorOnClick(object sender, EventArgs e) {
            if (mainForm.colorDialogSelectionPictureBox.ShowDialog() == DialogResult.OK) {
                (sender as PictureBox).BackColor = mainForm.colorDialogSelectionPictureBox.Color;
            }
        }


        // Удаление цвета
        private void buttonDeleteColorOnClick(object sender, EventArgs e) {
            int tag = (int)(sender as Button).Tag;

            GetListPictureBoxs();

            GetListButtons();

            foreach (PictureBox pictureBox in listPictureBoxs) {
                if ((int)pictureBox.Tag == tag) {
                    mainForm.flowLayoutPanel1.Controls.Remove(pictureBox);
                    pictureBox.Dispose();
                    break;
                }
            }

            foreach (Button button in listButtons) {
                if ((int)button.Tag == tag) {
                    mainForm.flowLayoutPanel1.Controls.Remove(button);
                    button.Dispose();
                    break;
                }
            }

            countColors--;
        }


        // Получить список цветов
        private void GetListColors() {
            if (mainForm.checkBoxUseCustomListColor.Checked) {
                listColorsPalette = GetListColorsFromPictureBox();
            }
            else {
                listColorsPalette = GetListColorsFromSelectedPalette();
            }
        }


        // Получить список цветов из PictureBox
        private List<Color> GetListColorsFromPictureBox() {
            List<Color> listColors = new List<Color>();

            GetListPictureBoxs();

            foreach (PictureBox pictureBox in listPictureBoxs) {
                listColors.Add(pictureBox.BackColor);
            }

            return listColors;
        }


        // Получить список цветов из палитры
        private List<Color> GetListColorsFromSelectedPalette() {
            List<Color> listColors = new List<Color>();

            int width = palette.Width;

            for (int i = 0; i < width; i++) {
                listColors.Add(palette.GetPixel(i, 0));
            }

            return listColors;
        }


        // Получить список всех PictureBox
        private void GetListPictureBoxs() {
            listPictureBoxs = new List<PictureBox>();

            foreach (PictureBox control in mainForm.flowLayoutPanel1.Controls.OfType<PictureBox>()) {
                listPictureBoxs.Add(control);
            }
        }


        // Получить список всех Button
        private void GetListButtons() {
            listButtons = new List<Button>();

            foreach (Button control in mainForm.flowLayoutPanel1.Controls.OfType<Button>()) {
                listButtons.Add(control);
            }
        }


        // Установка изображения из Bitmap
        private void SetImageToPictureBox(Bitmap bitmap) {
            mainForm.pictureBoxPreview.Image = new Bitmap(bitmap);
        }


        // Создание палитры на основе картинки
        private void CreatePaletteByImage() {
            int amountChunksInWidht = Convert.ToInt32(mainForm.textBoxChunkWidth.Text);
            int amountChunksInHeight = Convert.ToInt32(mainForm.textBoxChunkHeight.Text);
            int widhtInChunk = sourceImage.Width / amountChunksInWidht;
            int heightInChunk = sourceImage.Height / amountChunksInHeight;

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

            palette = new Bitmap(colorPosX, 1);

            for (int i = 0; i < colorPosX; i++) {
                palette.SetPixel(i, 0, bitmap.GetPixel(i, 0));
            }
        }


        // Получение среднего цвета из чанка
        private Color GetAvgColorFromChunk(int widhtInChunk, int heightInChunk, int currentChunkX, int currentChunkY) {
            Color avgColor = Color.White;
            int[] avgColorRGB = { 0, 0, 0 };

            for (int i = 0; i < heightInChunk; i++) {
                for (int j = 0; j < widhtInChunk; j++) {
                    int x = (currentChunkX * widhtInChunk) + j;
                    int y = (currentChunkY * heightInChunk) + i;

                    Color color = sourceImage.GetPixel(x, y);
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


        // Проверка на добавление цвета если его нету в списке
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


        // Создание палитры из PictureBox
        private void CreatePaletteFromPictureBox() {
            int width = listPictureBoxs.Count;

            Bitmap bitmap = new Bitmap(width, 1);

            for (int x = 0; x < width; x++) {
                Color color = listPictureBoxs[x].BackColor;

                bitmap.SetPixel(x, 0, color);
            }

            if (mainForm.saveFileDialogPalette.ShowDialog() == DialogResult.OK) {
                bitmap.Save(mainForm.saveFileDialogPalette.FileName, ImageFormat.Png);
            }
        }
    }
}
