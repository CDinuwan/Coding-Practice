using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_and_OOP
{
    public abstract class Flower
    {
        private int flowerHeight;
        public abstract void blossom();

        public int FlowerHeight
        {
            get
            {
                return flowerHeight;
            }
            set
            {
                flowerHeight = value;
            }
        }
    }
    public class Nelum : Flower
    {
        public Nelum()
        {
            //Constructor
        }
        public override void blossom()
        {
            Console.WriteLine("Nelum flower");
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach(int num in numbers)
                {
                Console.WriteLine(num);
            }

            Flower f1;
            f1 = new Nelum();
            f1.blossom();
            f1.FlowerHeight = 90;
            Console.WriteLine(f1.FlowerHeight);

            Console.ReadLine();
        }
    }
}
