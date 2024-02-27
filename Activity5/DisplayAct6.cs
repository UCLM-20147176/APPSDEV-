using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Activity5
{
    public partial class DisplayAct6 : Form
    {
        public DisplayAct6()
        {
            InitializeComponent();
        }

        public void display(double total, double famount, string percent)
        {
            label4.Text = percent.ToString();
            label5.Text = "PHP" +total.ToString("N2");
            label6.Text = "PHP" +famount.ToString("N2");



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
