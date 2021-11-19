using System;

namespace Chapter_10
{
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello World!");
            spool r25_5 = new spool(2, 3);
            r25_5.widht = 25;
            // r25_5.height = 5;
            int r25_5Weight = r25_5.GetWeight();
            Console.WriteLine(r25_5Weight);

            spool r10_10 = new spool(10);
            int r10_10Weight = r10_10.GetWeight(); ;
            Console.WriteLine(r10_10Weight);

            spool r0_0 = new spool();
            int r0_0Weight = r0_0.GetWeight(); ;
            Console.WriteLine(r0_0Weight);

            spool rInit = new spool() { height = 11, widht = 17 }; //Instant Init!
            Console.WriteLine(rInit.GetWeight());




            //NULL KEYWORD
            string s = null;
            string Ts = null;
            // int strLength = s.Length;
            if (s == null) {
                s = "";
            }
            int strLength = s.Length;
            Console.WriteLine(strLength);
            strLength = (Ts != null) ? Ts.Length : 0;
        }
    }
    class spool 
    {
       public int widht, height;
        //   public spool (int x, int y)
        public spool(int widht, int height)     // CONSTRUCTOR OVERLOADING
        {
            //   widht = x;
            //   height = y;
            this.widht = widht;
            this.height = height;

        }
        public spool(int widhtHeight)       
        {
            this.widht = widhtHeight;
            this.height = widhtHeight;
        }
        public spool() : this(0, 0) { }     //Constructor Chaining!
        public int GetWeight() { return widht * height; }  
    }
}
