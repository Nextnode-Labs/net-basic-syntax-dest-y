using System;

namespace Chapter_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class MyBase
    {
        public int myPublic;
        protected internal int myProtInt;
        private protected int myPrivProt;
        internal int myInternal;
        protected int myProtected;
        private int myPrivate;

        void Test()
        {
            myPublic = 0;
            myProtInt = 0;
            myPrivProt = 0;
            myInternal = 0;
            myProtected = 0;
            myPrivate = 0;
        }
    }
    class Derived : MyBase 
    {
        void Test()
        {
            myPublic = 0;
            myProtInt = 0;
            myPrivProt = 0;
            myInternal = 0;
            myProtected = 0;
        //    myPrivate = 0; Inaccessible!
        }
    }
    class OtherClass
    {
        void Test(MyBase m)
        {
            m.myPublic = 0;
            m.myProtInt = 0;
            //   m.myPrivProt = 0;  Inaccessible!
            m.myInternal = 0;
            //   m.myProtected = 0; Inaccessible!
            //  m.myPrivate = 0;    Inaccessible!
        }
    }
}
