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
    public partial class CreateAccount : Form
    {
        Database D = new Database();
        public bool IsTrue=false;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //create accout goes direct to the db
            D.User_Name = guna2TextBox1NameUser.Text;
            D.User_Email= guna2TextBox1EmailUser.Text;
            D.gender = guna2ComboBox1.Text;
            IsTrue = D.InsertUser();

            if(IsTrue )
            {
                MessageBox.Show("Account created sussesfully");
            }
            else
            {
                MessageBox.Show("An error occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
