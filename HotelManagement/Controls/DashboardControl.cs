using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DatabaseProject; // Your namespace containing DbConnections

namespace HotelManagement.Forms
{
    public partial class DashboardControl : UserControl
    {
        private Chart salesPieChart;

        public DashboardControl()
        {
            InitializeComponent();
            InitializeChart();
            LoadAndDisplayData();
        }

        public string PageTitle => "Dashboard";

        private void InitializeChart()
        {
            salesPieChart = new Chart();
            salesPieChart.Dock = DockStyle.Fill;
            this.Controls.Add(salesPieChart);

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.Area3DStyle.Enable3D = true;
            salesPieChart.ChartAreas.Clear();
            salesPieChart.ChartAreas.Add(chartArea);

            salesPieChart.Series.Clear();

            Series pieSeries = new Series("Revenue by Date")
            {
                ChartType = SeriesChartType.Pie,
                IsVisibleInLegend = true
            };
            salesPieChart.Series.Add(pieSeries);

            salesPieChart.Legends.Clear();
            Legend legend = new Legend("MainLegend");
            legend.Enabled = true;
            salesPieChart.Legends.Add(legend);
        }

        // Fetch data from database
        private DataTable GetDailySalesData()
        {
            DataTable dt = new DataTable();
            string query = @"
                SELECT CAST(checkin_date AS DATE) AS sales_date, 
                       SUM(amount) AS total_revenue
                FROM dbo.tbl_Booking
                GROUP BY CAST(checkin_date AS DATE)
                ORDER BY sales_date";

            using (var db = new DbConnections())
            {
                db.readDatathroughAdapter(query, dt);
            }
            return dt;
        }

        // Load data into chart
        private void LoadAndDisplayData()
        {
            try
            {
                var dt = GetDailySalesData();

                var series = salesPieChart.Series["Revenue by Date"];
                series.Points.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string salesDate = Convert.ToDateTime(row["sales_date"]).ToString("MM-dd");
                    int totalRevenue = (int)row["total_revenue"];

                    series.Points.AddXY(salesDate, totalRevenue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}