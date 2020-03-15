using AlmatyKSKForms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmatyKSKForms
{

    static class Program
    {
        public const bool DevVersion = false;
        public static List<Period> periods = new List<Period>() {
            new Period("01.01.2019", "31.03.2019","1 кв. 2019","2019"),
            new Period("01.04.2019", "30.06.2019","2 кв. 2019","2019"),
            new Period("01.07.2019", "30.09.2019","3 кв. 2019","2019"),
            new Period("01.10.2019", "31.12.2019","4 кв. 2019","2019"),

            new Period("01.01.2020", "31.03.2020","1 кв. 2020","2020"),
            new Period("01.04.2020", "30.06.2020","2 кв. 2020","2020"),
            new Period("01.07.2020", "30.09.2020","3 кв. 2020","2020"),
            new Period("01.10.2020", "31.12.2020","4 кв. 2020","2020"),
        };
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new parseForm());
        }
    }
}
