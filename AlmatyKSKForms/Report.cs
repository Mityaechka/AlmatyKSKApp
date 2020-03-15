using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    public class Report
    {
        public Dictionary<ReportElement, double> Data = new Dictionary<ReportElement, double>();
        public Dictionary<ReportElement, string> TextData = new Dictionary<ReportElement, string>();
        public string House;
        public double Total;
        public double TotalBalance
        {
            get
            {
                double totalBalance = 0;
                foreach (var h in Data.Where(x => x.Key.ValueName.RequestName != "CurrencyAccountBalanceBegin" &&
                     x.Key.ValueName.RequestName != "MonthlyInstalmentsForRepairs" &&
                     x.Key.ValueName.RequestName != "CurrencyAccountBalanceEnd"))
                {
                    totalBalance -= Math.Round(h.Value);
                }
                var d1 = Data.
                    Where(x => x.Key.ValueName.RequestName == "CurrencyAccountBalanceBegin");
                if (d1.Count() == 1)
                    totalBalance += Math.Round(d1.FirstOrDefault().Value);

                var d2 = Data.
                     Where(x => x.Key.ValueName.RequestName == "MonthlyInstalmentsForRepairs");
                if (d2.Count() == 1)
                    totalBalance += Math.Round(d2.FirstOrDefault().Value);
                return totalBalance;
            }
        }
    }
}
