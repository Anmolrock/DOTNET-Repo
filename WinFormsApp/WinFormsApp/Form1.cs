namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;
        private void txtDisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 8;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Clear();
            count = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplayBox.Text);
            txtDisplayBox.Clear();
            txtDisplayBox.Focus();
            count = 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 2;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 3;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplayBox.Text = txtDisplayBox.Text + 0+0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int c = txtDisplayBox.TextLength;
            int flag = 0;
            string text = txtDisplayBox.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                txtDisplayBox.Text = txtDisplayBox.Text + ".";
            }
        }
            private void btnSubstract_Click(object sender, EventArgs e)
        {
            if (txtDisplayBox.Text != "")
            {
                num1 = float.Parse(txtDisplayBox.Text);
                txtDisplayBox.Clear();
                txtDisplayBox.Focus();
                count = 1;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplayBox.Text);
            txtDisplayBox.Clear();
            txtDisplayBox.Focus();
            count = 3;
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txtDisplayBox.Text);
                    txtDisplayBox.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txtDisplayBox.Text);
                    txtDisplayBox.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txtDisplayBox.Text);
                    txtDisplayBox.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txtDisplayBox.Text);
                    txtDisplayBox.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtDisplayBox.Text);
            txtDisplayBox.Clear();
            txtDisplayBox.Focus();
            count = 2;
        }
    }
}