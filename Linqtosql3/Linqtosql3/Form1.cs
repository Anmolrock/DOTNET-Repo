namespace Linqtosql3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
            dataGridView1.DataSource = dc.Employees;
        }
    }
}