using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderDetails od1 = new OrderDetails("a", "0", "John", "45");
            OrderDetails od2 = new OrderDetails("b", "1", "Jack", "46");
            OrderDetails od3 = new OrderDetails("c", "0", "Mary", "47");

            OrderService.Add(order, od1);               //加入订单条目1
            OrderService.Add(order, od2);               //加入订单条目2
            OrderService.Add(order, od3);               //加入订单条目3
            Console.WriteLine("初始化的订单：");
            OrderService.printOrder(order);             //第一次打印订单

            OrderService.Delete(order, od3);            //删除订单条目3
            Console.WriteLine("删除后的订单：");
            OrderService.printOrder(order);

            OrderService.Change(order, 0, 3, "40");     //将第一条订单条目中的商品数目改为40
            Console.WriteLine("修改后的订单：");
            OrderService.printOrder(order);

            int index = OrderService.Find(order, "Jack");

            //用Linq语句实现查询
            Console.Write("输入查询的商品名称：");
            string key1 = Console.ReadLine();
            var result1 = order.OrderList.Where(a => a.myDictionary[0] == key1);
            Console.WriteLine(result1.ToString());

            Console.Write("输入查询的客户名称：");
            string key2 = Console.ReadLine();
            var result2 = order.OrderList.Where(a => a.myDictionary[2] == key2);
           
            var result3 = order.OrderList.Where( a => Int32.Parse(a.myDictionary[3]) >= 20);
        }
    }
}
