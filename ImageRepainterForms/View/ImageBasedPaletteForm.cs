using ImageRepainterForms.Model.StaticFields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms.View {
    /// <summary>
    /// Форма для создания палитры на основе изображения
    /// </summary>
    public partial class ImageBasedPaletteForm : Form {
        private bool isUserClickButton = false; // Нажал ли пользователь кнопку «Создать палитру на основе картинки»

        public ImageBasedPaletteForm() {
            InitializeComponent();

            CreatePaletteByImage();
        }

        /// <summary>
        /// Клик по кнопке «Создать палитру на основе картинки»
        /// </summary>
        private void buttonCreatePaletteByImage_Click(object sender, EventArgs e) {
            isUserClickButton = true;

            CreatePaletteByImage();
        }

        /// <summary>
        /// Создание палитры на основе изображения
        /// </summary>
        private void CreatePaletteByImage() {
            ListColor.s_ListColor = new List<Color>();

            int amountChunksInWidht = Convert.ToInt32(numericUpDownAmountChunkWidth.Text); // Количетсво чанков по ширине
            int amountChunksInHeight = Convert.ToInt32(numericUpDownAmountChunkHeight.Text); // Количетсво чанков по высоте
            int widhtInChunk = SourceImage.s_sourceImage.Width / amountChunksInWidht; // Количество пикселей в одном чанке по ширине
            int heightInChunk = SourceImage.s_sourceImage.Height / amountChunksInHeight; // Количество пикселей в одном чанке по высоте
            int paletteLength = amountChunksInWidht * amountChunksInHeight; // Максимальное количетсво цветов в палитре
            int indexCurrentPaletteColor = 0; // Индекс текущего цвета палитры
            Bitmap palette = new Bitmap(paletteLength, 1); // Палитра

            for (int i = 0; i < amountChunksInHeight; i++) {
                for (int j = 0; j < amountChunksInWidht; j++) {
                    Color color = GetAvgColorFromChunk(widhtInChunk, heightInChunk, j, i);

                    if (CheckingColorMatchingInList(color, palette, indexCurrentPaletteColor)) {
                        palette.SetPixel(indexCurrentPaletteColor, 0, color);
                        indexCurrentPaletteColor++;
                    }
                }
            }

            for (int i = 0; i < indexCurrentPaletteColor; i++) {
                ListColor.s_ListColor.Add(palette.GetPixel(i, 0));
            }

            if (isUserClickButton) {
                isUserClickButton = false;

                MessageBox.Show(Properties.Resources.infoPaletteCreated,
                    Properties.Resources.captionSuccess,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
            Color avgColor;
            int[] avgColorRGB = { 0, 0, 0 };

            for (int i = 0; i < heightInChunk; i++) {
                for (int j = 0; j < widhtInChunk; j++) {
                    int x = (currentChunkX * widhtInChunk) + j;
                    int y = (currentChunkY * heightInChunk) + i;

                    Color color = SourceImage.s_sourceImage.GetPixel(x, y);
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
        /// Проверка добавления цвета в список, если его еще нет
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
    }
}