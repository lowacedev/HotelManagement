using DatabaseProject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement
{
    
    public partial class AddRoomForm : Form
    {
        DbConnections objdbConnections = new DbConnections();
        public AddRoomForm()
        {
            InitializeComponent();

            int radius = 20;
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int roomNo = int.Parse(txtRoomNo.Text);
            string roomtype = txtroomtype.Text;
            int price = int.Parse(txtprice.Text);
            string status = txtstatus.Text;
            if (roomNo.Equals(""))
            {
                MessageBox.Show("Required Room No.");
            }
            else if (roomtype.Equals(""))
            {
                MessageBox.Show("Required Room Type");
            }
            else
            {
                SqlCommand insertCommand = new SqlCommand("insert into tbl_Room(room_number, room_type, price, status) values(@roomno, @roomtype, @price, @status)");
            // insertCommand.Parameters.AddWithValue("@ID", ID);
insertCommand.Parameters.AddWithValue("@roomno", roomNo);
                insertCommand.Parameters.AddWithValue("@roomtype", roomtype);
                insertCommand.Parameters.AddWithValue("@price", price);
                insertCommand.Parameters.AddWithValue("@status", status);
                int row = objdbConnections.executeQuery(insertCommand);
                if (row == 1)
                {
                    MessageBox.Show("The Record has been Added!");
                    
                }
            }
        }
    }
}
