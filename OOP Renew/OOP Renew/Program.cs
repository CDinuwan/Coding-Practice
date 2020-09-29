using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Renew
{
    
    class Book
    {
        public string bookName;
        public int pages;
        public string author;

        public static string SayHi(string hi)
        {
            return "Hi " + hi;
        }
    }
    class Vehicle
    {
        private string name;
        public string model;
        public int year;

        public Vehicle(string Name,string Model,int Year)
        {
            this.name = Name;
            this.model = Model;
            this.year = Year;
        }
        public string Name { 
            get { return name; }
            set { 
                if(value=="Toyota")
                {
                    name = value;
                }
                else
                {
                    name = "Invalid";
                }
            }
        }

        public bool NewCar()
        {
            if(year>2020)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Chef
    {
        public virtual void Fo()
        {
            Console.WriteLine("Creating normal dishes");
        }
    }

    class ItalianChef:Chef
    {
        public override void Fo()
        {
            Console.WriteLine("Creating Italian foods");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.bookName = "Harry Pottr";
            Console.WriteLine(book1.bookName);

            Vehicle car1 = new Vehicle("Honda", "Pryus", 2020);
            Console.WriteLine(car1.Name);
            Console.WriteLine(car1.NewCar());

            Console.WriteLine(Book.SayHi("Chanuka"));


            //When we call static method we must call with it in our class object
            Console.ReadLine();
        }
    }
}
