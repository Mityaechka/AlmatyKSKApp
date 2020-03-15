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
    public partial class ErrorForm : Form
    {
        public ErrorForm(List<string> errors)
        {
            InitializeComponent();
            int i = 1;
            foreach(var e in errors)
            {
                errorGrid.Rows.Add(i, e);
                i++;
            }
        }
    }
}
