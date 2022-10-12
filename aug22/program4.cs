using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22
{
    internal class program4
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();


            myList.Add(2);
            myList.Add(4);
            myList.Add(6);
            myList.Add(8);
            myList.Add(10);
            myList.Add(12);



            Console.WriteLine("The initial ArrayList: ");

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count : " + myList.Count);

            myList.RemoveAt(4);


            Console.WriteLine("The ArrayList after Removing elements: ");


            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count after removing elements : " + myList.Count);

            Console.ReadLine();
        }
    }
}
