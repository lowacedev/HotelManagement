using DatabaseProject;
using HotelManagement.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string name1 = txtname.Text;
            string username = txtUsername1.Text;
            string email = txtemail.Text;
            string password = txtPassword1.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("Required Student's Name");
            }
            else if (name1.Equals(""))
            {
                MessageBox.Show("Required Student's Age");
            }
            else if (email.Equals(""))
            {
                MessageBox.Show("Required Student's Age");
            }
            else if (password.Equals(""))
            {
                MessageBox.Show("Required Student's Address");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into tbl_User(name, email, username, password) values(@name, @email, @username, @password)");
                // insertCommand.Parameters.AddWithValue("@ID", ID);
                insertCommand.Parameters.AddWithValue("@name", name1);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", password);
                int row = objdbConnections.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("Successfully registered");
                    txtname.Text = "";

                }


            }
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();

            // Display the new form.
            newForm.Show();

            // Optionally, hide the current form.
            this.Hide();
        }

        private void txtUsername1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}

