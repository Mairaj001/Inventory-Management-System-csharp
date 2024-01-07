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
    public partial class Submenu1 : Form
    {
        Database D = new Database();

        bool isTrue = false;
        public Submenu1()
        {
            InitializeComponent();
            deletedataGridView1.DataSource = D.Select();
            
        }
        private void UpdateTable()
        {
            deletedataGridView1.DataSource = D.Select();
        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            D.ProductName = ItemId.Text;

            isTrue = D.DeleteProduct();

            if(isTrue)
            {
                MessageBox.Show("Data delete sussesfuly");
                UpdateTable();
            }
            else
            {
                MessageBox.Show("Error while delting the data from the db");
            }
        }

        private void deletedataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex; int columnIndex = e.ColumnIndex;

            this.ItemId.Text = deletedataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            this.comboBoxCatogry.Text = deletedataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            this.comboBoxBrand.Text = deletedataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            this.comboBoxSize.Text = deletedataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            this.numericUpDownQuantity.Text = deletedataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            this.textBoxPrice.Text = deletedataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void Submenu1_Load(object sender, EventArgs e)
        {

        }
    }
}
