using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP4915M_ALL
{
    public partial class Form3 : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=classicmodels;User ID=root;Password=;Pooling=true;";

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string employeeName, string employeePosition, string region)
        {
            InitializeComponent();
            label4.Text = $"Hi: {employeeName} ({employeePosition}) ({region})";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1350;
            this.Height = 600;

            dataGridView2.Width = 1312;
            dataGridView2.Height = 92;

            dataGridView1.Width = 1312;
            dataGridView1.Height = 267;

            LoadMaterialData();
            LoadOrderData();
        }

        private void LoadMaterialData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaterialID, MaterialName, MaterialQuantity FROM material";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading material data: " + ex.Message);
                }
            }
        }

        private void LoadOrderData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT OrderNumber, `Product ID`, Material, quantity, Priority FROM `order`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading order data: " + ex.Message);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string materialName = row.Cells["MaterialName"].Value.ToString();
                string materialQuantity = row.Cells["MaterialQuantity"].Value.ToString();
                MessageBox.Show($"Material: {materialName}\nQuantity: {materialQuantity}", "Material Details");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string orderNumber = row.Cells["OrderNumber"].Value.ToString();
                string productId = row.Cells["Product ID"].Value.ToString();
                string materialId = row.Cells["Material"].Value.ToString();
                int orderQuantity = Convert.ToInt32(row.Cells["quantity"].Value);

                textBox1.Text = orderNumber;
                textBox2.Text = productId;
                textBox5.Text = row.Cells["Priority"].Value.ToString();

                string productName = GetProductName(productId);
                textBox2.Text = productName;

                string materialDetails = GetProductMaterials(productId);
                label21.Text = materialDetails;

                UpdateMaterialQuantity(Convert.ToInt32(materialId), orderQuantity);
                CheckMaterialStock();
            }
        }

        private string GetProductName(string productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ProductName FROM product WHERE ProductID = @ProductID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "Unknown Product";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting product name: " + ex.Message);
                    return "Error";
                }
            }
        }

        private string GetProductMaterials(string productId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT pm.MaterialName, pm.MaterialQuantity " +
                                   "FROM product_materials pm " +
                                   "WHERE pm.ProductID = @ProductID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    string materialDetails = "Required Materials:\n";
                    while (reader.Read())
                    {
                        string materialName = reader["MaterialName"].ToString();
                        int materialQuantity = Convert.ToInt32(reader["MaterialQuantity"]);
                        materialDetails += $"{materialName}: {materialQuantity}\n";
                    }
                    return materialDetails;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting material details: " + ex.Message);
                    return "Error retrieving materials";
                }
            }
        }

        private void UpdateMaterialQuantity(int materialId, int orderQuantity)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string selectQuery = "SELECT MaterialQuantity FROM material WHERE MaterialID = @MaterialID";
                    MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@MaterialID", materialId);
                    int currentQuantity = Convert.ToInt32(selectCmd.ExecuteScalar());

                    int newQuantity = currentQuantity - orderQuantity;
                    if (newQuantity < 0)
                    {
                        MessageBox.Show("Not enough material in stock!");
                        return;
                    }

                    string updateQuery = "UPDATE material SET MaterialQuantity = @NewQuantity WHERE MaterialID = @MaterialID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                    updateCmd.Parameters.AddWithValue("@MaterialID", materialId);
                    updateCmd.ExecuteNonQuery();

                    LoadMaterialData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating material quantity: " + ex.Message);
                }
            }
        }

        private void CheckMaterialStock()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT MaterialName, MaterialQuantity FROM material WHERE MaterialQuantity < 5000";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string materialName = reader["MaterialName"].ToString();
                        int quantity = Convert.ToInt32(reader["MaterialQuantity"]);
                        MessageBox.Show($"Material {materialName} is low in stock! Current quantity: {quantity}. Please restock.", "Low Stock Alert");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking material stock: " + ex.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}