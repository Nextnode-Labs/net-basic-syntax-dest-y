using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string inputStr = Console.ReadLine();

            int CountN = 0;
            bool DecimateFounded = false;

            for (int i = 0; i < inputStr.Length; i++) 
            {

                if (inputStr[i] == 'н' && !DecimateFounded ) 
                {
                    CountN = CountN + 1;
                }
                if (!DecimateFounded && inputStr[i] == ',')
                {
                    DecimateFounded = true;
                }
            }



            CountN = (DecimateFounded) ? CountN : 0;  //закоментить если в предложения без запятых не может быть.

            Console.WriteLine($"Количество букв 'н' до 1 запятой равно {CountN}");

        }
    }
}
