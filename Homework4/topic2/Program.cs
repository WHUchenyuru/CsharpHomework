using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderDetails od1 = new OrderDetails("a","0","John","45");
            OrderDetails od2 = new OrderDetails("b","1","Jack","46");
            OrderDetails od3 = new OrderDetails("c","0","Mary","47");
            OrderService.Add(order, od1);
            OrderService.Add(order, od2);
            OrderService.Add(order, od3);
            OrderService.Delete(order, od1);
            OrderService.Change(order, 0, 3, "40");
            int index = OrderService.Find(order, "Jack");
        }
    }
}
