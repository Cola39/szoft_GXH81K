namespace Adatkotes
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInSquareKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSzerkesztes = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonMegnyitas = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.areaInSquareKmDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.countryDataBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            this.areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            this.areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            this.countryDataBindingSource.DataSource = typeof(Adatkotes.CountryData);
            // 
            // buttonSzerkesztes
            // 
            this.buttonSzerkesztes.Location = new System.Drawing.Point(692, 395);
            this.buttonSzerkesztes.Name = "buttonSzerkesztes";
            this.buttonSzerkesztes.Size = new System.Drawing.Size(83, 26);
            this.buttonSzerkesztes.TabIndex = 1;
            this.buttonSzerkesztes.Text = "Szerkesztés";
            this.buttonSzerkesztes.UseVisualStyleBackColor = true;
            this.buttonSzerkesztes.Click += new System.EventHandler(this.buttonSzerkesztes_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(603, 395);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(83, 26);
            this.buttonTorles.TabIndex = 2;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonMegnyitas
            // 
            this.buttonMegnyitas.Location = new System.Drawing.Point(692, 47);
            this.buttonMegnyitas.Name = "buttonMegnyitas";
            this.buttonMegnyitas.Size = new System.Drawing.Size(83, 26);
            this.buttonMegnyitas.TabIndex = 3;
            this.buttonMegnyitas.Text = "Megnyitás";
            this.buttonMegnyitas.UseVisualStyleBackColor = true;
            this.buttonMegnyitas.Click += new System.EventHandler(this.buttonMegnyitas_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(603, 47);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(83, 26);
            this.buttonMentes.TabIndex = 4;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonMegnyitas);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonSzerkesztes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSzerkesztes;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.Button buttonMegnyitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource countryDataBindingSource;
        private System.Windows.Forms.Button buttonMentes;
    }
}

