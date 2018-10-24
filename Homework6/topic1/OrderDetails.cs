using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    [Serializable]
    public class OrderDetails
    {
        public string Name { get; set; }            //商品名称
        public int ID { get; set; }                 //商品订单号
        public string ClientName { get; set; }      //客户名称
        public int Num { get; set; }                //订购数量
        public int Price{get;set;}                  //商品价值
        public OrderDetails(string name , int id , string clientname , int num , int price)
        {
            Name = name;
            ID = id;
            ClientName = clientname;
            Num = num;
            Price = price;
        }
        public OrderDetails() { }
    }
}
