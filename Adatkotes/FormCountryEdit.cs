using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotes
{
    public partial class FormCountryEdit : Form
    {
        public CountryData CountryData;
        public FormCountryEdit()
        {
            InitializeComponent();
        }

        private void FormCountryEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
