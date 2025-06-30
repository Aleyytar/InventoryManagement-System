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

        private void dataGridStyle()
        {
            UsersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            UsersGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            UsersGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            UsersGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UsersGV.RowHeadersVisible = false;
            UsersGV.EnableHeadersVisualStyles = false;
            UsersGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            UsersGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            UsersGV.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            UsersGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            UsersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersGV.MultiSelect = false;
        }
        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM UserTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
            dataGridStyle();
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
                populate();
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

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();    
            TelephoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (UsersGV.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE Uphone = @Uphone", con);
                    cmd.Parameters.AddWithValue("@Uphone", UsersGV.SelectedRows[0].Cells[3].Value); // ← Buraya dikkat
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate(); // listeyi yenile
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kullanıcı seçin.");
            }

        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE UserTbl SET Uname = @Uname, Ufullname = @Ufullname, Upassword = @Upassword, Uphone = @Uphone WHERE Uphone = @Uphone", con);

                cmd.Parameters.AddWithValue("@Uname", UnameTb.Text);
                cmd.Parameters.AddWithValue("@Ufullname", FnameTb.Text);
                cmd.Parameters.AddWithValue("@Upassword", PasswordTb.Text);
                cmd.Parameters.AddWithValue("@Uphone", TelephoneTb.Text);
                cmd.Parameters.AddWithValue("@UserId", (TelephoneTb.Text)); // Kullanıcının ID'si telefon number

                cmd.ExecuteNonQuery();
                MessageBox.Show("User updated successfully.");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }
    }
}
