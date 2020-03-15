using AlmatyKSKForms.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmatyKSKForms
{
    public partial class LoginForm : Form
    {
        parseForm form;
        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(parseForm form)
        {
            InitializeComponent();
            this.form = form;
            var data = JsonConvert.DeserializeObject<LoginPassword>( Properties.Settings.Default.LoginPassword);
            if (data != null)
            {
                binField.Text = data.login;
                passwordField.Text = data.password;
            }
        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                HttpController http = new HttpController();
                var code = await http.LoginAsync(binField.Text, passwordField.Text);
                if (code.code == HttpStatusCode.OK)
                {
                    if (remember.Checked)
                    {
                        Properties.Settings.Default.LoginPassword = JsonConvert.SerializeObject(new LoginPassword(binField.Text,
                            passwordField.Text));
                        Properties.Settings.Default.Save();
                    }
                    if (form != null)
                    {
                        form.RefreshInfo(null, null);
                    }
                    Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                  "Проверьте введенные данные",
                  "Ошибка!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
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
    }
}
