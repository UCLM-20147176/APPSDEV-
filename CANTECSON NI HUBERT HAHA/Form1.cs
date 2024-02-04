namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Double bagp = 5.50;
        Double bag = 52;
        Double large = 3;
        Double med = 2.50;
        Double small = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double price = (bagp * bag) + (large * 2) + med + small;
            label5.Text = "Your total cost is: $" + price.ToString("N2");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsmall_TextChanged(object sender, EventArgs e)
        {

        }
    }
}