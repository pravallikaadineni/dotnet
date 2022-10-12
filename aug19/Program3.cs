using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1;
            char ch2;
            Console.Write("Enter a character: ");
            ch1 = Console.ReadLine()[0];
            Console.Write("Enter another character: ");
            ch2 = Console.ReadLine()[0];
            if (ch1 == ch2)
                Console.WriteLine("characters are the same");
            else
                Console.WriteLine(" characters are not the same");
            Console.ReadLine();
        }
    }
}
