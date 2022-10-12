using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22
{
    internal class program9
    {
        static void Main(string[] args)
        {
            List<float> mylist = new List<float>();
            mylist.Add(2.4f);
            mylist.Add(3.4f);
            mylist.Add(4.4f);
            mylist.Add(5.4f);
            mylist.Add(6.5f);
            Console.WriteLine("The list elements are");
            foreach (float f in mylist)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
    }

