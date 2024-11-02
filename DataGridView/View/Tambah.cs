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

namespace DataGridView
{
    public partial class Tambah : Form
    {
        public int id;
        Controller control;
        public Tambah(Controller controll)
        {
            InitializeComponent();
            control = controll;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (control.validate() && button2.Text == "Tambahkan")
            {
                control.simpan_tambah_data(Nama.Text, Asal.Text, int.Parse(Semester.Text),(int)comboBox1.SelectedValue);
                this.Close();
            }
            else if(control.validate())
            {
                control.ubah_data(Nama.Text,Asal.Text,Semester.Text,(int)comboBox1.SelectedValue,id);
                this.Close();
            }
        }
    }
}
