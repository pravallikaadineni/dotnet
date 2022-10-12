using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug18_10_
{
    internal class project15
    {
        static void Main(string[] args)
        {
            double usd = 0;
            double inr = 0;
            double value = 0;

            Console.Write("Enter amount in USD: ");
            usd = double.Parse(Console.ReadLine());

            Console.Write("Enter the USD value :");
            value = double.Parse(Console.ReadLine());

            inr = usd * value;
            Console.WriteLine("USD " + usd + "-> INR " + inr);
            Console.ReadLine();

        }
    }
}
