using ExcelDataReader;
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
    public partial class SelectPeriodForm : Form
    {
        public int SelectIndex { get; private set; }
        public string FileName { get; private set; }
        public int StartCell { get; private set; }
        public Pattern Pattern { get; private set; }

        public SelectPeriodForm()
        {
            InitializeComponent();
            var r =openFileDialog.ShowDialog();
            if (r != DialogResult.OK)
            {
                Close();
                return;
            }
            FileName = openFileDialog.FileName;

            using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read,FileShare.ReadWrite))
            {
                IExcelDataReader reader;
                reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                var conf = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = _ => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };
                var dataSet = reader.AsDataSet(conf);

                int i = 1;
                tableSelectGrid.Rows.Clear();
                foreach (DataTable table in dataSet.Tables)
                {
                    tableSelectGrid.Rows.Add(i, table.TableName);
                    i++;
                }

                var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
                patternsBox.Items.Clear();
                if (patterns == null) return;
                i = 0;
                foreach (var p in patterns)
                {
                    patternsBox.Items.Add( p.Name);
                    i++;
                }
            }
        }


        private void SelectClick(object sender, EventArgs e)
        {
            SelectIndex = tableSelectGrid.CurrentCell.RowIndex;
            var patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);

            Pattern = patterns[patternsBox.SelectedIndex];
        }
    }
}
