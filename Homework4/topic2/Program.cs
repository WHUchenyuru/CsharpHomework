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
            OrderDetails od1 = new OrderDetails("a", 0, "John", 45, 3);
            OrderDetails od2 = new OrderDetails("b", 1, "Jack", 46, 2);
            OrderDetails od3 = new OrderDetails("c", 0, "Mary", 47, 4);
            OrderService.Add(order, od1);
            OrderService.Add(order, od2);
            OrderService.Add(order, od3);
        }
    }
}
