using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace topic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderDetails od1 = new OrderDetails("a", 0, "John", 45 , 3);
            OrderDetails od2 = new OrderDetails("b", 1, "Jack", 46 , 2);
            OrderDetails od3 = new OrderDetails("c", 0, "Mary", 47 , 4);
            OrderService.Add(order, od1);
            OrderService.Add(order, od2);
            OrderService.Add(order, od3);

            //序列化
            XmlSerializer xmler = new XmlSerializer(typeof(Order));
            String xmlFileName = "s.xml";
            OrderService.Export(xmler, xmlFileName, order);
            //显示XML文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);

            //反序列化
            OrderDetails orderDetails = OrderService.Import(xmler, xmlFileName)as OrderDetails;
            foreach(OrderDetails od in order.OrderList)
            {
                Console.WriteLine(od);
            }
        }
    }
}
