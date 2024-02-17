using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestC
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        public void setSum(int sum) 
        {
            lblint1.Text = sum.ToString();

        }
        public void setAve(int sum, double aver)
        { 
            lblint1.Text = sum.ToString();
            lblint2.Text = aver.ToString("N2");
        }

        public void setDisplay(int sum, double aver, int high, int low)
        { 
            lblint1.Text = sum.ToString();
            lblint2.Text = aver.ToString("N2");
            lblint3.Text = high.ToString();
            lblint4.Text = low.ToString();
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblint4_Click(object sender, EventArgs e)
        {

        }
    }
}
