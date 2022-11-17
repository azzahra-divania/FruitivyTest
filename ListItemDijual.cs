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
    public partial class ListItemDijual : Form
    {
        public ListItemDijual()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void button11_Click(object sender, EventArgs e)
        {
            EditBarang editBarang = new EditBarang();
            editBarang.Show();
            this.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TambahBarang tambahBarang = new TambahBarang();
            tambahBarang.Show();
            this.Visible = false;
        }
    }
}
