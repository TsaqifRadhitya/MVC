using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataGridView.Model_folder
{
    public class Model : Connection
    {
        public static List<prodi> prodi;
        public Model()
        {
            setup_db();
        }
        public void GetDataprodi()
        {
            prodi = new List<prodi>();
            NpgsqlDataReader data = Execute_With_Return("select * from prodi");
            while (data.Read())
            {
                prodi data_permahasiswa = new prodi
                {
                    ProdiId = data.GetInt16(0),
                    Nama = data.GetString(1)
                };
                prodi.Add(data_permahasiswa);
            }
            conn.Close();
        }
        public List<Mahasiswa> GetDataMahasiswa()
        {
            List<Mahasiswa> mahasiswa = new List<Mahasiswa>();
            NpgsqlDataReader data = Execute_With_Return("select * from mahasiswa m Join Prodi p on m.fk_prodi = p.id_prodi");
            while (data.Read())
            {
                Mahasiswa data_permahasiswa = new Mahasiswa
                {
                    MahasiswaId = data.GetInt16(0),
                    Nama = data.GetString(1),
                    Asal = data.GetString(2),
                    Semester = data.GetInt32(3),
                    prodi = data.GetString(6)
                };
                mahasiswa.Add(data_permahasiswa);
            }
            conn.Close();
            return mahasiswa;
        }
        public void DeleteData(string id)
        {
            Execute_No_Return($"Delete from mahasiswa where id_mahasiswa = {int.Parse(id)}");
        }
        public void InsertData(Mahasiswa Data)
        {
            Execute_No_Return($"INSERT INTO Mahasiswa(nama,asal,semester,fk_prodi) VALUES ('{Data.Nama}','{Data.Asal}',{Data.Semester},{int.Parse(Data.prodi)})");
        }
        public void updateData(string nama, string asal, string semester, int prodi, int id)
        {
            Execute_No_Return($"UPDATE Mahasiswa set nama = '{nama}',asal = '{asal}',semester = {int.Parse(semester)},fk_prodi = {prodi} where id_mahasiswa = {id}");
        }
    }

    public class Mahasiswa
    {
        public int MahasiswaId { get; set; }
        public string Nama { get; set; }
        public string Asal { get; set; }
        public int Semester { get; set; }
        public string prodi { get; set; }
    }

    public class prodi
    {
        public int ProdiId { get; set; }
        public string Nama { get; set; }
    }

    public abstract class Connection
    {
        private readonly string addres = "Host=localhost;Username=postgres;Password=;Database=Project Catatan Tugas";
        protected NpgsqlConnection conn;

        public bool Execute_No_Return(string query)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }

        }

        public NpgsqlDataReader Execute_With_Return(string query)
        {
            conn = new NpgsqlConnection(addres);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            NpgsqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public void setup_db()
        {
            Execute_No_Return("CREATE TABLE IF NOT EXISTS Prodi(id_prodi serial UNIQUE,nama_prodi varchar not null)");
            Execute_No_Return("CREATE TABLE IF NOT EXISTS Mahasiswa(id_mahasiswa serial,nama varchar not null,asal varchar not null,semester integer not null,fk_prodi integer not null,CONSTRAINT fk_prodi FOREIGN KEY (fk_prodi) REFERENCES Prodi(id_prodi))");
        }
    }
}
