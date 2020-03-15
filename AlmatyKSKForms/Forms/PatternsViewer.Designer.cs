namespace AlmatyKSKForms.Forms
{
    partial class PatternsViewer
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
            this.components = new System.ComponentModel.Container();
            this.patternsGrid = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFile = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.importDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.patternsGrid)).BeginInit();
            this.exportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // patternsGrid
            // 
            this.patternsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patternsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.Имя});
            this.patternsGrid.Location = new System.Drawing.Point(13, 13);
            this.patternsGrid.Name = "patternsGrid";
            this.patternsGrid.Size = new System.Drawing.Size(261, 150);
            this.patternsGrid.TabIndex = 0;
            this.patternsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditPattern);
            this.patternsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowContextMenu);
            // 
            // index
            // 
            this.index.Frozen = true;
            this.index.HeaderText = "№";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 25;
            // 
            // Имя
            // 
            this.Имя.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Имя.HeaderText = "Name";
            this.Имя.Name = "Имя";
            // 
            // addBtn
            // 
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.Location = new System.Drawing.Point(199, 169);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddPattern);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(94, 169);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.Clear);
            // 
            // exportMenu
            // 
            this.exportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.exportMenu.Name = "exportMenu";
            this.exportMenu.Size = new System.Drawing.Size(120, 48);
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.импортToolStripMenuItem.Text = "Экспорт";
            this.импортToolStripMenuItem.Click += new System.EventHandler(this.Export);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.Remove);
            // 
            // exportFile
            // 
            this.exportFile.Filter = "|.pf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Импорт шаблона";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Import);
            // 
            // importDialog
            // 
            this.importDialog.Filter = "|*.pf";
            // 
            // PatternsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.patternsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PatternsViewer";
            this.Text = "Шаблоны";
            ((System.ComponentModel.ISupportInitialize)(this.patternsGrid)).EndInit();
            this.exportMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView patternsGrid;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ContextMenuStrip exportMenu;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog importDialog;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}