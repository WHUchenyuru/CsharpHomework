﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = this.textBox1.Text;
            string s2 = this.textBox2.Text;
            double d1 = Double.Parse(s1);
            double d2 = Double.Parse(s2);
            double r = d1 * d2;
            textBox3.Text = d1 + " * " + d2 + " = " + r;
        }
    }
}
