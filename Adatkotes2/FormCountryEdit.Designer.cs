namespace Adatkotes2
{
    partial class FormCountryEdit
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
            buttonOk = new Button();
            labelName = new Label();
            labelArea = new Label();
            labelPop = new Label();
            textBoxName = new TextBox();
            bindingSource1 = new BindingSource(components);
            textBoxArea = new TextBox();
            textBoxPop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(243, 365);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(139, 36);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(67, 23);
            labelName.Name = "labelName";
            labelName.Size = new Size(86, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Country name:";
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(67, 254);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(73, 15);
            labelArea.TabIndex = 2;
            labelArea.Text = "Area in km2:";
            // 
            // labelPop
            // 
            labelPop.AutoSize = true;
            labelPop.Location = new Point(67, 142);
            labelPop.Name = "labelPop";
            labelPop.Size = new Size(68, 15);
            labelPop.TabIndex = 3;
            labelPop.Text = "Population:";
            // 
            // textBoxName
            // 
            textBoxName.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBoxName.Location = new Point(71, 51);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(230, 23);
            textBoxName.TabIndex = 4;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // textBoxArea
            // 
            textBoxArea.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBoxArea.Location = new Point(71, 286);
            textBoxArea.Name = "textBoxArea";
            textBoxArea.Size = new Size(230, 23);
            textBoxArea.TabIndex = 5;
            // 
            // textBoxPop
            // 
            textBoxPop.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBoxPop.Location = new Point(71, 175);
            textBoxPop.Name = "textBoxPop";
            textBoxPop.Size = new Size(230, 23);
            textBoxPop.TabIndex = 6;
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 430);
            Controls.Add(textBoxPop);
            Controls.Add(textBoxArea);
            Controls.Add(textBoxName);
            Controls.Add(labelPop);
            Controls.Add(labelArea);
            Controls.Add(labelName);
            Controls.Add(buttonOk);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Label labelName;
        private Label labelArea;
        private Label labelPop;
        private TextBox textBoxName;
        private TextBox textBoxArea;
        private TextBox textBoxPop;
        private BindingSource bindingSource1;
    }
}