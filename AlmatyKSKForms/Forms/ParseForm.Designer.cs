namespace AlmatyKSKForms.Forms
{
    partial class parseForm
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.houseSelectGrid = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.selectBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.userInfo = new System.Windows.Forms.Label();
            this.periodList = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.housesGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.houseSelectGrid)).BeginInit();
            this.housesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // houseSelectGrid
            // 
            this.houseSelectGrid.AllowUserToAddRows = false;
            this.houseSelectGrid.AllowUserToDeleteRows = false;
            this.houseSelectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseSelectGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HouseNumber,
            this.HouseName,
            this.Column1,
            this.Column2,
            this.Column3});
            this.houseSelectGrid.Location = new System.Drawing.Point(6, 48);
            this.houseSelectGrid.Name = "houseSelectGrid";
            this.houseSelectGrid.ReadOnly = true;
            this.houseSelectGrid.Size = new System.Drawing.Size(643, 150);
            this.houseSelectGrid.TabIndex = 2;
            this.houseSelectGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Show);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(559, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Загрузить все";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.UploadAllReport);
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(6, 19);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(93, 23);
            this.selectBtn.TabIndex = 8;
            this.selectBtn.Text = "Выбрать лист";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.SelectList);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 8);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 9;
            this.loginBtn.Text = "Войти";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.Login);
            // 
            // userInfo
            // 
            this.userInfo.AutoSize = true;
            this.userInfo.Location = new System.Drawing.Point(93, 13);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(288, 13);
            this.userInfo.TabIndex = 10;
            this.userInfo.Text = "Для дальнейшей работы необходимо авторизирваться";
            // 
            // periodList
            // 
            this.periodList.FormattingEnabled = true;
            this.periodList.Location = new System.Drawing.Point(60, 204);
            this.periodList.Name = "periodList";
            this.periodList.Size = new System.Drawing.Size(97, 21);
            this.periodList.TabIndex = 12;
            this.periodList.SelectedIndexChanged += new System.EventHandler(this.PeriodList_SelectedIndexChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 207);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 13;
            this.label.Text = "Период:";
            this.label.Click += new System.EventHandler(this.Label_Click);
            // 
            // housesGroupBox
            // 
            this.housesGroupBox.Controls.Add(this.houseSelectGrid);
            this.housesGroupBox.Controls.Add(this.label);
            this.housesGroupBox.Controls.Add(this.periodList);
            this.housesGroupBox.Controls.Add(this.selectBtn);
            this.housesGroupBox.Controls.Add(this.button3);
            this.housesGroupBox.Location = new System.Drawing.Point(12, 41);
            this.housesGroupBox.Name = "housesGroupBox";
            this.housesGroupBox.Size = new System.Drawing.Size(655, 233);
            this.housesGroupBox.TabIndex = 14;
            this.housesGroupBox.TabStop = false;
            this.housesGroupBox.Text = "Дома";
            this.housesGroupBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Шаблоны";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenPatterns);
            // 
            // HouseNumber
            // 
            this.HouseNumber.HeaderText = "№";
            this.HouseNumber.Name = "HouseNumber";
            this.HouseNumber.ReadOnly = true;
            this.HouseNumber.Width = 25;
            // 
            // HouseName
            // 
            this.HouseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HouseName.HeaderText = "Имя";
            this.HouseName.Name = "HouseName";
            this.HouseName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Остаток(док.)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Остаток(прог.)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Итог";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // parseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.housesGroupBox);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "parseForm";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.houseSelectGrid)).EndInit();
            this.housesGroupBox.ResumeLayout(false);
            this.housesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.DataGridView houseSelectGrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label userInfo;
        public System.Windows.Forms.ComboBox periodList;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox housesGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}