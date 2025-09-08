using DatabaseProject;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Forms.Room
{
    public partial class EditRoomForm : Form
    {
        private int roomId;
        private DbConnections objdbConnections = new DbConnections();

        public EditRoomForm(int roomId)
        {
            InitializeComponent();
            this.roomId = roomId;
        }

        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            string query = $"SELECT * FROM tbl_Room WHERE room_id = {roomId}";
            DataTable dt = new DataTable();

            try
            {
                objdbConnections.readDatathroughAdapter(query, dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    // Populate your text fields here
                    txtRoomNo.Text = row["room_number"].ToString(); // Adjust column name
                    txtroomtype.Text = row["room_type"].ToString(); // Adjust column name
                    txtprice.Text = row["price"].ToString(); // Adjust column name
                    txtstatus.Text = row["status"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading room data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Collect data from text fields
            string roomNumber = txtRoomNo.Text;
            string roomType = txtroomtype.Text;
            string status = txtstatus.Text;
            decimal price;
            if (!decimal.TryParse(txtprice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            // Build update query
            string updateQuery = $"UPDATE tbl_Room SET " +
                $"room_number = '{roomNumber}', " +
                $"room_type = '{roomType}', " +
                $"price = {price}, " +
                $"status = '{status}' " +
                $"WHERE room_id = {roomId}";

            try
            {
                objdbConnections.executeQuery(updateQuery);
                MessageBox.Show("Room updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating room: " + ex.Message);
            }
        }


        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}