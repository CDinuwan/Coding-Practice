using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Person
    {
        public int Age { get; set; }
        public int Energy { get; set; }
        public Person(int age,int energy)
        {
            this.Age = age;
            this.Energy = energy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(21, 566);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Energy);

            var chanuka = new Person(24, 1000);
            Console.WriteLine("Chanuka's age is "+chanuka.Age);
            Console.ReadLine();
        }
    }
}
