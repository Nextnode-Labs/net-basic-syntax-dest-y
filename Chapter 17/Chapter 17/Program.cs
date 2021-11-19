using System;

namespace Chapter_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IComparable l2 = new Circle();
            IComparable l3 = new Circle();
            IComparable l4 = new Circle();
            l3.setr(3);
            l2.setr(10);
            Console.WriteLine(l2.Compare(l3));

            static IComparable LargestCircle(IComparable a, IComparable b)
            {
                return (a.Compare(b) > 0) ? a : b;
            }

            Console.WriteLine(LargestCircle(l2, l3));
            l4 = LargestCircle(l2, l3);
            l4.setr(15);

            l2.showR(); //3
            l3.showR(); //10
            l4.showR(); //15
            l2.showR(); // l2===l4 reference!!!
            l3.showR();
        }
    }
    }
    interface IComparable
    {
        int Compare(object o);
        void setr(int k);
        public void showR();
    }

    class Circle : IComparable
    {
        public int r = 4;
        public int Compare(object o)
        {
            return r - (o as Circle).r;
        }
        public void setr(int k) { this.r = k; }
        public void showR() { Console.WriteLine(this.r); }
}
    
