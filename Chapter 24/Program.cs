using System;

namespace Chapter_24
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        Point a = new Point();
        Point b = new Point(2, 3);
        Point c;
        Console.WriteLine((a.x + a.y)); //0?
        Console.WriteLine((b.x + b.y)); //5?
        //Console.WriteLine((c.x + c.y)); //undefined!!
        //only for semantic and perfomance!
        }
    }
    struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
