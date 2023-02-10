
namespace ImageRepainterForms.View {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
            this.tableLayoutPanelProcessing = new System.Windows.Forms.TableLayoutPanel();
            this.buttonProcessImage = new System.Windows.Forms.Button();
            this.comboBoxColorModels = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelPrevie = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarImageProcessing = new System.Windows.Forms.ProgressBar();
            this.groupBoxPictureBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.menuStripTabs = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteChoiceCreationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteLoadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteImageBasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteSaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsInversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialogSelectionPictureBox = new System.Windows.Forms.ColorDialog();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogImage = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogPalette = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPalette = new System.Windows.Forms.SaveFileDialog();
            this.timerThreadIsAlive = new System.Windows.Forms.Timer(this.components);
            this.timerProgressBarUpdate = new System.Windows.Forms.Timer(this.components);
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelProcessing.SuspendLayout();
            this.tableLayoutPanelPrevie.SuspendLayout();
            this.groupBoxPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.menuStripTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelProcessing, 0, 1);
            tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelPrevie, 0, 0);
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.Location = new System.Drawing.Point(0, 31);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            tableLayoutPanelMain.Size = new System.Drawing.Size(801, 629);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // tableLayoutPanelProcessing
            // 
            this.tableLayoutPanelProcessing.ColumnCount = 2;
            this.tableLayoutPanelProcessing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcessing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcessing.Controls.Add(this.buttonProcessImage, 0, 0);
            this.tableLayoutPanelProcessing.Controls.Add(this.comboBoxColorModels, 1, 0);
            this.tableLayoutPanelProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcessing.Location = new System.Drawing.Point(3, 564);
            this.tableLayoutPanelProcessing.Name = "tableLayoutPanelProcessing";
            this.tableLayoutPanelProcessing.RowCount = 1;
            this.tableLayoutPanelProcessing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProcessing.Size = new System.Drawing.Size(795, 62);
            this.tableLayoutPanelProcessing.TabIndex = 0;
            // 
            // buttonProcessImage
            // 
            this.buttonProcessImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcessImage.Location = new System.Drawing.Point(78, 9);
            this.buttonProcessImage.Name = "buttonProcessImage";
            this.buttonProcessImage.Size = new System.Drawing.Size(240, 44);
            this.buttonProcessImage.TabIndex = 0;
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
            this.comboBoxColorModels.Location = new System.Drawing.Point(476, 17);
            this.comboBoxColorModels.Name = "comboBoxColorModels";
            this.comboBoxColorModels.Size = new System.Drawing.Size(240, 28);
            this.comboBoxColorModels.TabIndex = 1;
            // 
            // tableLayoutPanelPrevie
            // 
            this.tableLayoutPanelPrevie.ColumnCount = 1;
            this.tableLayoutPanelPrevie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrevie.Controls.Add(this.progressBarImageProcessing, 0, 1);
            this.tableLayoutPanelPrevie.Controls.Add(this.groupBoxPictureBox, 0, 0);
            this.tableLayoutPanelPrevie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrevie.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPrevie.Name = "tableLayoutPanelPrevie";
            this.tableLayoutPanelPrevie.RowCount = 2;
            this.tableLayoutPanelPrevie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.26605F));
            this.tableLayoutPanelPrevie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.733945F));
            this.tableLayoutPanelPrevie.Size = new System.Drawing.Size(795, 555);
            this.tableLayoutPanelPrevie.TabIndex = 1;
            // 
            // progressBarImageProcessing
            // 
            this.progressBarImageProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarImageProcessing.Location = new System.Drawing.Point(3, 526);
            this.progressBarImageProcessing.Name = "progressBarImageProcessing";
            this.progressBarImageProcessing.Size = new System.Drawing.Size(789, 26);
            this.progressBarImageProcessing.Step = 1;
            this.progressBarImageProcessing.TabIndex = 0;
            // 
            // groupBoxPictureBox
            // 
            this.groupBoxPictureBox.Controls.Add(this.pictureBoxPreview);
            this.groupBoxPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPictureBox.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPictureBox.Name = "groupBoxPictureBox";
            this.groupBoxPictureBox.Size = new System.Drawing.Size(789, 517);
            this.groupBoxPictureBox.TabIndex = 1;
            this.groupBoxPictureBox.TabStop = false;
            this.groupBoxPictureBox.Text = "Просмотр изображения";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.White;
            this.pictureBoxPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreview.Location = new System.Drawing.Point(3, 22);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(783, 492);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // menuStripTabs
            // 
            this.menuStripTabs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.paletteToolStripMenuItem,
            this.effectsToolStripMenuItem,
            this.getInfoToolStripMenuItem});
            this.menuStripTabs.Location = new System.Drawing.Point(0, 0);
            this.menuStripTabs.Name = "menuStripTabs";
            this.menuStripTabs.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripTabs.Size = new System.Drawing.Size(801, 31);
            this.menuStripTabs.TabIndex = 0;
            this.menuStripTabs.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageLoadToolStripMenuItem,
            this.imageSaveToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.imageToolStripMenuItem.Text = "Изображение";
            // 
            // imageLoadToolStripMenuItem
            // 
            this.imageLoadToolStripMenuItem.Name = "imageLoadToolStripMenuItem";
            this.imageLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.imageLoadToolStripMenuItem.Text = "Загрузить";
            this.imageLoadToolStripMenuItem.Click += new System.EventHandler(this.imageLoadToolStripMenuItem_Click);
            // 
            // imageSaveToolStripMenuItem
            // 
            this.imageSaveToolStripMenuItem.Name = "imageSaveToolStripMenuItem";
            this.imageSaveToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.imageSaveToolStripMenuItem.Text = "Сохранить";
            this.imageSaveToolStripMenuItem.Click += new System.EventHandler(this.imageSaveToolStripMenuItem_Click);
            // 
            // paletteToolStripMenuItem
            // 
            this.paletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletteChoiceCreationsToolStripMenuItem,
            this.paletteSaveToolStripMenuItem1});
            this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
            this.paletteToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.paletteToolStripMenuItem.Text = "Палитра";
            // 
            // paletteChoiceCreationsToolStripMenuItem
            // 
            this.paletteChoiceCreationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletteLoadFromFileToolStripMenuItem,
            this.paletteSettingToolStripMenuItem,
            this.paletteImageBasedToolStripMenuItem});
            this.paletteChoiceCreationsToolStripMenuItem.Name = "paletteChoiceCreationsToolStripMenuItem";
            this.paletteChoiceCreationsToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.paletteChoiceCreationsToolStripMenuItem.Text = "Выбор создания";
            // 
            // paletteLoadFromFileToolStripMenuItem
            // 
            this.paletteLoadFromFileToolStripMenuItem.Name = "paletteLoadFromFileToolStripMenuItem";
            this.paletteLoadFromFileToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.paletteLoadFromFileToolStripMenuItem.Text = "Загрузить палитру из файла";
            this.paletteLoadFromFileToolStripMenuItem.Click += new System.EventHandler(this.paletteLoadFromFileToolStripMenuItem_Click);
            // 
            // paletteSettingToolStripMenuItem
            // 
            this.paletteSettingToolStripMenuItem.Name = "paletteSettingToolStripMenuItem";
            this.paletteSettingToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.paletteSettingToolStripMenuItem.Text = "Настройка палитры";
            this.paletteSettingToolStripMenuItem.Click += new System.EventHandler(this.paletteSettingToolStripMenuItem_Click);
            // 
            // paletteImageBasedToolStripMenuItem
            // 
            this.paletteImageBasedToolStripMenuItem.Name = "paletteImageBasedToolStripMenuItem";
            this.paletteImageBasedToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.paletteImageBasedToolStripMenuItem.Text = "Палитра на основе картинки";
            this.paletteImageBasedToolStripMenuItem.Click += new System.EventHandler(this.paletteImageBasedToolStripMenuItem_Click);
            // 
            // paletteSaveToolStripMenuItem1
            // 
            this.paletteSaveToolStripMenuItem1.Name = "paletteSaveToolStripMenuItem1";
            this.paletteSaveToolStripMenuItem1.Size = new System.Drawing.Size(197, 26);
            this.paletteSaveToolStripMenuItem1.Text = "Сохранить";
            this.paletteSaveToolStripMenuItem1.Click += new System.EventHandler(this.paletteSaveToolStripMenuItem_Click);
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectsInversionToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.effectsToolStripMenuItem.Text = "Эффекты";
            // 
            // effectsInversionToolStripMenuItem
            // 
            this.effectsInversionToolStripMenuItem.Name = "effectsInversionToolStripMenuItem";
            this.effectsInversionToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.effectsInversionToolStripMenuItem.Text = "Инверсия";
            this.effectsInversionToolStripMenuItem.Click += new System.EventHandler(this.effectsInversionToolStripMenuItem_Click);
            // 
            // getInfoToolStripMenuItem
            // 
            this.getInfoToolStripMenuItem.Name = "getInfoToolStripMenuItem";
            this.getInfoToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.getInfoToolStripMenuItem.Text = "Справка";
            this.getInfoToolStripMenuItem.Click += new System.EventHandler(this.getInfoToolStripMenuItem_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "ALL (*.*)|*.*";
            // 
            // saveFileDialogImage
            // 
            this.saveFileDialogImage.Filter = "PNG (*.png)|*.png";
            // 
            // openFileDialogPalette
            // 
            this.openFileDialogPalette.Filter = "ALL (*.*)|*.*";
            // 
            // saveFileDialogPalette
            // 
            this.saveFileDialogPalette.Filter = "PNG (*.png)|*.png";
            // 
            // timerThreadIsAlive
            // 
            this.timerThreadIsAlive.Tick += new System.EventHandler(this.timerThreadIsAlive_Tick);
            // 
            // timerProgressBarUpdate
            // 
            this.timerProgressBarUpdate.Tick += new System.EventHandler(this.timerProgressBarUpdate_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 660);
            this.Controls.Add(tableLayoutPanelMain);
            this.Controls.Add(this.menuStripTabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripTabs;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(817, 699);
            this.Name = "MainForm";
            this.Text = " Перерисовщик изображений";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelProcessing.ResumeLayout(false);
            this.tableLayoutPanelPrevie.ResumeLayout(false);
            this.groupBoxPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.menuStripTabs.ResumeLayout(false);
            this.menuStripTabs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTabs;
        private System.Windows.Forms.ColorDialog colorDialogSelectionPictureBox;
        public System.Windows.Forms.OpenFileDialog openFileDialogImage;
        public System.Windows.Forms.SaveFileDialog saveFileDialogImage;
        public System.Windows.Forms.OpenFileDialog openFileDialogPalette;
        public System.Windows.Forms.SaveFileDialog saveFileDialogPalette;
        public System.Windows.Forms.Timer timerThreadIsAlive;
        public System.Windows.Forms.Timer timerProgressBarUpdate;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteChoiceCreationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteSaveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem paletteLoadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paletteImageBasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getInfoToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProcessing;
        public System.Windows.Forms.Button buttonProcessImage;
        public System.Windows.Forms.ComboBox comboBoxColorModels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrevie;
        public System.Windows.Forms.ProgressBar progressBarImageProcessing;
        private System.Windows.Forms.GroupBox groupBoxPictureBox;
        public System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.ToolStripMenuItem effectsInversionToolStripMenuItem;
    }
}