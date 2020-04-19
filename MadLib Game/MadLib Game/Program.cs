using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter color :");
            string color = Console.ReadLine();

            Console.WriteLine("Enter pluralNoun :");
            string pluraNoun = Console.ReadLine();

            Console.WriteLine("Enter celebrity");
            string celebrity = Console.ReadLine();

            Console.WriteLine("Roses are "+color);
            Console.WriteLine(pluraNoun+" are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();
        }
    }
}
