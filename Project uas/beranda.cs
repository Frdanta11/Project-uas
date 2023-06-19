using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_uas
{
    public partial class beranda : Form
    {
        public beranda()
        {
            InitializeComponent();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            pesanan_pembeli pesanan_Pembeli = new pesanan_pembeli();
            pesanan_Pembeli.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }
    }
}
