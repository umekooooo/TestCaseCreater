using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddIn_TestCaseCreator
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void CreateFactorTableButton_Click(object sender, RibbonControlEventArgs e)
        {
        }

        private void CreateTestCaseButton_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new EnterFactorControl();
        }
    }
}
