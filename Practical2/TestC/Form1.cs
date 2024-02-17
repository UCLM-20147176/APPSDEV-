using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoption_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            int display1 = Convert.ToInt32(txtinput1.Text);
            int display2 = Convert.ToInt32(txtinput2.Text);
            int display3 = Convert.ToInt32(txtoption.Text);

            int option = Convert.ToInt32(display3);
            int sum = display1 + display2;
            double aver = sum / 2;
            int high = Math.Max(display1, display2);
            int low = Math.Min(display1, display2);

            Display hub = new Display();
            switch (option)
            {
                case 1:
                    hub.setSum(sum);
                    hub.Show(); 
                    break;
                case 2:
                    hub.setAve(sum, aver);
                    hub.Show(); 
                    break;
                case 3:
                    hub.setDisplay(sum, aver, high, low);
                    hub.Show() ; 
                    break;
                
            }

        }
    }
}
