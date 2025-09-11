using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Controls
{
    public partial class HumanResourceControl : UserControl
    {
        public string PageTitle { get; set; } = "Human Resource Management";
        public HumanResourceControl()
        {
            InitializeComponent();
        }
      
    }
}
