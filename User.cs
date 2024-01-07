using Inventory_Management_System.DatabaseHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class User : Form
    {
        Database D = new Database();
        public User()
        {
            InitializeComponent();
            guna2DataGridView2Users.DataSource = D.Users_Select();
        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
