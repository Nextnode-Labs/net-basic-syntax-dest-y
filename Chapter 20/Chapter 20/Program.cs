using System;

namespace Chapter_20
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Hello World!");

            State s = State.Jumping;
            s = (State)3;
            switch (s)
            {
                case State.Runing: { Console.WriteLine("я бегу"); break; }
                case State.Jumping: { Console.WriteLine("я прыгаю"); break; }
                case State.Talking: { Console.WriteLine("я разговариваю"); break; }
                case State.Waiting: { Console.WriteLine("я жду"); break; }
            }

            Console.WriteLine(s.ToString());  //running
            Console.WriteLine((int)s);        //int = 3  
        }
        enum State { Runing = 3, Jumping, Talking, Waiting };

        


        
    }
}
