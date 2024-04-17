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
            this.buttonSzerkesztes = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.buttonMegnyitas = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInSquareKmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 53);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(569, 442);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSzerkesztes
            // 
            this.buttonSzerkesztes.Location = new System.Drawing.Point(411, 503);
            this.buttonSzerkesztes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSzerkesztes.Name = "buttonSzerkesztes";
            this.buttonSzerkesztes.Size = new System.Drawing.Size(171, 32);
            this.buttonSzerkesztes.TabIndex = 1;
            this.buttonSzerkesztes.Text = "Szerkesztés";
            this.buttonSzerkesztes.UseVisualStyleBackColor = true;
            this.buttonSzerkesztes.Click += new System.EventHandler(this.buttonSzerkesztes_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(13, 503);
            this.buttonTorles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(171, 32);
            this.buttonTorles.TabIndex = 2;
            this.buttonTorles.Text = "Törlés";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // buttonMegnyitas
            // 
            this.buttonMegnyitas.Location = new System.Drawing.Point(411, 13);
            this.buttonMegnyitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMegnyitas.Name = "buttonMegnyitas";
            this.buttonMegnyitas.Size = new System.Drawing.Size(171, 32);
            this.buttonMegnyitas.TabIndex = 3;
            this.buttonMegnyitas.Text = "Megnyitás";
            this.buttonMegnyitas.UseVisualStyleBackColor = true;
            this.buttonMegnyitas.Click += new System.EventHandler(this.buttonMegnyitas_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(13, 13);
            this.buttonMentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(171, 32);
            this.buttonMentes.TabIndex = 4;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 548);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonMegnyitas);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonSzerkesztes);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

