using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    public class Pattern
    {
        public string Name;
        public string id;
        public int StreetIndex, HomeIndex;
        public List<ReportElement> Elements = new List<ReportElement>();
        public Dictionary<string, string> StreetNames = new Dictionary<string, string>();

        public Pattern()
        {
        }

        public Pattern(bool setId)
        {
            if(setId)
            id = Guid.NewGuid().ToString();
        }
    }
}
