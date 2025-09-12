using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DatabaseProject; // Your database connection class

namespace HotelManagement.Forms
{
    public partial class EditBookingForm : Form
    {
        private int bookingId;
        private DbConnections dbConnections = new DbConnections();

        // List to hold all available rooms
        private List<RoomInfo> allAvailableRooms = new List<RoomInfo>();

        // List to hold filtered rooms based on selected type
        private List<RoomInfo> filteredRooms = new List<RoomInfo>();

        // Property to hold current room's price for calculations
        private decimal currentRoomPrice = 0m;

        public EditBookingForm(int bookingId)
        {
            InitializeComponent();
            this.bookingId = bookingId;

            LoadAvailableRooms(); // Load all available rooms
            PopulateRoomTypeComboBox(); // Populate room type options
            PopulateStayTypeMethod(); // Populate stay type and method options
            BindRoomsToComboBox(); // Bind initial room list
            LoadBookingData(); // Load existing booking info

            // Event: when room type changes, filter rooms
            cbRoomType.SelectedIndexChanged += CbRoomType_SelectedIndexChanged;
            cbRoomNumber.SelectedIndexChanged += CbRoomNumber_SelectedIndexChanged;
            dtpCheckIn.ValueChanged += DatePicker_ValueChanged;
            dtpCheckOut.ValueChanged += DatePicker_ValueChanged;
        }

        private void LoadAvailableRooms()
        {
            DataTable dtRooms = new DataTable();
            dbConnections.readDatathroughAdapter(@"
                SELECT room_id, room_type, room_number, price, status
                FROM tbl_Room
                WHERE status = 'Available'", dtRooms);

            allAvailableRooms.Clear();
            foreach (DataRow row in dtRooms.Rows)
            {
                allAvailableRooms.Add(new RoomInfo
                {
                    RoomId = Convert.ToInt32(row["room_id"]),
                    RoomType = row["room_type"].ToString(),
                    RoomNumber = row["room_number"].ToString(),
                    Price = Convert.ToDecimal(row["price"])
                });
            }
        }

        private void PopulateRoomTypeComboBox()
        {
            cbRoomType.Items.Clear();
            cbRoomType.Items.Add("Singular Room");
            cbRoomType.Items.Add("Double Room");
            cbRoomType.Items.Add("Presidential Suite");
            cbRoomType.SelectedIndex = 0;
        }

        private void PopulateStayTypeMethod()
        {
            // Populate stay type options
            cbStayType.Items.Clear();
            cbStayType.Items.AddRange(new string[] { "Check-in", "Long Stay" });
            cbStayType.SelectedIndex = 0;

            // Populate method options
            cbMethod.Items.Clear();
            cbMethod.Items.AddRange(new string[] { "Cash", "Debit/Credit Card", "Gcash" });
            cbMethod.SelectedIndex = 0;
        }

        private void CbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbRoomType.SelectedItem.ToString();
            FilterRoomsByType(selectedType);
        }

        private void FilterRoomsByType(string roomType)
        {
            filteredRooms = allAvailableRooms
                .Where(r => r.RoomType.Equals(roomType, StringComparison.OrdinalIgnoreCase))
                .ToList();

            cbRoomNumber.DataSource = filteredRooms;
            cbRoomNumber.DisplayMember = "RoomNumber";
            cbRoomNumber.ValueMember = "RoomId";

            // After filtering, update total amount based on selected room
            UpdateTotalAmount();
        }

        private void BindRoomsToComboBox()
        {
            if (cbRoomType.SelectedItem != null)
            {
                FilterRoomsByType(cbRoomType.SelectedItem.ToString());
            }
        }

        private void LoadBookingData()
        {
            try
            {
                string query = $@"
            SELECT b.*, r.room_type, r.room_number
            FROM tbl_Booking b
            JOIN tbl_Room r ON b.room_id = r.room_id
            WHERE b.booking_id = {bookingId}";

                DataTable dt = new DataTable();
                dbConnections.readDatathroughAdapter(query, dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Populate textboxes
                    txtName.Text = row["guest_name"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtPhoneNo.Text = row["phone_number"].ToString();
                    txtage.Text = row["age"].ToString();

                    // Get current room info
                    string currentRoomNumber = row["room_number"].ToString();
                    string currentRoomType = row["room_type"].ToString();

                    // Set current room number in ComboBox
                    if (cbRoomType.Items.Contains(currentRoomType))
                        cbRoomType.SelectedItem = currentRoomType;
                    else
                        cbRoomType.SelectedIndex = 0;

                    // Filter rooms based on current type
                    FilterRoomsByType(currentRoomType);

                    // Set selected room number
                    var selectedRoom = filteredRooms.Find(r => r.RoomNumber == currentRoomNumber);
                    if (selectedRoom != null)
                    {
                        cbRoomNumber.SelectedValue = selectedRoom.RoomId;
                        currentRoomPrice = selectedRoom.Price;
                        UpdateTotalAmount();
                    }

                    // Set stay type and method from booking data
                    cbStayType.SelectedItem = row["stay_type"].ToString();
                    cbMethod.SelectedItem = row["method"].ToString();

                    // Set total amount, advance payment, number of guests
                    txtTotalAmount.Text = row["amount"].ToString();
                    txtAdvPay.Text = row["advance_payment"].ToString();
                    nupNoOfGuests.Value = Convert.ToDecimal(row["no_guest"]);

                    // Set check-in and check-out dates
                    dtpCheckIn.Value = Convert.ToDateTime(row["checkin_date"]);
                    dtpCheckOut.Value = Convert.ToDateTime(row["checkout_date"]);

                    // Display gender
                    string genderValue = row["gender"].ToString();
                    if (genderValue.Equals("Female", StringComparison.OrdinalIgnoreCase))
                        female.Checked = true; // assuming you have RadioButton named female
                    else
                        male.Checked = true;   // assuming you have RadioButton named male
                }
                else
                {
                    MessageBox.Show("Booking not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading booking data: " + ex.Message);
            }
        }

        // Event handler for changing room selection
        private void CbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoom = cbRoomNumber.SelectedItem as RoomInfo;
            if (selectedRoom != null)
            {
                currentRoomPrice = selectedRoom.Price;
                UpdateTotalAmount();
            }
        }

        // Event handler for date changes
        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        // Method to calculate total amount based on room price and stay duration
        private void UpdateTotalAmount()
        {
            if (currentRoomPrice > 0 && dtpCheckIn.Value < dtpCheckOut.Value)
            {
                int nights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                if (nights <= 0) nights = 1; // minimum 1 night
                decimal total = currentRoomPrice * nights;
                txtTotalAmount.Text = total.ToString("F2");
            }
            else
            {
                txtTotalAmount.Text = "0.00";
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect data
                string guestName = txtName.Text;
                string guestEmail = txtEmail.Text;
                string guestPhone = txtPhoneNo.Text;
                int guestAge = int.Parse(txtage.Text);
                string gender = female.Checked ? "Female" : "Male";

                int newRoomId = (int)cbRoomNumber.SelectedValue;

                // Get current room id for comparison
                int oldRoomId = 0;
                string getOldRoomQuery = $"SELECT room_id FROM tbl_Booking WHERE booking_id = {bookingId}";
                DataTable dtOldRoom = new DataTable();
                dbConnections.readDatathroughAdapter(getOldRoomQuery, dtOldRoom);
                if (dtOldRoom.Rows.Count > 0)
                {
                    oldRoomId = Convert.ToInt32(dtOldRoom.Rows[0]["room_id"]);
                }

                bool roomChanged = oldRoomId != newRoomId;

                // Update booking
                string updateQuery = $@"
                    UPDATE tbl_Booking
                    SET guest_name = '{guestName}',
                        email = '{guestEmail}',
                        phone_number = '{guestPhone}',
                        age = {guestAge},
                        gender = '{gender}',
                        room_id = {newRoomId},
                        stay_type = '{cbStayType.SelectedItem?.ToString() ?? ""}',
                        method = '{cbMethod.SelectedItem?.ToString() ?? ""}',
                        amount = {decimal.Parse(txtTotalAmount.Text)},
                        advance_payment = {int.Parse(txtAdvPay.Text)},
                        checkin_date = '{dtpCheckIn.Value:yyyy-MM-dd}',
                        checkout_date = '{dtpCheckOut.Value:yyyy-MM-dd}',
                        no_guest= {Convert.ToInt32(nupNoOfGuests.Value)}
                    WHERE booking_id = {bookingId}";

                dbConnections.executeQuery(updateQuery);

                // Update room statuses if changed
                if (roomChanged)
                {
                    // Set old room as Available
                    string updateOldRoomStatus = $"UPDATE tbl_Room SET status='Available' WHERE room_id = {oldRoomId}";
                    dbConnections.executeQuery(updateOldRoomStatus);

                    // Set new room as Booked
                    string updateNewRoomStatus = $"UPDATE tbl_Room SET status='Booked' WHERE room_id = {newRoomId}";
                    dbConnections.executeQuery(updateNewRoomStatus);
                }

                MessageBox.Show("Booking updated successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message);
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Define RoomInfo class
    public class RoomInfo
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public string RoomNumber { get; set; }
        public decimal Price { get; set; }
        public string DisplayText => $"{RoomNumber} ({RoomType})"; // Optional
    }
}