using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HotelManagement.Forms
{
    public partial class BookingsControl : UserControl
    {
        public BookingsControl()
        {
            InitializeComponent();
        }
        public string PageTitle
        {
            get { return "Bookings"; }
        }

        private void DGVBookings_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            AddBookingForm addBookingForm = new AddBookingForm();
            addBookingForm.ShowDialog();
        }
    }
}
