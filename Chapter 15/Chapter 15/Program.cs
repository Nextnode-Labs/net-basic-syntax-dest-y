using System;

namespace Chapter_15
{
    class Program
    {
        static void Main(string[] args)
        {
            spool s88 = new spool();
            s88.length = 132;

            Console.WriteLine(s88.length);
        }
    }
    class spool
    {
        private int SpoolLength;
        public int length
        {
            get {return SpoolLength;}
            set {if (value > 0)
                    SpoolLength = value;
                else
                    SpoolLength = 0;
             }
        }
    }
}
