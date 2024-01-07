using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System.DatabaseHandler
{
    public partial class Completed : Form
    {
        Database D = new Database();
        public Completed()
        {
            InitializeComponent();
            guna2DataGridView1Completed.DataSource= D.GetInCompletedOrdersDetails();
        }


        private void Completed_Load(object sender, EventArgs e)
        {

        }
    }
}
