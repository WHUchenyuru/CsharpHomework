using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic9
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建2-100的数组
            int[] num = new int[99];
            for (int i = 0; i < 99; i++)
            {
                num[i] = i + 2;
            }
            //埃氏筛法
            for (int n = 2; n <= 10; n++)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if ((num[i] % n == 0) && num[i] > n)

                    {
                        Array.Clear(num, i, 1);
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != 0)
                {
                    System.Console.WriteLine(num[i]);
                }
            }
        }
    }
}
