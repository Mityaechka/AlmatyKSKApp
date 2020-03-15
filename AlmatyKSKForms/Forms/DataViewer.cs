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
    public partial class DataViewer : Form
    {
        parseForm form;
        List<Report> data;

        int index;
        public DataViewer(parseForm form, List<Report> data, int index)
        {
            InitializeComponent();
            this.form = form;
            this.data = data;
            this.index = index;
            homeLabel.Text = data[index].House;
            homeLabel.Text = data[index].House;
        }
        public void ShowData()
        {
            periodLabel.Text = "Загрузить за " + form.periodList.SelectedItem.ToString();
            houseViewGrid.Rows.Clear();
            int i = 1;
            if (index >= data.Count)
            {
                MessageBox.Show("Сначала выберите строку");
                return;
            }
            foreach (var h in data[index].Data)
            {
                houseViewGrid.Rows.Add(i, h.Key.ValueName.Name, Math.Round(h.Value));
                i++;
            }
           

            total.Text = "Итого: " + data[index].TotalBalance.ToString();
            ShowDialog();
        }

        private void UploadReport(object sender, EventArgs e)
        {
            var waitForm = new WaitForm(this);
            try
            {
                waitForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void upload(WaitForm f)
        {
            var r = await HttpController.UploadReport(data[index], Program.periods[form.periodList.SelectedIndex]);
            f.Close();
            if (!r.ContainsKey("create") || !r.ContainsKey("edit"))
            {
                MessageBox.Show("Произшла ошибка!");
            }
            else
            if ((r.ContainsKey("create") && r["create"].code == System.Net.HttpStatusCode.OK) &&
                (r.ContainsKey("edit") && r["edit"].code == System.Net.HttpStatusCode.OK))
            {
                MessageBox.Show("Отчет загружен успешно");
            }
            else
            {
                MessageBox.Show("Произшла ошибка!");
            }
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }


}
