using System;

namespace Chapter_18
{
    class Program
    {
        static void Main(string[] args)
        {
            driver Vlad = new driver();
            Vlad.driveCar(new mazda());
            Vlad.driveCar(new BMW());

            car bmwS = new BMW();
            bmwS.CarName();
        }
    }

    abstract class car 
    {
        public abstract void Drive();
        public void CarName() 
        {
            Console.WriteLine(GetType().Name);
        }
    }

    class driver 
    {
        public void driveCar(car car) 
        {
            car.Drive();
        }
    }

    class mazda : car
    {
        public override void Drive()
        {
            Console.WriteLine("Еду на мазде");
        }
    }
    class BMW : car
    {
        public override void Drive()
        {
            Console.WriteLine("Еду на БМВ");
        }
    }
}
