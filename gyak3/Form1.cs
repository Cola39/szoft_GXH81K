namespace gyak3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();

                    button.Width = 30;
                    button.Height = 30;
                    button.Top = i*30;
                    button.Left = j*30;

                    button.Text = (i*j).ToString();

                    if (i >= j)
                    {
                        Controls.Add(button);
                    }
                }
            }
        }
    }
}