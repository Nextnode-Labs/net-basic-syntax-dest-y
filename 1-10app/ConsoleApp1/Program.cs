using System;

namespace ConsoleApp1
{
    class MyApp
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            int myInt2;
            myInt2 = 25;
            int myInt3 = 35;
            System.Console.WriteLine(myInt2 + myInt3);


            sbyte myIntSbyte = 127;
            myIntSbyte = (sbyte)(myIntSbyte + 1);
            System.Console.WriteLine(myInt2 + myInt3);                  //overflow?


            float myFloat = 3.148141412F;
            System.Console.WriteLine(myFloat);                          //rounded!!
            double myDouble = (double)myFloat;
            System.Console.WriteLine(myDouble);                         //trash numbers 7+, because rounded.


            myFloat = myInt2 / (float)33;
            System.Console.WriteLine(myFloat);


            int Bint1 = 23, Bint2 = 23, Bint3 = 3;
            int x = Bint1 ^ Bint2 ^ Bint3;
            System.Console.WriteLine(x);                                 // == Bint3?


            System.Console.Clear();                                     //CLEAR CONSOLE!
            //Strings
            String a = "World";
            String b = "Hello " + a;
            System.Console.WriteLine(b);

            String c = x.ToString();
            System.Console.WriteLine(c);

            string s = $"Start! {b} №{c}";
            System.Console.WriteLine(s);

            string e = "E:\\.ssh\\github";

            a = a.Replace("o", "i").Remove(2, 1) + a;                   //WildWorld
            System.Console.WriteLine(a);

            System.Text.StringBuilder sb = new
            System.Text.StringBuilder("");
            sb.Append(a);
            sb.Remove(1, 3);
            a = sb.ToString();
            System.Console.WriteLine(a);



            //ARRAYS
            System.Console.Clear();                                     //CLEAR CONSOLE!

            int[] xarr;
            xarr = new int[3];

            xarr[0] = 1;
            xarr[1] = 11;
            xarr[2] = 32;

            int[] yarr = new int[] { 1, 11, 32 };
            int[] zarr = { 1, 11, 32 };

            System.Console.WriteLine(xarr[0] + yarr[1] + zarr[2]);


            int[,] RecArr = new int[3, 3];
            RecArr[0, 0] = 1;
            RecArr[0, 1] = 2;
            RecArr[0, 2] = 3;
            RecArr[1, 0] = 4;
            RecArr[1, 1] = 5;
            RecArr[1, 2] = 6;
            //...............
            RecArr[2, 2] = 9;

            if (RecArr[2, 1] > 1)
            {
                System.Console.WriteLine(RecArr[2, 1]);
            } 
            else
            {
                System.Console.WriteLine("no data for RecArr[2, 1]");
            }


            double randDouble = new System.Random().NextDouble();
            int randInt = (randDouble < 0.3) ? 2 : 3;
            System.Console.WriteLine(randInt);

    
            foreach (int n in xarr) {
                System.Console.WriteLine(n);
            }

           
            MyApp mm = new MyApp();
            mm.MyPrint(s,e);

            MyApp mInt = new MyApp();
            mInt.MyPrint(zarr);

            MyApp textApp = new MyApp();
            System.Console.WriteLine(textApp.GetText());

            mm.Set(ref myInt3);
            System.Console.WriteLine(myInt3);

            int unassignetInt;
            mm.SetOut(out unassignetInt);
            System.Console.WriteLine(myInt3);


            mm.Counter(3, 7);

        }

        void MyPrint(string s1, string s2)
        {
            System.Console.WriteLine(s1 + s2);
        }
        void MyPrint(params int[] s)
        {
            foreach (int x in s)
            System.Console.WriteLine(x);
        }
        String GetText() 
        {
            return "Some text...";
        }
        void Set(ref int ref_i) { ref_i = 15; }
        void SetOut(out int ref_i) { ref_i = 15; }

        void Counter(int startCount, int endCount) {

            RecursionCounter(startCount);
            System.Console.WriteLine("END!!!");

            void RecursionCounter(int i) {
                if (i > endCount) return;
                System.Console.WriteLine(i);
                System.Threading.Thread.Sleep(1000);
                RecursionCounter(i + 1);
            }
        }


    }




}
