using DatabaseProject; // Your database connection class
using HotelManagement.Forms.Room;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomsControl : UserControl
    {
        private DbConnections objdbConnections = new DbConnections();
        private ContextMenuStrip actionsMenu;
        private int selectedRoomId = -1; // Store selected room ID

        public RoomsControl()
        {
            InitializeComponent();
            actionsMenu = new ContextMenuStrip();
            LoadRoomsData();
            actionsMenu.Items.Add("Edit", null, editToolStripMenuItem_Click);

            // Attach MouseDown event to detect right-clicks
            this.dataGridView1.MouseDown += dataGridView1_MouseDown;
        }

        public string PageTitle
        {
            get { return "Rooms Management"; }
        }

        private void LoadRoomsData()
        {
            DataTable dtRooms = new DataTable();
            string query = "SELECT * FROM tbl_Room";

            try
            {
                objdbConnections.readDatathroughAdapter(query, dtRooms);
                dataGridView1.DataSource = dtRooms;

                // Hide the "room_id" column if it exists
                if (dataGridView1.Columns.Contains("room_id"))
                {
                    dataGridView1.Columns["room_id"].Visible = false;
                }

                // Set custom headers for your specific columns
                if (dataGridView1.Columns.Contains("room_number"))
                    dataGridView1.Columns["room_number"].HeaderText = "Room Number";

                if (dataGridView1.Columns.Contains("room_type"))
                    dataGridView1.Columns["room_type"].HeaderText = "Room Type";

                if (dataGridView1.Columns.Contains("price"))
                    dataGridView1.Columns["price"].HeaderText = "Price Per Night";

                if (dataGridView1.Columns.Contains("status"))
                    dataGridView1.Columns["status"].HeaderText = "Status";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    // Select the row under the mouse
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;

                    // Retrieve the room_id
                    var row = dataGridView1.Rows[hit.RowIndex];
                    if (row.Cells["room_id"].Value != null)
                    {
                        selectedRoomId = Convert.ToInt32(row.Cells["room_id"].Value);
                    }
                    else
                    {
                        selectedRoomId = -1;
                    }

                    // Show context menu at mouse position
                    actionsMenu.Show(dataGridView1, e.Location);
                }
            }
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddRoomForm())
            {
                addForm.ShowDialog();
            }
            LoadRoomsData();
        }

        private void contextMenuRooms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Optional: enable/disable menu items based on context
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRoomId != -1)
            {
                using (var editForm = new EditRoomForm(selectedRoomId))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadRoomsData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please right-click on a valid row to edit.");
            }
        }
    }
}