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
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnregister = new Button();
            label1 = new Label();
            linkBackToLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername1 = new TextBox();
            txtPassword1 = new TextBox();
            label4 = new Label();
            picShowPassword1 = new PictureBox();
            panelLogin = new Panel();
            picShowPassword = new PictureBox();
            pictureBox2 = new PictureBox();
            btnSignup = new Button();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            linkSignup = new Button();
            panelRegister = new Panel();
            label10 = new Label();
            txtname = new TextBox();
            label9 = new Label();
            txtemail = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword1).BeginInit();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(593, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnregister
            // 
            btnregister.BackColor = Color.Teal;
            btnregister.FlatAppearance.BorderSize = 0;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.Location = new Point(520, 450);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(259, 54);
            btnregister.TabIndex = 4;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = false;
            btnregister.Click += btnregister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(539, 528);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 6;
            label1.Text = "Already have an account?";
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.BackColor = Color.Transparent;
            linkBackToLogin.FlatAppearance.BorderSize = 0;
            linkBackToLogin.FlatStyle = FlatStyle.Flat;
            linkBackToLogin.ForeColor = Color.FromArgb(33, 145, 245);
            linkBackToLogin.Location = new Point(679, 524);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(63, 23);
            linkBackToLogin.TabIndex = 7;
            linkBackToLogin.Text = "Sign In";
            linkBackToLogin.UseVisualStyleBackColor = false;
            linkBackToLogin.Click += linkBackToLogin_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(520, 161);
            label2.Name = "label2";
            label2.Size = new Size(222, 45);
            label2.TabIndex = 8;
            label2.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(520, 273);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // txtUsername1
            // 
            txtUsername1.BackColor = Color.White;
            txtUsername1.Location = new Point(521, 299);
            txtUsername1.Name = "txtUsername1";
            txtUsername1.Size = new Size(259, 23);
            txtUsername1.TabIndex = 10;
            txtUsername1.TextChanged += txtUsername1_TextChanged;
            // 
            // txtPassword1
            // 
            txtPassword1.BackColor = Color.White;
            txtPassword1.Location = new Point(520, 409);
            txtPassword1.Margin = new Padding(0);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(259, 23);
            txtPassword1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(520, 385);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // picShowPassword1
            // 
            picShowPassword1.BackColor = Color.White;
            picShowPassword1.Image = (Image)resources.GetObject("picShowPassword1.Image");
            picShowPassword1.Location = new Point(747, 412);
            picShowPassword1.Margin = new Padding(0, 2, 0, 0);
            picShowPassword1.Name = "picShowPassword1";
            picShowPassword1.Size = new Size(23, 13);
            picShowPassword1.SizeMode = PictureBoxSizeMode.Zoom;
            picShowPassword1.TabIndex = 1;
            picShowPassword1.TabStop = false;
            picShowPassword1.Click += picShowPassword_Click;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(picShowPassword);
            panelLogin.Controls.Add(pictureBox2);
            panelLogin.Controls.Add(btnSignup);
            panelLogin.Controls.Add(label5);
            panelLogin.Controls.Add(label6);
            panelLogin.Controls.Add(button2);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Controls.Add(label7);
            panelLogin.Controls.Add(label8);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(linkSignup);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(874, 672);
            panelLogin.TabIndex = 13;
            // 
            // picShowPassword
            // 
            picShowPassword.BackColor = Color.White;
            picShowPassword.Image = (Image)resources.GetObject("picShowPassword.Image");
            picShowPassword.Location = new Point(748, 328);
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
            pictureBox2.Location = new Point(593, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(118, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Teal;
            btnSignup.FlatAppearance.BorderSize = 0;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Location = new Point(521, 417);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(259, 54);
            btnSignup.TabIndex = 15;
            btnSignup.Text = "Sign In";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(521, 212);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 20;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(521, 167);
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
            button2.Location = new Point(677, 351);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 16;
            button2.Text = "Forgot Password?";
            button2.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Location = new Point(521, 238);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 23);
            txtUsername.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(521, 322);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 23;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(550, 489);
            label7.Name = "label7";
            label7.Size = new Size(131, 15);
            label7.TabIndex = 17;
            label7.Text = "Don't have an account?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(521, 294);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
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
            // linkSignup
            // 
            linkSignup.BackColor = Color.Transparent;
            linkSignup.FlatAppearance.BorderSize = 0;
            linkSignup.FlatStyle = FlatStyle.Flat;
            linkSignup.ForeColor = Color.FromArgb(33, 145, 245);
            linkSignup.Location = new Point(677, 485);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(63, 23);
            linkSignup.TabIndex = 18;
            linkSignup.Text = "Sign Up";
            linkSignup.UseVisualStyleBackColor = false;
            linkSignup.Click += linkSignup_Click;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(btnregister);
            panelRegister.Controls.Add(label10);
            panelRegister.Controls.Add(txtname);
            panelRegister.Controls.Add(label9);
            panelRegister.Controls.Add(txtemail);
            panelRegister.Controls.Add(pictureBox1);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(picShowPassword1);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(txtUsername1);
            panelRegister.Controls.Add(txtPassword1);
            panelRegister.Controls.Add(linkBackToLogin);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(panel2);
            panelRegister.Dock = DockStyle.Fill;
            panelRegister.Location = new Point(0, 0);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(874, 672);
            panelRegister.TabIndex = 0;
            panelRegister.Paint += panelRegister_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(519, 212);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 28;
            label10.Text = "Name";
            label10.Click += label10_Click;
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.Location = new Point(520, 238);
            txtname.Name = "txtname";
            txtname.Size = new Size(259, 23);
            txtname.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(520, 330);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 26;
            label9.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.Location = new Point(520, 356);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(259, 23);
            txtemail.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 672);
            panel2.TabIndex = 25;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(874, 672);
            Controls.Add(panelLogin);
            Controls.Add(panelRegister);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShowPassword1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnregister;
        private Label label1;
        private Button linkBackToLogin;
        private Label label2;
        private Label label3;
        private TextBox txtUsername1;
        private TextBox txtPassword1;
        private Label label4;
        private PictureBox picShowPassword1;
        private Panel panelLogin;
        private Panel panelRegister;
        private PictureBox pictureBox2;
        private Button btnSignup;
        private Label label5;
        private Label label6;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button linkSignup;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private TextBox txtemail;
        private PictureBox picShowPassword;
        private Label label10;
        private TextBox txtname;
    }
}