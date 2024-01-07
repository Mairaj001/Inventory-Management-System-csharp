using Inventory_Management_System.DatabaseHandler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {

        Dashboard dashboard;
        Submenu1 submenu1;
        Submenu2 submenu2;
        About about;
        
        User user;
        Update update;
        Orders orders;

        private bool drag=false;
        private Point start_point = new Point (0,0);



        public Form1()
        {
            InitializeComponent();
            
            OpenChildForm(new Dashboard());
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Height >= 70 || flowLayoutPanel2Order.Height >= 210)
            {
                if (MenuContainer.Height >= 70)
                    MenuTransistion.Start();
                if (flowLayoutPanel2Order.Height >= 210)
                    Menu2Transistion.Start();
            }

            OpenChildForm(new Dashboard());
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menu_expand = true;

        private void MenuTransistion_Tick(object sender, EventArgs e)
        {
            if(menu_expand)
            {
                MenuContainer.Height += 10;
                if(MenuContainer.Height >= 230)
                {
                    MenuTransistion.Stop();
                    menu_expand = false;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if(MenuContainer.Height<=70)
                {
                    MenuTransistion.Stop();
                    menu_expand = true;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Height >= 70 || flowLayoutPanel2Order.Height >= 210)
            {
                
                if (flowLayoutPanel2Order.Height >= 210)
                    Menu2Transistion.Start();
            }
            MenuTransistion.Start();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool sidebar_expand=true;
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if(sidebar_expand)
            {
                Sidebar.Width -= 10;
                if(Sidebar.Width<=65)
                {
                    sidebar_expand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;
                if(Sidebar.Width>=200)
                {
                    sidebar_expand=true;
                    SidebarTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

    
        private void button4_Click(object sender, EventArgs e)
        {


            OpenChildForm(new Submenu1());
        }

      

      
        private void button5_Click(object sender, EventArgs e)
        {

            //submenu2
            OpenChildForm(new Submenu2());
           
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            //about
            if (MenuContainer.Height >= 70 || flowLayoutPanel2Order.Height >= 210)
            {
                if(MenuContainer.Height >= 70)
                MenuTransistion.Start();
                if(flowLayoutPanel2Order.Height >= 210)
                Menu2Transistion.Start();
            }

            OpenChildForm(new About());
        }

       

        private void Update_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Update());
        }

        private Form activeForm = null;

        private void OpenChildForm(Form child)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = child;
            activeForm.MdiParent= this;
            activeForm.Dock = DockStyle.Fill;
            activeForm.Show();
            
        }

       



        private void Users_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Height >= 70 || flowLayoutPanel2Order.Height >= 210)
            {
                if (MenuContainer.Height >= 70)
                    MenuTransistion.Start();
                if (flowLayoutPanel2Order.Height >= 210)
                    Menu2Transistion.Start();
            }
            OpenChildForm(new User());
        }


       


        private void button7_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Height >= 70 || flowLayoutPanel2Order.Height >= 210)
            {
                if (MenuContainer.Height >= 70)
                    MenuTransistion.Start();
                if (flowLayoutPanel2Order.Height >= 210)
                    Menu2Transistion.Start();
            }
            //logout
            Mainpage form = new Mainpage();
            form.Show();
            this.Visible = false;
        }


        


        public bool menu_expand2 = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (MenuContainer.Height >= 70)
            {
                MenuTransistion.Start();
                
            }

            Menu2Transistion.Start();
            //orders
           

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //max min
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //max min
            
            
            this.WindowState = FormWindowState.Minimized;
          
                //this.WindowState= FormWindowState.Normal;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Menu2Transistion_Tick(object sender, EventArgs e)
        {
            if (menu_expand2)
            {
                flowLayoutPanel2Order.Height += 10;
                if (flowLayoutPanel2Order.Height >= 210)
                {
                    Menu2Transistion.Stop();
                    menu_expand2 = false;
                }
            }
            else
            {
                flowLayoutPanel2Order.Height -= 10;
                if (flowLayoutPanel2Order.Height <= 69)
                {
                    Menu2Transistion.Stop();
                    menu_expand2 = true;

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new InProgress());

        }

        private void CompeletedOrders_Click(object sender, EventArgs e)
        {
            //order completed submenu
            OpenChildForm(new Completed());


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y-start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag=false;
        }
    }
}
