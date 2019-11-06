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
    public partial class Form1 : Form
    {
        public static string username;
        public static string email;
        public static string Password;
        public static Boolean male;
        public static Boolean female;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            login();
        }

        private void login()
        {
             username = txtUser.Text;
             Password = txtPassword.Text;
            email = txtEmail.Text;


            if (username == "Saim" && Password == "saim1234")
            {
                WelcomePage wp = new WelcomePage();
                wp.Show();
                this.Hide();
            }

            else
                MessageBox.Show("UserName or Password is incorrect");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMale.Checked)
                male = true;
            else
                male = false;
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked)
                female = true;
            else
                female = false;

        }
    }
}
