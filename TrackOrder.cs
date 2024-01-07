using Guna.UI2.WinForms;
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
    public partial class TrackOrder : Form
    {
        Database D = new Database();

        public TrackOrder()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        public int IsFOund = -1;
        public bool isTrue=false;
        private void guna2GradientButton1Track_Click(object sender, EventArgs e)
        {
            D.User_Email = guna2TextBox1EmailUser.Text;
            IsFOund = D.GetUserIdByEmail();

            if(IsFOund!=-1)
            {
                guna2DataGridView1.DataSource = D.Get_orders_wrt_email(IsFOund);

            }
            else
            {
                MessageBox.Show("Plaese create the account first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex; int columnIndex = e.ColumnIndex;
            Console.WriteLine("clicked");
            MessageBox.Show("Plaese create the account first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.guna2TextBox1Pid.Text = guna2DataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            this.guna2NumericUpDownQty1.Text = guna2DataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            
        }

        private void guna2DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex; int columnIndex = e.ColumnIndex;
            Console.WriteLine("clicked");
            MessageBox.Show("Plaese create the account first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.guna2TextBox1Pid.Text = guna2DataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            this.guna2NumericUpDownQty1.Text = guna2DataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void guna2NumericUpDownQty1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                D.Productid = Convert.ToInt32(guna2TextBox1Pid.Text);
                double p = D.GetProductPrice();

                double numeric_value = Convert.ToDouble(guna2NumericUpDownQty1.Value);
                p *= numeric_value;
                guna2HtmlLabel8PriceNew.Text = p.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Updatetabel()
        {
            guna2DataGridView1.DataSource = D.Get_orders_wrt_email(IsFOund);
        }
        private void guna2GradientButton3DeleteOrder_Click(object sender, EventArgs e)
        {
            D.orderId = Convert.ToInt32(guna2TextBox1Orderid.Text);
            isTrue = D.Delete_order();

            if (isTrue)
            {
                MessageBox.Show("Order deleted sussesfully");
                Updatetabel();
            }
            else
            {
                MessageBox.Show("Error occoured while deleting the order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guna2GradientButton2UpdateOrder_Click(object sender, EventArgs e)
        {
            D.Productid = Convert.ToInt32(guna2TextBox1Pid.Text);
            D.Quantity = Convert.ToInt32(guna2NumericUpDownQty1.Value);
            string totalPrice = guna2HtmlLabel8PriceNew.Text;
            totalPrice = totalPrice.Replace("$", "").Trim();

          
            decimal price = Convert.ToDecimal(totalPrice);
            D.User_address = guna2TextBox1Address.Text;
            D.orderId = Convert.ToInt32(guna2TextBox1Orderid.Text);

            isTrue = D.UpdateOrder(price);

            if (isTrue)
            {
                MessageBox.Show("Order updated sussesfully");
                Updatetabel();
            }
            else
            {
                MessageBox.Show("Error occoured while Updatingthe order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
