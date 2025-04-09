namespace EF_final_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlSidebar = new Panel();
            Offices = new Label();
            Home = new Label();
            Customer = new Label();
            Employee = new Label();
            OrderProduct = new Label();
            Order = new Label();
            Categories = new Label();
            Products = new Label();
            panel1 = new Panel();
            MainTitle = new Label();
            mainForm = new Panel();
            pnlSidebar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.ActiveCaption;
            pnlSidebar.BackgroundImage = (Image)resources.GetObject("pnlSidebar.BackgroundImage");
            pnlSidebar.BackgroundImageLayout = ImageLayout.None;
            pnlSidebar.Controls.Add(Offices);
            pnlSidebar.Controls.Add(Home);
            pnlSidebar.Controls.Add(Customer);
            pnlSidebar.Controls.Add(Employee);
            pnlSidebar.Controls.Add(OrderProduct);
            pnlSidebar.Controls.Add(Order);
            pnlSidebar.Controls.Add(Categories);
            pnlSidebar.Controls.Add(Products);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(250, 709);
            pnlSidebar.TabIndex = 0;
            // 
            // Offices
            // 
            Offices.AutoSize = true;
            Offices.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Offices.Location = new Point(72, 571);
            Offices.Name = "Offices";
            Offices.Size = new Size(98, 32);
            Offices.TabIndex = 8;
            Offices.Text = "Offices";
            Offices.TextAlign = ContentAlignment.MiddleCenter;
            Offices.Click += Offices_Click;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Home.Location = new Point(95, 128);
            Home.Name = "Home";
            Home.Size = new Size(0, 32);
            Home.TabIndex = 7;
            Home.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Customer.Location = new Point(63, 510);
            Customer.Name = "Customer";
            Customer.Size = new Size(127, 32);
            Customer.TabIndex = 6;
            Customer.Text = "Customers";
            Customer.TextAlign = ContentAlignment.MiddleCenter;
            Customer.Click += Customer_Click;
            // 
            // Employee
            // 
            Employee.AutoSize = true;
            Employee.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Employee.Location = new Point(65, 446);
            Employee.Name = "Employee";
            Employee.Size = new Size(125, 32);
            Employee.TabIndex = 5;
            Employee.Text = "Employees";
            Employee.TextAlign = ContentAlignment.MiddleCenter;
            Employee.Click += label1_Click;
            // 
            // OrderProduct
            // 
            OrderProduct.AutoSize = true;
            OrderProduct.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            OrderProduct.Location = new Point(38, 382);
            OrderProduct.Name = "OrderProduct";
            OrderProduct.Size = new Size(172, 32);
            OrderProduct.TabIndex = 4;
            OrderProduct.Text = "Order Product";
            OrderProduct.TextAlign = ContentAlignment.MiddleCenter;
            OrderProduct.Click += label2_Click;
            // 
            // Order
            // 
            Order.AutoSize = true;
            Order.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Order.Location = new Point(76, 319);
            Order.Name = "Order";
            Order.Size = new Size(92, 32);
            Order.TabIndex = 2;
            Order.Text = "Orders";
            Order.TextAlign = ContentAlignment.MiddleCenter;
            Order.Click += Order_Click;
            // 
            // Categories
            // 
            Categories.AutoSize = true;
            Categories.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Categories.Location = new Point(65, 254);
            Categories.Name = "Categories";
            Categories.Size = new Size(129, 32);
            Categories.TabIndex = 1;
            Categories.Text = "Categories";
            Categories.TextAlign = ContentAlignment.MiddleCenter;
            Categories.Click += Categories_Click;
            // 
            // Products
            // 
            Products.AutoSize = true;
            Products.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Italic);
            Products.Location = new Point(76, 191);
            Products.Name = "Products";
            Products.Size = new Size(109, 32);
            Products.TabIndex = 0;
            Products.Text = "Products";
            Products.TextAlign = ContentAlignment.MiddleLeft;
            Products.Click += Products_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(MainTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 78);
            panel1.TabIndex = 1;
            // 
            // MainTitle
            // 
            MainTitle.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MainTitle.Location = new Point(54, 0);
            MainTitle.MinimumSize = new Size(50, 10);
            MainTitle.Name = "MainTitle";
            MainTitle.Padding = new Padding(10);
            MainTitle.Size = new Size(784, 75);
            MainTitle.TabIndex = 1;
            MainTitle.Text = "Order Management System";
            // 
            // mainForm
            // 
            mainForm.AutoScroll = true;
            mainForm.BackgroundImage = (Image)resources.GetObject("mainForm.BackgroundImage");
            mainForm.BackgroundImageLayout = ImageLayout.Stretch;
            mainForm.Dock = DockStyle.Fill;
            mainForm.Location = new Point(250, 0);
            mainForm.Name = "mainForm";
            mainForm.Size = new Size(1038, 709);
            mainForm.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1288, 709);
            Controls.Add(panel1);
            Controls.Add(mainForm);
            Controls.Add(pnlSidebar);
            Name = "Form1";
            Text = "MainForm";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel panel1;
        private Label Order;
        private Label Categories;
        private Label Products;
        private Label MainTitle;
        private Panel mainForm;
        private Label Employee;
        private Label OrderProduct;
        private Label Customer;
        private Label Home;
        private Label Offices;
    }
}
