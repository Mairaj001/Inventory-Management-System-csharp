namespace Inventory_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.flowLayoutPanel2Order = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.CompeletedOrders = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.MenuTransistion = new System.Windows.Forms.Timer(this.components);
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.Menu2Transistion = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.flowLayoutPanel2Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1203, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(82, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(44, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 30);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(512, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Sidebar.Controls.Add(this.button1);
            this.Sidebar.Controls.Add(this.MenuContainer);
            this.Sidebar.Controls.Add(this.flowLayoutPanel2Order);
            this.Sidebar.Controls.Add(this.Users);
            this.Sidebar.Controls.Add(this.button6);
            this.Sidebar.Controls.Add(this.button7);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 57);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(200, 629);
            this.Sidebar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "        DashBoard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.MenuContainer.Controls.Add(this.button3);
            this.MenuContainer.Controls.Add(this.button5);
            this.MenuContainer.Controls.Add(this.button4);
            this.MenuContainer.Controls.Add(this.Update);
            this.MenuContainer.Location = new System.Drawing.Point(0, 61);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(194, 69);
            this.MenuContainer.TabIndex = 2;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button3.Size = new System.Drawing.Size(191, 49);
            this.button3.TabIndex = 8;
            this.button3.Text = "      Inventory";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "       Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "        Remove";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.Color.White;
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update.Location = new System.Drawing.Point(3, 182);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(153, 49);
            this.Update.TabIndex = 9;
            this.Update.Text = "        Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // flowLayoutPanel2Order
            // 
            this.flowLayoutPanel2Order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel2Order.Controls.Add(this.button2);
            this.flowLayoutPanel2Order.Controls.Add(this.button8);
            this.flowLayoutPanel2Order.Controls.Add(this.CompeletedOrders);
            this.flowLayoutPanel2Order.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel2Order.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2Order.Name = "flowLayoutPanel2Order";
            this.flowLayoutPanel2Order.Size = new System.Drawing.Size(200, 72);
            this.flowLayoutPanel2Order.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "        Orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 79);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 49);
            this.button8.TabIndex = 12;
            this.button8.Text = "        Inprogress";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // CompeletedOrders
            // 
            this.CompeletedOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.CompeletedOrders.FlatAppearance.BorderSize = 0;
            this.CompeletedOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompeletedOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompeletedOrders.ForeColor = System.Drawing.Color.White;
            this.CompeletedOrders.Image = ((System.Drawing.Image)(resources.GetObject("CompeletedOrders.Image")));
            this.CompeletedOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CompeletedOrders.Location = new System.Drawing.Point(3, 148);
            this.CompeletedOrders.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.CompeletedOrders.Name = "CompeletedOrders";
            this.CompeletedOrders.Size = new System.Drawing.Size(169, 49);
            this.CompeletedOrders.TabIndex = 13;
            this.CompeletedOrders.Text = "        Completed";
            this.CompeletedOrders.UseVisualStyleBackColor = false;
            this.CompeletedOrders.Click += new System.EventHandler(this.CompeletedOrders_Click);
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.Users.FlatAppearance.BorderSize = 0;
            this.Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.ForeColor = System.Drawing.Color.White;
            this.Users.Image = ((System.Drawing.Image)(resources.GetObject("Users.Image")));
            this.Users.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Users.Location = new System.Drawing.Point(3, 212);
            this.Users.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(194, 49);
            this.Users.TabIndex = 11;
            this.Users.Text = "        Users";
            this.Users.UseVisualStyleBackColor = false;
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 281);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 49);
            this.button6.TabIndex = 5;
            this.button6.Text = "        About";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 350);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "        Logout";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MenuTransistion
            // 
            this.MenuTransistion.Interval = 10;
            this.MenuTransistion.Tick += new System.EventHandler(this.MenuTransistion_Tick);
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // Menu2Transistion
            // 
            this.Menu2Transistion.Interval = 20;
            this.Menu2Transistion.Tick += new System.EventHandler(this.Menu2Transistion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1329, 686);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.flowLayoutPanel2Order.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Timer MenuTransistion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Users;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2Order;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button CompeletedOrders;
        private System.Windows.Forms.Timer Menu2Transistion;
    }
}

