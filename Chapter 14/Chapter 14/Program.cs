using System;

namespace Chapter_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            float f = Spool.ComputeArea(Spool.pi);
            Console.WriteLine(f);
            // float f = Spool.GetArea(); No Access

            Cointer();
            Console.WriteLine(count);
            Cointer();
            Console.WriteLine(count);
            Cointer();
            Console.WriteLine(count);

            string GetName()
            {
                string name = "newName";
                return LocalFunc();
                string LocalFunc() { return name; }
            }

            Console.WriteLine(GetName());

            string s = "16";
            int k = s.ToInt();
            Console.WriteLine(k);
        }
        static int count = 0;
        public static void Cointer()
        {
            count++;
        }
    }

    class Spool
    {
        public float r = 25F;
        public static float pi = 3.14F;

        public float GetArea()
        {
            return ComputeArea(r);
        }
        public static float ComputeArea(float a)
        {
            return pi * a * a;
        }
        
    }
    static class MyExtansions
    {
        public static int ToInt(this string s)
        {
            return Int32.Parse(s);
        }
    }
}
