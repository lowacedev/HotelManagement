using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class RoomsControl : UserControl
    {
        public RoomsControl()
        {
            InitializeComponent();


        }
        public string PageTitle
        {
            get { return "Rooms Management"; }
        }

        private void FilterRooms(object sender, EventArgs e)
        {

        }

        private void addroombtn_Click(object sender, EventArgs e)
        {
            AddRoomForm frm = new AddRoomForm();
            frm.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
