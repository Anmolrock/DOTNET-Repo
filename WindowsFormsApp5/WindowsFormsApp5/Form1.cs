using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\sqlexpress;Database=CompaanyDB;Trusted_Connection='True'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                MessageBox.Show("Connected to Database is Successfully", "SQL Says", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
