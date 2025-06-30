namespace InventoryManagement_System
{
    partial class ManageCustomerscs
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
            CustomeIdTb = new TextBox();
            CustomerNameTb = new TextBox();
            CustomerPhoneTb = new TextBox();
            label4 = new Label();
            customersGV = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 72);
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
            label1.Size = new Size(387, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // CustomeIdTb
            // 
            CustomeIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CustomeIdTb.ForeColor = Color.Crimson;
            CustomeIdTb.Location = new Point(12, 187);
            CustomeIdTb.Name = "CustomeIdTb";
            CustomeIdTb.Size = new Size(322, 34);
            CustomeIdTb.TabIndex = 2;
            CustomeIdTb.Text = "CustomerId";
            CustomeIdTb.TextChanged += UnameTb_TextChanged;
            // 
            // CustomerNameTb
            // 
            CustomerNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CustomerNameTb.ForeColor = Color.Crimson;
            CustomerNameTb.Location = new Point(12, 236);
            CustomerNameTb.Name = "CustomerNameTb";
            CustomerNameTb.Size = new Size(322, 34);
            CustomerNameTb.TabIndex = 3;
            CustomerNameTb.Text = "CustomerName";
            // 
            // CustomerPhoneTb
            // 
            CustomerPhoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CustomerPhoneTb.ForeColor = Color.Crimson;
            CustomerPhoneTb.Location = new Point(12, 287);
            CustomerPhoneTb.Name = "CustomerPhoneTb";
            CustomerPhoneTb.Size = new Size(322, 34);
            CustomerPhoneTb.TabIndex = 4;
            CustomerPhoneTb.Text = "CustomerPhone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(689, 128);
            label4.Name = "label4";
            label4.Size = new Size(263, 43);
            label4.TabIndex = 12;
            label4.Text = "CUSTOMERS LİST";
            // 
            // customersGV
            // 
            customersGV.BackgroundColor = Color.White;
            customersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersGV.Location = new Point(372, 187);
            customersGV.Name = "customersGV";
            customersGV.RowHeadersWidth = 51;
            customersGV.Size = new Size(917, 331);
            customersGV.TabIndex = 13;
            customersGV.CellContentClick += customersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 673);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 23);
            panel2.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(126, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 16;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(226, 342);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(126, 403);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 18;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(372, 543);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 115);
            panel3.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(143, 31);
            label5.TabIndex = 8;
            label5.Text = "Order Count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(76, 49);
            label6.Name = "label6";
            label6.Size = new Size(85, 31);
            label6.TabIndex = 9;
            label6.Text = "Orders";
            label6.Click += label6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(702, 543);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 115);
            panel4.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(80, 49);
            label7.Name = "label7";
            label7.Size = new Size(97, 31);
            label7.TabIndex = 9;
            label7.Text = "Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(164, 31);
            label8.TabIndex = 8;
            label8.Text = "Order Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(1039, 543);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 115);
            panel5.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.White;
            label9.Location = new Point(80, 49);
            label9.Name = "label9";
            label9.Size = new Size(63, 31);
            label9.TabIndex = 9;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.White;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(177, 31);
            label10.TabIndex = 8;
            label10.Text = "Last Order Date";
            // 
            // ManageCustomerscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 696);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(customersGV);
            Controls.Add(label4);
            Controls.Add(CustomerPhoneTb);
            Controls.Add(CustomerNameTb);
            Controls.Add(CustomeIdTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomerscs";
            Text = "ManageCustomers";
            Load += ManageCustomerscs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CustomeIdTb;
        private TextBox CustomerNameTb;
        private TextBox CustomerPhoneTb;
        private Label label4;
        private DataGridView customersGV;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel3;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private Label label10;
    }
}