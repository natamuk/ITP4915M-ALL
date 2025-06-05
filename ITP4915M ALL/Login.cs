using System;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ITP4915M_ALL
{
    public partial class Login : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=classicmodels;User ID=root;Password=;Pooling=true;";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String pas = textBox2.Text;

            if (name == "" || pas == "")
            {
                MessageBox.Show("Please enter your username and password!");
                return;
            }

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM employee";
                MySqlCommand com1 = new MySqlCommand(sql, conn);
                MySqlDataReader com2 = com1.ExecuteReader();
                while (com2.Read())
                {
                    if (com2["EmployeeID"].ToString() == name &&
                        com2["Password"].ToString() == pas)
                    {
                        string job = com2["EmployeePosition"].ToString();
                        string employeeName = com2["EmployeeName"].ToString();
                        string region = com2["responsible_region"].ToString();

                        if (job == "production manager")
                        {
                            Form3 manager = new Form3(employeeName, job, region);
                            manager.Show();
                        }
                        else if (job == "staff")
                        {
                            Form1 staff = new Form1(employeeName, job, region);
                            staff.Show();
                        }
                        else if (job == "quality control")
                        {
                            Quality_Control_RawMaterial_ quality = new Quality_Control_RawMaterial_(employeeName, job, region);
                            quality.Show();
                        }
                        break;
                    }
                }
                com2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_Register_ reg = new Login_Register_();
            reg.Show();
            this.Hide();
        }
    }
}