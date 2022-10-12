using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug30
{
    internal class search
    {
        static void Main(string[] args)
        {


            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Find element to search..");
            int e = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == e)
                {
                    Console.WriteLine("Found it at index = " + i);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }


            Console.ReadLine();


        }
    }
}

       
    

