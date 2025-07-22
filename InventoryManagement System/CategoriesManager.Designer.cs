namespace InventoryManagement_System
{
    partial class CategoriesManager
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
            CategoryIdTb = new TextBox();
            CategoryNameTb = new TextBox();
            CategoryGV = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label1.Size = new Size(388, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
            label1.Click += label1_Click;
            // 
            // CategoryIdTb
            // 
            CategoryIdTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CategoryIdTb.ForeColor = Color.Crimson;
            CategoryIdTb.Location = new Point(24, 203);
            CategoryIdTb.Name = "CategoryIdTb";
            CategoryIdTb.Size = new Size(322, 34);
            CategoryIdTb.TabIndex = 3;
            CategoryIdTb.Text = "CategoryId";
            CategoryIdTb.TextChanged += CategoryIdTb_TextChanged;
            // 
            // CategoryNameTb
            // 
            CategoryNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CategoryNameTb.ForeColor = Color.Crimson;
            CategoryNameTb.Location = new Point(24, 258);
            CategoryNameTb.Name = "CategoryNameTb";
            CategoryNameTb.Size = new Size(322, 34);
            CategoryNameTb.TabIndex = 4;
            CategoryNameTb.Text = "Category Name";
            // 
            // CategoryGV
            // 
            CategoryGV.BackgroundColor = Color.White;
            CategoryGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGV.Location = new Point(372, 187);
            CategoryGV.Name = "CategoryGV";
            CategoryGV.RowHeadersWidth = 51;
            CategoryGV.Size = new Size(917, 331);
            CategoryGV.TabIndex = 14;
            CategoryGV.CellContentClick += CategoryGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(689, 128);
            label4.Name = "label4";
            label4.Size = new Size(236, 43);
            label4.TabIndex = 15;
            label4.Text = "CATEGORY LİST";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 319);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 16;
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
            button2.Location = new Point(124, 319);
            button2.Name = "button2";
            button2.Size = new Size(94, 46);
            button2.TabIndex = 17;
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
            button3.Location = new Point(224, 319);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 18;
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
            button4.Location = new Point(124, 371);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 19;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 673);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 23);
            panel2.TabIndex = 20;
            // 
            // CategoriesManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 696);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(CategoryGV);
            Controls.Add(CategoryNameTb);
            Controls.Add(CategoryIdTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CategoriesManager";
            Text = "CategoriesManager";
            Load += CategoriesManager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoryGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox CategoryIdTb;
        private TextBox CategoryNameTb;
        private DataGridView CategoryGV;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
    }
}