namespace MintaZH2
{
    partial class FormNew
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelVersenyzo = new Label();
            labelNev = new Label();
            labelNemzetiseg = new Label();
            labelEredmeny = new Label();
            labelKategoria = new Label();
            textBoxVersenyzo = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBoxNev = new TextBox();
            textBoxNemzetiseg = new TextBox();
            textBoxEredmeny = new TextBox();
            textBoxKategoria = new TextBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // labelVersenyzo
            // 
            labelVersenyzo.AutoSize = true;
            labelVersenyzo.Location = new Point(13, 26);
            labelVersenyzo.Name = "labelVersenyzo";
            labelVersenyzo.Size = new Size(124, 15);
            labelVersenyzo.TabIndex = 0;
            labelVersenyzo.Text = "Versenyző Azonosítója";
            // 
            // labelNev
            // 
            labelNev.AutoSize = true;
            labelNev.Location = new Point(13, 105);
            labelNev.Name = "labelNev";
            labelNev.Size = new Size(28, 15);
            labelNev.TabIndex = 1;
            labelNev.Text = "Név";
            // 
            // labelNemzetiseg
            // 
            labelNemzetiseg.AutoSize = true;
            labelNemzetiseg.Location = new Point(13, 177);
            labelNemzetiseg.Name = "labelNemzetiseg";
            labelNemzetiseg.Size = new Size(69, 15);
            labelNemzetiseg.TabIndex = 2;
            labelNemzetiseg.Text = "Nemzetiség";
            // 
            // labelEredmeny
            // 
            labelEredmeny.AutoSize = true;
            labelEredmeny.Location = new Point(13, 260);
            labelEredmeny.Name = "labelEredmeny";
            labelEredmeny.Size = new Size(60, 15);
            labelEredmeny.TabIndex = 3;
            labelEredmeny.Text = "Eredmény";
            // 
            // labelKategoria
            // 
            labelKategoria.AutoSize = true;
            labelKategoria.Location = new Point(13, 346);
            labelKategoria.Name = "labelKategoria";
            labelKategoria.Size = new Size(57, 15);
            labelKategoria.TabIndex = 4;
            labelKategoria.Text = "Kategória";
            // 
            // textBoxVersenyzo
            // 
            textBoxVersenyzo.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBoxVersenyzo.Location = new Point(13, 44);
            textBoxVersenyzo.Name = "textBoxVersenyzo";
            textBoxVersenyzo.Size = new Size(214, 23);
            textBoxVersenyzo.TabIndex = 5;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Versenyzok);
            // 
            // textBoxNev
            // 
            textBoxNev.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBoxNev.Location = new Point(13, 123);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(214, 23);
            textBoxNev.TabIndex = 6;
            // 
            // textBoxNemzetiseg
            // 
            textBoxNemzetiseg.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBoxNemzetiseg.Location = new Point(13, 195);
            textBoxNemzetiseg.Name = "textBoxNemzetiseg";
            textBoxNemzetiseg.Size = new Size(214, 23);
            textBoxNemzetiseg.TabIndex = 7;
            // 
            // textBoxEredmeny
            // 
            textBoxEredmeny.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBoxEredmeny.Location = new Point(13, 278);
            textBoxEredmeny.Name = "textBoxEredmeny";
            textBoxEredmeny.Size = new Size(214, 23);
            textBoxEredmeny.TabIndex = 8;
            // 
            // textBoxKategoria
            // 
            textBoxKategoria.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBoxKategoria.Location = new Point(13, 364);
            textBoxKategoria.Name = "textBoxKategoria";
            textBoxKategoria.Size = new Size(214, 23);
            textBoxKategoria.TabIndex = 9;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(88, 429);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(131, 29);
            buttonOk.TabIndex = 10;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 485);
            Controls.Add(buttonOk);
            Controls.Add(textBoxKategoria);
            Controls.Add(textBoxEredmeny);
            Controls.Add(textBoxNemzetiseg);
            Controls.Add(textBoxNev);
            Controls.Add(textBoxVersenyzo);
            Controls.Add(labelKategoria);
            Controls.Add(labelEredmeny);
            Controls.Add(labelNemzetiseg);
            Controls.Add(labelNev);
            Controls.Add(labelVersenyzo);
            Name = "FormNew";
            Text = "FormNew";
            Load += FormNew_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVersenyzo;
        private Label labelNev;
        private Label labelNemzetiseg;
        private Label labelEredmeny;
        private Label labelKategoria;
        private TextBox textBoxVersenyzo;
        private TextBox textBoxNev;
        private TextBox textBoxNemzetiseg;
        private TextBox textBoxEredmeny;
        private TextBox textBoxKategoria;
        private Button buttonOk;
        private BindingSource bindingSource1;
    }
}