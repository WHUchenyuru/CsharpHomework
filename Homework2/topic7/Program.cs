using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] num = new int[] { 23, 45, 7, 46, 98, 9 };
            int max = num[0];
            int min = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (max < num[i])
                {
                    max = num[i];
                }
                if (min > num[i])
                {
                    min = num[i];
                }
                sum += num[i];
                System.Console.WriteLine(num[i]);
            }
            int aver = sum / (num.Length);
            System.Console.WriteLine("max number = " + max);
            System.Console.WriteLine("min number = " + min);
            System.Console.WriteLine("summary number = " + sum);
            System.Console.WriteLine("averange number = " + aver);

        }
    }
}
