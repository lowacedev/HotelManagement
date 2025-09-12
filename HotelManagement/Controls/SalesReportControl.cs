using DatabaseProject;
using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;
using SkiaSharp;
using System;
using System.Data;
using System.Windows.Forms; // For MessageBox

namespace HotelManagement.Controls
{
    public partial class SalesReportControl : UserControl
    {
        public SalesReportControl()
        {
            InitializeComponent();
            this.Load += SalesReportControl_Load;
        }
        public string PageTitle
        {
            get { return "Sales Report"; }
        }


        private void SalesReportControl_Load(object sender, EventArgs e)
        {
            LoadBookingData();

        }

        private void LoadBookingData()
        {
            string query = "SELECT booking_id, checkin_date, amount, method, gender, no_guest FROM tbl_Booking";

            DataTable dt = new DataTable();

            try
            {
                using (var db = new DbConnections())
                {
                    dt = new DataTable();
                    db.readDatathroughAdapter(query, dt);
                }
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching booking data: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}