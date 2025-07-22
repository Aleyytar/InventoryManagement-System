namespace InventoryManagement_System
{
    partial class ManageOrders
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
            panel1 = new Panel();
            button6 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            CustomerListGV = new DataGridView();
            OrderIdTb = new TextBox();
            CustomerIdTb = new TextBox();
            orderDatetime = new DateTimePicker();
            label5 = new Label();
            Catbox = new ComboBox();
            ProductListGV = new DataGridView();
            QuantityTb = new TextBox();
            label6 = new Label();
            button4 = new Button();
            OrderGV = new DataGridView();
            CustomerNameTb = new TextBox();
            label7 = new Label();
            TotalPriceLb = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerListGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductListGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 125);
            panel1.TabIndex = 4;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(3, 72);
            button6.Name = "button6";
            button6.Size = new Size(296, 46);
            button6.TabIndex = 7;
            button6.Text = "Test database connect";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(1331, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 54);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(286, 9);
            label2.Name = "label2";
            label2.Size = new Size(710, 60);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(469, 61);
            label1.Name = "label1";
            label1.Size = new Size(314, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 766);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 23);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(156, 128);
            label4.Name = "label4";
            label4.Size = new Size(233, 43);
            label4.TabIndex = 26;
            label4.Text = "CUSTOMER LİST";
            // 
            // CustomerListGV
            // 
            CustomerListGV.BackgroundColor = Color.White;
            CustomerListGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerListGV.Location = new Point(26, 174);
            CustomerListGV.Name = "CustomerListGV";
            CustomerListGV.RowHeadersWidth = 51;
            CustomerListGV.Size = new Size(532, 227);
            CustomerListGV.TabIndex = 27;
            CustomerListGV.CellContentClick += CustomerListGV_CellContentClick;
            // 
            // OrderIdTb
            // 
            OrderIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            OrderIdTb.ForeColor = Color.Crimson;
            OrderIdTb.Location = new Point(26, 424);
            OrderIdTb.Name = "OrderIdTb";
            OrderIdTb.Size = new Size(322, 34);
            OrderIdTb.TabIndex = 28;
            OrderIdTb.Text = "OrderId";
            // 
            // CustomerIdTb
            // 
            CustomerIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CustomerIdTb.ForeColor = Color.Crimson;
            CustomerIdTb.Location = new Point(26, 477);
            CustomerIdTb.Name = "CustomerIdTb";
            CustomerIdTb.Size = new Size(322, 34);
            CustomerIdTb.TabIndex = 29;
            CustomerIdTb.Text = "CustomerId";
            // 
            // orderDatetime
            // 
            orderDatetime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            orderDatetime.CalendarForeColor = Color.Crimson;
            orderDatetime.CalendarMonthBackground = Color.Crimson;
            orderDatetime.Location = new Point(26, 604);
            orderDatetime.Name = "orderDatetime";
            orderDatetime.Size = new Size(250, 27);
            orderDatetime.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(26, 577);
            label5.Name = "label5";
            label5.Size = new Size(89, 24);
            label5.TabIndex = 31;
            label5.Text = "Order Date";
            // 
            // Catbox
            // 
            Catbox.Font = new Font("Segoe UI", 12F);
            Catbox.ForeColor = Color.Crimson;
            Catbox.FormattingEnabled = true;
            Catbox.Location = new Point(879, 135);
            Catbox.Name = "Catbox";
            Catbox.Size = new Size(226, 36);
            Catbox.TabIndex = 33;
            Catbox.Text = " Product Category";
            Catbox.SelectedIndexChanged += Catbox_SelectedIndexChanged;
            // 
            // ProductListGV
            // 
            ProductListGV.BackgroundColor = Color.White;
            ProductListGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductListGV.Location = new Point(564, 174);
            ProductListGV.Name = "ProductListGV";
            ProductListGV.RowHeadersWidth = 51;
            ProductListGV.Size = new Size(807, 227);
            ProductListGV.TabIndex = 32;
            ProductListGV.CellContentClick += ProductGV_CellContentClick;
            // 
            // QuantityTb
            // 
            QuantityTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            QuantityTb.ForeColor = Color.Crimson;
            QuantityTb.Location = new Point(759, 417);
            QuantityTb.Name = "QuantityTb";
            QuantityTb.Size = new Size(322, 34);
            QuantityTb.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(681, 424);
            label6.Name = "label6";
            label6.Size = new Size(72, 24);
            label6.TabIndex = 35;
            label6.Text = "Quantity";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1087, 410);
            button4.Name = "button4";
            button4.Size = new Size(94, 49);
            button4.TabIndex = 36;
            button4.Text = " Add To";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // OrderGV
            // 
            OrderGV.BackgroundColor = Color.White;
            OrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGV.Location = new Point(376, 477);
            OrderGV.Name = "OrderGV";
            OrderGV.RowHeadersWidth = 51;
            OrderGV.Size = new Size(1004, 229);
            OrderGV.TabIndex = 37;
            OrderGV.CellContentClick += OrderGV_CellContentClick;
            // 
            // CustomerNameTb
            // 
            CustomerNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CustomerNameTb.ForeColor = Color.Crimson;
            CustomerNameTb.Location = new Point(26, 530);
            CustomerNameTb.Name = "CustomerNameTb";
            CustomerNameTb.Size = new Size(322, 34);
            CustomerNameTb.TabIndex = 38;
            CustomerNameTb.Text = "CustomerName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.RoyalBlue;
            label7.Location = new Point(803, 723);
            label7.Name = "label7";
            label7.Size = new Size(81, 24);
            label7.TabIndex = 39;
            label7.Text = "TotalPrice";
            // 
            // TotalPriceLb
            // 
            TotalPriceLb.AutoSize = true;
            TotalPriceLb.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPriceLb.ForeColor = Color.Black;
            TotalPriceLb.Location = new Point(890, 723);
            TotalPriceLb.Name = "TotalPriceLb";
            TotalPriceLb.Size = new Size(23, 23);
            TotalPriceLb.TabIndex = 40;
            TotalPriceLb.Text = "$";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 657);
            button1.Name = "button1";
            button1.Size = new Size(164, 49);
            button1.TabIndex = 41;
            button1.Text = "Insert Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(183, 657);
            button2.Name = "button2";
            button2.Size = new Size(165, 49);
            button2.TabIndex = 42;
            button2.Text = "View Orders";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 789);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TotalPriceLb);
            Controls.Add(label7);
            Controls.Add(CustomerNameTb);
            Controls.Add(OrderGV);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(QuantityTb);
            Controls.Add(Catbox);
            Controls.Add(ProductListGV);
            Controls.Add(label5);
            Controls.Add(orderDatetime);
            Controls.Add(CustomerIdTb);
            Controls.Add(OrderIdTb);
            Controls.Add(CustomerListGV);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerListGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductListGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView CustomerListGV;
        private TextBox OrderIdTb;
        private TextBox CustomerIdTb;
        private DateTimePicker orderDatetime;
        private Label label5;
        private ComboBox Catbox;
        private DataGridView ProductListGV;
        private TextBox QuantityTb;
        private Label label6;
        private Button button4;
        private DataGridView OrderGV;
        private TextBox CustomerNameTb;
        private Label label7;
        private Label TotalPriceLb;
        private Button button1;
        private Button button2;
    }
}