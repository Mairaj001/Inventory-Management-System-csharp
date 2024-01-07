using Inventory_Management_System.DatabaseHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class UserForm : Form
    {
        Database D = new Database();
        private bool drag = false;
        private Point start_point = new Point(0, 0);
        public UserForm()
        {
            InitializeComponent();
            guna2DataGridView1.DataSource = D.Select();
            guna2Panel8subButtons.Visible = false;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel2Quantity_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Mainpage page = new Mainpage();
            page.Show();
            this.Visible = false;
            this.Dispose();
        }



        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                D.Productid = Convert.ToInt32(guna2TextBox1Pid.Text);
                double p = D.GetProductPrice();

                double numeric_value = Convert.ToDouble(guna2NumericUpDown1.Value);
                p *= numeric_value;
                guna2HtmlLabel8Price.Text =  p.ToString();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool isTrue=false;
        public int isFounduser = -1;
        bool allowdb = false;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
                D.User_Name = guna2TextBox1Name.Text;
                D.User_Email = guna2TextBox2Email.Text;
                D.User_address = guna2TextBox1Address.Text;//ya
                D.Productid = Convert.ToInt32(guna2TextBox1Pid.Text);//ya
                D.Quantity = Convert.ToInt32(guna2NumericUpDown1.Value);//ya
                string totalPrice = guna2HtmlLabel8Price.Text;
                totalPrice = totalPrice.Replace("$","").Trim();
                
                 Console.WriteLine(totalPrice);
                decimal price = Convert.ToDecimal(totalPrice);
                D.Total_price= price;


                isFounduser = D.GetUserIdByEmail();//ya

                if (isFounduser != -1)
                {
                allowdb = true;

                }
                else
                {
                    MessageBox.Show("Plaese create the account first then you have allowed to order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if(allowdb)
                {
                    isTrue = D.InsertOrder(isFounduser);
                }

                Console.WriteLine(isFounduser);
            }
            



        

        
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (guna2Panel8subButtons.Visible == true)
            {
                guna2Panel8subButtons.Visible = false;
               
            }
            else
            {
                guna2Panel8subButtons.Visible = true;
            }
        }

        private void button2CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();

        }

        private void button1TrackOrders_Click(object sender, EventArgs e)
        {
            TrackOrder trackOrder = new TrackOrder();
            trackOrder.Show();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
                
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
