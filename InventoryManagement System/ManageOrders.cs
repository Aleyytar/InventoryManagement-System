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

        private void ProductdataGridStyle()
        {
            CustomerListGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerListGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            CustomerListGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            CustomerListGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CustomerListGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerListGV.RowHeadersVisible = false;
            CustomerListGV.EnableHeadersVisualStyles = false;
            CustomerListGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            CustomerListGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CustomerListGV.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            CustomerListGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            CustomerListGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerListGV.MultiSelect = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            ProductdataGridStyle();
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

        }
    }
}
