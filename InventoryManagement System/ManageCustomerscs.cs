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
    public partial class ManageCustomerscs : Form
    {
        public ManageCustomerscs()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B6S9L8P\SQLEXPRESS;Initial Catalog=inventorymgdb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        private void populate()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM customerTbl";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                customersGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void CustomerGVStyle()
        {
            customersGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            customersGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            customersGV.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            customersGV.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            customersGV.RowHeadersVisible = false;
            customersGV.EnableHeadersVisualStyles = false;
            customersGV.ColumnHeadersDefaultCellStyle.BackColor = Color.Crimson;
            customersGV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            customersGV.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            customersGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            customersGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersGV.MultiSelect = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
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

        private void ManageCustomerscs_Load(object sender, EventArgs e)
        {
            populate();
            CustomerGVStyle();
        }

        private void customersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomeIdTb.Text = customersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = customersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTb.Text = customersGV.SelectedRows[0].Cells[2].Value.ToString();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT  Count(*) from OrdersTbl WHERE CustId = " + CustomeIdTb.Text + "" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OrderLabel.Text = dt.Rows[0][0].ToString();


            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT  Sum(TotalAmount) from OrdersTbl WHERE CustId = " + CustomeIdTb.Text + "", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            AmountLabel.Text = dt1.Rows[0][0].ToString();
            con.Close();

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT  MAX(OrderDate) from OrdersTbl WHERE CustId = " + CustomeIdTb.Text + "", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            DateLabel.Text = dt2.Rows[0][0].ToString();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO customerTbl ( CustName, CustPhone) VALUES ( @CustName, @CustPhone)", con);


                cmd.Parameters.AddWithValue("@CustName", CustomerNameTb.Text);
                cmd.Parameters.AddWithValue("@CustPhone", CustomerPhoneTb.Text);


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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE customerTbl SET CustName = @CustName, CustPhone = @CustPhone WHERE CustomerId = @CustomerId", con);

                cmd.Parameters.AddWithValue("@CustName", CustomerNameTb.Text);
                cmd.Parameters.AddWithValue("@CustPhone", CustomerPhoneTb.Text);
                cmd.Parameters.AddWithValue("@CustomerId", CustomeIdTb.Text); // Sadece WHERE için

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (customersGV.SelectedRows.Count > 0)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM customerTbl WHERE CustomerId = @CustomerId", con);
                    cmd.Parameters.AddWithValue("@CustomerId", customersGV.SelectedRows[0].Cells[0].Value); // ← Buraya dikkat
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
