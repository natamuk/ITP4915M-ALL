namespace ITP4915M_ALL
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1(string employeeName, string employeePosition, string region)
        {
            InitializeComponent();
            label4.Text = $"Hi: {employeeName} ({employeePosition}) ({region})";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
