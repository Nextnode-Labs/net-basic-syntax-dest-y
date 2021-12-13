using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6
{
    class Program
    {

        static void Main(string[] args)
        {
            SectretNumber a = new SectretNumber();
            gameMain game = new gameMain();
            game.startGame(a.mask);
        }
    }
    
    class SectretNumber 
    {
        public int value;
        Random rnd = new Random();
        List<int> usedNumbers = new List<int>();
        int tInt;
        public List<int> mask;

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
                if (!usedNumbers.Contains(tInt))
                {

                    value = value + tInt * (int)Math.Pow(10, usedNumbers.Count);
                    usedNumbers.Add(tInt);
                }
                }
            }
            mask = (usedNumbers.GroupBy(x => x).Select(x => x.First()).ToList());
            mask.Reverse();
        }
    }
    class gameMain 
    {
        int userNumber;
        int attempsCount;
        List<int> userNumberMask;
        List<int> SectretNumber;
        
        public void startGame(List<int> SectretNumber) 
        {
            attempsCount = 0;

        List<int> getUserNumberMask() 
            {
                Console.WriteLine("ВВедите четырехзначное число");
                userNumber = Convert.ToInt32(Console.ReadLine());
                return CreateUserMask(userNumber);  
            }
            while (!SectretNumber.SequenceEqual(userNumberMask = getUserNumberMask()))
            {
                attempsCount++;
                for (int i = 0; i < userNumberMask.Count; i++)
                {
                    if (SectretNumber.IndexOf(userNumberMask[i]) >= 0)
                    {
                        if (SectretNumber.IndexOf(userNumberMask[i]) == i)
                        {
                            Console.WriteLine($"БЫК {i + 1}");
                        }
                        else { Console.WriteLine($"КОРОВА {userNumberMask[i]}"); }
                        
                    }
                }
            }
            Console.WriteLine($"Победа! Количество попыток = {attempsCount}");
        }


        static List<int> CreateUserMask(int number)
        {
            List<int> userMask = new List<int>();

            while (number > 0)
            {
                userMask.Add(number % 10);
                number = number / 10;
            }
            userMask.Reverse();
            return userMask;
        }
    }
}
