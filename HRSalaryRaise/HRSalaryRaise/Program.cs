using System;
using System.Collections.Generic;


namespace HRSalaryRaise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> RaisingList = new List<Person>
            {
                new Person() { Name = "Pepe", Salary = 4000 },
                new Person() { Name = "Alberto", Salary = 5000 },
                new Person() { Name = "Mario", Salary = 9000 },
                new Person() { Name = "Tereza", Salary = 10000 },
                new Person() { Name = "Celeste", Salary = 2000 },
                new Person() { Name = "Toni", Salary = 25000 }
            };

            HR(RaisingList);
        }

        static void HR(List<Person> RaisingList)
        {
            int salary;
            foreach (Person person in RaisingList)
            {
                salary = (person.Salary * 10 / 100) + person.Salary;
                Console.WriteLine("{1} 10% added {0:C}", salary, person.Name);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}




