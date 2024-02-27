using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
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

        private void button1_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(txtjan.Text);
            double input2 = Convert.ToDouble(txtfeb.Text);
            double input3 = Convert.ToDouble(txtmarch.Text);


            double sum = input1 + input2 + input3;
            double total = 0;
            double famount = 0;
            string percent = " ";
            
           

            label5.Text = sum.ToString("N2");


            if (chkfifty.Checked)
            {
                total = sum * 0.5;
                famount = total + sum;
                percent = "50%";

            }
            else if (checkBox2.Checked)
            {
                total = sum * 0.15;
                famount = total + sum;
                percent = "15%";
            }
            else if (checkBox3.Checked)
            {
                total = sum * 0.10;
                famount = total + sum;
                percent = "10%";
            }


            DisplayAct6 hub = new DisplayAct6();
            hub.display(total, famount, percent);
            hub.Show();
        }
    }
}
