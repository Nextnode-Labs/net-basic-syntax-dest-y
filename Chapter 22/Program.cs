using System;

namespace Chapter_22
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            MyNum a = new MyNum(10);
            MyNum b = new MyNum(15);
            MyNum c = MyNum.add(a, b);
            MyNum f =(a + b); //бинарная перегрузка = а+б +100!!!
        }
    }
    class MyNum 
    {
        private int val;
        public MyNum(int i) { this.val = i; System.Console.WriteLine(i); }
        public static MyNum add(MyNum a, MyNum b) { System.Console.WriteLine(a.val + b.val); return new MyNum(a.val + b.val); }
        public static MyNum operator +(MyNum a, MyNum b) { System.Console.WriteLine($"бинарная перегрузка a + b"); return new MyNum(a.val + b.val + 100); }
    }
}
