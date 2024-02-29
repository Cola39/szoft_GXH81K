using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlo1
{
    internal class SzamoloGomb : Button
    {
        int szám;
        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;

            Click += SzamoloGomb_Click;
            szám = 1;
            Text = szám.ToString();
        }

        private void SzamoloGomb_Click(object sender, EventArgs e)
        {
            if (szám == 5) {
                szám = 0;
            }
            szám ++;
            Text = szám.ToString();
        }

    }
}
