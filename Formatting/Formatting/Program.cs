using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong maxValue = UInt64.MaxValue;
            Console.WriteLine(maxValue);

            float f = 0.1f;
            Console.WriteLine(f);

            double d= 0.1f;
            Console.WriteLine(d);

            float ff = 1.0f / 3;
            Console.WriteLine(ff);

            double dd = ff;
            Console.WriteLine(dd);

            double nan = Double.NaN;
            Console.WriteLine(nan);

            double infinity = Double.PositiveInfinity;
            Console.WriteLine(infinity);

            char ch = 'A';
            Console.WriteLine("The ASCI code of A is {0}", (int)ch);

            int i = 5;
            int? ni = i;//Nullable Value

            ni = null;
            i = ni.GetValueOrDefault();
            Console.WriteLine(i);

            decimal decimalPI = 3.141592653589793238m;
            Console.WriteLine(decimalPI);

            double myDouble = 5e9d;
            Console.WriteLine(myDouble);

            float heightInMeters = 1.74f;
            double maxHeight = heightInMeters;
            Console.WriteLine(maxHeight);
            double minHeight = (double)heightInMeters;
            Console.WriteLine(minHeight);

            int num = 1;
            double denum = 0;
            int zeroInt = (int)denum;
            Console.WriteLine(num / denum);
            Console.WriteLine(denum / denum);
            try
            {
                Console.WriteLine(zeroInt / zeroInt);
            }catch(Exception er)
            {
                Console.WriteLine(er.Message);
            }

            double incorrect = (double)((1 + 2) / 4);//Incorrect
            Console.WriteLine(incorrect);

            double correct = ((double)(1 + 2) / 4);
            Console.WriteLine(correct);
        }
    }
}
