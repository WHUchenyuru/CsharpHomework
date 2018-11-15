using System;
using System.Windows.Forms;
using System.Linq;
using topic2;
using System.Xml.Serialization;
using System.IO;

namespace topic1
{
    public partial class Form1 : Form
    {
        public Order order = new Order();
        public string keyword { get; set; }
        public Form1()
        {
            InitializeComponent();
            order.OrderList.Add(new OrderDetails("a", "20180131", "John", 45, 3, "13457857659"));
            order.OrderList.Add(new OrderDetails("b", "20180123", "Jack", 46, 2, "158725638745"));
            //检验订单号以及手机号
            foreach(OrderDetails od in order.OrderList)
            {
                if (!(RegexTest.OrderNumTest(od.ID) && RegexTest.PhoneTest(od.Phone)))
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                }
            }

     
            //数据绑定
            bindingSource1.DataSource = order.OrderList;
            //绑定查询条件
            textBox1.DataBindings.Add("Text", this, "KeyWord");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //点击查询
        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = order.OrderList.Where(o => o.Name == keyword || o.ClientName == keyword);
        }

        //点击删除
        private void button3_Click(object sender, EventArgs e)
        {           
                this.dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        //点击新建
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            //order.OrderList.Add(form2.orderDetails);
        }

        //点击修改
        private void button4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }
    }
}
