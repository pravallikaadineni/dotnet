using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug18_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5, j = 6;
            CallByValueExp(i, j);
            Console.WriteLine("But the actual value of i=" + i);
            Console.WriteLine("But the actual value of j=" + j);
            Console.WriteLine("------------------------");
            CallByReferenceExp(ref i, ref j);
            Console.WriteLine("But the actual value of i=" + i);
            Console.WriteLine("But the actual value of j=" + j);
            Console.Read();
        }
        static void CallByValueExp(int i, int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine(" swapped Value of i=" + i);
            Console.WriteLine("swapped Value of i=" + j);



        }
        static void CallByReferenceExp(ref int i, ref int j)
        {
            int k = i;
            i = j;
            j = k;
            Console.WriteLine(" swapped Value of i=" + i);
            Console.WriteLine(" swapped Value of i=" + j);


        }
    }
}
