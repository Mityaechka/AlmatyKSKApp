namespace AlmatyKSKForms.Forms
{
    partial class PatternEditor
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
            this.patternEditorGrid = new System.Windows.Forms.DataGridView();
            this.CollumIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPattern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.patternName = new System.Windows.Forms.TextBox();
            this.textEditorGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.streetColumn = new System.Windows.Forms.NumericUpDown();
            this.homeColumn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.homeGrid = new System.Windows.Forms.DataGridView();
            this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.patternEditorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // patternEditorGrid
            // 
            this.patternEditorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternEditorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CollumIndex});
            this.patternEditorGrid.Location = new System.Drawing.Point(6, 6);
            this.patternEditorGrid.Name = "patternEditorGrid";
            this.patternEditorGrid.Size = new System.Drawing.Size(428, 219);
            this.patternEditorGrid.TabIndex = 0;
            // 
            // CollumIndex
            // 
            this.CollumIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CollumIndex.HeaderText = "Колонка";
            this.CollumIndex.Name = "CollumIndex";
            this.CollumIndex.Width = 75;
            // 
            // addPattern
            // 
            this.addPattern.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPattern.Location = new System.Drawing.Point(385, 303);
            this.addPattern.Name = "addPattern";
            this.addPattern.Size = new System.Drawing.Size(75, 23);
            this.addPattern.TabIndex = 1;
            this.addPattern.Text = "Добавить";
            this.addPattern.UseVisualStyleBackColor = true;
            this.addPattern.Click += new System.EventHandler(this.CreatePattern);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // patternName
            // 
            this.patternName.Location = new System.Drawing.Point(77, 13);
            this.patternName.Name = "patternName";
            this.patternName.Size = new System.Drawing.Size(100, 20);
            this.patternName.TabIndex = 3;
            // 
            // textEditorGrid
            // 
            this.textEditorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textEditorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.textEditorGrid.Location = new System.Drawing.Point(6, 6);
            this.textEditorGrid.Name = "textEditorGrid";
            this.textEditorGrid.Size = new System.Drawing.Size(432, 219);
            this.textEditorGrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.HeaderText = "Колонка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Колонка улицы";
            // 
            // streetColumn
            // 
            this.streetColumn.Location = new System.Drawing.Point(273, 14);
            this.streetColumn.Name = "streetColumn";
            this.streetColumn.Size = new System.Drawing.Size(48, 20);
            this.streetColumn.TabIndex = 6;
            // 
            // homeColumn
            // 
            this.homeColumn.Location = new System.Drawing.Point(416, 14);
            this.homeColumn.Name = "homeColumn";
            this.homeColumn.Size = new System.Drawing.Size(48, 20);
            this.homeColumn.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Колонка дома";
            // 
            // homeGrid
            // 
            this.homeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShortName,
            this.FullName});
            this.homeGrid.Location = new System.Drawing.Point(6, 6);
            this.homeGrid.Name = "homeGrid";
            this.homeGrid.Size = new System.Drawing.Size(432, 219);
            this.homeGrid.TabIndex = 9;
            // 
            // ShortName
            // 
            this.ShortName.HeaderText = "Абривеатура";
            this.ShortName.Name = "ShortName";
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "Полное имя";
            this.FullName.Name = "FullName";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 257);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.patternEditorGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.homeGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(444, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дома";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textEditorGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(444, 231);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Доп. статьи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PatternEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 336);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.homeColumn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.streetColumn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patternName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PatternEditor";
            this.Text = "Редактирование шаблона";
            ((System.ComponentModel.ISupportInitialize)(this.patternEditorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditorGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patternEditorGrid;
        private System.Windows.Forms.Button addPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patternName;
        private System.Windows.Forms.DataGridView textEditorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollumIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown streetColumn;
        private System.Windows.Forms.NumericUpDown homeColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView homeGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}