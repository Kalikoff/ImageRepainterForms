
namespace ImageRepainterForms.View {
    partial class CustomPaletteForm {
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
            this.colorDialogSelectionPictureBox = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxListColors = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.tableLayoutPanelColorList = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxListColors.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxListColors, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(311, 500);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBoxListColors
            // 
            this.groupBoxListColors.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxListColors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxListColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxListColors.Location = new System.Drawing.Point(3, 3);
            this.groupBoxListColors.Name = "groupBoxListColors";
            this.groupBoxListColors.Size = new System.Drawing.Size(305, 494);
            this.groupBoxListColors.TabIndex = 2;
            this.groupBoxListColors.TabStop = false;
            this.groupBoxListColors.Text = "Список цветов";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAddColor, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanelColorList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 469);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddColor.Location = new System.Drawing.Point(3, 425);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(293, 41);
            this.buttonAddColor.TabIndex = 2;
            this.buttonAddColor.Text = "Добавить цвет";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // tableLayoutPanelColorList
            // 
            this.tableLayoutPanelColorList.AutoScroll = true;
            this.tableLayoutPanelColorList.ColumnCount = 2;
            this.tableLayoutPanelColorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelColorList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelColorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelColorList.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelColorList.Name = "tableLayoutPanelColorList";
            this.tableLayoutPanelColorList.RowCount = 1;
            this.tableLayoutPanelColorList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelColorList.Size = new System.Drawing.Size(293, 416);
            this.tableLayoutPanelColorList.TabIndex = 3;
            // 
            // CustomPaletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(327, 9999);
            this.MinimumSize = new System.Drawing.Size(327, 539);
            this.Name = "CustomPaletteForm";
            this.Text = "Настраиваемая палитра";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomPaletteForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxListColors.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialogSelectionPictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.GroupBox groupBoxListColors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelColorList;
    }
}