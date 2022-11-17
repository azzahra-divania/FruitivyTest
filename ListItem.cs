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
    public partial class ListItem : Form
    {
        public ListItem()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSignUp loginSignUp = new LoginSignUp();
            loginSignUp.Show();
            this.Visible = false;
        }
    }
}
