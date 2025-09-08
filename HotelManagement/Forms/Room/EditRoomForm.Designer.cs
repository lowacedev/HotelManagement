namespace HotelManagement.Forms.Room
{
    partial class EditRoomForm
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
            this.Load += new System.EventHandler(this.EditRoomForm_Load);
            panel1 = new Panel();
            label1 = new Label();
            btncancel = new Button();
            button1 = new Button();
            txtprice = new TextBox();
            txtstatus = new ComboBox();
            txtroomtype = new ComboBox();
            txtRoomNo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 40);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Edit Room";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.LightGray;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.ForeColor = Color.Black;
            btncancel.Location = new Point(237, 341);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(78, 35);
            btncancel.TabIndex = 21;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(153, 341);
            button1.Name = "button1";
            button1.Size = new Size(78, 35);
            button1.TabIndex = 20;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 9.75F);
            txtprice.ForeColor = Color.Black;
            txtprice.Location = new Point(153, 197);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(201, 25);
            txtprice.TabIndex = 19;
            // 
            // txtstatus
            // 
            txtstatus.Font = new Font("Segoe UI", 9.75F);
            txtstatus.ForeColor = Color.Black;
            txtstatus.FormattingEnabled = true;
            txtstatus.Items.AddRange(new object[] { "Available", "Not Available" });
            txtstatus.Location = new Point(153, 254);
            txtstatus.Name = "txtstatus";
            txtstatus.Size = new Size(201, 25);
            txtstatus.TabIndex = 18;
            txtstatus.Text = "Select";
            // 
            // txtroomtype
            // 
            txtroomtype.Font = new Font("Segoe UI", 9.75F);
            txtroomtype.ForeColor = Color.Black;
            txtroomtype.FormattingEnabled = true;
            txtroomtype.Items.AddRange(new object[] { "Singular Room", "Double Room", "Presidential Suite" });
            txtroomtype.Location = new Point(153, 140);
            txtroomtype.Name = "txtroomtype";
            txtroomtype.Size = new Size(201, 25);
            txtroomtype.TabIndex = 17;
            txtroomtype.Text = "Select";
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Segoe UI", 9.75F);
            txtRoomNo.ForeColor = Color.Black;
            txtRoomNo.Location = new Point(153, 86);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.Size = new Size(201, 25);
            txtRoomNo.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(153, 234);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 15;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(153, 177);
            label4.Name = "label4";
            label4.Size = new Size(36, 17);
            label4.TabIndex = 14;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(153, 120);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 13;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(153, 66);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 12;
            label2.Text = "Room No.";
            // 
            // EditRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 400);
            Controls.Add(panel1);
            Controls.Add(btncancel);
            Controls.Add(button1);
            Controls.Add(txtprice);
            Controls.Add(txtstatus);
            Controls.Add(txtroomtype);
            Controls.Add(txtRoomNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditRoomForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btncancel;
        private Button button1;
        private TextBox txtprice;
        private ComboBox txtstatus;
        private ComboBox txtroomtype;
        private TextBox txtRoomNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}