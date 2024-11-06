
using System.ComponentModel;
using System.Data;
using DataGridView.Controller_folder;
namespace DataGridView.View_folder
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.event_click(e,dataGridView1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tambah_data(object sender, EventArgs e)
        {
            controller.tambah_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.refresh();
        }
    }
}
