﻿using System;
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
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }
        public void setDisplay(double option)
        { 
            txtdisplay.Text = option.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
