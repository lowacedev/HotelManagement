namespace HotelManagement
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panelLogin = new Panel();
            lblPasswordError = new Label();
            lblUsernameError = new Label();
            picShowPassword = new PictureBox();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(lblPasswordError);
            panelLogin.Controls.Add(lblUsernameError);
            panelLogin.Controls.Add(picShowPassword);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(label8);
            panelLogin.Controls.Add(panel1);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(874, 672);
            panelLogin.TabIndex = 13;
            // 
            // lblPasswordError
            // 
            lblPasswordError.AutoSize = true;
            lblPasswordError.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordError.ForeColor = Color.Red;
            lblPasswordError.Location = new Point(531, 383);
            lblPasswordError.Name = "lblPasswordError";
            lblPasswordError.Size = new Size(90, 15);
            lblPasswordError.TabIndex = 27;
            lblPasswordError.Text = "Invalid password";
            lblPasswordError.Visible = false;
            // 
            // lblUsernameError
            // 
            lblUsernameError.AutoSize = true;
            lblUsernameError.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsernameError.ForeColor = Color.Red;
            lblUsernameError.Location = new Point(531, 299);
            lblUsernameError.Name = "lblUsernameError";
            lblUsernameError.Size = new Size(90, 15);
            lblUsernameError.TabIndex = 26;
            lblUsernameError.Text = "Invalid username";
            lblUsernameError.Visible = false;
            // 
            // picShowPassword
            // 
            picShowPassword.BackColor = Color.White;
            picShowPassword.Image = (Image)resources.GetObject("picShowPassword.Image");
            picShowPassword.Location = new Point(758, 363);
            picShowPassword.Margin = new Padding(0);
            picShowPassword.Name = "picShowPassword";
            picShowPassword.Padding = new Padding(0, 2, 0, 0);
            picShowPassword.Size = new Size(23, 13);
            picShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            picShowPassword.TabIndex = 25;
            picShowPassword.TabStop = false;
            picShowPassword.Click += picShowPassword_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(531, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(269, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(531, 439);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(259, 54);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(531, 254);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 20;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(531, 202);
            label6.Name = "label6";
            label6.Size = new Size(222, 45);
            label6.TabIndex = 19;
            label6.Text = "Sign in";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(33, 145, 245);
            button2.Location = new Point(687, 386);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 16;
            button2.Text = "Forgot Password?";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(531, 273);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 23);
            txtUsername.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(531, 357);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(531, 338);
            label8.Name = "label8";
            label8.Size = new Size(64, 16);
            label8.TabIndex = 22;
            label8.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 672);
            panel1.TabIndex = 24;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Tag = "";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(874, 672);
            Controls.Add(panelLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelLogin;
        private PictureBox pictureBox2;
        private Button btnLogin;
        private Label label5;
        private Label label6;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label8;
        private Panel panel1;
        private PictureBox picShowPassword;
        private ErrorProvider errorProvider1;
        private Label lblPasswordError;
        private Label lblUsernameError;
    }
}