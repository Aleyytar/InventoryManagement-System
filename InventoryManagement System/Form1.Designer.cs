namespace InventoryManagement_System
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AccessibleDescription = "";
            panel1.AccessibleName = "";
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUsername);
            panel1.Location = new Point(134, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 357);
            panel1.TabIndex = 0;
            panel1.Tag = "";
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkBox1.ForeColor = Color.Crimson;
            checkBox1.Location = new Point(90, 325);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 21);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "ShowPassword";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(45, 325);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 4;
            label3.Text = "Clear";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 38);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.DodgerBlue;
            button1.Location = new Point(28, 259);
            button1.Name = "button1";
            button1.Size = new Size(193, 49);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DodgerBlue;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(28, 197);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(193, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.Text = "Şifre";
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.UseWaitCursor = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.DodgerBlue;
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(28, 152);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(193, 27);
            textBoxUsername.TabIndex = 1;
            textBoxUsername.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 40);
            label2.Name = "label2";
            label2.Size = new Size(467, 38);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(463, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 54);
            label4.TabIndex = 3;
            label4.Text = "X";
            label4.Click += label4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(512, 463);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
