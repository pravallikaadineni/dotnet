using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a Number:");
            n = Int32.Parse(Console.ReadLine());

            switch (n > 100)
            {
                case true:
                    Console.WriteLine("large Number");
                    break;
                case false:
                    switch (n == 0)
                    {
                        case true:
                            Console.WriteLine("Zero");
                            break;
                        case false:
                            if (n % 2 == 0)
                            {
                                Console.WriteLine("Even Number");
                            }
                            else
                            {
                                Console.WriteLine("Odd Number");
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
