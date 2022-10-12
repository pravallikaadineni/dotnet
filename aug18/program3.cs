using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arthematic_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Console.WriteLine("Enter the first value");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second value");
            j = Convert.ToInt32(Console.ReadLine());

            int Add = i + j;
            Console.WriteLine("Add=" + Add);

            int Sub = i - j;
            Console.WriteLine("Sub=" + Sub);
            int Mul = i * j;
            Console.WriteLine("Mul=" + Sub);
            int Div = i / j;
            Console.WriteLine("Div=" + Div);
            Console.ReadLine();


        }
    }
}
