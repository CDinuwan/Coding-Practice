using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practising
{
    interface Run
    {
        string run();

        int Hight
        {
            get;
            set;
        }
    }
    interface Animal
    {
        string sound();
        string Name
        {
            get;
            set;
        }
    }
    public class Dog: Animal,Run
    {
        private string name;
        private int hight;

        public string run()
        {
            return "Run Fast";
        }
        public Dog(string name,int hight)
        {
            this.name = name;
            this.hight = hight;
        }
        public string sound()
        {
            return "Baw Baw";
        }
        public int Hight
        {
            get
            {
                return hight;
            }
            set
            {
                Hight = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Bawwa",12);
            Console.WriteLine(dog.run());
            Console.WriteLine(dog.sound());
            Console.WriteLine(dog.Name);
            Console.WriteLine(dog.Hight);

            Console.ReadLine();
        }
    }
}
