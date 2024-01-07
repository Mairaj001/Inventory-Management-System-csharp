namespace Inventory_Management_System
{
    partial class Submenu1
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
            this.deletedataGridView1 = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.Size = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.Brand = new System.Windows.Forms.Label();
            this.comboBoxCatogry = new System.Windows.Forms.ComboBox();
            this.catogry = new System.Windows.Forms.Label();
            this.ItemId = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // deletedataGridView1
            // 
            this.deletedataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(251)))));
            this.deletedataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deletedataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(251)))));
            this.deletedataGridView1.Location = new System.Drawing.Point(171, 385);
            this.deletedataGridView1.Name = "deletedataGridView1";
            this.deletedataGridView1.RowHeadersWidth = 51;
            this.deletedataGridView1.RowTemplate.Height = 24;
            this.deletedataGridView1.Size = new System.Drawing.Size(783, 184);
            this.deletedataGridView1.TabIndex = 28;
            this.deletedataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deletedataGridView1_RowHeaderMouseClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(78)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(464, 312);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(176, 34);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.BackColor = System.Drawing.Color.White;
            this.textBoxPrice.Location = new System.Drawing.Point(790, 238);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(212, 22);
            this.textBoxPrice.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(862, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quantity";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(447, 238);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(212, 22);
            this.numericUpDownQuantity.TabIndex = 23;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "XX-Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(98, 236);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(225, 24);
            this.comboBoxSize.TabIndex = 22;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size.Location = new System.Drawing.Point(166, 206);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(50, 27);
            this.Size.TabIndex = 21;
            this.Size.Text = "Size";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Gull Ahmed ",
            "Local",
            "Peshawri",
            "Nishat",
            "Zara",
            "Maria B",
            "Khaddi",
            "Asim Jofa",
            "Bonanza Satrangi",
            "Cross-stich",
            "Laam",
            "J.",
            "Almirah"});
            this.comboBoxBrand.Location = new System.Drawing.Point(790, 110);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(212, 24);
            this.comboBoxBrand.TabIndex = 20;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand.Location = new System.Drawing.Point(862, 80);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(69, 27);
            this.Brand.TabIndex = 19;
            this.Brand.Text = "Brand";
            // 
            // comboBoxCatogry
            // 
            this.comboBoxCatogry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCatogry.FormattingEnabled = true;
            this.comboBoxCatogry.Items.AddRange(new object[] {
            "Jeans",
            "Coat",
            "Shirt",
            "Casual",
            "Sweater",
            "Pashmina"});
            this.comboBoxCatogry.Location = new System.Drawing.Point(447, 108);
            this.comboBoxCatogry.Name = "comboBoxCatogry";
            this.comboBoxCatogry.Size = new System.Drawing.Size(212, 24);
            this.comboBoxCatogry.TabIndex = 18;
            // 
            // catogry
            // 
            this.catogry.AutoSize = true;
            this.catogry.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catogry.Location = new System.Drawing.Point(501, 78);
            this.catogry.Name = "catogry";
            this.catogry.Size = new System.Drawing.Size(88, 27);
            this.catogry.TabIndex = 17;
            this.catogry.Text = "Catogry";
            // 
            // ItemId
            // 
            this.ItemId.BackColor = System.Drawing.Color.White;
            this.ItemId.Location = new System.Drawing.Point(98, 108);
            this.ItemId.Name = "ItemId";
            this.ItemId.Size = new System.Drawing.Size(225, 22);
            this.ItemId.TabIndex = 16;
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(132, 80);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(144, 27);
            this.ProductName.TabIndex = 15;
            this.ProductName.Text = "ProductName";
            // 
            // Submenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(233)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1129, 629);
            this.Controls.Add(this.deletedataGridView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.comboBoxCatogry);
            this.Controls.Add(this.catogry);
            this.Controls.Add(this.ItemId);
            this.Controls.Add(this.ProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Submenu1";
            this.Text = "Submenu1";
            this.Load += new System.EventHandler(this.Submenu1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletedataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView deletedataGridView1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.ComboBox comboBoxCatogry;
        private System.Windows.Forms.Label catogry;
        private System.Windows.Forms.TextBox ItemId;
        private System.Windows.Forms.Label ProductName;
    }
}