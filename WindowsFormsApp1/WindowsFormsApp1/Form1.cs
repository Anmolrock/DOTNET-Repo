using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username = "Admin";
            String password = "1234";
            if ((this.textBox1.Text == username) && (this.textBox2.Text == password))
            {
                MessageBox.Show("Welcome Admin", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid User", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}