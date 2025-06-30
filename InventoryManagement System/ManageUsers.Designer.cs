namespace InventoryManagement_System
{
    partial class ManageUsers
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
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            TelephoneTb = new TextBox();
            FnameTb = new TextBox();
            EditBt = new Button();
            DeleteBt = new Button();
            HomeBt = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.Size = new Size(1301, 125);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.White;
            button6.Location = new Point(26, 69);
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
            label3.Location = new Point(1252, 0);
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
            label1.Location = new Point(505, 69);
            label1.Name = "label1";
            label1.Size = new Size(283, 54);
            label1.TabIndex = 0;
            label1.Text = "Manage User ";
            label1.Click += label1_Click;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            UnameTb.ForeColor = Color.Crimson;
            UnameTb.Location = new Point(26, 157);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(322, 34);
            UnameTb.TabIndex = 1;
            UnameTb.Text = "UserName";
            UnameTb.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            PasswordTb.ForeColor = Color.Crimson;
            PasswordTb.Location = new Point(26, 258);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(322, 34);
            PasswordTb.TabIndex = 2;
            PasswordTb.Text = "Password";
            PasswordTb.TextChanged += textBox2_TextChanged;
            // 
            // TelephoneTb
            // 
            TelephoneTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            TelephoneTb.ForeColor = Color.Crimson;
            TelephoneTb.Location = new Point(26, 310);
            TelephoneTb.Name = "TelephoneTb";
            TelephoneTb.Size = new Size(322, 34);
            TelephoneTb.TabIndex = 3;
            TelephoneTb.Text = "Telephone";
            TelephoneTb.TextChanged += textBox3_TextChanged;
            // 
            // FnameTb
            // 
            FnameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FnameTb.ForeColor = Color.Crimson;
            FnameTb.Location = new Point(26, 208);
            FnameTb.Name = "FnameTb";
            FnameTb.Size = new Size(322, 34);
            FnameTb.TabIndex = 4;
            FnameTb.Text = "FullName";
            // 
            // EditBt
            // 
            EditBt.BackColor = Color.Crimson;
            EditBt.FlatAppearance.BorderSize = 0;
            EditBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            EditBt.ForeColor = Color.White;
            EditBt.Location = new Point(135, 365);
            EditBt.Name = "EditBt";
            EditBt.Size = new Size(94, 46);
            EditBt.TabIndex = 6;
            EditBt.Text = "Edit";
            EditBt.UseVisualStyleBackColor = false;
            EditBt.Click += EditBt_Click;
            // 
            // DeleteBt
            // 
            DeleteBt.BackColor = Color.Crimson;
            DeleteBt.FlatAppearance.BorderSize = 0;
            DeleteBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            DeleteBt.ForeColor = Color.White;
            DeleteBt.Location = new Point(254, 365);
            DeleteBt.Name = "DeleteBt";
            DeleteBt.Size = new Size(94, 46);
            DeleteBt.TabIndex = 7;
            DeleteBt.Text = "Delete";
            DeleteBt.UseVisualStyleBackColor = false;
            DeleteBt.Click += button3_Click;
            // 
            // HomeBt
            // 
            HomeBt.BackColor = Color.Crimson;
            HomeBt.FlatAppearance.BorderSize = 0;
            HomeBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            HomeBt.ForeColor = Color.White;
            HomeBt.Location = new Point(135, 436);
            HomeBt.Name = "HomeBt";
            HomeBt.Size = new Size(94, 46);
            HomeBt.TabIndex = 8;
            HomeBt.Text = "Home";
            HomeBt.UseVisualStyleBackColor = false;
            // 
            // UsersGV
            // 
            UsersGV.BackgroundColor = Color.White;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(364, 174);
            UsersGV.Name = "UsersGV";
            UsersGV.RowHeadersWidth = 51;
            UsersGV.Size = new Size(907, 308);
            UsersGV.TabIndex = 9;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(1301, 37);
            panel2.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(26, 365);
            button1.Name = "button1";
            button1.Size = new Size(94, 46);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(756, 128);
            label4.Name = "label4";
            label4.Size = new Size(137, 43);
            label4.TabIndex = 11;
            label4.Text = "User List";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 557);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(UsersGV);
            Controls.Add(HomeBt);
            Controls.Add(DeleteBt);
            Controls.Add(EditBt);
            Controls.Add(button1);
            Controls.Add(FnameTb);
            Controls.Add(TelephoneTb);
            Controls.Add(PasswordTb);
            Controls.Add(UnameTb);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private TextBox TelephoneTb;
        private TextBox FnameTb;
        private Button EditBt;
        private Button DeleteBt;
        private Button HomeBt;
        private DataGridView UsersGV;
        private Panel panel2;
        private Button button6;
        private Button button1;
        private Label label4;
    }
}