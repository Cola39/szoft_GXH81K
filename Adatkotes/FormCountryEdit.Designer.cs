namespace Adatkotes
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
            this.components = new System.ComponentModel.Container();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelAreaInKm2 = new System.Windows.Forms.Label();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.textBoxPopulation = new System.Windows.Forms.TextBox();
            this.textBoxAreaInKm2 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCountryName
            // 
            this.labelCountryName.AutoSize = true;
            this.labelCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCountryName.Location = new System.Drawing.Point(23, 28);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(102, 17);
            this.labelCountryName.TabIndex = 0;
            this.labelCountryName.Text = "Country Name:";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPopulation.Location = new System.Drawing.Point(23, 123);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(79, 17);
            this.labelPopulation.TabIndex = 1;
            this.labelPopulation.Text = "Population:";
            // 
            // labelAreaInKm2
            // 
            this.labelAreaInKm2.AutoSize = true;
            this.labelAreaInKm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAreaInKm2.Location = new System.Drawing.Point(23, 215);
            this.labelAreaInKm2.Name = "labelAreaInKm2";
            this.labelAreaInKm2.Size = new System.Drawing.Size(87, 17);
            this.labelAreaInKm2.TabIndex = 2;
            this.labelAreaInKm2.Text = "Area in km2:";
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Name", true));
            this.textBoxCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCountryName.Location = new System.Drawing.Point(26, 59);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(230, 21);
            this.textBoxCountryName.TabIndex = 3;
            // 
            // textBoxPopulation
            // 
            this.textBoxPopulation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Population", true));
            this.textBoxPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPopulation.Location = new System.Drawing.Point(26, 152);
            this.textBoxPopulation.Name = "textBoxPopulation";
            this.textBoxPopulation.Size = new System.Drawing.Size(230, 21);
            this.textBoxPopulation.TabIndex = 4;
            // 
            // textBoxAreaInKm2
            // 
            this.textBoxAreaInKm2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "AreaInSquareKm", true));
            this.textBoxAreaInKm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAreaInKm2.Location = new System.Drawing.Point(26, 244);
            this.textBoxAreaInKm2.Name = "textBoxAreaInKm2";
            this.textBoxAreaInKm2.Size = new System.Drawing.Size(230, 21);
            this.textBoxAreaInKm2.TabIndex = 5;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(210, 305);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(68, 26);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "&Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Adatkotes.CountryData);
            // 
            // FormCountryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 343);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxAreaInKm2);
            this.Controls.Add(this.textBoxPopulation);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.labelAreaInKm2);
            this.Controls.Add(this.labelPopulation);
            this.Controls.Add(this.labelCountryName);
            this.Name = "FormCountryEdit";
            this.Text = "FormCountryEdit";
            this.Load += new System.EventHandler(this.FormCountryEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.Label labelPopulation;
        private System.Windows.Forms.Label labelAreaInKm2;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.TextBox textBoxPopulation;
        private System.Windows.Forms.TextBox textBoxAreaInKm2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}