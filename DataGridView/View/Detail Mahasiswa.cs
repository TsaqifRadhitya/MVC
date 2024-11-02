using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridView.Controller_folder;

namespace DataGridView.View_folder
{
    public partial class Form_Tambah_Mahasiswa : Form
    {
        Controller parent;        
        public Form_Tambah_Mahasiswa(Controller parrent)
        {
            InitializeComponent();
            this.parent = parrent;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (inputemail.Text != "" && inputnama.Text != "" && inputsemester.Text != "" && inputemail.Text != "")
            //{
            //    try
            //    {
            //        Mahasiswa mahasiswa = new Mahasiswa();
            //        mahasiswa.Nama = inputnama.Text;
            //        mahasiswa.email = inputemail.Text;
            //        mahasiswa.Semester = int.Parse(inputsemester.Text);
            //        mahasiswa.NIM = inputnim.Text;
            //        this.parent.mahasiswas.Add(mahasiswa);
            //        this.Hide();
            //    }
            //    catch (Exception ex) {
            //    }
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
