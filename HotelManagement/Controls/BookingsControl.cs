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
            actionsMenu.Items.Add("Edit", null, EditMenuItem_Click);
            actionsMenu.Items.Add("Delete", null, DeleteMenuItem_Click);
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

        public void LoadBookings()
        {
            List<BookingDisplay> bookings = new List<BookingDisplay>();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tbl_Booking";

            try
            {
                objdbConnections.readDatathroughAdapter(query, dt);
                DGVBookings.DataSource = dt;

                                if (DGVBookings.Columns.Contains("Actions"))
                {
                    DGVBookings.Columns.Remove("Actions");
                }

                
                DataGridViewButtonColumn actionsButtonColumn = new DataGridViewButtonColumn();
                actionsButtonColumn.Name = "Actions";
                actionsButtonColumn.HeaderText = "Actions";
                actionsButtonColumn.Text = "Actions";
                actionsButtonColumn.UseColumnTextForButtonValue = true;
                DGVBookings.Columns.Add(actionsButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
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

            DGVBookings.DataSource = null; 
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

        private void toolStripMenuEdit_Click(object sender, EventArgs e)
        {
            EditBookingForm editBookingForm = new EditBookingForm();
            var result = editBookingForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadBookings(); 
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
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < DGVBookings.Rows.Count)
            {
                DataGridViewRow row = DGVBookings.Rows[selectedRowIndex];
                int booking_id = Convert.ToInt32(row.Cells["booking_id"].Value);


                using (var editForm = new EditRoomForm(booking_id))
                {
                    editForm.ShowDialog();
                }
                LoadBookings();
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < DGVBookings.Rows.Count)
            {
                DataGridViewRow row = DGVBookings.Rows[selectedRowIndex];
                int booking_id = Convert.ToInt32(row.Cells["booking_id"].Value);

                var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM tbl_Booking WHERE booking_id = {booking_id}";
                    try
                    {
                        objdbConnections.executeQuery(deleteQuery);
                        LoadBookings();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
        }
    }
}