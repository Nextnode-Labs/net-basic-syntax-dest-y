using System;

namespace Chapter_13_second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Derived : Chapter_13.MyBase
    {
        void Test()
        {
            myPublic = 0;
            myProtInt = 0;
            // myPrivProt = 0;  Inaccessible!
            // myInternal = 0;  Inaccessible!
            myProtected = 0;
            //    myPrivate = 0; Inaccessible!
        }
    }
    class OtherClass
    {
        void Test(Chapter_13.MyBase m)
        {
            m.myPublic = 0;         //!ONLY PUBLIC ALLOWED!
            // m.myProtInt = 0;     Inaccessible!
            //   m.myPrivProt = 0;  Inaccessible!
            // m.myInternal = 0;    Inaccessible!
            //   m.myProtected = 0; Inaccessible!
            //  m.myPrivate = 0;    Inaccessible!
        }
    }
}
