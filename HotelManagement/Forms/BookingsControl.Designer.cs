namespace HotelManagement.Forms
{
    partial class BookingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            btnAddBooking = new Button();
            txtSearch = new TextBox();
            comboBox2 = new ComboBox();
            addroombtn = new Button();
            comboBox1 = new ComboBox();
            DGVBookings = new DataGridView();
            txtBookingID = new DataGridViewTextBoxColumn();
            txtGuestName = new DataGridViewTextBoxColumn();
            txtRoom = new DataGridViewTextBoxColumn();
            txtCheckInDate = new DataGridViewTextBoxColumn();
            txtCheckOutDate = new DataGridViewTextBoxColumn();
            txtTotalAmount = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            btnCheckIn = new DataGridViewButtonColumn();
            btnCheckOut = new DataGridViewButtonColumn();
            btnCancel = new DataGridViewButtonColumn();
            contextMenuBookings = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBookings).BeginInit();
            contextMenuBookings.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(comboBox4);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(btnAddBooking);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(addroombtn);
            panel3.Controls.Add(comboBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1158, 48);
            panel3.TabIndex = 6;
            // 
            // comboBox4
            // 
            comboBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(879, 12);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(86, 23);
            comboBox4.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(787, 12);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(86, 23);
            comboBox3.TabIndex = 9;
            // 
            // btnAddBooking
            // 
            btnAddBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBooking.BackColor = Color.Teal;
            btnAddBooking.FlatStyle = FlatStyle.Flat;
            btnAddBooking.ForeColor = Color.White;
            btnAddBooking.Location = new Point(971, 3);
            btnAddBooking.Name = "btnAddBooking";
            btnAddBooking.Size = new Size(160, 37);
            btnAddBooking.TabIndex = 8;
            btnAddBooking.Text = "Add New Booking";
            btnAddBooking.UseVisualStyleBackColor = false;
            btnAddBooking.Click += btnAddBooking_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(200, 25);
            txtSearch.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1947, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(86, 23);
            comboBox2.TabIndex = 7;
            // 
            // addroombtn
            // 
            addroombtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addroombtn.BackColor = Color.Teal;
            addroombtn.FlatStyle = FlatStyle.Flat;
            addroombtn.ForeColor = Color.White;
            addroombtn.Location = new Point(2039, 5);
            addroombtn.Name = "addroombtn";
            addroombtn.Size = new Size(133, 37);
            addroombtn.TabIndex = 6;
            addroombtn.Text = "Add New Room";
            addroombtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1854, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(86, 23);
            comboBox1.TabIndex = 5;
            // 
            // DGVBookings
            // 
            DGVBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVBookings.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVBookings.Columns.AddRange(new DataGridViewColumn[] { txtBookingID, txtGuestName, txtRoom, txtCheckInDate, txtCheckOutDate, txtTotalAmount, txtStatus, btnCheckIn, btnCheckOut, btnCancel });
            DGVBookings.ContextMenuStrip = contextMenuBookings;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGVBookings.DefaultCellStyle = dataGridViewCellStyle5;
            DGVBookings.Dock = DockStyle.Fill;
            DGVBookings.EnableHeadersVisualStyles = false;
            DGVBookings.GridColor = SystemColors.ActiveCaptionText;
            DGVBookings.Location = new Point(0, 48);
            DGVBookings.Name = "DGVBookings";
            DGVBookings.ReadOnly = true;
            DGVBookings.RowHeadersWidth = 51;
            DGVBookings.Size = new Size(1158, 587);
            DGVBookings.TabIndex = 7;
            DGVBookings.CellPainting += DGVBookings_CellPainting;
            // 
            // txtBookingID
            // 
            txtBookingID.FillWeight = 30F;
            txtBookingID.HeaderText = "ID";
            txtBookingID.MinimumWidth = 6;
            txtBookingID.Name = "txtBookingID";
            txtBookingID.ReadOnly = true;
            txtBookingID.Resizable = DataGridViewTriState.True;
            // 
            // txtGuestName
            // 
            txtGuestName.HeaderText = "Guest Name";
            txtGuestName.MinimumWidth = 6;
            txtGuestName.Name = "txtGuestName";
            txtGuestName.ReadOnly = true;
            // 
            // txtRoom
            // 
            txtRoom.HeaderText = "RoomNo";
            txtRoom.MinimumWidth = 6;
            txtRoom.Name = "txtRoom";
            txtRoom.ReadOnly = true;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.HeaderText = "Check-in Date";
            txtCheckInDate.MinimumWidth = 6;
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.ReadOnly = true;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.HeaderText = "Check-Out Date ";
            txtCheckOutDate.MinimumWidth = 6;
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.ReadOnly = true;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.HeaderText = "Total Amount";
            txtTotalAmount.MinimumWidth = 6;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            // 
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 6;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            // 
            // btnCheckIn
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightGreen;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = Color.DarkGreen;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkGreen;
            btnCheckIn.DefaultCellStyle = dataGridViewCellStyle2;
            btnCheckIn.FillWeight = 40F;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.HeaderText = "Check-In";
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.ReadOnly = true;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseColumnTextForButtonValue = true;
            // 
            // btnCheckOut
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkBlue;
            btnCheckOut.DefaultCellStyle = dataGridViewCellStyle3;
            btnCheckOut.FillWeight = 40F;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.HeaderText = "Check Out";
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.ReadOnly = true;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseColumnTextForButtonValue = true;
            // 
            // btnCancel
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkRed;
            btnCancel.DefaultCellStyle = dataGridViewCellStyle4;
            btnCancel.FillWeight = 40F;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.HeaderText = "Cancel";
            btnCancel.Name = "btnCancel";
            btnCancel.ReadOnly = true;
            btnCancel.Text = "Cancel";
            btnCancel.UseColumnTextForButtonValue = true;
            // 
            // contextMenuBookings
            // 
            contextMenuBookings.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuBookings.Name = "contextMenuStrip1";
            contextMenuBookings.Size = new Size(95, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(94, 22);
            toolStripMenuItem1.Text = "Edit";
            // 
            // BookingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DGVBookings);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingsControl";
            Size = new Size(1158, 635);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBookings).EndInit();
            contextMenuBookings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private TextBox txtSearch;
        private ComboBox comboBox2;
        private Button addroombtn;
        private ComboBox comboBox1;
        private DataGridView BookingsDGV;
        private Button btnAddBooking;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private DataGridView DGVBookings;
        private DataGridViewTextBoxColumn txtBookingID;
        private DataGridViewTextBoxColumn txtGuestName;
        private DataGridViewTextBoxColumn txtRoom;
        private DataGridViewTextBoxColumn txtCheckInDate;
        private DataGridViewTextBoxColumn txtCheckOutDate;
        private DataGridViewTextBoxColumn txtTotalAmount;
        private DataGridViewTextBoxColumn txtStatus;
        private DataGridViewButtonColumn btnCheckIn;
        private DataGridViewButtonColumn btnCheckOut;
        private DataGridViewButtonColumn btnCancel;
        private ContextMenuStrip contextMenuBookings;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
