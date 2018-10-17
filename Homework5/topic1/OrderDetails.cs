using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    public class OrderDetails
    {
        public Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        public OrderDetails(string name = "", string id = "", string clientName = "", string num = "", string price = "")
        {
            myDictionary[0] = name;          //商品名称
            myDictionary[1] = id;            //商品订单号
            myDictionary[2] = clientName;    //客户名称
            myDictionary[3] = num;           //订购数量
            myDictionary[4] = price;         //商品价格
        }
    }
}
