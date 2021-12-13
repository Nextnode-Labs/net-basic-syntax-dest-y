using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string inputStr = Console.ReadLine();

            char FirstChar = ' ';

            int CountFirstChar = 0;


            for (int i = 0; i < inputStr.Length; i++)
            {
                if (inputStr[i] == 'Т' || inputStr[i] == 'с') 
                {
                    CountFirstChar = i + 1;
                    FirstChar = inputStr[i];
                    break;
                }
            }
            Console.WriteLine($"Первая встреченная буква в предложении - {FirstChar} а ее порядковый номер {CountFirstChar}");

        }
    }
}
