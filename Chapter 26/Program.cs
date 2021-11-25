using System;

namespace Chapter_26
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate d = Print;

            MyDelegate f = new MyDelegate(Print);

            d("1");
            f("f");

            MyDelegate fd = f + d;

            fd("f + d");

            spool spool8_10 = new spool(8, 10);
            spool8_10.RegHandler(Print);


            spool8_10.ShowInfo();




        }
        static void Print(string s)
        {
            Console.WriteLine(s);
        }
    }

    delegate void MyDelegate(string str);

    delegate void ShowMessageHandler(string str);


    class spool
    {
        int width;
        int height;
        public spool(int width, int height) { this.width = width; this.height = height; }

        public void ShowInfo()
        {
            ShowWidthHeight($"Высота катушки = {height}");
            ShowWidthHeight($"Ширина катушки = {width}");
        }

        ShowMessageHandler ShowWidthHeight = null;
        public void RegHandler(ShowMessageHandler del) 
        {
            ShowWidthHeight = del;
        }
        
    }

}
