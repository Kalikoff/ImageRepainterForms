﻿
namespace ImageRepainterForms {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxListColors = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelCustomListColor = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.colorDialogSelectionPictureBox = new System.Windows.Forms.ColorDialog();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProcessImage = new System.Windows.Forms.Button();
            this.comboBoxColorModels = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelPaletteByImage = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPaletteByImage = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelChunkSizes = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseCustomListColor = new System.Windows.Forms.CheckBox();
            this.openFileDialogPalette = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPalette = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.timerCheckingProcessImage = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBoxListColors.SuspendLayout();
            this.flowLayoutPanelCustomListColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelPaletteByImage.SuspendLayout();
            this.tableLayoutPanelChunkSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkHeight)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.paletteToolStripMenuItem,
            this.effectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageOpenToolStripMenuItem,
            this.imageSaveToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.imageToolStripMenuItem.Text = "Изображение";
            // 
            // imageOpenToolStripMenuItem
            // 
            this.imageOpenToolStripMenuItem.Name = "imageOpenToolStripMenuItem";
            this.imageOpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.imageOpenToolStripMenuItem.Text = "Открыть";
            this.imageOpenToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // imageSaveToolStripMenuItem
            // 
            this.imageSaveToolStripMenuItem.Name = "imageSaveToolStripMenuItem";
            this.imageSaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.imageSaveToolStripMenuItem.Text = "Сохранить";
            this.imageSaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // paletteToolStripMenuItem
            // 
            this.paletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletteOpenToolStripMenuItem,
            this.paletteSaveToolStripMenuItem});
            this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
            this.paletteToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paletteToolStripMenuItem.Text = "Палитра";
            // 
            // paletteOpenToolStripMenuItem
            // 
            this.paletteOpenToolStripMenuItem.Name = "paletteOpenToolStripMenuItem";
            this.paletteOpenToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paletteOpenToolStripMenuItem.Text = "Открыть";
            this.paletteOpenToolStripMenuItem.Click += new System.EventHandler(this.paletteOpenToolStripMenuItem_Click);
            // 
            // paletteSaveToolStripMenuItem
            // 
            this.paletteSaveToolStripMenuItem.Name = "paletteSaveToolStripMenuItem";
            this.paletteSaveToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.paletteSaveToolStripMenuItem.Text = "Сохранить";
            this.paletteSaveToolStripMenuItem.Click += new System.EventHandler(this.paletteSaveToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectsInversionToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.effectsToolStripMenuItem.Text = "Эффекты";
            // 
            // effectsInversionToolStripMenuItem
            // 
            this.effectsInversionToolStripMenuItem.Name = "effectsInversionToolStripMenuItem";
            this.effectsInversionToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.effectsInversionToolStripMenuItem.Text = "Инверсия";
            this.effectsInversionToolStripMenuItem.Click += new System.EventHandler(this.effectsInversionToolStripMenuItem_Click);
            // 
            // groupBoxListColors
            // 
            this.groupBoxListColors.Controls.Add(this.flowLayoutPanelCustomListColor);
            this.groupBoxListColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListColors.Enabled = false;
            this.groupBoxListColors.Location = new System.Drawing.Point(3, 41);
            this.groupBoxListColors.Name = "groupBoxListColors";
            this.groupBoxListColors.Size = new System.Drawing.Size(150, 335);
            this.groupBoxListColors.TabIndex = 1;
            this.groupBoxListColors.TabStop = false;
            this.groupBoxListColors.Text = "Список цветов";
            // 
            // flowLayoutPanelCustomListColor
            // 
            this.flowLayoutPanelCustomListColor.AutoScroll = true;
            this.flowLayoutPanelCustomListColor.Controls.Add(this.buttonAddColor);
            this.flowLayoutPanelCustomListColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCustomListColor.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelCustomListColor.Name = "flowLayoutPanelCustomListColor";
            this.flowLayoutPanelCustomListColor.Size = new System.Drawing.Size(144, 316);
            this.flowLayoutPanelCustomListColor.TabIndex = 0;
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Location = new System.Drawing.Point(3, 3);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(113, 23);
            this.buttonAddColor.TabIndex = 3;
            this.buttonAddColor.Text = "Добавить цвет";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(640, 360);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxPreview);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 379);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотр изображения";
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.RestoreDirectory = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelPaletteByImage, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 82);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonProcessImage
            // 
            this.buttonProcessImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcessImage.Location = new System.Drawing.Point(26, 33);
            this.buttonProcessImage.Name = "buttonProcessImage";
            this.buttonProcessImage.Size = new System.Drawing.Size(145, 36);
            this.buttonProcessImage.TabIndex = 6;
            this.buttonProcessImage.Text = "Обработать изображение";
            this.buttonProcessImage.UseVisualStyleBackColor = true;
            this.buttonProcessImage.Click += new System.EventHandler(this.buttonProcessImageToMultiColorModel_Click);
            // 
            // comboBoxColorModels
            // 
            this.comboBoxColorModels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxColorModels.FormattingEnabled = true;
            this.comboBoxColorModels.Items.AddRange(new object[] {
            "RGB",
            "HSL",
            "HSV",
            "XYZ"});
            this.comboBoxColorModels.Location = new System.Drawing.Point(26, 3);
            this.comboBoxColorModels.Name = "comboBoxColorModels";
            this.comboBoxColorModels.Size = new System.Drawing.Size(145, 21);
            this.comboBoxColorModels.TabIndex = 9;
            // 
            // tableLayoutPanelPaletteByImage
            // 
            this.tableLayoutPanelPaletteByImage.ColumnCount = 1;
            this.tableLayoutPanelPaletteByImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaletteByImage.Controls.Add(this.tableLayoutPanelChunkSizes, 0, 1);
            this.tableLayoutPanelPaletteByImage.Controls.Add(this.checkBoxPaletteByImage, 0, 0);
            this.tableLayoutPanelPaletteByImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaletteByImage.Location = new System.Drawing.Point(612, 3);
            this.tableLayoutPanelPaletteByImage.Name = "tableLayoutPanelPaletteByImage";
            this.tableLayoutPanelPaletteByImage.RowCount = 2;
            this.tableLayoutPanelPaletteByImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelPaletteByImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelPaletteByImage.Size = new System.Drawing.Size(199, 76);
            this.tableLayoutPanelPaletteByImage.TabIndex = 10;
            // 
            // checkBoxPaletteByImage
            // 
            this.checkBoxPaletteByImage.AutoSize = true;
            this.checkBoxPaletteByImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxPaletteByImage.Location = new System.Drawing.Point(3, 3);
            this.checkBoxPaletteByImage.Name = "checkBoxPaletteByImage";
            this.checkBoxPaletteByImage.Size = new System.Drawing.Size(193, 24);
            this.checkBoxPaletteByImage.TabIndex = 0;
            this.checkBoxPaletteByImage.Text = "Палитра на основе картинки";
            this.checkBoxPaletteByImage.UseVisualStyleBackColor = true;
            this.checkBoxPaletteByImage.CheckedChanged += new System.EventHandler(this.checkBoxPaletteByImage_CheckedChanged);
            // 
            // tableLayoutPanelChunkSizes
            // 
            this.tableLayoutPanelChunkSizes.ColumnCount = 3;
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelChunkSizes.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.numericUpDownChunkWidth, 0, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.numericUpDownChunkHeight, 2, 0);
            this.tableLayoutPanelChunkSizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChunkSizes.Enabled = false;
            this.tableLayoutPanelChunkSizes.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanelChunkSizes.Name = "tableLayoutPanelChunkSizes";
            this.tableLayoutPanelChunkSizes.RowCount = 1;
            this.tableLayoutPanelChunkSizes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChunkSizes.Size = new System.Drawing.Size(193, 40);
            this.tableLayoutPanelChunkSizes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // numericUpDownChunkWidth
            // 
            this.numericUpDownChunkWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownChunkWidth.Location = new System.Drawing.Point(4, 10);
            this.numericUpDownChunkWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownChunkWidth.Name = "numericUpDownChunkWidth";
            this.numericUpDownChunkWidth.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownChunkWidth.TabIndex = 3;
            this.numericUpDownChunkWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownChunkHeight
            // 
            this.numericUpDownChunkHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownChunkHeight.Location = new System.Drawing.Point(132, 10);
            this.numericUpDownChunkHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownChunkHeight.Name = "numericUpDownChunkHeight";
            this.numericUpDownChunkHeight.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownChunkHeight.TabIndex = 4;
            this.numericUpDownChunkHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // checkBoxUseCustomListColor
            // 
            this.checkBoxUseCustomListColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxUseCustomListColor.AutoSize = true;
            this.checkBoxUseCustomListColor.Location = new System.Drawing.Point(3, 4);
            this.checkBoxUseCustomListColor.Name = "checkBoxUseCustomListColor";
            this.checkBoxUseCustomListColor.Size = new System.Drawing.Size(149, 30);
            this.checkBoxUseCustomListColor.TabIndex = 7;
            this.checkBoxUseCustomListColor.Text = "Использовать\rнастраиваемую палитру";
            this.checkBoxUseCustomListColor.UseVisualStyleBackColor = true;
            this.checkBoxUseCustomListColor.CheckedChanged += new System.EventHandler(this.checkBoxUseCustomListColor_CheckedChanged);
            // 
            // openFileDialogPalette
            // 
            this.openFileDialogPalette.RestoreDirectory = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 479);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.17242F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.82759F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(814, 385);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.checkBoxUseCustomListColor, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBoxListColors, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(655, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02639F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.97362F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(156, 379);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // timerCheckingProcessImage
            // 
            this.timerCheckingProcessImage.Tick += new System.EventHandler(this.timerCheckingProcessImage_Tick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxColorModels, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonProcessImage, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.93976F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.06024F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(197, 76);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(836, 542);
            this.Name = "Form1";
            this.Text = "Замена цвета";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxListColors.ResumeLayout(false);
            this.flowLayoutPanelCustomListColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelPaletteByImage.ResumeLayout(false);
            this.tableLayoutPanelPaletteByImage.PerformLayout();
            this.tableLayoutPanelChunkSizes.ResumeLayout(false);
            this.tableLayoutPanelChunkSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChunkHeight)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem imageSaveToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBoxListColors;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCustomListColor;
        public System.Windows.Forms.Button buttonAddColor;
        public System.Windows.Forms.ColorDialog colorDialogSelectionPictureBox;
        public System.Windows.Forms.PictureBox pictureBoxPreview;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.OpenFileDialog openFileDialogImage;
        public System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button buttonProcessImage;
        public System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialogPalette;
        public System.Windows.Forms.ToolStripMenuItem paletteOpenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem paletteSaveToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialogPalette;
        public System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem effectsInversionToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaletteByImage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelChunkSizes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBoxUseCustomListColor;
        public System.Windows.Forms.ComboBox comboBoxColorModels;
        public System.Windows.Forms.CheckBox checkBoxPaletteByImage;
        public System.Windows.Forms.NumericUpDown numericUpDownChunkWidth;
        public System.Windows.Forms.NumericUpDown numericUpDownChunkHeight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Timer timerCheckingProcessImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

