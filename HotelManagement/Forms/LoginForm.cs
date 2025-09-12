using DatabaseProject;
using HotelManagement.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class LoginForm : Form
    {
        DbConnections objdbConnections = new DbConnections();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;
        }

        private bool passwordVisible = false;

        private void picShowPassword_Click_1(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShowPassword.Image = Properties.Resources.hidePassword;
                passwordVisible = false;
            }
            else
            {
                // Show password
                txtPassword.UseSystemPasswordChar = false;
                picShowPassword.Image = Properties.Resources.showPassword;
                passwordVisible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblUsernameError.Visible = false;
            lblPasswordError.Visible = false;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            bool isValid = true;

            if (string.IsNullOrEmpty(username))
            {
                lblUsernameError.Text = "Username cannot be empty.";
                lblUsernameError.Visible = true;
                isValid = false;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Text = "Password cannot be empty.";
                lblPasswordError.Visible = true;
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            if (username == "admin" && password == "admin")
            {
                MainForm newForm = new MainForm();
                newForm.Show();
                this.Hide();
            }
            else
            {
                lblUsernameError.Text = "Invalid username.";
                lblPasswordError.Text = "Invalid password.";
                lblUsernameError.Visible = true;
                lblPasswordError.Visible = true;
                txtPassword.Text = "";
                txtUsername.Text = "";
            }
        }
    }
}