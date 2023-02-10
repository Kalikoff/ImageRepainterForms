
namespace ImageRepainterForms.View {
    partial class ImageBasedPaletteForm {
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
            this.tableLayoutPanelChunkSizes = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownAmountChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownAmountChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreatePaletteByImage = new System.Windows.Forms.Button();
            this.tableLayoutPanelChunkSizes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountChunkWidth)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountChunkHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelChunkSizes
            // 
            this.tableLayoutPanelChunkSizes.ColumnCount = 3;
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelChunkSizes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelChunkSizes.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelChunkSizes.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanelChunkSizes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelChunkSizes.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelChunkSizes.Name = "tableLayoutPanelChunkSizes";
            this.tableLayoutPanelChunkSizes.RowCount = 1;
            this.tableLayoutPanelChunkSizes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelChunkSizes.Size = new System.Drawing.Size(363, 51);
            this.tableLayoutPanelChunkSizes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "НА";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownAmountChunkWidth, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(139, 45);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // numericUpDownAmountChunkWidth
            // 
            this.numericUpDownAmountChunkWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAmountChunkWidth.Location = new System.Drawing.Point(58, 9);
            this.numericUpDownAmountChunkWidth.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownAmountChunkWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAmountChunkWidth.Name = "numericUpDownAmountChunkWidth";
            this.numericUpDownAmountChunkWidth.Size = new System.Drawing.Size(67, 26);
            this.numericUpDownAmountChunkWidth.TabIndex = 3;
            this.numericUpDownAmountChunkWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownAmountChunkHeight, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(220, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 45);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // numericUpDownAmountChunkHeight
            // 
            this.numericUpDownAmountChunkHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAmountChunkHeight.Location = new System.Drawing.Point(59, 9);
            this.numericUpDownAmountChunkHeight.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownAmountChunkHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAmountChunkHeight.Name = "numericUpDownAmountChunkHeight";
            this.numericUpDownAmountChunkHeight.Size = new System.Drawing.Size(67, 26);
            this.numericUpDownAmountChunkHeight.TabIndex = 4;
            this.numericUpDownAmountChunkHeight.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество чанков";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanelChunkSizes, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCreatePaletteByImage, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(369, 115);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // buttonCreatePaletteByImage
            // 
            this.buttonCreatePaletteByImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreatePaletteByImage.Location = new System.Drawing.Point(32, 66);
            this.buttonCreatePaletteByImage.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreatePaletteByImage.Name = "buttonCreatePaletteByImage";
            this.buttonCreatePaletteByImage.Size = new System.Drawing.Size(304, 39);
            this.buttonCreatePaletteByImage.TabIndex = 3;
            this.buttonCreatePaletteByImage.Text = "Создать палитру на основе картинки";
            this.buttonCreatePaletteByImage.UseVisualStyleBackColor = true;
            this.buttonCreatePaletteByImage.Click += new System.EventHandler(this.buttonCreatePaletteByImage_Click);
            // 
            // ImageBasedPaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 179);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(391, 179);
            this.MinimumSize = new System.Drawing.Size(391, 179);
            this.Name = "ImageBasedPaletteForm";
            this.Text = "Палитра на основе картинки";
            this.tableLayoutPanelChunkSizes.ResumeLayout(false);
            this.tableLayoutPanelChunkSizes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountChunkWidth)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountChunkHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelChunkSizes;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericUpDownAmountChunkWidth;
        public System.Windows.Forms.NumericUpDown numericUpDownAmountChunkHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonCreatePaletteByImage;
    }
}