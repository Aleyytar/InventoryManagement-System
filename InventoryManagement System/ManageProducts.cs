using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement_System
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        void fillCategory()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CategoriesTbl", con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dt.Load(rdr);
                CatBox.ValueMember = "CatName";
                CatBox.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM ProductssTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void ProductdataGridStyle()
        {
            ProductGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ProductGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            ProductGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ProductGV.RowHeadersVisible = false;
            ProductGV.EnableHeadersVisualStyles = false;
            ProductGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            ProductGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ProductGV.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            ProductGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            ProductGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGV.MultiSelect = false;
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

        private void CategoryGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            ProductdataGridStyle();
            fillCategory();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedCategoryName = CatBox.Text;
            int catId = -1;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Önce kategori adından ID'yi çek
                SqlCommand getCatIdCmd = new SqlCommand("SELECT CatId FROM CategoriesTbl WHERE CatName = @CatName", con);
                getCatIdCmd.Parameters.AddWithValue("@CatName", selectedCategoryName);

                SqlDataReader rdr = getCatIdCmd.ExecuteReader();
                if (rdr.Read())
                {
                    catId = Convert.ToInt32(rdr["CatId"]);
                }
                rdr.Close();

                // CatId bulunamadıysa durdur
                if (catId == -1)
                {
                    MessageBox.Show("Seçilen kategoriye ait bir ID bulunamadı.");
                    return;
                }

                // Ürünü ekle
                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO ProductssTbl (ProductName, ProductQty, ProductPrice, ProductDesc, CatId) " +
                    "VALUES (@ProductName, @ProductQty, @ProductPrice, @ProductDesc, @CatId)", con);

                insertCmd.Parameters.AddWithValue("@ProductName", ProductNameTb.Text);
                insertCmd.Parameters.AddWithValue("@ProductQty", ProductQtyTb.Text);
                insertCmd.Parameters.AddWithValue("@ProductPrice", ProductPriceTb.Text);
                insertCmd.Parameters.AddWithValue("@ProductDesc", ProductDescTb.Text);
                insertCmd.Parameters.AddWithValue("@CatId", catId);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi.");

                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }



        }

        private void ProductIdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
