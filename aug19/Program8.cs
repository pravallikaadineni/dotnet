using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            for(row=1;row<=5;row++)
            {
                for(col=1;col<=row;col++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
