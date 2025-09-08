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
        private int selectedRowIndex;

        public RoomsControl()
        {
            InitializeComponent();

            // Initialize context menu with "Edit" and "Delete"
            actionsMenu = new ContextMenuStrip();
            actionsMenu.Items.Add("Edit", null, EditMenuItem_Click);
            actionsMenu.Items.Add("Delete", null, DeleteMenuItem_Click);

            // Load data into DataGridView
            LoadRoomsData();

            // Attach CellContentClick event
            this.dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
                // The readDatathroughAdapter method is assumed to be correctly implemented.
                objdbConnections.readDatathroughAdapter(query, dtRooms);
                dataGridView1.DataSource = dtRooms;

                // Remove existing "Actions" column if it exists to prevent duplicates.
                if (dataGridView1.Columns.Contains("Actions"))
                {
                    dataGridView1.Columns.Remove("Actions");
                }

                // Add a single "Actions" button column.
                DataGridViewButtonColumn actionsButtonColumn = new DataGridViewButtonColumn();
                actionsButtonColumn.Name = "Actions";
                actionsButtonColumn.HeaderText = "Actions";
                actionsButtonColumn.Text = "Actions";
                actionsButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(actionsButtonColumn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "Actions" column and not in a header.
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Actions")
            {
                selectedRowIndex = e.RowIndex;

                // Get the display rectangle of the cell to position the context menu.
                var rect = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                var point = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height);
                actionsMenu.Show(dataGridView1, point);
            }
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                int roomId = Convert.ToInt32(row.Cells["room_id"].Value);

                // Open the edit form and pass the room ID.
                using (var editForm = new EditRoomForm(roomId))
                {
                    editForm.ShowDialog();
                }
                // Reload data after the edit form is closed.
                LoadRoomsData();
            }
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                int roomId = Convert.ToInt32(row.Cells["room_id"].Value);

                // Show a confirmation dialog before deleting.
                var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    string deleteQuery = $"DELETE FROM tbl_Room WHERE room_id = {roomId}";
                    try
                    {
                        // Execute the delete query using the DbConnections class.
                        objdbConnections.executeQuery(deleteQuery);
                        // Reload data after successful deletion.
                        LoadRoomsData();
                    }
                    catch (Exception ex)
                    {
                        // The error in the image is likely caught here.
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                }
            }
        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            // Open the add room form.
            using (var addForm = new AddRoomForm())
            {
                addForm.ShowDialog();
            }
            // Reload data after the add form is closed.
            LoadRoomsData();
        }
    }
}