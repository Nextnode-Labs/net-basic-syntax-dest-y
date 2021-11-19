using System;
using System.Collections.Generic;
namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            //person Bred = new person("Bred", 16);
            //Console.WriteLine(Bred.name);

            Console.WriteLine("размер группы");
            int length = Convert.ToInt32(Console.ReadLine()); ;

            Group myg = new Group(length);
            int mygMaxAge = MaxAgeinGroup(myg);
            int mygMinAge = MinAgeinGroup(myg);

            if (mygMaxAge > mygMinAge)
            {
                Console.WriteLine($"Самый молодой человек указан раньше его номер : {mygMinAge + 1} а имя {myg.arr[mygMinAge].name}");
            }
            else 
            {
                Console.WriteLine($"Самый старый человек указан раньше его номер : {mygMaxAge + 1} а имя {myg.arr[mygMaxAge].name}");
            }
        }

        static int MaxAgeinGroup(Group anyGroup)
        {
            int maxAge = anyGroup.arr[0].age;
            int i = 0;
            int max_i = 0;
            while (anyGroup.arr.Length > i) 
            {
                if (anyGroup.arr[i].age > maxAge) 
                {
                    maxAge = anyGroup.arr[i].age;
                    max_i = i;
                    i = i + 1;   
                }
                i = i + 1;
            }
            return max_i;
        }
        static int MinAgeinGroup(Group anyGroup)
        {
            int minAge = anyGroup.arr[0].age;
            int i = 0;
            int min_i = 0;
            while (anyGroup.arr.Length > i)
            {
                if (anyGroup.arr[i].age < minAge)
                {
                    minAge = anyGroup.arr[i].age;
                    min_i = i;
                    i = i + 1;
                }
                i = i + 1;
            }
            return min_i;
        }

    }

    public class person 
    {
        public string name { get; set; }
        public int age { get; set; }
        public person( string name,  int age) {
            this.name = name;
            this.age = age;
        }
    }
    public class Group
    {
        public person[] arr;
        int i = 0;

        public void AddPerson()
        {
            int personAge;
            string personName;

            Console.WriteLine("Введите возраст");
            personAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя");
            personName = Console.ReadLine();

            this.arr[i] = new person(personName, personAge);
            this.i = this.i + 1;
        }

        public Group(int count)
        {
            person[] arr = new person[count];
            this.arr = arr;

            while (this.arr.Length > this.i) 
            {
                AddPerson();
            } 
                
        }
        
    }
}
