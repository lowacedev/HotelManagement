namespace HotelManagement.Controls
{
    partial class SalesReportControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            tabReport = new TabControl();
            dgvBookings = new TabPage();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            tabPage = new TabPage();
            dgvService = new DataGridView();
            tabpage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvBooking = new DataGridView();
            txtBookingID = new DataGridViewTextBoxColumn();
            txtGuestName = new DataGridViewTextBoxColumn();
            txtRoomNo = new DataGridViewTextBoxColumn();
            txtCheckInDate = new DataGridViewTextBoxColumn();
            txtCheckOutDate = new DataGridViewTextBoxColumn();
            txtTotalAmount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tabReport.SuspendLayout();
            dgvBookings.SuspendLayout();
            tabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvService).BeginInit();
            tabpage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1664, 55);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            comboBox1.Location = new Point(10, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // tabReport
            // 
            tabReport.Controls.Add(dgvBookings);
            tabReport.Controls.Add(tabPage);
            tabReport.Controls.Add(tabpage2);
            tabReport.Dock = DockStyle.Fill;
            tabReport.Location = new Point(0, 55);
            tabReport.Name = "tabReport";
            tabReport.SelectedIndex = 0;
            tabReport.Size = new Size(1664, 426);
            tabReport.TabIndex = 1;
            // 
            // dgvBookings
            // 
            dgvBookings.Controls.Add(cartesianChart1);
            dgvBookings.Controls.Add(pieChart1);
            dgvBookings.Location = new Point(4, 24);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.Padding = new Padding(3);
            dgvBookings.Size = new Size(1656, 398);
            dgvBookings.TabIndex = 0;
            dgvBookings.Text = "Bookings";
            dgvBookings.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartesianChart1.BackColor = Color.White;
            cartesianChart1.Location = new Point(6, 30);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(451, 320);
            cartesianChart1.TabIndex = 6;
            // 
            // pieChart1
            // 
            pieChart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pieChart1.BackColor = Color.White;
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(509, 6);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(419, 370);
            pieChart1.TabIndex = 5;
            // 
            // tabPage
            // 
            tabPage.Controls.Add(dgvService);
            tabPage.Location = new Point(4, 24);
            tabPage.Name = "tabPage";
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(1656, 398);
            tabPage.TabIndex = 1;
            tabPage.Text = "Service";
            tabPage.UseVisualStyleBackColor = true;
            // 
            // dgvService
            // 
            dgvService.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvService.Dock = DockStyle.Fill;
            dgvService.Location = new Point(3, 3);
            dgvService.Name = "dgvService";
            dgvService.Size = new Size(1650, 392);
            dgvService.TabIndex = 1;
            // 
            // tabpage2
            // 
            tabpage2.Controls.Add(chart1);
            tabpage2.Location = new Point(4, 24);
            tabpage2.Name = "tabpage2";
            tabpage2.Padding = new Padding(3);
            tabpage2.Size = new Size(1656, 398);
            tabpage2.TabIndex = 2;
            tabpage2.Text = "Summary";
            tabpage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(380, 58);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(398, 293);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // dgvBooking
            // 
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.BackgroundColor = SystemColors.ActiveBorder;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Columns.AddRange(new DataGridViewColumn[] { txtBookingID, txtGuestName, txtRoomNo, txtCheckInDate, txtCheckOutDate, txtTotalAmount });
            dgvBooking.Dock = DockStyle.Bottom;
            dgvBooking.Location = new Point(0, 481);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.RightToLeft = RightToLeft.No;
            dgvBooking.Size = new Size(1664, 418);
            dgvBooking.TabIndex = 0;
            // 
            // txtBookingID
            // 
            txtBookingID.HeaderText = "BookingID";
            txtBookingID.Name = "txtBookingID";
            txtBookingID.ReadOnly = true;
            // 
            // txtGuestName
            // 
            txtGuestName.HeaderText = "Guest Name";
            txtGuestName.Name = "txtGuestName";
            txtGuestName.ReadOnly = true;
            // 
            // txtRoomNo
            // 
            txtRoomNo.HeaderText = "RoomNo";
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.ReadOnly = true;
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.HeaderText = "Check-In Date";
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.ReadOnly = true;
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.HeaderText = "Check-Out Date";
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.ReadOnly = true;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.HeaderText = "Total Amount";
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            // 
            // SalesReportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabReport);
            Controls.Add(dgvBooking);
            Controls.Add(panel1);
            Name = "SalesReportControl";
            Size = new Size(1664, 899);
            Load += SalesReportControl_Load;
            panel1.ResumeLayout(false);
            tabReport.ResumeLayout(false);
            dgvBookings.ResumeLayout(false);
            tabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvService).EndInit();
            tabpage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabReport;
        private TabPage dgvBookings;
        private TabPage tabPage;
        private TabPage tabpage2;
        private DataGridView dgvBooking;
        private DataGridView dgvService;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataGridViewTextBoxColumn txtBookingID;
        private DataGridViewTextBoxColumn txtGuestName;
        private DataGridViewTextBoxColumn txtRoomNo;
        private DataGridViewTextBoxColumn txtCheckInDate;
        private DataGridViewTextBoxColumn txtCheckOutDate;
        private DataGridViewTextBoxColumn txtTotalAmount;
        private ComboBox comboBox1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    }
}
