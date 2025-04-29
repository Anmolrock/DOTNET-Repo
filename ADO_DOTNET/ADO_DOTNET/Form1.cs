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

namespace ADO_DOTNET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void filldetails()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Employee", "Server=localhost\\sqlexpress;database=CompaanyDB;Trusted_Connection='true'");
            DataTable dt= new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=localhost\\sqlexpress;database=CompaanyDB;Trusted_Connection='true'";
            
            if (conn.State == ConnectionState.Closed) 
            {
                conn.Open();
            }
            filldetails();
        }
    }
}
