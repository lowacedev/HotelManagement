using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword1.UseSystemPasswordChar = true;

            txtPassword.UseSystemPasswordChar = true;
        }



        private bool passwordVisible = false;

        private void picShowPassword_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                
                txtPassword1.UseSystemPasswordChar = true;
                picShowPassword1.Image = Properties.Resources.hidePassword; 
                passwordVisible = false;
            }
            else
            {
               
                txtPassword1.UseSystemPasswordChar = false;
                picShowPassword1.Image = Properties.Resources.showPassword; 
                passwordVisible = true;
            }
        }




        private void btnregister_Click(object sender, EventArgs e)
        {

        }

        private void linkBackToLogin_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void linkSignup_Click(object sender, EventArgs e)
        {

            panelRegister.BringToFront();
        }

        private void picShowPassword_Click_1(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                // Hide password
                txtPassword.UseSystemPasswordChar = true;
                picShowPassword.Image = Properties.Resources.hidePassword; // replace with your closed-eye icon
                passwordVisible = false;
            }
            else
            {
                // Show password
                txtPassword.UseSystemPasswordChar = false;
                picShowPassword.Image = Properties.Resources.showPassword; // replace with your open-eye icon
                passwordVisible = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

