using DatabaseProject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class AddBookingForm : Form
    {
        private DbConnections objdbConnections = new DbConnections();

        private class RoomInfo
        {
            public int RoomId { get; set; }
            public string RoomType { get; set; }
            public string RoomNumber { get; set; }
            public decimal Price { get; set; }
        }

        // List to hold available rooms
        private List<RoomInfo> availableRooms = new List<RoomInfo>();

        public AddBookingForm()
        {
            InitializeComponent();

            // Load available rooms when form loads
            LoadAvailableRooms();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // Get selected room number
            string selectedRoomNumber = cbRoomNumber.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRoomNumber))
            {
                MessageBox.Show("Please select a room number.");
                return;
            }

            // Find the RoomInfo object for the selected room number
            var selectedRoom = availableRooms.FirstOrDefault(r => r.RoomNumber == selectedRoomNumber);

            if (selectedRoom == null)
            {
                MessageBox.Show("Selected room not found.");
                return;
            }

            int selectedRoomId = selectedRoom.RoomId;

            // Collect other data from form controls
            string guestName = txtName.Text;
            string phoneNumber = txtPhoneNo.Text;
            string email = txtEmail.Text;
            int age = int.Parse(txtage.Text);
            string gender = female.Checked ? "Female" : "Male"; // example
            string method = cbMethod.SelectedItem.ToString();
            decimal amount = decimal.Parse(txtTotalAmount.Text);
            int advancePayment = 0;

            if (!int.TryParse(txtAdvPay.Text, out advancePayment))
            {
                MessageBox.Show("Please enter a valid number for advance payment.");
                return; // Exit the method if invalid
            }
            string stayType = cbStayType.SelectedItem.ToString();
            DateTime checkinDate = dtpCheckIn.Value;
            DateTime checkoutDate = dtpCheckOut.Value;
            int noGuest = int.Parse(nupNoOfGuests.Text);

            var db = new DbConnections();

            // Insert booking
            int result = db.InsertBooking(selectedRoomId, guestName, phoneNumber, email, age, gender, method, amount, advancePayment, stayType, checkinDate, checkoutDate, noGuest);

            if (result > 0)
            {
                // Update room status to "Booked"
                db.UpdateRoomStatus(selectedRoomId, "Booked");
                MessageBox.Show("Booking successfully added!");
                this.Close();
            }
        }

        private void LoadAvailableRooms()
        {
            DataTable dtRooms = new DataTable();

            // Call your DB method to fill dtRooms with room details including price
            objdbConnections.readDatathroughAdapter(@"
                SELECT room_id, room_type, room_number, price
                FROM tbl_Room
                WHERE status = 'Available'", dtRooms);

            // Populate the list of available rooms
            availableRooms.Clear();
            foreach (DataRow row in dtRooms.Rows)
            {
                availableRooms.Add(new RoomInfo
                {
                    RoomId = Convert.ToInt32(row["room_id"]),
                    RoomType = row["room_type"].ToString(),
                    RoomNumber = row["room_number"].ToString(),
                    Price = Convert.ToDecimal(row["price"])
                });
            }

            // Populate Room Type ComboBox
            var roomTypes = availableRooms
                .Select(r => r.RoomType)
                .Distinct()
                .ToList();

            cbRoomType.DataSource = roomTypes;

            // Handle selection change for Room Type
            cbRoomType.SelectedIndexChanged += (s, e) =>
            {
                string selectedType = cbRoomType.SelectedItem.ToString();
                var roomNumbers = availableRooms
                    .Where(r => r.RoomType == selectedType)
                    .Select(r => r.RoomNumber)
                    .ToList();

                cbRoomNumber.DataSource = roomNumbers;
            };

            // After setting the room number data source, attach the selection changed event
            // First, ensure previous handlers are removed to prevent multiple subscriptions
            cbRoomNumber.SelectedIndexChanged -= cbRoomNumber_SelectedIndexChanged;
            cbRoomNumber.SelectedIndexChanged += cbRoomNumber_SelectedIndexChanged;

            // Optionally, select the first room type by default
            if (cbRoomType.Items.Count > 0)
            {
                cbRoomType.SelectedIndex = 0;
            }
        }

        // Define the event handler method for room number selection
        private void cbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoomNumber = cbRoomNumber.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRoomNumber))
                return;

            var selectedRoom = availableRooms.FirstOrDefault(r => r.RoomNumber == selectedRoomNumber);
            if (selectedRoom != null)
            {
                txtTotalAmount.Text = selectedRoom.Price.ToString("F2");
            }
        }
    }
}