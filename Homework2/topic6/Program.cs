using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = "";
                System.Console.Write("Please input a natural number: ");
                s = Console.ReadLine();
                int c = Int32.Parse(s);
                while (c % 2 == 0)
                {
                    c = c / 2;
                    System.Console.WriteLine("2");
                }
                for (int i = 3; i <= Math.Sqrt(c); i += 2)
                {
                    while (c % i == 0)
                    {
                        c = c / i;
                        System.Console.WriteLine(i);
                    }
                }
                if (c > 2)
                {
                    System.Console.WriteLine(c);
                }

            }
        }
    }
}
