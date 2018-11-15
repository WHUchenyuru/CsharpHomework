using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace topic2
{
    public class OrderService
    {
        //添加订单
        public static void Add(Order order, OrderDetails add) => order.OrderList.Add(add);

        //删除订单
        public static void Delete(Order order , OrderDetails od)
        {
            try
            {
                order.OrderList.Remove(od);
            }
            catch (Exception e)
            {
                Console.WriteLine("订单为空无法删除!");
            }
        }

        //修改订单中商品数量
        public static void Change(Order order, int index, int s)
        {
            try
            {
                order.OrderList[index].Num = s;
            }
            catch (Exception e)
            {
                Console.WriteLine("修改不符合规范！");
            }
        }

        //订单查询
        public static int Find(Order order, string s)
        {
            for (int i = 0; i < order.OrderList.Count; i++)
            {
                if (order.OrderList[i].Name == s || order.OrderList[i].ClientName == s)
                    return i;
            }
            return -1;
        }
        //XML序列化
        public static void Export(XmlSerializer ser, string FileName, object obj)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
    }
}
