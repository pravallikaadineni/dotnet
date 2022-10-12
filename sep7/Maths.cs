using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{
    public delegate int thirdDelegate(int n1, int n2);
    public class Maths
    {
        public int Add(int a, int b)
        {
            Console.WriteLine($"Addition : {a + b}");
            return a + b;
        }
        public int Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction : {a - b}");
            return a - b;
        }
        public int Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication : {a * b}");
            return a * b;
        }

    }
}
