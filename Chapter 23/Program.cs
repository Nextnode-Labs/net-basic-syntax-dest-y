using System;

namespace Chapter_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyNum o = new MyNum(1);
            o = 2;
            o = 14;
            int q = (int)o;

            Console.WriteLine(q);
        }
    }
    class MyNum 
    {
        public int val;
        public MyNum(int i) { val = i; }
        public static implicit operator MyNum(int a) 
        {
            Console.WriteLine("MyNum Присвоено новое значение");
            return new MyNum(a);
        }
        public static explicit operator int(MyNum a)
        {
            Console.WriteLine("MyNum - приведение к int ");
            return a.val;
        }
    }
}
