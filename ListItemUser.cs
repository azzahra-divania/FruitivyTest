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
    public partial class ListItemUser : Form
    {
        public ListItemUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Keranjang keranjang = new Keranjang();
            keranjang.Show();
            this.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ListItemUser listItemUser = new ListItemUser();
            listItemUser.Show();
            this.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
