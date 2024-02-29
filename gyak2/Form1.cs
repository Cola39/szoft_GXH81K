using System.Security.Cryptography;

namespace gyak2
{
    public partial class Form1 : Form
    {
        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
            {
                int width = rng.Next(20, 100);
                int height = rng.Next(20, 100);

                int top = rng.Next(this.ClientSize.Height - height);
                int left = rng.Next(this.ClientSize.Width - width);

                int r = rng.Next(256);
                int g = rng.Next(256);
                int b = rng.Next(256);

                Button button = new Button();
                button.Width = width;
                button.Height = height;
                button.Top = top;
                button.Left = left;
                button.BackColor = Color.FromArgb(r, g, b);

                Controls.Add(button);
            }
        }
    }
}