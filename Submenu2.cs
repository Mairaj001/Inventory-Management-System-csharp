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
    public partial class Submenu2 : Form
    {
        Database D = new Database();

        bool isTrue = false;

        

        public Submenu2()
        {
            InitializeComponent();
            AdddataGridView1.DataSource = D.Select();
        }

        private void AdddataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateTable()
        {
            AdddataGridView1.DataSource = D.Select();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            D.ProductName = ItemId.Text;
            D.catogry=comboBoxCatogry.Text;
            D.Brand=comboBoxBrand.Text;
            D.Size=comboBoxSize.Text;
            D.Quantity=Convert.ToInt32(numericUpDownQuantity.Value);
            D.Price=Convert.ToDouble(textBoxPrice.Text);

            isTrue = D.InsertProduct();

            if(isTrue)
            {
                MessageBox.Show("Prduct added sussesfuly");
               UpdateTable();
            }
            else{
                MessageBox.Show("Error occured while adding the product to the DB");
            }
            

        }

        private void Submenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
