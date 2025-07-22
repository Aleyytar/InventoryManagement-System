namespace InventoryManagement_System
{
    partial class ViewOrders
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
            ViewOrderGV = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewOrderGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 125);
            panel1.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
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
            label1.Size = new Size(253, 54);
            label1.TabIndex = 0;
            label1.Text = "View Orders";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 766);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 23);
            panel2.TabIndex = 6;
            // 
            // ViewOrderGV
            // 
            ViewOrderGV.BackgroundColor = Color.White;
            ViewOrderGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewOrderGV.Location = new Point(97, 183);
            ViewOrderGV.Name = "ViewOrderGV";
            ViewOrderGV.RowHeadersWidth = 51;
            ViewOrderGV.Size = new Size(1190, 418);
            ViewOrderGV.TabIndex = 38;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(643, 636);
            button1.Name = "button1";
            button1.Size = new Size(164, 49);
            button1.TabIndex = 42;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 789);
            Controls.Add(button1);
            Controls.Add(ViewOrderGV);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewOrderGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView ViewOrderGV;
        private Button button1;
    }
}