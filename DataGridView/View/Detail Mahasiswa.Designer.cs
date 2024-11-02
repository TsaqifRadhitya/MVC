namespace DataGridView.View_folder
{
    partial class Form_Tambah_Mahasiswa
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
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            nama = new Label();
            asal = new Label();
            label4 = new Label();
            Semester = new Label();
            label6 = new Label();
            prodi = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 102);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 30);
            label1.TabIndex = 1;
            label1.Text = "Tambah Data Mahasiswa";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(162, 574);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(176, 54);
            button2.TabIndex = 10;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(87, 30);
            label2.TabIndex = 11;
            label2.Text = "Nama : ";
            // 
            // nama
            // 
            nama.AutoSize = true;
            nama.Location = new Point(132, 193);
            nama.Name = "nama";
            nama.Size = new Size(87, 30);
            nama.TabIndex = 12;
            nama.Text = "Nama : ";
            // 
            // asal
            // 
            asal.AutoSize = true;
            asal.Location = new Point(132, 241);
            asal.Name = "asal";
            asal.Size = new Size(87, 30);
            asal.TabIndex = 14;
            asal.Text = "Nama : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 241);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 13;
            label4.Text = "Asal : ";
            // 
            // Semester
            // 
            Semester.AutoSize = true;
            Semester.Location = new Point(132, 291);
            Semester.Name = "Semester";
            Semester.Size = new Size(0, 30);
            Semester.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 291);
            label6.Name = "label6";
            label6.Size = new Size(115, 30);
            label6.TabIndex = 15;
            label6.Text = "Semester :";
            // 
            // prodi
            // 
            prodi.AutoSize = true;
            prodi.Location = new Point(132, 333);
            prodi.Name = "prodi";
            prodi.Size = new Size(87, 30);
            prodi.TabIndex = 18;
            prodi.Text = "Nama : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 333);
            label8.Name = "label8";
            label8.Size = new Size(81, 30);
            label8.TabIndex = 17;
            label8.Text = "Prodi : ";
            // 
            // Form_Tambah_Mahasiswa
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 729);
            Controls.Add(prodi);
            Controls.Add(label8);
            Controls.Add(Semester);
            Controls.Add(label6);
            Controls.Add(asal);
            Controls.Add(label4);
            Controls.Add(nama);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F);
            Margin = new Padding(6);
            Name = "Form_Tambah_Mahasiswa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Tambah_Mahasiswa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label label8;
        public Label nama;
        public Label asal;
        public Label Semester;
        public Label prodi;
    }
}