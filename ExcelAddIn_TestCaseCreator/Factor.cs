using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAddIn_TestCaseCreator
{
    public class Factor
    {
        public string Name { set; get; }
        public string ValuesStr
        {
            set
            {
                ValuesStr = value;
                Values = new List<string>(value.Split(',')) { };
            }
            get
            {
                return ValuesStr;
            }
        }
        public List<string> Values { set; get; }
    }
}
