using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = comboBox2.SelectedIndex;
            Form1 form1 = new Form1();
            form1.order.OrderList[i].Num = Int32.Parse(textBox1.Text);
            this.Close();
            form1.Show();
        }
    }
}
