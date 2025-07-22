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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        DataTable table = new DataTable();
        int num = 0;
        int uprice, qty, totprice;
        string product;

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
                Catbox.ValueMember = "CatName";
                Catbox.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void populateProduct()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM ProductssTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                ProductListGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM CustomerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                CustomerListGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void StyleDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            StyleDataGridView(CustomerListGV);
            StyleDataGridView(ProductListGV);
            StyleDataGridView(OrderGV);
            populateProduct();
            fillCategory();
            table.Columns.Add("num", typeof(int));
            table.Columns.Add("product", typeof(string));
            table.Columns.Add("qty", typeof(int));
            table.Columns.Add("uprice", typeof(int));
            table.Columns.Add("totprice", typeof(int));
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

        private void CustomerListGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomerListGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomerListGV.SelectedRows[0].Cells[1].Value.ToString();
        }
        int flag = 0;
        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductListGV.SelectedRows[0].Cells[1].Value.ToString();
            // qty = Convert.ToInt32(QuantityTb.Text);
            uprice = Convert.ToInt32(ProductListGV.SelectedRows[0].Cells[3].Value.ToString());
            // totprice = qty * uprice;
            flag = 1;

        }

        private void Catbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = Catbox.Text;

                if (string.IsNullOrWhiteSpace(selectedCategory))
                    return;

                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT P.ProductId, P.ProductName, P.ProductQty, P.ProductPrice, P.ProductDesc, C.CatName " +
                    "FROM ProductssTbl P " +
                    "JOIN CategoriesTbl C ON P.CatId = C.CatId " +
                    "WHERE C.CatName = @CatName", con);

                cmd.Parameters.AddWithValue("@CatName", selectedCategory);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductListGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuantityTb.Text) || !int.TryParse(QuantityTb.Text, out qty))
            {
                MessageBox.Show("Enter The Quantity  Of Product");

            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");




            }
            else if (Convert.ToInt32(QuantityTb.Text) <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
            }
            else if (Convert.ToInt32(QuantityTb.Text) > Convert.ToInt32(ProductListGV.SelectedRows[0].Cells[2].Value.ToString()))
            {
                MessageBox.Show("Not Enough Product In Stock");
            }
            else if (OrderIdTb.Text == "")
            {
                MessageBox.Show("Please Enter Order Id");
            }
            else if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Please Select Customer");
            }

            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QuantityTb.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                totprice = qty * uprice;
                OrderGV.DataSource = table;
                flag = 0;
            }
            int grandTotal = 0;
            foreach (DataRow row in table.Rows)
            {
                grandTotal += Convert.ToInt32(row["totprice"]);
            }
            TotalPriceLb.Text = "Total: $" + grandTotal.ToString();
            try
            {
                con.Open();
                SqlCommand updateCmd = new SqlCommand("UPDATE ProductssTbl SET ProductQty = ProductQty - @SoldQty WHERE ProductName = @ProductName", con);
                updateCmd.Parameters.AddWithValue("@SoldQty", qty);
                updateCmd.Parameters.AddWithValue("@ProductName", product);
                updateCmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stok güncelleme hatası: " + ex.Message);
            }
            populateProduct();
        }

        private void OrderGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderIdTb.Text = OrderGV.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
