using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    class OrderService
    {
        //添加订单
        public static void Add(Order order, OrderDetails add) => order.OrderList.Add(add);

        //删除订单
        public static void Delete(Order order, OrderDetails od)
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
        public static void Change(Order order, int index, int key, string s)
        {
            try
            {
                order.OrderList[index].myDictionary[key] = s;
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
                if (order.OrderList[i].myDictionary[0] == s || order.OrderList[i].myDictionary[1] == s || order.OrderList[i].myDictionary[2] == s)
                    return i;
            }
            return -1;
        }

        //打印订单
        public static void printOrder(Order order)
        {
            foreach (OrderDetails od in order.OrderList)
            {
                Console.WriteLine(od.myDictionary[0] + "" + od.myDictionary[1] + " " + od.myDictionary[2] + " " + od.myDictionary[3] + " " + od.myDictionary[4]);
            }
        }
    }
}
