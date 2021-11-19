using System;

namespace Chapter_11
{
    class Program
    {
        static void Main()
        {
            //   Console.WriteLine("Hello World!");

            spool r = new spool8_8();
            r.x = 8;
            r.y = 8;
            int Weight8_8 = r.getWeight();
            Console.WriteLine(Weight8_8);

            spool l = r;

            spool l2 = (spool)l;


            int myInt = 77;
            object myObj = myInt; 
            Console.WriteLine(myObj);

            spool rs = new spool8_8();
            if (rs is spool8_8) { spool o = rs;  }

            spool rt = new spool();
            spool8_8 ot = rt as spool8_8;


            testApp C =  new testApp();
            C.testObj(1);
            C.testObj(15);
            C.testObj(0);
            C.testObj(null);
        }
    }
    class spool
    {
        public int x, y;
        public int getWeight() { return x * y; }
    }
    class spool8_8 : spool { }
    class testApp 
    { 
       public void testObj(object obj) 
        {
            if (obj is 15)
                System.Console.WriteLine("15");
            else if (obj is int i) 
            {
                System.Console.WriteLine("int" + i);
            }
            else if (obj is null)
            {
                System.Console.WriteLine("NULL!");
            }
        }
    }
    
}