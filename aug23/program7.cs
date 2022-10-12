using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23
{
    internal class program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number :");
            int j = Convert.ToInt32(Console.ReadLine());

            div(i, j);
            Console.ReadLine();

        }
        static void div(int i, int j)
        {
            int k = 0;
            try
            {
                k = i / j;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Entered a Non Zero Number");
                Console.WriteLine(ex.StackTrace + "\n");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Result : {0}", k);
            }


        }
    }
}
    