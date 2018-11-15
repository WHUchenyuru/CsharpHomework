using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic2
{
    [Serializable]
    public class OrderDetails
    {
        public string Name { get; set; }            //商品名称
        public string ID { get; set; }                 //商品订单号
        public string ClientName { get; set; }      //客户名称
        public int Num { get; set; }                //订购数量
        public int Price { get; set; }                  //商品价值
        public string Phone { get; set; }           //电话号码
        public OrderDetails(string name, string id, string clientname, int num, int price, string phone)
        {
            Name = name;
            ID = id;
            ClientName = clientname;
            Num = num;
            Price = price;
            Phone = phone;
        }
        public OrderDetails() { }
    }
}
