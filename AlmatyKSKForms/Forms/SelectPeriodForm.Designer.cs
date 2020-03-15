namespace AlmatyKSKForms.Forms
{
    partial class SelectPeriodForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableSelectGrid = new System.Windows.Forms.DataGridView();
            this.TableNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.startCell = new System.Windows.Forms.NumericUpDown();
            this.endCell = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patternsBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableSelectGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCell)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSelectGrid
            // 
            this.tableSelectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSelectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableNumber,
            this.TableIndex});
            this.tableSelectGrid.Location = new System.Drawing.Point(12, 26);
            this.tableSelectGrid.Name = "tableSelectGrid";
            this.tableSelectGrid.Size = new System.Drawing.Size(367, 200);
            this.tableSelectGrid.TabIndex = 4;
            // 
            // TableNumber
            // 
            this.TableNumber.HeaderText = "№";
            this.TableNumber.Name = "TableNumber";
            this.TableNumber.ReadOnly = true;
            this.TableNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableNumber.Width = 25;
            // 
            // TableIndex
            // 
            this.TableIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableIndex.HeaderText = "Имя";
            this.TableIndex.Name = "TableIndex";
            this.TableIndex.ReadOnly = true;
            this.TableIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите лист";
            // 
            // selectBtn
            // 
            this.selectBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.selectBtn.Location = new System.Drawing.Point(304, 260);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(75, 23);
            this.selectBtn.TabIndex = 6;
            this.selectBtn.Text = "Выбрать";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начальная ячейка";
            // 
            // startCell
            // 
            this.startCell.Location = new System.Drawing.Point(118, 237);
            this.startCell.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startCell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startCell.Name = "startCell";
            this.startCell.Size = new System.Drawing.Size(62, 20);
            this.startCell.TabIndex = 10;
            this.startCell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endCell
            // 
            this.endCell.Location = new System.Drawing.Point(118, 263);
            this.endCell.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.endCell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endCell.Name = "endCell";
            this.endCell.Size = new System.Drawing.Size(62, 20);
            this.endCell.TabIndex = 12;
            this.endCell.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Последняя ячейка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Шаблон";
            // 
            // patternsBox
            // 
            this.patternsBox.FormattingEnabled = true;
            this.patternsBox.Location = new System.Drawing.Point(238, 236);
            this.patternsBox.Name = "patternsBox";
            this.patternsBox.Size = new System.Drawing.Size(141, 21);
            this.patternsBox.TabIndex = 14;
            // 
            // SelectPeriodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 300);
            this.Controls.Add(this.patternsBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endCell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startCell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableSelectGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPeriodForm";
            this.Text = "Выбор периода";
            ((System.ComponentModel.ISupportInitialize)(this.tableSelectGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView tableSelectGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableIndex;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown startCell;
        public System.Windows.Forms.NumericUpDown endCell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox patternsBox;
    }
}