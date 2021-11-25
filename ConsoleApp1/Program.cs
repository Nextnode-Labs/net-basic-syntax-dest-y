using System;
delegate int intDelegate(int a, int b);

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            intDelegate a = sum;
            Console.WriteLine(a(1,9));
            Console.WriteLine(sum(1,9));
        }
        static int sum(int a, int b)
        {
            return a + b;
    }
    }
}
