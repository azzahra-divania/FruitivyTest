using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruitivy
{
    public partial class PesananBerhasil : Form
    {
        public PesananBerhasil()
        {
            InitializeComponent();
        }

        private void PesananBerhasil_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RiwayatPemesanan riwayatPemesanan = new RiwayatPemesanan();
            riwayatPemesanan.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
        }
    }
}
