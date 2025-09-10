using HotelManagement.Forms;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelMain.Padding = new Padding(0, 62, 0, 0);
            this.FormBorderStyle = FormBorderStyle.None; // Remove borders and title bar
            this.WindowState = FormWindowState.Maximized; // Maximize the window

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadPage(UserControl page)
        {
            panelMain.Controls.Clear();        // Clear previous control
            page.Dock = DockStyle.Fill;        // Fill the panel
            panelMain.Controls.Add(page);      // Add the new page

            var pageWithTitle = page as dynamic;
            if (pageWithTitle != null && pageWithTitle.PageTitle != null)
            {
                SetPageTitle(pageWithTitle.PageTitle);
            }
        }
        public void SetPageTitle(string title)
        {
            lblPageTitle.Text = title;
        }

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            RoomsControl roomsPage = new RoomsControl();
            LoadPage(roomsPage);

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardControl());
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnBookings_Click(object sender, EventArgs e)
        {
            BookingsControl bookingsPage = new BookingsControl();
            LoadPage(bookingsPage);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryControl inventoryPage = new InventoryControl();
            LoadPage(inventoryPage);
        }

        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            HousekeepingControl housekeepingControl = new HousekeepingControl();
            LoadPage(housekeepingControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to logout?");
            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UserControl UserControl = new UserControl();
            LoadPage(UserControl);
        }
    }
}
