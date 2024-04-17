using System.Windows.Forms;

namespace HajósTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> ÖsszesKérdés;
        List<Kérdés> AktívKérdések = new List<Kérdés>();

        int AktívKérdés = 0;
        public Form1()
        {
            InitializeComponent();
        }

        List<Kérdés> KérdésBeolvasás()
        {
            List<Kérdés> kérdések = new List<Kérdés>();
            StreamReader sr = new StreamReader("kérdések.txt", true);

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? string.Empty;
                string[] tömb = sor.Split("\t");
                if (tömb.Length != 7) continue;

                Kérdés k = new Kérdés();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int.TryParse(tömb[6], out int jóválasz);
                k.HelyesVálasz = jóválasz;

                kérdések.Add(k);
            }

            sr.Close();
            return kérdések;
        }

        void KérdésMegjelenítés(Kérdés kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            valaszGomb1.Text = kérdés.Válasz1;
            valaszGomb2.Text = kérdés.Válasz2;
            valaszGomb3.Text = kérdés.Válasz3;
            if (!string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKérdés = KérdésBeolvasás();

            for (int i = 0; i < 7; i++)
            {
                AktívKérdések.Add(ÖsszesKérdés[0]);
                ÖsszesKérdés.RemoveAt(0);
            }
            dataGridView1.DataSource = AktívKérdések;
            KérdésMegjelenítés(AktívKérdések[AktívKérdés]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AktívKérdés++;
            if (AktívKérdés == 7) AktívKérdés = 0;

            valaszGomb1.BackColor = Color.LightGray;
            valaszGomb2.BackColor = Color.LightGray;
            valaszGomb3.BackColor = Color.LightGray;

            if (AktívKérdések[AktívKérdés].HelyesVálaszokSzáma == 3)
            {
                AktívKérdések[AktívKérdés] = ÖsszesKérdés[0];
                ÖsszesKérdés.RemoveAt(0);
            }
            KérdésMegjelenítés(AktívKérdések[AktívKérdés]);

        }

        private void valaszGomb1_Click(object sender, EventArgs e)
        {
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 1) 
            { 
                valaszGomb1.BackColor = Color.Green;
                AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++;
            }
            else valaszGomb1.BackColor = Color.Red;
        }

        private void valaszGomb2_Click(object sender, EventArgs e)
        {
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 2)
            {
                valaszGomb2.BackColor = Color.Green;
                AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++;
            }
            else valaszGomb2.BackColor = Color.Red;
        }

        private void valaszGomb3_Click(object sender, EventArgs e)
        {
            if (AktívKérdések[AktívKérdés].HelyesVálasz == 3)
            {
                valaszGomb3.BackColor = Color.Green;
                AktívKérdések[AktívKérdés].HelyesVálaszokSzáma++;
            }
            else valaszGomb3.BackColor = Color.Red;
        }
    }
}