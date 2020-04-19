using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your value : ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            do
            {
                factorial = n * factorial;
                n--;
            } while (n >= 1);
            Console.WriteLine(factorial);
            int[] number = new int[20];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter nnumber : ");
                int num = Int32.Parse(Console.ReadLine());
                number[i] = num;
            }

            for(int i=0;i<5;i++)
            {
                if(number[i]%5==0)
                {
                    Console.WriteLine("Answer is "+number[i]);
                }
            }

        Console.ReadLine();
        }
    }
}
