using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ITP4915M_ALL
{
    public partial class Customer__Shopping_ : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=classicmodels;User ID=root;Password=;";

        public Customer__Shopping_()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts(string search = "")
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                string query = "SELECT ProductName, ProductDetails, Price FROM product";
                if (search != "")
                {
                    query += " WHERE ProductName LIKE '%" + search + "%'";
                }
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: ");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProducts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(textBox1.Text);
        }
    }
}