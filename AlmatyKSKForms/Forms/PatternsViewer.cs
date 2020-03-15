using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmatyKSKForms.Forms
{
    public partial class PatternsViewer : Form
    {
        private int rowIndex = 0;
        public PatternsViewer()
        {
            InitializeComponent();
            addBtn.Visible = Program.DevVersion;
            showPatterns();
        }
        void showPatterns()
        {
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
            patternsGrid.Rows.Clear();
            if (patterns == null) return;
            var i = 1;
            foreach (var p in patterns)
            {
                patternsGrid.Rows.Add(i, p.Name);
                i++;
            }
        }
        private void AddPattern(object sender, EventArgs e)
        {
            PatternEditor form = new PatternEditor(null);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) showPatterns();
        }

        private void Clear(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Удалить все шаблоны?",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.Patterns = JsonConvert.SerializeObject(new List<Pattern>());
                Properties.Settings.Default.Save();
                showPatterns();
            }
        }

        private void EditPattern(object sender, DataGridViewCellEventArgs e)
        {
            Visible = false;
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
           
            PatternEditor form = new PatternEditor(patterns[patternsGrid.CurrentCell.RowIndex]);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) showPatterns();
            Visible = true;
        }

        private void ShowContextMenu(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                patternsGrid.Rows[e.RowIndex].Selected = true;
                rowIndex = e.RowIndex;
                patternsGrid.CurrentCell = patternsGrid.Rows[e.RowIndex].Cells[1];
                exportMenu.Show(patternsGrid, e.Location);
                exportMenu.Show(Cursor.Position);
            }
        }

        private void Export(object sender, EventArgs e)
        {
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
            var pattern = patterns[patternsGrid.CurrentCell.RowIndex];
            exportFile.FileName = pattern.Name;

            if (exportFile.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = exportFile.FileName;
            System.IO.File.WriteAllText(filename, JsonConvert.SerializeObject(pattern));

        }

        private void Import(object sender, EventArgs e)
        {
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
            if (patterns == null) patterns = new List<Pattern>();
            if (importDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string fileName = importDialog.FileName;

                string text = File.ReadAllText(fileName, Encoding.UTF8);
                var pattern = JsonConvert.DeserializeObject<Pattern>(text);
                patterns.Add(pattern);

                Properties.Settings.Default.Patterns = JsonConvert.SerializeObject(patterns);
                Properties.Settings.Default.Save();
            showPatterns();
        }

        private void Remove(object sender, EventArgs e)
        {
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
            patterns.RemoveAt(patternsGrid.CurrentCell.RowIndex);

            Properties.Settings.Default.Patterns = JsonConvert.SerializeObject(patterns);
            Properties.Settings.Default.Save();
            showPatterns();
        }
    }
}
