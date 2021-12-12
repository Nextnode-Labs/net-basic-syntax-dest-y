using System;
using System.Collections.Generic;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            int Divisions = 0;
            Console.WriteLine("ВВедите количество часов экспириемента");
            int ExpDuration = int.Parse(Console.ReadLine());
;
            List<Amoeba> exp = new List<Amoeba>();
            exp.Add(new Amoeba());

            for (int duration = 0; duration <= ExpDuration; duration++) 
            {
                if (duration % 3 == 0 && duration != 0) 
                {
                    foreach (Amoeba a in exp) 
                    {
                        Divisions++;
                    }
                    for (int i = 0; Divisions > i; i++) 
                    {
                        exp.Add(new Amoeba());
                    }
                    Divisions = 0;
                    Console.WriteLine($"Количество амеб после прошествия {duration} часов эксперемента равно {exp.Count}");
                }
            }



    }
    }
    class Amoeba 
    {

    }
}
