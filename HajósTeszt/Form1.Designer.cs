namespace HajósTeszt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            valaszGomb1 = new ValaszGomb();
            label1 = new Label();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 275);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 171);
            dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Location = new Point(352, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 260);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.LightGray;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(10, 62);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(336, 50);
            valaszGomb1.TabIndex = 6;
            valaszGomb1.Click += valaszGomb1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.LightGray;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(10, 118);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(336, 50);
            valaszGomb2.TabIndex = 10;
            valaszGomb2.Click += valaszGomb2_Click;
            // 
            // valaszGomb3
            // 
            valaszGomb3.BackColor = Color.LightGray;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(10, 174);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(336, 50);
            valaszGomb3.TabIndex = 11;
            valaszGomb3.Click += valaszGomb3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(195, 239);
            button1.Name = "button1";
            button1.Size = new Size(151, 31);
            button1.TabIndex = 12;
            button1.Text = "Következő";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 455);
            Controls.Add(button1);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(label1);
            Controls.Add(valaszGomb1);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ValaszGomb valaszGomb1;
        private Label label1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private Button button1;
    }
}
