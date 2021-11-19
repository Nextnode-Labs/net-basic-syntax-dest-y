using System;
using myNamespaces = Chapter_19.SecondNamespaces;
using includedClass = Chapter_19.SecondNamespaces.MyClass;

namespace Chapter_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

         //   SecondNamespaces.MyClass myClass = new SecondNamespaces.MyClass();
            myNamespaces.MyClass myClass = new myNamespaces.MyClass();

            MyClass myClass2 = new MyClass();  

            Console.WriteLine(myClass.r);
            Console.WriteLine(myClass2.r);      // included namespace class Myclass HIDDEN!


            includedClass myClass3 = new includedClass();

            Console.WriteLine(myClass3.r);
        }
        class MyClass 
        {
            public int r = 10;
        }
    }
    namespace SecondNamespaces
    {
        class MyClass 
        {
            public int r = 1;
        }
    }
}
