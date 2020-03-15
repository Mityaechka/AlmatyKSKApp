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
    public partial class WaitForm : Form
    {
        public WaitForm()
        {
            InitializeComponent();
        }
        public WaitForm(DataViewer f)
        {
            InitializeComponent();
            f.upload(this);
        }
        public WaitForm(parseForm f)
        {
            InitializeComponent();
            f.upload(this);
        }
    }
}
