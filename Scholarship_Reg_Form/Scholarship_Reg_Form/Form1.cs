using System.Security.Cryptography.X509Certificates;

namespace Scholarship_Reg_Form
{
    public partial class mainform : Form
    {
        public mainform()
        {
            this.Size = new Size(Width, Height);
            InitializeComponent();
            loadcaptchaimage();

        }
        int number = 0;
        private void loadcaptchaimage()
        {
            Random r1 = new Random();
            number = r1.Next(10000, 100000);
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Strikeout, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.GreenYellow, new Point(0, 0));
            pictureBox1.Image = image;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jila_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadcaptchaimage();
        }

        

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {

        }
    }
}