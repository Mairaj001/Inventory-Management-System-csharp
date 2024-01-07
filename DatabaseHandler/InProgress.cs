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
    public partial class InProgress : Form
    {
        Database D = new Database();    
        bool isTrue=false;
        public InProgress()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = D.GetInProgressOrdersDetails();
        }

        private void InProgress_Load(object sender, EventArgs e)
        {

        }

        private void UpdateTable()
        {
            guna2DataGridView1.DataSource = D.GetInProgressOrdersDetails();
        }
        private void guna2GradientButton1Track_Click(object sender, EventArgs e)
        {
            D.orderId = Convert.ToInt32(guna2TextBox1orderId.Text);
            //isTrue = D.UpdateOrderStatus();

            
               
                var temp = D.GetProductAndQuantityFromOrder();
                int productid = temp.productId;
                int quantity = temp.quantity;

                int ProdcutQuantity = D.GetProductQuantity(productid);

                int temp_quant = ProdcutQuantity - quantity;
                if (temp_quant < 0)
                {
                    MessageBox.Show("Unable to ship due to unavailability of the Products in the Store ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   isTrue = D.UpdateProductQuantity(productid, temp_quant);
                   if(isTrue)
                   {
                    D.UpdateOrderStatus();
                    MessageBox.Show("Order shiped sussesfully");
                    UpdateTable();

                   }
                   else
                   {
                    MessageBox.Show("error in DB ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            
            
        }
        
    }
}
