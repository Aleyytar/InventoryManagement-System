using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Olaylarý baðla
            UserNameTB.Enter += TextBoxUsername_Enter;
            UserNameTB.Leave += TextBoxUsername_Leave;
            PasswordTb.Enter += TextBoxPassword_Enter;
            PasswordTb.Leave += TextBoxPassword_Leave;
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        private void Form1_Load(object sender, EventArgs e)
        {
            // Varsayýlan metinleri ayarla
            UserNameTB.Text = "Username";
            PasswordTb.Text = "Password";
            PasswordTb.UseSystemPasswordChar = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_Enter(object sender, EventArgs e)
        {
            if (UserNameTB.Text == "Username")
                UserNameTB.Text = "";
        }

        private void TextBoxUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserNameTB.Text))
                UserNameTB.Text = "Username";
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (PasswordTb.Text == "Password")
            {
                PasswordTb.Text = "";
                PasswordTb.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTb.Text))
            {
                PasswordTb.UseSystemPasswordChar = false;
                PasswordTb.Text = "Password";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Eðer kutu iþaretliyse þifre göster, deðilse gizle
            PasswordTb.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserNameTB.Text = "Username";
            PasswordTb.Text = "Password";
            PasswordTb.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM UserTbl WHERE Uname=@username AND Upassword=@password", con);
            sda.SelectCommand.Parameters.AddWithValue("@username", UserNameTB.Text);
            sda.SelectCommand.Parameters.AddWithValue("@password", PasswordTb.Text);
            DataTable dt = new DataTable();
            sda.Fill(dt);
          
            if (dt.Rows[0][0].ToString() == "1")
            {
                // Giriþ baþarýlý, yeni formu aç
                ManageCustomerscs cust = new ManageCustomerscs();
                cust.Show();
                this.Hide();
            }
            else
            {
                // Giriþ baþarýsýz, hata mesajý göster
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
            }   
            
            con.Close();

        }

        

        private void label4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
