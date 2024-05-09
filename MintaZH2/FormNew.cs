using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintaZH2
{
    public partial class FormNew : Form
    {
        public Versenyzok UjVersenyzo = new Versenyzok();
        public FormNew()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = UjVersenyzo;
        }
    }
}
