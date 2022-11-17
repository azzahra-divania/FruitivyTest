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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PanelCode.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelResetPass.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password Reset Succed!");
            LoginSignUp loginSignUp = new LoginSignUp();
            loginSignUp.Show();
            this.Visible = false;
        }
    }
}
