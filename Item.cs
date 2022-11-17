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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            checkout.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
            this.Visible = false;
        }
    }
}
