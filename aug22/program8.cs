using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22
{
    internal class program8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            Console.WriteLine("before deleting from hash table");
            h.Add(1, "tea");
            h.Add(2, "Coffee");
            h.Add(3, "Coke");
            h.Add(4, "Milk");
            h.Add(5, "thumsup");
            IDictionaryEnumerator ie = h.GetEnumerator();
            while (ie.MoveNext())
            {
                Console.WriteLine(ie.Key + "  " + ie.Value);
            }
            Console.WriteLine("after deleting from hash table");
            h.Remove(2);
            IDictionaryEnumerator se = h.GetEnumerator();
            while (se.MoveNext())
            {
                Console.WriteLine(se.Key + "  " + se.Value);
            }
            Console.ReadLine();






            Console.ReadLine();
        }

    }
}

