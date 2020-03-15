using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    class Period
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Name { get; private set; }
        public string AnualPeriod{get;set;}

        public Period(string from, string to, string name, string anualPeriod)
        {
            From = from;
            To = to;
            Name = name;
            AnualPeriod = anualPeriod;
        }
    }
}
