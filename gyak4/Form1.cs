namespace gyak4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Button button = new Button();
                    
                    button.Width = 20;
                    button.Height = 20;
                    button.Top = i * 20;
                    button.Left = ClientRectangle.Width / 2 + j * 20 - i*10;

                    button.Text = (i * j).ToString();

                    Controls.Add(button);
                }
            }
        }
    }
}