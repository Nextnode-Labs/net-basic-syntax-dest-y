using System;

namespace Chapter_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            AnyArray arr = new AnyArray();
            arr[5] = "Что то здесь..";
            object o = arr[4];
            Console.WriteLine(o);

            MyArray arr2 = new MyArray();
            arr2[5, 3] = "Что то здесь..2";
            arr2[5, 5] = 5;
            arr2[5, 4] = null;
            Console.WriteLine(arr2[5, 3]);
            Console.WriteLine(arr2[5, 5]);
            Console.WriteLine(arr2[5, 4]);
            Console.WriteLine(arr[o]);
            Console.ReadKey();

            string[] b = { "A", "B", "C", "D", "F" };
            foreach (string n in b[1..3])
            {
                System.Console.WriteLine(n);
            }

            System.Range MyRange = 0..3;
            foreach (string n in b[MyRange])
            {
                System.Console.WriteLine(n);
            }

        }
    }
    class AnyArray
    {
        object[] data = new object[10];
        public object this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        public int this[object o]
        {
            get { return System.Array.IndexOf(data, o); }
        }
    }
    class MyArray
    {
        object[,] data = new object[6, 6];
        public object this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }
    }
}
