using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_13_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, a;
            Console.WriteLine("Enter the integer value");
            i = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                Console.WriteLine("given number is zero");
            }
            else

            {
                Console.WriteLine("given num is not 0");
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("Entered Number is an Even Number");

            }
            else
            {
                Console.Write("Entered Number is an Odd Number\n");

            }
            a = i % 10;

            if (a == 0)
            {
                Console.WriteLine("given number is divisible by 10\n");
            }

            if (i > 100)
            {
                Console.WriteLine("Given number is greater than 100\n");
            }
            Console.ReadLine();

        }
    }
}
