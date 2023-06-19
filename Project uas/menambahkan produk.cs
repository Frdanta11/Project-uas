using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_uas
{
    public partial class menambahkan_produk : Form
    {
 
        MySqlConnection conn= new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        public menambahkan_produk()
        {
            InitializeComponent();

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String constring = "Server=localhost;database=dbhomecatering;uid=root;pwd=\"\"";
            MySqlConnection cnn = new MySqlConnection(constring);
            MySqlCommand cmd;
            cmd = cnn.CreateCommand();
            cmd.CommandText = "INSERT INTO tbpesanan (nama produk,kategori,paket) VALUES (@namaproduk,@kategori,@paket)";
            cmd.Parameters.AddWithValue("nama produk", textBoxNamaProduk.Text);
            cmd.Parameters.AddWithValue("harga", textBoxKategori.Text);
            cmd.Parameters.AddWithValue("harga", textBoxPaket.Text);
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Input Data");
                //crud
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Input data" + ex.Message);
            }
        }


            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {

        }
    }
}
