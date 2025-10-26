using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Point
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point(double value) : this(value, value)
        {
        }
        public Point() : this(0, 0)
        {
        }

        public void Show()
        {
            Console.WriteLine($"Точка:({X}, {Y})");
        }
    }

}
