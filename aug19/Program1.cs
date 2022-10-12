using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int min;
            int max;
            Console.Write("Enter first number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());


            if (x > y)
                max = x;
            else
                max = y;

            if (x < y)
                min = x;
            else
                min = y;
            Console.WriteLine("Minimum number = {0}", min);
            Console.WriteLine("Maximum number = {0}", max);
            Console.ReadLine();
        }
    }
}
