
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.colorDialogSelectionPictureBox = new System.Windows.Forms.ColorDialog();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProcessImageToHSL = new System.Windows.Forms.Button();
            this.comboBoxColorModels = new System.Windows.Forms.ComboBox();
            this.checkBoxUseCustomListColor = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelPaletteByImage = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxPaletteByImage = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelChunkSizes = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxChunkWidth = new System.Windows.Forms.TextBox();
            this.textBoxChunkHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogPalette = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPalette = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxListColors.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelPaletteByImage.SuspendLayout();
            this.tableLayoutPanelChunkSizes.SuspendLayout();
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
            this.groupBoxListColors.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxListColors.Enabled = false;
            this.groupBoxListColors.Location = new System.Drawing.Point(664, 27);
            this.groupBoxListColors.Name = "groupBoxListColors";
            this.groupBoxListColors.Size = new System.Drawing.Size(144, 379);
            this.groupBoxListColors.TabIndex = 1;
            this.groupBoxListColors.TabStop = false;
            this.groupBoxListColors.Text = "Список цветов";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.buttonAddColor);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(138, 360);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
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
            this.tableLayoutPanel1.Controls.Add(this.buttonProcessImageToHSL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxColorModels, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUseCustomListColor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelPaletteByImage, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 412);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(793, 66);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonProcessImageToHSL
            // 
            this.buttonProcessImageToHSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcessImageToHSL.Location = new System.Drawing.Point(26, 15);
            this.buttonProcessImageToHSL.Name = "buttonProcessImageToHSL";
            this.buttonProcessImageToHSL.Size = new System.Drawing.Size(145, 36);
            this.buttonProcessImageToHSL.TabIndex = 6;
            this.buttonProcessImageToHSL.Text = "Обработать изображение";
            this.buttonProcessImageToHSL.UseVisualStyleBackColor = true;
            this.buttonProcessImageToHSL.Click += new System.EventHandler(this.buttonProcessImageToMultiColorModel_Click);
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
            this.comboBoxColorModels.Location = new System.Drawing.Point(224, 22);
            this.comboBoxColorModels.Name = "comboBoxColorModels";
            this.comboBoxColorModels.Size = new System.Drawing.Size(145, 21);
            this.comboBoxColorModels.TabIndex = 9;
            // 
            // checkBoxUseCustomListColor
            // 
            this.checkBoxUseCustomListColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxUseCustomListColor.AutoSize = true;
            this.checkBoxUseCustomListColor.Location = new System.Drawing.Point(409, 24);
            this.checkBoxUseCustomListColor.Name = "checkBoxUseCustomListColor";
            this.checkBoxUseCustomListColor.Size = new System.Drawing.Size(171, 17);
            this.checkBoxUseCustomListColor.TabIndex = 7;
            this.checkBoxUseCustomListColor.Text = "Использовать свою палитру";
            this.checkBoxUseCustomListColor.UseVisualStyleBackColor = true;
            this.checkBoxUseCustomListColor.CheckedChanged += new System.EventHandler(this.checkBoxUseCustomListColor_CheckedChanged);
            // 
            // tableLayoutPanelPaletteByImage
            // 
            this.tableLayoutPanelPaletteByImage.ColumnCount = 1;
            this.tableLayoutPanelPaletteByImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPaletteByImage.Controls.Add(this.checkBoxPaletteByImage, 0, 0);
            this.tableLayoutPanelPaletteByImage.Controls.Add(this.tableLayoutPanelChunkSizes, 0, 1);
            this.tableLayoutPanelPaletteByImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPaletteByImage.Location = new System.Drawing.Point(597, 3);
            this.tableLayoutPanelPaletteByImage.Name = "tableLayoutPanelPaletteByImage";
            this.tableLayoutPanelPaletteByImage.RowCount = 2;
            this.tableLayoutPanelPaletteByImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelPaletteByImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelPaletteByImage.Size = new System.Drawing.Size(193, 60);
            this.tableLayoutPanelPaletteByImage.TabIndex = 10;
            // 
            // checkBoxPaletteByImage
            // 
            this.checkBoxPaletteByImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPaletteByImage.AutoSize = true;
            this.checkBoxPaletteByImage.Location = new System.Drawing.Point(3, 4);
            this.checkBoxPaletteByImage.Name = "checkBoxPaletteByImage";
            this.checkBoxPaletteByImage.Size = new System.Drawing.Size(173, 17);
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
            this.tableLayoutPanelChunkSizes.Controls.Add(this.textBoxChunkWidth, 0, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.textBoxChunkHeight, 2, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelChunkSizes.Enabled = false;
            this.tableLayoutPanelChunkSizes.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanelChunkSizes.Name = "tableLayoutPanelChunkSizes";
            this.tableLayoutPanelChunkSizes.RowCount = 1;
            this.tableLayoutPanelChunkSizes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChunkSizes.Size = new System.Drawing.Size(187, 30);
            this.tableLayoutPanelChunkSizes.TabIndex = 1;
            // 
            // textBoxChunkWidth
            // 
            this.textBoxChunkWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChunkWidth.Location = new System.Drawing.Point(3, 5);
            this.textBoxChunkWidth.Name = "textBoxChunkWidth";
            this.textBoxChunkWidth.Size = new System.Drawing.Size(56, 20);
            this.textBoxChunkWidth.TabIndex = 0;
            // 
            // textBoxChunkHeight
            // 
            this.textBoxChunkHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxChunkHeight.Location = new System.Drawing.Point(127, 5);
            this.textBoxChunkHeight.Name = "textBoxChunkHeight";
            this.textBoxChunkHeight.Size = new System.Drawing.Size(57, 20);
            this.textBoxChunkHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // openFileDialogPalette
            // 
            this.openFileDialogPalette.RestoreDirectory = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxListColors);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Замена цвета";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxListColors.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelPaletteByImage.ResumeLayout(false);
            this.tableLayoutPanelPaletteByImage.PerformLayout();
            this.tableLayoutPanelChunkSizes.ResumeLayout(false);
            this.tableLayoutPanelChunkSizes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem imageOpenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem imageSaveToolStripMenuItem;
        public System.Windows.Forms.GroupBox groupBoxListColors;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button buttonAddColor;
        public System.Windows.Forms.ColorDialog colorDialogSelectionPictureBox;
        public System.Windows.Forms.PictureBox pictureBoxPreview;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.OpenFileDialog openFileDialogImage;
        public System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button buttonProcessImageToHSL;
        public System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialogPalette;
        public System.Windows.Forms.ToolStripMenuItem paletteOpenToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem paletteSaveToolStripMenuItem;
        public System.Windows.Forms.SaveFileDialog saveFileDialogPalette;
        public System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem effectsInversionToolStripMenuItem;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelPaletteByImage;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelChunkSizes;
        public System.Windows.Forms.TextBox textBoxChunkWidth;
        public System.Windows.Forms.TextBox textBoxChunkHeight;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBoxUseCustomListColor;
        public System.Windows.Forms.ComboBox comboBoxColorModels;
        public System.Windows.Forms.CheckBox checkBoxPaletteByImage;
    }
}

