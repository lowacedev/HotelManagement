using HotelManagement.Controls;
using HotelManagement.Forms;
using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelMain.Padding = new Padding(0, 62, 0, 0);
            this.FormBorderStyle = FormBorderStyle.None;   // Remove borders and title bar
            this.WindowState = FormWindowState.Maximized;  // Maximize the window
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panelMain_Paint(object sender, PaintEventArgs e) { }
        private void panelHeader_Paint(object sender, PaintEventArgs e) { }

        // ? Universal LoadPage method
        private void LoadPage(UserControl page)
        {
            panelMain.Controls.Clear();        // Clear previous control
            page.Dock = DockStyle.Fill;        // Fill the panel
            panelMain.Controls.Add(page);      // Add the new page

            try
            {
                var pageWithTitle = page as dynamic;
                if (pageWithTitle != null && pageWithTitle.PageTitle != null)
                {
                    SetPageTitle(pageWithTitle.PageTitle);
                }
                else
                {
                    SetPageTitle("Hotel Management System");
                }
            }
            catch
            {
                SetPageTitle("Hotel Management System");
            }
        }

        public void SetPageTitle(string title)
        {
            lblPageTitle.Text = title;
        }

        // ? Button events
        private void btndashboard_Click(object sender, EventArgs e)
        {
            LoadPage(new DashboardControl());
        }

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            LoadPage(new RoomsControl());
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            LoadPage(new BookingsControl());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadPage(new InventoryControl());
        }


        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            LoadPage(new SalesReportControl());
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            LoadPage(new ServiceControl());
        }

        private void btnHumanResource_Click(object sender, EventArgs e)
        {
            LoadPage(new HumanResourceControl());
        }

        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            LoadPage(new HousekeepingControl());
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(btnUserMenu, new Point(0, btnUserMenu.Height));
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LoginForm newForm = new LoginForm();
            newForm.Show();
            this.Hide();
        }
    }
        
    
}
