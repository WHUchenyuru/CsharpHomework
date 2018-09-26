using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic1
{
    public abstract class Shape
    {
        public abstract string Show();
        public abstract string Area
        {
            get;
        }
    }

    public class Square : Shape
    {
        private int side;
        public Square(int s)
        {
            side = s;
        }
        public override string Show()
        {
            return "正方形创建成功！";
        }
        public override string Area
        {
            get
            {
                return "面积为：" + side * side;
            }           
        }
    }

    public class Circle : Shape
    {
        private int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public override string Show()
        {
            return "圆形创建成功！";
        }
        public override string Area
        {
            get
            {
                return "面积为：" + radius * radius * 3.1415;
            }
        }
    }

    public class Rectangle : Shape
    {
        private int width;
        private int height;
        public Rectangle(int a , int b)
        {
            width = a;
            height = b;
        }
        public override string Show()
        {
            return "长方形创建成功！";
        }
        public override string Area
        {
            get
            {
                return "面积为：" + width * height;
            }
        }
    }

    public class Triangle : Shape
    {
        private int side;
        private int height;
        public Triangle(int s , int h)
        {
            side = s;
            height = h;
        }
        public override string Show()
        {
            return "三角形创建成功！";
        }
        public override string Area
        {
            get
            {
                return "面积为：" + side * height * 1/2;
            }
        }
    }

    public class Factory
    {
        public static Shape CreateShape(string type)
        {
            Shape sha = null;
            switch(type)
            {
                case "square":
                    sha = new Square(4);
                    break;
                case "circle":
                    sha = new Circle(5);
                    break;
                case "rectangle":
                    sha = new Rectangle(3 , 2);
                    break;
                case "triangle":
                    sha = new Triangle(3 , 7);
                    break;
            }
            return sha;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape Square = Factory.CreateShape("square");
                Shape Circle = Factory.CreateShape("circle");
                Shape Rectangle = Factory.CreateShape("rectangle");
                Shape Triangle = Factory.CreateShape("triangle");
                if(Square != null)
                {
                    Console.WriteLine(Square.Show());
                    Console.WriteLine(Square.Area);
                }
                if(Circle != null)
                {
                    Console.WriteLine(Circle.Show());
                    Console.WriteLine(Circle.Area);
                }
                if(Rectangle != null)
                {
                    Console.WriteLine(Rectangle.Show());
                    Console.WriteLine(Rectangle.Area);
                }
                if(Triangle != null)
                {
                    Console.WriteLine(Triangle.Show());
                    Console.WriteLine(Triangle.Area);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("输入错误！");
            }
        }
    }
}
