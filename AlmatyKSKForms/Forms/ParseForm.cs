using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AlmatyKSKForms.Forms
{
    public partial class parseForm : Form
    {
        List<Report> data = new List<Report>();
        string fileName;
        int startCell, endCell;
        int index;
        bool isDataSet = false;
        public parseForm()
        {
            InitializeComponent();
            foreach (var p in Program.periods)
            {
                periodList.Items.Add(p.Name);
            }
            periodList.SelectedIndex = 0;
        }

        List<Report> readFile(int tableIndex, Pattern pattern)
        {
            try
            {
                using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
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
                    data = new List<Report>();

                    var dataSet = reader.AsDataSet(conf);
                    var dataTable = dataSet.Tables[tableIndex];
                    int startRow = startCell;

                    while (startRow <= endCell)
                    {
                        var values = new Report();

                        string house = "";

                        foreach (var h in pattern.StreetNames)
                        {

                            if (dataTable.Rows[startRow][pattern.StreetIndex - 1].ToString() == h.Key)
                            {
                                house = h.Value;
                            }
                        }

                        values.House = house + dataTable.Rows[startRow][pattern.HomeIndex - 1].ToString();
                        foreach (var element in pattern.Elements)
                        {
                            if (element.ValueName.isNumerical)
                            {
                                var d = values.Data
                                    .Where(x => x.Key.ValueName.RequestName == element.ValueName.RequestName);
                                if (d.Count() != 0)
                                {
                                    var e = d.FirstOrDefault();
                                    var f = values.Data[e.Key];
                                    f += Convert.ToDouble(dataTable.Rows[startRow][element.Collum - 1]);
                                    values.Data[e.Key] = f;
                                }
                                else
                                {
                                    values.Data[element] = Convert.ToDouble(dataTable.Rows[startRow][element.Collum - 1]);
                                }
                            }
                            else
                            {
                                values.TextData[element] = element.CustomName;
                            }
                        }
                        double total = 0;
                        foreach (var e in values.Data)
                        {
                            total += e.Value;
                        }
                        values.Total = total;
                        data.Add(values);
                        startRow++;
                    }
                    return data;
                }
            }
            catch
            {
                DialogResult result = MessageBox.Show(
                  "Во время чтения файла произошла ошибка",
                  "Ошибка!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            return null;
        }
        public async void RefreshInfo(object sender, EventArgs e)
        {
            try
            {
                var r = await HttpController.UserInfo();
                if (r.code == System.Net.HttpStatusCode.Unauthorized)
                {
                    housesGroupBox.Visible = false;
                    userInfo.Text = "Для дальнейшей работы авторизуйтесь";
                }
                else if (r.code == System.Net.HttpStatusCode.OK)
                {
                    housesGroupBox.Visible = true;
                    var definition = new
                    {
                        FullName = ""
                    };

                    var data = JsonConvert.DeserializeAnonymousType(r.response, definition);
                    userInfo.Text = "Добро пожаловать, " + data.FullName;

                }
            }
            catch
            {
                DialogResult result = MessageBox.Show(
                  "Повторите попытку",
                  "Ошибка!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }

        public void ShowData(object sender, EventArgs e)
        {
            var index = houseSelectGrid.CurrentCell.RowIndex;

            var form = new DataViewer(this, data, index);
            form.ShowData();
        }
        private void UploadAllReport(object sender, EventArgs e)
        {
            if (isDataSet)
            {
                var waitForm = new WaitForm(this);

            }
        }
        public async void upload(WaitForm f)
        {
            var errors = new List<String>();
            Cursor = Cursors.WaitCursor;
            foreach (var h in data)
            {
                try
                {
                    var r = await HttpController.UploadReport(h, Program.periods[periodList.SelectedIndex]);
                    if (!r.ContainsKey("create") || !r.ContainsKey("edit"))
                    { errors.Add(h.House); }
                    else
                        if ((r.ContainsKey("create") && r["create"].code != System.Net.HttpStatusCode.OK) ||
                        (r.ContainsKey("edit") && r["edit"].code != System.Net.HttpStatusCode.OK))
                    {
                        errors.Add(h.House);
                    }
                }catch(Exception e)
                {
                    errors.Add(h.House);
                }
            }
            Cursor = Cursors.Arrow;
            f.Close();
            if (errors.Count == 0)
            {
                MessageBox.Show("Отчеты загружены успешно");
            }
            else
            {
                var form = new ErrorForm(errors);
                form.ShowDialog();
            }
        }

        private void SelectList(object sender, EventArgs e)
        {

            var form = new SelectPeriodForm();
            if (!form.IsDisposed)
            {
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    houseSelectGrid.Rows.Clear();
                    isDataSet = false;
                    fileName = form.FileName;
                    index = form.SelectIndex;
                    startCell = Convert.ToInt32(form.startCell.Value) - 2;
                    endCell = Convert.ToInt32(form.endCell.Value) - 2;
                    if (readFile(index, form.Pattern) == null)
                    {
                        this.Visible = true;
                        return;
                    }
                    int i = 1;
                    isDataSet = true;
                    foreach (var h in data)
                    {
                        var totalProg = h.TotalBalance;
                        var r = h.Data.Where(x => x.Key.ValueName.RequestName == "CurrencyAccountBalanceEnd");
                        if (r.Count()!=0)
                        {
                            var totalDoc = Math.Round( r.FirstOrDefault().Value);
                            houseSelectGrid.Rows.Add(i, h.House,totalDoc,totalProg, Math.Round(totalDoc - totalProg));
                        }
                        else
                        {
                            houseSelectGrid.Rows.Add(i, h.House, "Отс.", totalProg, "Отс.");
                        }
                        
                        i++;
                    }
                }
            }
        }

        private void Login(object sender, EventArgs e)
        {
            var form = new LoginForm(this);
            form.ShowDialog();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void OpenPatterns(object sender, EventArgs e)
        {
            this.Visible = false;
            var form = new PatternsViewer();
            form.ShowDialog();
            this.Visible = true;
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Show(object sender, DataGridViewCellEventArgs e)
        {
            if (isDataSet)
            {
                var index = houseSelectGrid.CurrentCell.RowIndex;

                var form = new DataViewer(this, data, index);
                form.ShowData();
            }
        }

        private void PeriodList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

/*switch (dataTable.Rows[startRow][1].ToString())
                   {
                       case "Сейфуллина":
                           house = "г.Алматы,Турксибский район,пр.Сейфуллина,дом ";
                           break;
                       case "Жарылгасова":
                           house = "г.Алматы,Турксибский район,ул.Жарылгасова,дом ";
                           break;
                       case "Сервантеса":
                           house = "г.Алматы,Турксибский район,ул.Сервантеса,дом ";
                           break;
                       case "Успенского":
                           house = "г.Алматы,Турксибский район,ул.Успенского,дом ";
                           break;
                   }*/
//if (house == "") break;
/*values.Add("Номер", house + dataTable.Rows[startRow][2].ToString());
                    values.Add("Нако.нач.пер.", dataTable.Rows[startRow][4].ToString());////////////////////1
                    values.Add("ВсегоДоход", dataTable.Rows[startRow][40].ToString());/////////////////////1
                    values.Add("АУП", dataTable.Rows[startRow][21].ToString());/////////////////////////////////1

                    values.Add("СоцНал.МедОтч.",///1
                        (
                        Convert.ToDouble(dataTable.Rows[startRow][23].ToString())
                        ).ToString());

                    values.Add("БанкУслуг", dataTable.Rows[startRow][24].ToString());///////////1
                    //values.Add("ВсегоДоход", dataTable.Rows[startRow][15].ToString());

                    values.Add("ОплРасчКассОбсл",////////////////////////////////////1
                        (
                        Convert.ToDouble(dataTable.Rows[startRow][25].ToString()) +
                        Convert.ToDouble(dataTable.Rows[startRow][27].ToString())
                        ).ToString());

                    values.Add("РасхСодОфф",////////////////////////////1
                        (
                        Convert.ToDouble(dataTable.Rows[startRow][28].ToString())
                        ).ToString());

                    values.Add("ЗарбПлатСотр",///////////////////////////////второй
                        (
                        Convert.ToDouble(dataTable.Rows[startRow][22].ToString()) //+
                                                                                  //Convert.ToDouble(dataTable.Rows[startRow][18].ToString())
                        ).ToString());

                    values.Add("ДежрОсвещ", dataTable.Rows[startRow][19].ToString());/////////////////////////////////////1
                    values.Add("РасхНаМат", dataTable.Rows[startRow][30].ToString());/////////////////////////1
                    //values.Add("ДогврПодряд", dataTable.Rows[startRow][29].ToString());/////////////////////

                    /*values.Add("ПрочРасх",
                        (
                        Convert.ToDouble(dataTable.Rows[startRow][30].ToString()) +
                        Convert.ToDouble(dataTable.Rows[startRow][33].ToString()) +
                        Convert.ToDouble(dataTable.Rows[startRow][35].ToString())
                        ).ToString());*/

/*  values.Add("ХозРасхд",//////////////////////////////////////////////////1
      (
      Convert.ToDouble(dataTable.Rows[startRow][29].ToString())
      ).ToString());
values.Add("ОстТекСч", (/////////////////////////////////////
      (
      Convert.ToDouble(dataTable.Rows[startRow][35].ToString())
      ).ToString()));*/
