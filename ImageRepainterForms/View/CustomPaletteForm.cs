using ImageRepainterForms.Model.StaticFields;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageRepainterForms.View {
    /// <summary>
    /// Форма настраиваемой палитры
    /// </summary>
    public partial class CustomPaletteForm : Form {
        private int _idColor = 0; // Текущий ID PictureBox

        public CustomPaletteForm() {
            InitializeComponent();

            if (ListColor.s_ListColor != null) {
                AddColorsFromPaletteToScreen();
            }
        }

        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        private void CustomPaletteForm_FormClosing(object sender, FormClosingEventArgs e) {
            UpdateListPictureBox();
        }

        /// <summary>
        /// Добавление цвета
        /// </summary>
        private void buttonAddColor_Click(object sender, EventArgs e) {
            PictureBox pictureBox = CreateNewPictureBox();

            Button button = CreateNewButton();

            tableLayoutPanelColorList.Controls.Add(pictureBox, 0, _idColor);
            tableLayoutPanelColorList.Controls.Add(button, 1, _idColor);
            tableLayoutPanelColorList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            _idColor++;

            UpdateListPictureBox();
        }

        /// <summary>
        /// Клик по PictureBox для выбора цвета
        /// </summary>
        private void pictureBoxSelectColor_Click(object sender, EventArgs e) {
            if (colorDialogSelectionPictureBox.ShowDialog() == DialogResult.OK) {
                (sender as PictureBox).BackColor = colorDialogSelectionPictureBox.Color;
                UpdateListPictureBox();
            }
        }

        /// <summary>
        /// Клик по кнопке удаления цвета из таблицы
        /// </summary>
        private void buttonDeleteColor_Click(object sender, EventArgs e) {
            int tag = Convert.ToInt32((sender as Button).Tag);
            var pictureBox = tableLayoutPanelColorList.Controls.Find($"pictureBox{tag}", true);

            tableLayoutPanelColorList.Controls.Remove(sender as Button);
            tableLayoutPanelColorList.Controls.Remove(pictureBox[0]);

            UpdateListPictureBox();
        }

        /// <summary>
        /// Обновить список цветов для палитры
        /// </summary>
        private void UpdateListPictureBox() {
            ListColor.s_ListColor = new List<Color>();

            if (ListColor.s_ListColor == null) {
                ListColor.s_ListColor = new List<Color>();
            }

            for (int i = 0; i < _idColor; i++) {
                var pictureBoxList = tableLayoutPanelColorList.Controls.Find($"pictureBox{i}", true);

                if (pictureBoxList.Length > 0) {
                    ListColor.s_ListColor.Add(pictureBoxList[0].BackColor);
                }
            }
        }


        /// <summary>
        /// Добавление цветов из палитры на форму
        /// </summary>
        private void AddColorsFromPaletteToScreen() {
            _idColor = 0;

            foreach (var color in ListColor.s_ListColor) {
                PictureBox pictureBox = CreateNewPictureBox();
                pictureBox.BackColor = color;

                Button button = CreateNewButton();

                tableLayoutPanelColorList.Controls.Add(pictureBox, 0, _idColor);
                tableLayoutPanelColorList.Controls.Add(button, 1, _idColor);
                tableLayoutPanelColorList.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                _idColor++;
            }
        }

        /// <summary>
        /// Создание нового PictureBox
        /// </summary>
        /// <returns>Возвращает новый PictureBox</returns>
        private PictureBox CreateNewPictureBox() {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Anchor = AnchorStyles.Top;
            pictureBox.Size = new Size(30, 30);
            pictureBox.Name = $"pictureBox{_idColor}";
            pictureBox.Tag = _idColor;
            pictureBox.Click += pictureBoxSelectColor_Click;
            pictureBox.BackColor = Color.Black;

            return pictureBox;
        }

        /// <summary>
        /// Создание новой Button
        /// </summary>
        /// <returns>Возвращает новый Button</returns>
        private Button CreateNewButton() {
            Button button = new Button();
            button.Anchor = AnchorStyles.Top;
            button.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button.Size = new Size(95, 30);
            button.Text = "Удалить";
            button.UseVisualStyleBackColor = true;
            button.Tag = _idColor;
            button.Click += buttonDeleteColor_Click;

            return button;
        }
    }
}