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
    public partial class Update : Form
    {
        Database D = new Database();

        bool isTrue = false;

        private void UpdateTable()
        {
           UpdatedataGridView1.DataSource = D.Select();
        }
        public Update()
        {
            InitializeComponent();

            UpdatedataGridView1.DataSource = D.Select();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            D.ProductName = ItemId.Text;
            D.catogry = comboBoxCatogry.Text;
            D.Brand = comboBoxBrand.Text;
            D.Size = comboBoxSize.Text;
            D.Quantity = Convert.ToInt32(numericUpDownQuantity.Value);
            D.Price = Convert.ToDouble(textBoxPrice.Text);

            Console.WriteLine(D.ProductName);

            isTrue = D.UpdateProduct();

            if (isTrue)
            {
                MessageBox.Show("Data updated susessfully");
                UpdateTable();
            }
            else
            {
                MessageBox.Show("Error occured while updating the product on the DB");
            }
        }

        private void UpdatedataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; int columnIndex = e.ColumnIndex;

            this.ItemId.Text = UpdatedataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            this.comboBoxCatogry.Text = UpdatedataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            this.comboBoxBrand.Text = UpdatedataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            this.comboBoxSize.Text = UpdatedataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            this.numericUpDownQuantity.Text = UpdatedataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            this.textBoxPrice.Text = UpdatedataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        
    }
}
