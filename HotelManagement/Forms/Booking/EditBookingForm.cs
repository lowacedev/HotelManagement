using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelManagement.Forms.BookingsControl;

namespace HotelManagement.Forms
{



    public partial class EditBookingForm : Form
    {

        public EditBookingForm()
        {
           InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
