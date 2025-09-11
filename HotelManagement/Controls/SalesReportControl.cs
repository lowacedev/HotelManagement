using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Windows.Forms;

namespace HotelManagement.Controls
{
    public partial class SalesReportControl : UserControl
    {
        public SalesReportControl()
        {
            InitializeComponent();
            this.Load += SalesReportControl_Load;
        }

        public string PageTitle { get; } = "Sales Report";

        private void SalesReportControl_Load(object sender, EventArgs e)
        {
           
            double bookingsValue = 5000;
            double servicesValue = 2000;

            pieChart1.Series = new ISeries[]
            {
                new PieSeries<double>
                {
                    Values = new double[] { bookingsValue },
                    Name = "Bookings",
                    DataLabelsSize = 14,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer
                },
                new PieSeries<double>
                {
                    Values = new double[] { servicesValue },
                    Name = "Services",
                    DataLabelsSize = 14,
                    DataLabelsPaint = new SolidColorPaint(SKColors.Black),
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Outer
                }
            };

            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;

            cartesianChart1.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values = new double[] { 4000, 5000, 6000, 3000, 7000, 8000 },
                    Name = "Bookings",
                    Fill = new SolidColorPaint(SKColors.CornflowerBlue)
                },
                new ColumnSeries<double>
                {
                    Values = new double[] { 2000, 2500, 3000, 1500, 3500, 4000 },
                    Name = "Services",
                    Fill = new SolidColorPaint(SKColors.Orange)
                }
            };

           
            cartesianChart1.XAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Month",
                    Labels = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun" }
                }
            };

           
            cartesianChart1.YAxes = new Axis[]
            {
                new Axis
                {
                    Name = "Amount",
                    Labeler = value => "$" + value
                }
            };
        }
    }
}
