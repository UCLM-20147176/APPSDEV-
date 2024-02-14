using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class display: Form
    {
        public display()
        {
            InitializeComponent();
        }
        public void showDis(int sum)
        {
            lbldisplay1.Text = sum.ToString();
        }
        public void showAve(int sum, double ave)
        {
            lbldisplay1.Text = sum.ToString();
            lbldisplay2.Text = ave.ToString("N2");
        }
        public void showMaxMin(int sum, double ave, int maxi, int mini) 
        {
            lbldisplay1.Text = sum.ToString();
            lbldisplay2.Text = ave.ToString("N2");
            lblmax.Text = maxi.ToString();
            lblmin.Text = mini.ToString();
        }

        private void display_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
