using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using topic2;

namespace topic1
{
    public partial class Form2 : Form
    {
        public OrderDetails orderDetails = new OrderDetails("", "", "", 0, 0, "");
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox2.Text;
            string cilentname = textBox3.Text;
            int num = Int32.Parse(textBox4.Text);
            int price = Int32.Parse(textBox5.Text);
            orderDetails.Name = name;
            orderDetails.ID = id;
            orderDetails.ClientName = cilentname;
            orderDetails.Num = num;
            orderDetails.Price = price;
            this.Close();
            Form1 form1 = new Form1();
            form1.order.OrderList.Add(orderDetails);
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
