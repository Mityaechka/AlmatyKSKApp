using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmatyKSKForms.Forms
{
    public partial class PatternEditor : Form
    {
        Pattern editPattern;
        bool isEdit;
        public PatternEditor(Pattern pattern)
        {
            
            InitializeComponent();
            DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn textColumn = new DataGridViewComboBoxColumn();
            var names = new List<string>();
            var strElements = new List<String>();
            foreach(var e in ReportElement.RequestNames)
            {
                if(e.isNumerical)
                names.Add(e.Name);
                else strElements.Add(e.Name);
            }
            column.DataSource = names;
            column.Name = "ValueType";
            column.HeaderText = "Тип данных";
            column.Width = 200;
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            textColumn.DataSource = strElements;
            textColumn.Name = "ValueType";
            textColumn.HeaderText = "Тип данных";
            textColumn.Width = 200;
            textColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            patternEditorGrid.Columns.Insert(0,column);
            textEditorGrid.Columns.Insert(0, textColumn);

            if (pattern != null)
            {
                isEdit = true;
                editPattern = pattern;
                patternName.Text = pattern.Name;
                streetColumn.Value = pattern.StreetIndex;
                homeColumn.Value = pattern.HomeIndex;
                foreach(var h in pattern.StreetNames)
                {
                    homeGrid.Rows.Add(h.Key, h.Value);
                }
                foreach (var e in pattern.Elements)
                {
                    if (e.ValueName.isNumerical)
                    {
                        patternEditorGrid.Rows.Add(e.ValueName.Name, e.Collum);
                    }
                    else
                    {
                        textEditorGrid.Rows.Add(e.ValueName.Name, e.CustomName);
                    }
                }
            }
        }

        private void CreatePattern(object sender, EventArgs e)
        {
            var pattern = new Pattern(!isEdit);
            pattern.Name = patternName.Text;
            pattern.StreetIndex = Convert.ToInt32( streetColumn.Value);
            pattern.HomeIndex = Convert.ToInt32(homeColumn.Value);
            foreach(DataGridViewRow r in homeGrid.Rows)
            {
                if (r.Cells[0].Value == null || r.Cells[1].Value == null)
                    continue;
                pattern.StreetNames.Add(r.Cells[0].Value.ToString(), r.Cells[1].Value.ToString());
            }
            foreach (DataGridViewRow row in patternEditorGrid.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                    continue;
                var element = ReportElement.RequestNames.Where<Value>(x => x.Name == row.Cells[0].Value.ToString()).FirstOrDefault();
                if (element == null) continue;
                if(element.isNumerical)
                pattern.Elements.Add(new ReportElement(element ,Convert.ToInt32(row.Cells[1].Value)));
            }
            foreach (DataGridViewRow row in textEditorGrid.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                    continue;
                var element = ReportElement.RequestNames.Where<Value>(x => x.Name == row.Cells[0].Value.ToString()).FirstOrDefault();
                if (element == null) continue;
                if (!element.isNumerical)
                    pattern.Elements.Add(new ReportElement(element, row.Cells[1].Value.ToString()));
            }

            List<Pattern> patterns = new List<Pattern>();

            patterns = JsonConvert.DeserializeObject<List<Pattern>>(Properties.Settings.Default.Patterns);
            if (patterns == null) patterns = new List<Pattern>();
            if(!isEdit)
            patterns.Add(pattern);
            else
            {
                int index = patterns.FindIndex(x => x.id == editPattern.id);
                pattern.id = editPattern.id;
                patterns[index] = pattern;
            }
            var s = patterns;
            Properties.Settings.Default.Patterns = JsonConvert.SerializeObject(patterns);
            Properties.Settings.Default.Save();
        }
    }
}
