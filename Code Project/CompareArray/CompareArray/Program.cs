using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool equal1 = true;
            Console.WriteLine("Enter number of values for Array 1 :");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arr1 = new int[n];

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter your value : ");
                int num = Int32.Parse(Console.ReadLine());

                arr1[i] = num;
            }

            Console.WriteLine();

            Console.WriteLine("Enter number of values for Array 2 :");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arr2 = new int[n1];

            for(int j=0;j<n1;j++)
            {
                Console.WriteLine("Enter your value : ");
                int num2 = Int32.Parse(Console.ReadLine());

                arr2[j] = num2;
            }


            if (n == n1)
            {
                for (int k = 0; k < n; k++)
                {
                    if (arr1[k] != arr2[k])
                    {
                        equal1 = false;
                    }

                }
            }else
            {
                equal1 = true;
            }

            Console.WriteLine();

            if(n==n1 && equal1==false)
            {
                Console.WriteLine("Arrays are not equal!..");
            }
            else
            {
                Console.WriteLine("Arrays are equal!..");
            }
            Console.ReadLine();
            
        }
    }
}
