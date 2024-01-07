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
using System.Windows.Forms.VisualStyles;

namespace Inventory_Management_System
{
    public partial class Dashboard : Form
    {
        Database database = new Database();

        public int Toatal_items = 0;
        public double k = 2;

        public Dashboard()
        {
           
            InitializeComponent();
            pbar.Value = 0;
            labelTotalSales.Text = Convert.ToString(database.GetTotalPriceOfCompletedOrders());
            labelOrders.Text = Convert.ToString(database.GetTotalRowsInOrders());
            TotalCustomers.Text= Convert.ToString(database.GetTotalRowsInCustomers());
            Totalitems.Text = Convert.ToString(database.GetTotalQuantityOfProducts());
            Toatal_items=database.GetTotalQuantityOfProducts();
            Console.WriteLine(Toatal_items);
            k = ((double)Toatal_items  / 5000) * 100;
            Console.WriteLine(k);
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbar.Value >= pbar.Maximum)
            {
                timer1.Enabled = false;
            }
            else
            {
                pbar.Value += 1;
                pbar.Text = pbar.Value.ToString() + "%";

                
                if (pbar.Value >= k)
                {
                    timer1.Enabled = false;
                }
            }
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
