using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary = Convert.ToDouble(txtinp1.Text);
            double option = Convert.ToInt32(txtoption.Text);

            double money = 0;
           //double totals = 0;

            Display hub = new Display();
            if (option == 1)
            {
                money = salary * 0.10;
                hub.setDisplay(money);
                hub.Show();
            }
            else if (option >= 2 && option <= 5)
            {
                money = salary * 0.2;
                hub.setDisplay(money);
                hub.Show();
            }
            else if (option >= 6 && option <= 10)
            {
                money = salary * 0.5;
                hub.setDisplay(money);
                hub.Show();
            }
            else
            {
                money = salary * 0.75;
                hub.setDisplay(money);
                hub.Show();
            }

        }

        private void txtoption_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
