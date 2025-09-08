using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Forms
{
    public partial class InventoryControl : UserControl
    {
        public InventoryControl()
        {
            InitializeComponent();
        }
        public string PageTitle
        {
            get { return "Inventory"; }
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            AddInventoryForm addInventoryForm = new AddInventoryForm();
            addInventoryForm.ShowDialog();
        }

        private void restockToolStripRestock_Click(object sender, EventArgs e)
        {
            RestockForm restockForm = new RestockForm();
            restockForm.ShowDialog();
        }
    }
}
