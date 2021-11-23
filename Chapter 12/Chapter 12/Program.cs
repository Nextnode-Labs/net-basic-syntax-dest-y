using System;

namespace Chapter_12
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            Spool k = new Spool();
            Console.WriteLine(k.GetWeight());


            DoubleSpool r = new DoubleSpool();
            Console.WriteLine(r.GetWeight());

            OverrideSpool ov = new OverrideSpool();
            Spool sp = ov;
            Spool sk = r;

            Console.WriteLine(sp.GetWeight() + " redefined"); //redefined!
            Console.WriteLine(sk.GetWeight()); 
        }
    }
    class Spool
    {
        public int width = 2, height = 4;
        public virtual int GetWeight() { return width * height; }
    }
    class DoubleSpool : Spool 
    { 
        public new int GetWeight() { return 2 * width * height; }
    }
    class OverrideSpool : Spool
    {
        //public override int GetWeight() { return 10 * width * height; }
        public override int GetWeight() { return base.GetWeight()*99; }
    }   

}   
