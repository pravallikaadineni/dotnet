using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second;

            Console.WriteLine("Enter the first number : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            if (first > second)
            {
                Console.WriteLine("First number is biggest");
            }
            else
            {
                Console.WriteLine("second number is biggest");
            }
            Console.ReadLine();
        }
    }
}
