using DatabaseProject;
using HotelManagement.Forms.Room;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.Forms
{

    public partial class BookingsControl : UserControl
    {
        private DbConnections objdbConnections = new DbConnections();
        private ContextMenuStrip actionsMenu;
        private int selectedRowIndex;
        public BookingsControl()
        {
            InitializeComponent();
            this.Load += BookingsControl_Load;
            InitializeDataGridView();
            actionsMenu = new ContextMenuStrip();

            LoadBookings();
            this.DGVBookings.CellContentClick += DGVBookings_CellContentClick;

        }

        public string PageTitle
        {
            get { return "Bookings"; }
        }

        // Data class for displaying bookings
        public class BookingDisplay
        {
            public int BookingId { get; set; }
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
                Name = "booking_id",
                DataPropertyName = "BookingId", // matches property name
                Visible = false// Visible = false


            });
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

        public void LoadBookings()
        {
            List<BookingDisplay> bookings = new List<BookingDisplay>();
            DataTable dt = new DataTable();

            try
            {
                // Read data into DataTable
                objdbConnections.readDatathroughAdapter(@"SELECT 
            b.booking_id,
            b.guest_name, 
            r.room_number, 
            r.room_type, 
            b.checkin_date, 
            b.checkout_date, 
            b.amount, 
            b.stay_type AS status
            FROM tbl_Booking b
            JOIN tbl_Room r ON b.room_id = r.room_id", dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
                return;
            }

            // Map DataTable rows to BookingDisplay list
            foreach (DataRow row in dt.Rows)
            {
                bookings.Add(new BookingDisplay
                {
                    BookingId = Convert.ToInt32(row["booking_id"]),
                    GuestName = row["guest_name"].ToString(),
                    RoomNumber = row["room_number"].ToString(),
                    RoomType = row["room_type"].ToString(),
                    CheckInDate = Convert.ToDateTime(row["checkin_date"]),
                    CheckOutDate = Convert.ToDateTime(row["checkout_date"]),
                    TotalAmount = Convert.ToDecimal(row["amount"]),
                    Status = row["status"].ToString(),

                });
            }

            // Clear existing data
            DGVBookings.DataSource = null;

            // Bind new data
            DGVBookings.DataSource = bookings;

        }

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
                LoadBookings(); 
            }
        }
        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = DGVBookings.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    // Select the row under the mouse
                    DGVBookings.ClearSelection();
                    DGVBookings.Rows[hit.RowIndex].Selected = true;

                    // Retrieve the room_id
                    DataGridViewRow row = DGVBookings.CurrentRow;
                    int booking_id = Convert.ToInt32(row.Cells["booking_id"].Value);

                    using (var editForm = new EditBookingForm(booking_id))
                    {
                        var result = editForm.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            LoadBookings();
                        }

                        else
                        {
                            booking_id = -1;
                        }

                        // Show context menu at mouse position
                        actionsMenu.Show(DGVBookings, e.Location);
                    }
                }
            }
        }
        
        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            if (DGVBookings.CurrentRow != null)
            {
                DataGridViewRow row = DGVBookings.CurrentRow;
                int booking_id = Convert.ToInt32(row.Cells["booking_id"].Value);

                using (var editForm = new EditBookingForm(booking_id))
                {
                    var result = editForm.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadBookings();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to edit.");
            }
}
        private void DGVBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVBookings.Columns[e.ColumnIndex].Name == "Actions")
            {
                selectedRowIndex = e.RowIndex;

                var rect = DGVBookings.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                var point = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height);
                actionsMenu.Show(DGVBookings, point);
            }
        }
    }
}