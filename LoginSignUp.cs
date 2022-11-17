namespace Fruitivy
{
    public partial class LoginSignUp : Form
    {
        public LoginSignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbPembeliLogin.Checked)
            {
                ListItemUser listItemUser = new ListItemUser();
                listItemUser.Show();
                this.Visible = false;
            }
            else if (rbPenjualLogin.Checked)
            {
                ListItemDijual listItemDijual = new ListItemDijual();
                listItemDijual.Show();
                this.Visible = false;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Visible = false;
        }
    }
}