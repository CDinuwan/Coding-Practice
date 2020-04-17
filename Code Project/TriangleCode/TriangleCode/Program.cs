using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(" ");
                    for(int k=0;k<5;k++)
                    {
                        Console.WriteLine("* ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter positive number do you want to add : ");
            int num = Int32.Parse(Console.ReadLine());

            int[] numbers = new int[num];

            for (int j=0; j < num;j++)
            {
                Console.WriteLine("Enter integer value : ");
                numbers[j] = Int32.Parse(Console.ReadLine());
            }

            bool semettric = true;
            for(int i=0;i<numbers.Length/2;i++)
            {
                if(numbers[i]!=numbers[num-i-1])
                {
                    semettric = false;
                    break;
                }
            }
            if(semettric==false)
            {
                Console.WriteLine("Array is not semmetric");
            }
            else if(semettric==true)
                        {
                Console.WriteLine("Array is semmtric");
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}
