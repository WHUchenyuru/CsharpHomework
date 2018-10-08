using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    //声明参数类型
    public class TimeArgs : EventArgs
    {
        public double time;
    }

    //声明委托类型
    public delegate void EventHandler(object sender, TimeArgs e);

    //定义事件类（闹钟类）
    public class Clock
    {
        //声明事件
        public event EventHandler Ring;
        public void DoTime()
        {
            double total;
            Console.Write("请设置提示时间(s): ");
            string s = Console.ReadLine();
            total = double.Parse(s);
            while(total != 0)
            {
                System.Threading.Thread.Sleep(1000);
                total--;
            }
            if(Ring != null)
            {
                TimeArgs args = new TimeArgs();
                args.time = total;
                Ring(this, args);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var time = new Clock();
            //注册事件
            time.Ring += Show;
            time.DoTime();
        }

        //事件处理方法
        static void Show(object sender , TimeArgs e)
        {
            Console.WriteLine("The alarm is ringing!");
        }
    }
}
