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
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // open the credential form 
            Form1 form = new Form1();
            form.Show();
            Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            UserForm form = new UserForm();
            form.Show();
            Visible=false;
        }
    }
}
