using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace topic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            OrderDetails od1 = new OrderDetails("a", "20180131", "John", 45, 3, "13457857659");
            OrderDetails od2 = new OrderDetails("b", "20180123", "Jack", 46, 2, "15872563874");
            OrderDetails od3 = new OrderDetails("c", "20180125", "Mary", 47, 4, "137783567623");
            OrderService.Add(order, od1);
            OrderService.Add(order, od2);
            OrderService.Add(order, od3);
            //序列化
            XmlSerializer xmler = new XmlSerializer(typeof(Order));
            String xmlFileName = "s.xml";
            OrderService.Export(xmler, xmlFileName, order);
            //创建XML文件
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"s.xml");

                XPathNavigator nav = doc.CreateNavigator();
                nav.MoveToRoot();

                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(@"s.xslt");

                FileStream outFileStream = File.OpenWrite(@"..\..\OrderList.html");
                XmlTextWriter writer =
                    new XmlTextWriter(outFileStream, System.Text.Encoding.UTF8);
                xt.Transform(nav, null, writer);
            }
            catch (XmlException e)
            {
                Console.WriteLine("XML Exception:" + e.ToString());
            }
            catch (XsltException e)
            {
                Console.WriteLine("XSLT Exception:" + e.ToString());
            }
        }
    }
}
