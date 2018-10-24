using Microsoft.VisualStudio.TestTools.UnitTesting;
using topic1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void AddTest()
        {
            OrderDetails orderDetails = new OrderDetails()
            {
                Name = "d",
                Num = 40,
                ClientName = "Bob",
                ID = 4,
                Price = 54
            };
            Order order = new Order();
            OrderService.Add(order, orderDetails);
            CollectionAssert.Contains(order.OrderList, orderDetails);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            OrderDetails orderDetails = new OrderDetails()
            {
                Name = "d",
                Num = 40,
                ClientName = "Bob",
                ID = 4,
                Price = 54
            };
            Order order = new Order();
            OrderService.Add(order, orderDetails);
            OrderService.Delete(order, orderDetails);
            CollectionAssert.DoesNotContain(order.OrderList, orderDetails);
        }

        [TestMethod()]
        public void ChangeTest()
        {
            OrderDetails orderDetails = new OrderDetails()
            {
                Name = "d",
                Num = 40,
                ClientName = "Bob",
                ID = 4,
                Price = 54
            };
            Order order = new Order();
            OrderService.Add(order, orderDetails);
            OrderService.Change(order, 0, 56);
            Assert.IsTrue(order.OrderList[0].Num == 56);
        }

        [TestMethod()]
        public void FindTest()
        {
            OrderDetails orderDetails = new OrderDetails()
            {
                Name = "d",
                Num = 40,
                ClientName = "Bob",
                ID = 4,
                Price = 54
            };
            Order order = new Order();
            OrderService.Add(order, orderDetails);
            int n = OrderService.Find(order, "d");
            Assert.IsTrue(n == 0);
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}