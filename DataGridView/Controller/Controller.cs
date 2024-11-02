using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridView.Model_folder;
using DataGridView.View_folder;

namespace DataGridView.Controller_folder
{
    public class Controller
    {
        Form1 form1;
        Form_Tambah_Mahasiswa tambah_Mahasiswa;
        Tambah tambah;
        Model model = new Model();
        public Controller(Form1 form)
        {
            tambah_Mahasiswa = new Form_Tambah_Mahasiswa(this);
            form1 = form;
            load_data();
        }
        public void tambah_data()
        {
            tambah = new Tambah(this);
            model.GetDataprodi();
            tambah.comboBox1.DataSource = Model.prodi;
            tambah.comboBox1.DisplayMember = "Nama";
            tambah.comboBox1.ValueMember = "ProdiId";
            tambah.Show();
        }

        public void simpan_tambah_data(string Nama, string Asal, int Semester, int prodi)
        {
            Mahasiswa mahasiswa = new Mahasiswa
            {
                Nama = Nama,
                Asal = Asal,
                Semester = Semester,
                prodi = prodi.ToString()
            };
            model.InsertData(mahasiswa);
            refresh();
        }

        public void hapus_data(string id)
        {
            model.DeleteData(id);
            refresh();
        }

        public void Show_ubah_data(string nama, string asal, string semester, string prodi, int id)
        {
            tambah = new Tambah(this);
            model.GetDataprodi();
            tambah.id = id;
            tambah.comboBox1.DataSource = Model.prodi;
            tambah.comboBox1.DisplayMember = "Nama";
            tambah.comboBox1.ValueMember = "ProdiId";
            tambah.label1.Text = "Ubah Data Mahasiswa";
            tambah.button2.Text = "Simpan";
            tambah.Nama.Text = nama;
            tambah.Asal.Text = asal;
            tambah.Semester.Text = semester.ToString();
            tambah.comboBox1.Text = prodi.ToString();
            tambah.Show();
        }

        public void ubah_data(string nama, string asal, string semester, int prodi, int id)
        {
            model.updateData(nama, asal, semester, prodi, id);
            refresh();
        }

        public bool validate()
        {
            if (tambah.Nama.Text == "" || tambah.Asal.Text == "" || tambah.Semester.Text == "")
            {
                return false;
            }
            else
            {
                try
                {
                    int.Parse(tambah.Semester.Text);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public void load_data()
        {
            form1.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            form1.dataGridView1.AllowUserToAddRows = false;
            form1.dataGridView1.DataSource = model.GetDataMahasiswa();
            form1.dataGridView1.Columns["MahasiswaId"].Visible = false;
            DataGridViewButtonColumn detail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                HeaderText = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn delete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn ubah = new DataGridViewButtonColumn
            {
                Name = "Ubah",
                HeaderText = "Ubah",
                Text = "Ubah",
                UseColumnTextForButtonValue = true
            };

            form1.dataGridView1.Columns.Add(ubah);
            form1.dataGridView1.Columns.Add(delete);
            form1.dataGridView1.Columns.Add(detail);
        }

        public void detail_data(System.Windows.Forms.DataGridView data, DataGridViewCellEventArgs e)
        {
            string nama = data.Rows[e.RowIndex].Cells["Nama"].Value.ToString();
            string asal = data.Rows[e.RowIndex].Cells["Asal"].Value.ToString();
            string semester = data.Rows[e.RowIndex].Cells["Semester"].Value.ToString();
            string nama_prodi = data.Rows[e.RowIndex].Cells["Prodi"].Value.ToString();
            tambah_Mahasiswa = new Form_Tambah_Mahasiswa(this);
            tambah_Mahasiswa.nama.Text = nama;
            tambah_Mahasiswa.asal.Text = asal;
            tambah_Mahasiswa.prodi.Text = nama_prodi;
            tambah_Mahasiswa.Semester.Text = $"{semester}";
            tambah_Mahasiswa.Show();
        }

        public void refresh()
        {
            form1.dataGridView1.DataSource = null;
            form1.dataGridView1.Columns.Clear();
            load_data();
        }

        public void event_click(DataGridViewCellEventArgs a, System.Windows.Forms.DataGridView data)
        {
            if (a.ColumnIndex == data.Columns["Detail"].Index)
            {
                detail_data(form1.dataGridView1, a);
            }
            else if (a.ColumnIndex == data.Columns["Delete"].Index)
            {
                model.DeleteData(data.Rows[a.RowIndex].Cells["MahasiswaId"].Value.ToString());
                refresh();
            }
            else if (a.ColumnIndex == data.Columns["Ubah"].Index)
            {
                Show_ubah_data(data.Rows[a.RowIndex].Cells["Nama"].Value.ToString(),
                    data.Rows[a.RowIndex].Cells["Asal"].Value.ToString(),
                    data.Rows[a.RowIndex].Cells["Semester"].Value.ToString(),
                    data.Rows[a.RowIndex].Cells["Prodi"].Value.ToString(),
                    int.Parse(data.Rows[a.RowIndex].Cells["MahasiswaId"].Value.ToString()));
            }
        }
    }
}
