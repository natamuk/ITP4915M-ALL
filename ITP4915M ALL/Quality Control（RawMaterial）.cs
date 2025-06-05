using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915M_ALL
{
    public partial class Quality_Control_RawMaterial_ : Form
    {
        public Quality_Control_RawMaterial_(string employeeName, string employeePosition, string region)
        {
            InitializeComponent();
            label4.Text = $"Hi: {employeeName} ({employeePosition}) ({region})";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
