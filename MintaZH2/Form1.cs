using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace MintaZH2
{
    public partial class Form1 : Form
    {
        BindingList<Versenyzok> versenyzok = new BindingList<Versenyzok>();
        public Form1()
        {
            InitializeComponent();
            versenyzokBindingSource.DataSource = versenyzok;
            dataGridView1.DataSource = versenyzokBindingSource;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.csv");
                CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Versenyzok>();

                foreach (var item in tömb)
                {
                    versenyzok.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    CsvWriter csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(versenyzok);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (versenyzokBindingSource.Current == null)
            {
                MessageBox.Show("Hiba történt, nincs kijelölt sor!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Biztos szeretné törölni a kijelölt sort?", "Megerősítés szükséges!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                versenyzokBindingSource.RemoveCurrent();
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormNew fn = new FormNew();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                versenyzok.Add(fn.UjVersenyzo);
            }
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            int usa = 0;
            string gyors = string.Empty;
            int gyors_ido = 1000;

            foreach (var item in versenyzok)
            {
                if (item.Nemzetiseg == "USA") usa++;
                if (item.EredmenyPerc < gyors_ido)
                {
                    gyors_ido = item.EredmenyPerc;
                    gyors = item.Nev;
                }
            }
            MessageBox.Show("Az USA-ból " + usa + " versenyző érkezett, és a legjobb időt " + gyors + " futotta!", "", MessageBoxButtons.OK);
        }
    }
}
