using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryManagement_System
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO UserTbl (Uname, Ufullname, Upassword, Uphone) VALUES (@Uname, @Ufullname, @Upassword, @Uphone)", con);

                cmd.Parameters.AddWithValue("@Uname", UnameTb.Text);
                cmd.Parameters.AddWithValue("@Ufullname", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Upassword", PasswordTb.Text);
                cmd.Parameters.AddWithValue("@Uphone", TelephoneTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;TrustServerCertificate=True;");
                con.Open();
                MessageBox.Show("✅ Bağlantı başarılı!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Hata: " + ex.Message);
            }
        }
    }
}
