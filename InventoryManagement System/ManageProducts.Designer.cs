namespace InventoryManagement_System
{
    partial class ManageProducts
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
            CategoryIdTb = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            CatBox = new ComboBox();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            ProductGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).BeginInit();
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
            panel1.TabIndex = 3;
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
            label1.Size = new Size(354, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 673);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 23);
            panel2.TabIndex = 4;
            // 
            // CategoryIdTb
            // 
            CategoryIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CategoryIdTb.ForeColor = Color.Crimson;
            CategoryIdTb.Location = new Point(12, 188);
            CategoryIdTb.Name = "CategoryIdTb";
            CategoryIdTb.Size = new Size(322, 34);
            CategoryIdTb.TabIndex = 5;
            CategoryIdTb.Text = "ProductId";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(12, 238);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 34);
            textBox1.TabIndex = 6;
            textBox1.Text = "ProductName";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.ForeColor = Color.Crimson;
            textBox2.Location = new Point(12, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 34);
            textBox2.TabIndex = 7;
            textBox2.Text = "ProductQty";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox3.ForeColor = Color.Crimson;
            textBox3.Location = new Point(12, 336);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 34);
            textBox3.TabIndex = 8;
            textBox3.Text = "ProductPrice";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox4.ForeColor = Color.Crimson;
            textBox4.Location = new Point(12, 385);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(322, 34);
            textBox4.TabIndex = 9;
            textBox4.Text = "PDescription";
            // 
            // CatBox
            // 
            CatBox.Font = new Font("Segoe UI", 12F);
            CatBox.ForeColor = Color.Crimson;
            CatBox.FormattingEnabled = true;
            CatBox.Location = new Point(12, 439);
            CatBox.Name = "CatBox";
            CatBox.Size = new Size(322, 36);
            CatBox.TabIndex = 10;
            CatBox.Text = " Product Category";
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 491);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 20;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(112, 491);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 21;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(212, 491);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 22;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.White;
            button3.Location = new Point(312, 491);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 23;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(808, 128);
            label4.Name = "label4";
            label4.Size = new Size(222, 43);
            label4.TabIndex = 25;
            label4.Text = "PRODUCT LİST";
            // 
            // ProductGV
            // 
            ProductGV.BackgroundColor = Color.White;
            ProductGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGV.Location = new Point(443, 187);
            ProductGV.Name = "ProductGV";
            ProductGV.RowHeadersWidth = 51;
            ProductGV.Size = new Size(917, 350);
            ProductGV.TabIndex = 24;
            ProductGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 696);
            Controls.Add(label4);
            Controls.Add(ProductGV);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(CatBox);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CategoryIdTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductGV).EndInit();
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
        private TextBox CategoryIdTb;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox CatBox;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private DataGridView ProductGV;
    }
}