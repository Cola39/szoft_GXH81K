namespace Gyakorlo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0;i<10;i++)
            {
                for (int j=0;j<10;j++)
                {
                    SzamoloGomb uj = new SzamoloGomb();
                    uj.Width = 20;
                    uj.Height = 20;

                    uj.Left = j * 20;
                    uj.Top = i * 20;

                    Controls.Add(uj);
                }
            }
        }
    }
}