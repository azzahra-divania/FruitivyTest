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
    public partial class Keranjang : Form
    {
        public Keranjang()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
