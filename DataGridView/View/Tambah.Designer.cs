namespace DataGridView
{
    partial class Tambah
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
            label2 = new Label();
            Nama = new TextBox();
            Asal = new TextBox();
            label3 = new Label();
            Semester = new TextBox();
            label4 = new Label();
            Prodi = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 51);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Tambah Data Mahasiswa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 102);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama : ";
            // 
            // Nama
            // 
            Nama.Location = new Point(136, 99);
            Nama.Name = "Nama";
            Nama.Size = new Size(611, 23);
            Nama.TabIndex = 2;
            // 
            // Asal
            // 
            Asal.Location = new Point(136, 128);
            Asal.Name = "Asal";
            Asal.Size = new Size(611, 23);
            Asal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 131);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Asal : ";
            // 
            // Semester
            // 
            Semester.Location = new Point(136, 157);
            Semester.Name = "Semester";
            Semester.Size = new Size(611, 23);
            Semester.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 160);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Semester :";
            // 
            // Prodi
            // 
            Prodi.AutoSize = true;
            Prodi.Location = new Point(69, 189);
            Prodi.Name = "Prodi";
            Prodi.Size = new Size(41, 15);
            Prodi.TabIndex = 7;
            Prodi.Text = "Prodi :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(298, 344);
            button1.Name = "button1";
            button1.Size = new Size(111, 48);
            button1.TabIndex = 9;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 344);
            button2.Name = "button2";
            button2.Size = new Size(111, 48);
            button2.TabIndex = 10;
            button2.Text = "Tambahkan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Tambah
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(Prodi);
            Controls.Add(Semester);
            Controls.Add(label4);
            Controls.Add(Asal);
            Controls.Add(label3);
            Controls.Add(Nama);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tambah";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Prodi;
        public ComboBox comboBox1;
        private Button button1;
        public TextBox Nama;
        public TextBox Asal;
        public TextBox Semester;
        public Label label1;
        public Button button2;
    }
}