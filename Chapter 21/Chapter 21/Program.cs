using System;
using System.IO;

namespace Chapter_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 2;

            try
            {
                i = i / j;
                StreamReader sr = new StreamReader("miss.txt");
            }
            catch (FileNotFoundException e)
                when (e.FileName.Contains(".txt"))
            {
                Console.WriteLine("Ненайден файл" + e.FileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Нельзя делить на 0");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Проверьте введенные данные");
            }
            MyClass c = new MyClass();
            c.name = "not null";
            //c.name = null;

        }
        class MyClass
        {
            private string _name;
            public string name
            {
                get => _name;
                set => _name = value ?? throw new
                    ArgumentNullException(nameof(name) + " was null");
            }
        }
    }
}
