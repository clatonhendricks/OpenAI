using DalleWeb;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DallePPT
{
    public partial class RibMain
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnDalle_Click(object sender, RibbonControlEventArgs e)
        {
            frmDalle f = new frmDalle();
            f.ShowDialog();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            frmAbout a = new frmAbout();
            a.ShowDialog();
        }
    }
}
