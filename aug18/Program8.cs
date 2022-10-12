using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;

            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0} {0}", a);
            Console.WriteLine("{0}{0}{0}", a);
            Console.ReadLine();
        }
    }
}
