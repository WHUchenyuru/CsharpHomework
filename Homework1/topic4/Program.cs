using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double n = 0;
            double d = 0;
            Console.Write("Please input a number :");
            s = Console.ReadLine();
            n = Double.Parse(s);
            Console.Write("Please input a number :");
            s = Console.ReadLine();
            d = Double.Parse(s);
            Console.WriteLine(n + " * " + d + "=" + (n * d));
        }
    }
}
