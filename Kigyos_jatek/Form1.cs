namespace Kigyos_jatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;

        int irany_x = 1;
        int irany_y = 0;

        int hossz = 3;

        int lepesszam = 0;

        List<KigyoElem> kigyo = new List<KigyoElem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;

            fej_x += irany_x * KigyoElem.Meret;
            fej_y += irany_y * KigyoElem.Meret;

            foreach (object item in Controls)
            {
                if (item is KigyoElem)
                {
                    KigyoElem k = (KigyoElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }

                if (item is Kaja)
                {
                    Kaja a = (Kaja)item;

                    if (a.Top == fej_y && a.Left == fej_x)
                    {
                        hossz++;
                        Controls.Remove(a);
                        return;
                    }
                }

                if (item is Mereg)
                {
                    Mereg m = (Mereg)item;

                    if (m.Top == fej_y && m.Left == fej_x)
                    {
                        hossz--;
                        Controls.Remove(m);
                        return;
                    }
                }
            }

            KigyoElem ke = new KigyoElem();
            ke.Top = fej_y;
            ke.Left = fej_x;

            if (lepesszam % 2 == 0) ke.BackColor = Color.Yellow;

            kigyo.Add(ke);
            Controls.Add(ke);

            if (kigyo.Count > hossz)
            {
                KigyoElem levagando = kigyo[0];
                kigyo.RemoveAt(0);
                Controls.Remove(levagando);
            }

            if (lepesszam % 10 == 0)
            {
                Random rnd = new Random();

                Kaja alma = new Kaja();
                alma.Top = rnd.Next(ClientRectangle.Height / 20) * 20;
                alma.Left = rnd.Next(ClientRectangle.Width / 20) * 20;
                Controls.Add(alma);
            }

            if (lepesszam % 10 == 5)
            {
                Random rnd = new Random();

                Mereg mereg = new Mereg();
                mereg.Top = rnd.Next(ClientRectangle.Height / 20) * 20;
                mereg.Left = rnd.Next(ClientRectangle.Width / 20) * 20;
                Controls.Add(mereg);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irany_x = 0;
                irany_y = -1;
            }

            if (e.KeyCode == Keys.Down)
            {
                irany_x = 0;
                irany_y = 1;
            }

            if (e.KeyCode == Keys.Left)
            {
                irany_x = -1;
                irany_y = 0;
            }

            if (e.KeyCode == Keys.Right)
            {
                irany_x = 1;
                irany_y = 0;
            }
        }
    }
}