using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement_System
{
    public partial class CategoriesManager : Form
    {
        public CategoriesManager()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM CategoriesTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CategoryGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void CategoryGVStyle()
        {
            CategoryGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CategoryGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            CategoryGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CategoryGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoryGV.RowHeadersVisible = false;
            CategoryGV.EnableHeadersVisualStyles = false;
            CategoryGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            CategoryGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CategoryGV.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            CategoryGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            CategoryGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CategoryGV.MultiSelect = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CategoryGV.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CategoriesTbl WHERE CatId = @CatId", con);
                    cmd.Parameters.AddWithValue("@CatId", CategoryGV.SelectedRows[0].Cells[0].Value); // ← Buraya dikkat
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoryIdTb.Text = CategoryGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryNameTb.Text = CategoryGV.SelectedRows[0].Cells[1].Value.ToString();

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

        private void CategoriesManager_Load(object sender, EventArgs e)
        {
            populate();
            CategoryGVStyle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO CategoriesTbl ( Catname) VALUES ( @CatName)", con);

                cmd.Parameters.AddWithValue("@CatName", CategoryNameTb.Text);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE CategoriesTbl SET CatName = @CatName  WHERE CatId = @CatId", con);

                cmd.Parameters.AddWithValue("@CatName", CategoryNameTb.Text);
                cmd.Parameters.AddWithValue("@CatId", CategoryIdTb.Text); // Sadece WHERE için

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer updated successfully.");
                }
                else
                {
                    MessageBox.Show("Hata: Bu ID'ye sahip bir müşteri bulunamadı.");
                }

                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
