namespace HotelManagement.Forms
{
    partial class EditBookingForm
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
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            txtPhoneNo = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtAdvPay = new TextBox();
            txtTotalAmount = new TextBox();
            cbMethod = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            nupNoOfGuests = new NumericUpDown();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            cbRoomNumber = new ComboBox();
            cbRoomType = new ComboBox();
            cbStayType = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            btncancel = new Button();
            btnsubmit = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupNoOfGuests).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(355, 10);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "Edit Booking";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 161);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Guest Information";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(122, 110);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(202, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(122, 69);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(202, 23);
            txtPhoneNo.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 118);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 77);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 1;
            label3.Text = "Phone Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 33);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAdvPay);
            groupBox2.Controls.Add(txtTotalAmount);
            groupBox2.Controls.Add(cbMethod);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(31, 275);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 167);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment";
            // 
            // txtAdvPay
            // 
            txtAdvPay.Location = new Point(122, 101);
            txtAdvPay.Name = "txtAdvPay";
            txtAdvPay.Size = new Size(202, 23);
            txtAdvPay.TabIndex = 11;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(122, 62);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(202, 23);
            txtTotalAmount.TabIndex = 10;
            // 
            // cbMethod
            // 
            cbMethod.FormattingEnabled = true;
            cbMethod.Location = new Point(122, 30);
            cbMethod.Name = "cbMethod";
            cbMethod.Size = new Size(202, 23);
            cbMethod.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 109);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 9;
            label13.Text = "Advance Payment:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 70);
            label12.Name = "label12";
            label12.Size = new Size(82, 15);
            label12.TabIndex = 8;
            label12.Text = "Total Amount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 33);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 7;
            label11.Text = "Method:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nupNoOfGuests);
            groupBox3.Controls.Add(dtpCheckOut);
            groupBox3.Controls.Add(dtpCheckIn);
            groupBox3.Controls.Add(cbRoomNumber);
            groupBox3.Controls.Add(cbRoomType);
            groupBox3.Controls.Add(cbStayType);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(486, 93);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(349, 260);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Stay Details";
            // 
            // nupNoOfGuests
            // 
            nupNoOfGuests.Location = new Point(138, 215);
            nupNoOfGuests.Name = "nupNoOfGuests";
            nupNoOfGuests.Size = new Size(120, 23);
            nupNoOfGuests.TabIndex = 17;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(138, 178);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(200, 23);
            dtpCheckOut.TabIndex = 16;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(138, 138);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(200, 23);
            dtpCheckIn.TabIndex = 15;
            // 
            // cbRoomNumber
            // 
            cbRoomNumber.FormattingEnabled = true;
            cbRoomNumber.Location = new Point(137, 102);
            cbRoomNumber.Name = "cbRoomNumber";
            cbRoomNumber.Size = new Size(121, 23);
            cbRoomNumber.TabIndex = 14;
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(137, 64);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(121, 23);
            cbRoomType.TabIndex = 13;
            // 
            // cbStayType
            // 
            cbStayType.FormattingEnabled = true;
            cbStayType.Location = new Point(138, 30);
            cbStayType.Name = "cbStayType";
            cbStayType.Size = new Size(121, 23);
            cbStayType.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 219);
            label10.Name = "label10";
            label10.Size = new Size(81, 15);
            label10.TabIndex = 11;
            label10.Text = "No. of Guests:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 72);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 10;
            label9.Text = "Room Type:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 110);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 9;
            label8.Text = "Room Number:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 146);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 8;
            label7.Text = "Check In Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 186);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 7;
            label6.Text = "Check Out Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 30);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 6;
            label5.Text = "Stay Type:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btncancel);
            panel2.Controls.Add(btnsubmit);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(0, 480);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 48);
            panel2.TabIndex = 3;
            // 
            // btncancel
            // 
            btncancel.BackColor = SystemColors.ActiveBorder;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(480, 8);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(80, 35);
            btncancel.TabIndex = 5;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.Teal;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.ForeColor = Color.White;
            btnsubmit.Location = new Point(368, 8);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(80, 35);
            btnsubmit.TabIndex = 4;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            // 
            // EditBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 528);
            Controls.Add(panel2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBookingForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupNoOfGuests).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtEmail;
        private TextBox txtPhoneNo;
        private TextBox txtName;
        private NumericUpDown nupNoOfGuests;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private ComboBox cbRoomType;
        private ComboBox cbRoomNumber;
        private ComboBox cbStayType;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label13;
        private Label label12;
        private Label label11;
        private ComboBox cbMethod;
        private TextBox txtAdvPay;
        private TextBox txtTotalAmount;
        private Panel panel2;
        private Button btncancel;
        private Button btnsubmit;
    }
}