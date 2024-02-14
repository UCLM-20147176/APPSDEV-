using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = Convert.ToInt32(txtt1.Text);
            int t2 = Convert.ToInt32(txtt2.Text);
            int sh = Convert.ToInt32(txtt3.Text);

            int sum;
            //int max, min;
            sum = t1 + t2;

            double ave = sum / 2.00;
            
        


            display lol = new display();

            switch (sh)
            {
                case 1:

                    lol.showDis(sum);
                    lol.Show();
                break;
                case 2:
                    lol.showAve(sum, ave);
                    lol.Show();

                    break;
                case 3:
                    int maxi = Math.Max(t1, t2);
                    int mini = Math.Min(t1, t2);

                    lol.showMaxMin(sum, ave, maxi, mini);
                    lol.Show();
                    break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
