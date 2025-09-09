using DatabaseProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Forms
{

    public partial class BookingsControl : UserControl
    {
                private DbConnections objdbConnections = new DbConnections();

        public BookingsControl()
        {
            InitializeComponent();
            this.Load += BookingsControl_Load;
            InitializeDataGridView();
        }

        public string PageTitle
        {
            get { return "Bookings"; }
        }

        // Data class for displaying bookings
        public class BookingDisplay
        {
            public string GuestName { get; set; }
            public string RoomNumber { get; set; }
            public string RoomType { get; set; }
            public DateTime CheckInDate { get; set; }
            public DateTime CheckOutDate { get; set; }
            public decimal TotalAmount { get; set; }
            public string Status { get; set; }
        }

        // Initialize DataGridView columns
        private void InitializeDataGridView()
        {
            if (DGVBookings.Columns.Count > 0)
                DGVBookings.Columns.Clear();

            DGVBookings.AutoGenerateColumns = false;

            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Guest Name",
                DataPropertyName = "GuestName",
                Width = 150
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Room No",
                DataPropertyName = "RoomNumber",
                Width = 100
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Room Type",
                DataPropertyName = "RoomType",
                Width = 120
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-in Date",
                DataPropertyName = "CheckInDate",
                Width = 130
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check-out Date",
                DataPropertyName = "CheckOutDate",
                Width = 130
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Amount",
                DataPropertyName = "TotalAmount",
                Width = 100
            });
            DGVBookings.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 100
            });
        }

        // Load bookings from database
        public void LoadBookings()
        {
            List<BookingDisplay> bookings = new List<BookingDisplay>();
            DataTable dt = new DataTable();

            try
            {
                using (var db = new DbConnections())
                {
                    db.readDatathroughAdapter(@"
                SELECT 
                    b.guest_name, 
                    r.room_number, 
                    r.room_type, 
                    b.checkin_date, 
                    b.checkout_date, 
                    b.amount, 
                    b.stay_type AS status
                FROM 
                    tbl_Booking b
                JOIN 
                    tbl_Room r ON b.room_id = r.room_id", dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
                return;
            }

            foreach (DataRow row in dt.Rows)
            {
                bookings.Add(new BookingDisplay
                {
                    GuestName = row["guest_name"].ToString(),
                    RoomNumber = row["room_number"].ToString(),
                    RoomType = row["room_type"].ToString(),
                    CheckInDate = Convert.ToDateTime(row["checkin_date"]),
                    CheckOutDate = Convert.ToDateTime(row["checkout_date"]),
                    TotalAmount = Convert.ToDecimal(row["amount"]),
                    Status = row["status"].ToString()
                });
            }

            DGVBookings.DataSource = null; // Reset data source
            DGVBookings.DataSource = bookings;
        }

        // Load event
        private void BookingsControl_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddBookingForm addBookingForm = new AddBookingForm();
            var result = addBookingForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadBookings(); // Refresh bookings after adding
            }
        }

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            EditBookingForm editBookingForm = new EditBookingForm();
            var result = editBookingForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadBookings(); // Refresh bookings after editing
            }
        }
    }
}