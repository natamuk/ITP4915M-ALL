using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP4915M_ALL
{
    public partial class Login_Register_ : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=classicmodels;User ID=root;Password=;Pooling=true;";

        public Login_Register_()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string customerNumber = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();

            if (string.IsNullOrEmpty(customerNumber) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if (!int.TryParse(customerNumber, out int parsedCustomerNumber))
            {
                MessageBox.Show("Customer number must be a valid integer!");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM customers WHERE customerNumber = @customerNumber";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@customerNumber", parsedCustomerNumber);
                        long count = (long)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("This customer number already exists!");
                            return;
                        }
                    }

                    string insertQuery = @"INSERT INTO customers (customerNumber, password, phone, email, customerName, contactLastName, contactFirstName, addressLine1, city, country)
                                          VALUES (@customerNumber, @password, @phone, @email, @customerName, @contactLastName, @contactFirstName, @addressLine1, @city, @country)";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerNumber", parsedCustomerNumber);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@customerName", "New Customer");
                        cmd.Parameters.AddWithValue("@contactLastName", "Unknown");
                        cmd.Parameters.AddWithValue("@contactFirstName", "Unknown");
                        cmd.Parameters.AddWithValue("@addressLine1", "Unknown Address");
                        cmd.Parameters.AddWithValue("@city", "Unknown City");
                        cmd.Parameters.AddWithValue("@country", "Unknown");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registration successful!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}");
            }
        }
    }
}