using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkotes2
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader("european_countries.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var x = csv.GetRecords<CountryData>();
                foreach (var item in x)
                {
                    countryList.Add(item);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormCountryEdit formCountryEdit = new FormCountryEdit();
            formCountryEdit.CountryData = (CountryData)countryDataBindingSource.Current;
            formCountryEdit.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            { 
                csv.WriteRecords(countryList); 
            }

        }
    }
}
