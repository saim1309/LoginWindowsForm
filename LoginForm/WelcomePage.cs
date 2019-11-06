using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Welcome to Home Page";
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Form1.email;
            lblNmae.Text = Form1.username;
            if(Form1.male)
                lblSex.Text = "Male";
            else if (Form1.female)
                lblSex.Text = "Female";
            else
                lblSex.Text = "Sex not selected";

            lblMessage.Text = "Welcome " + Form1.username;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Cancel has been pressed!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
