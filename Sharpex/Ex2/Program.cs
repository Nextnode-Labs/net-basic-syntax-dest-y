using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Workers group = new Workers(12);
            Random rnd = new Random();

            List<Salary> SalaryList = new List<Salary>();
            SalaryList.Add(new Salary(2, Months.Feb, 200));

            

            foreach (Months m in (Months[]) Enum.GetValues(typeof(Months))) {       //генерируем лист зарплат со случайными ЗП
                foreach (Worker n in group.Lists) 
                {
                    SalaryList.Add(new Salary(n.idWorker, m, rnd.Next(700, 1500)));
                }
            }

            int GetSalaryInfo(int IdWorker)
            {
                int WorkerSalary = 0;
                foreach (Salary s in SalaryList)
                {
                    if (s.IdWorker == IdWorker) 
                    {
                        WorkerSalary = WorkerSalary + s.PayRoll;
                    }
                }
                return WorkerSalary;
            }
            int GetAllSalary(Months st)
            {
                int WorkersSalary = 0;
                foreach (Salary s in SalaryList)
                {
                    if (s.Month == st) 
                    {
                        WorkersSalary = WorkersSalary + s.PayRoll;
                    }
                }
                return WorkersSalary;
            }

            int QSalary = GetAllSalary(Months.Jan) + GetAllSalary(Months.Feb) + GetAllSalary(Months.Mar);

            Console.WriteLine(GetSalaryInfo(11));  //Зп работника с ид 11
            Console.WriteLine(GetAllSalary(Months.Feb)); //ЗП всех работников за месяц февраль
            Console.WriteLine(QSalary); //Зп всех работников за квартал;

        }
    }

    enum Months { Jan, Feb, Mar };

    class Salary
    {
        public int IdWorker { get; set; }
        public Months Month { get; set; }
        public int PayRoll { get; set; }

        public Salary(int IdWorker, Months Month, int PayRoll) 
        {
            this.IdWorker = IdWorker;
            this.Month = Month;
            this.PayRoll = PayRoll;
        }
    }

    class Worker
    {
        public int idWorker;

        public Worker(int id) 
        {
            this.idWorker = id;
        }

        public void SetId(int id) { this.idWorker = id; }
    }

    class Workers 
    {
        public List<Worker> Lists;

        public Workers(int CountWorkers) 
        {
            Lists = new List<Worker>();
            for (int i = 0; i < CountWorkers; i++) 
            {
                Lists.Add( new Worker(i+1) );
            }
          //  this.Lists = Lists;
        }    
    }


}
