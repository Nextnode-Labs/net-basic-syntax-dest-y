using System;
using System.Collections.Generic;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            SectretNumber a = new SectretNumber();

            Console.WriteLine(a.value);
            for (int i = 0; i < 200; i++) { Console.WriteLine(new SectretNumber().value); }
        }
    }

    class SectretNumber 
    {
        public int value;
        Random rnd = new Random();
        List<int> usedNumbers = new List<int>();
        int tInt;

        public SectretNumber() 
        {
            while (usedNumbers.Count < 4) {

                if (usedNumbers.Count == 3)
                {
                    tInt = rnd.Next(1, 9);
                    if (!usedNumbers.Contains(tInt))
                    {

                        value = value + tInt * (int)Math.Pow(10, usedNumbers.Count);
                        usedNumbers.Add(tInt);
                    }
                }
                else { 
                tInt = rnd.Next(0, 9);
                Console.WriteLine(tInt);
                if (!usedNumbers.Contains(tInt))
                {

                    value = value + tInt * (int)Math.Pow(10, usedNumbers.Count);
                    usedNumbers.Add(tInt);
                }
                }

            }
        }
    }
}
