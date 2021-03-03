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
    public abstract class Laptop
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Trun On.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turn Off.");
        }
        public abstract bool TouchScreen
        {
            get;
        }
    }
    public class MacBookAir : Laptop
    {
        public override bool TouchScreen => false;
    }
    public class AzusZenBook : Laptop
    {
        public override bool TouchScreen => true;

        public override void TurnOn()
        {
            Console.WriteLine("Turning on specific to AzusZenBook");
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

            Laptop macbookAir = new MacBookAir();
            Laptop azuszenbook = new AzusZenBook();

            macbookAir.TurnOn();
            macbookAir.TurnOff();

            azuszenbook.TurnOff();
            azuszenbook.TurnOn();

            Console.WriteLine(macbookAir.TouchScreen);
            Console.WriteLine(azuszenbook.TouchScreen);

            Console.ReadLine();
        }
    }
}
