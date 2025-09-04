namespace HotelManagement
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnBookings = new Button();
            btnReservation = new Button();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            roomsbtn = new Button();
            btnInventory = new Button();
            btndashboard = new Button();
            panelMain = new Panel();
            dashboardControl1 = new HotelManagement.Forms.DashboardControl();
            panelHeader = new Panel();
            lblPageTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panelMain.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(38, 39, 59);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 64, 97);
            panel2.Controls.Add(btnBookings);
            panel2.Controls.Add(btnReservation);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(roomsbtn);
            panel2.Controls.Add(btnInventory);
            panel2.Controls.Add(btndashboard);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 749);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnBookings
            // 
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.ForeColor = Color.White;
            btnBookings.Image = (Image)resources.GetObject("btnBookings.Image");
            btnBookings.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookings.Location = new Point(0, 153);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(20, 0, 0, 0);
            btnBookings.Size = new Size(234, 63);
            btnBookings.TabIndex = 7;
            btnBookings.Text = "Bookings";
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnReservation
            // 
            btnReservation.FlatAppearance.BorderSize = 0;
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.Image = (Image)resources.GetObject("btnReservation.Image");
            btnReservation.ImageAlign = ContentAlignment.MiddleLeft;
            btnReservation.Location = new Point(0, 222);
            btnReservation.Name = "btnReservation";
            btnReservation.Padding = new Padding(20, 0, 0, 0);
            btnReservation.Size = new Size(234, 63);
            btnReservation.TabIndex = 6;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 39, 59);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 62);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(92, 34);
            label2.Name = "label2";
            label2.Size = new Size(124, 17);
            label2.TabIndex = 8;
            label2.Text = "Hotel Management";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(92, 9);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 9;
            label3.Text = "SUMMIT";
            // 
            // roomsbtn
            // 
            roomsbtn.FlatAppearance.BorderSize = 0;
            roomsbtn.FlatStyle = FlatStyle.Flat;
            roomsbtn.Image = (Image)resources.GetObject("roomsbtn.Image");
            roomsbtn.ImageAlign = ContentAlignment.MiddleLeft;
            roomsbtn.Location = new Point(0, 291);
            roomsbtn.Name = "roomsbtn";
            roomsbtn.Padding = new Padding(20, 0, 0, 0);
            roomsbtn.Size = new Size(234, 63);
            roomsbtn.TabIndex = 5;
            roomsbtn.Text = "Rooms";
            roomsbtn.UseVisualStyleBackColor = true;
            roomsbtn.Click += roomsbtn_Click;
            // 
            // btnInventory
            // 
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Image = (Image)resources.GetObject("btnInventory.Image");
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 372);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(20, 0, 0, 0);
            btnInventory.Size = new Size(234, 63);
            btnInventory.TabIndex = 4;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // btndashboard
            // 
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.ForeColor = Color.White;
            btndashboard.Image = (Image)resources.GetObject("btndashboard.Image");
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 84);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(20, 0, 0, 0);
            btndashboard.Size = new Size(234, 63);
            btndashboard.TabIndex = 2;
            btndashboard.Text = "Dashboard";
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(dashboardControl1);
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(980, 800);
            panelMain.TabIndex = 2;
            panelMain.Paint += panelMain_Paint;
            // 
            // dashboardControl1
            // 
            dashboardControl1.Location = new Point(0, 0);
            dashboardControl1.Name = "dashboardControl1";
            dashboardControl1.Size = new Size(150, 150);
            dashboardControl1.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(lblPageTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(220, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(980, 62);
            panelHeader.TabIndex = 0;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(0, 21);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(119, 30);
            lblPageTitle.TabIndex = 5;
            lblPageTitle.Text = "Dashboard";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1200, 749);
            Controls.Add(panelHeader);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelMain.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        internal Button button1;
        internal Button btnBookings;
        internal Button button5;
        internal Button roomsbtn;
        internal Button btnInventory;
        private Panel panelMain;
        private Panel panelHeader;
        private Label lblPageTitle;
        private Label label2;
        private Label label3;
        private Panel panel4;
        internal Button btndashboard;
        private Forms.DashboardControl dashboardControl1;
        internal Button btnReservation;
    }
}
