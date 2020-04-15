using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practising
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for n number : ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for k number : ");
            int k = Int32.Parse(Console.ReadLine());

            int num = 1;
            int fac=1;
            do
            {
                num = num * n;
                n--;
            } while (n > 0);//Factorial Getting in do while loop

            do
            {
                fac = fac * k;
                n--;
            } while (n > 0);
            Console.WriteLine(num/fac);

            Console.ReadLine();
        }
    }
}