using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticearrays
{
    internal class linkedlistdemo
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("hello");
            mylist.AddLast("world");
            mylist.AddAfter(mylist.First, "welcome");
            mylist.AddBefore(mylist.Last, "electronic");
            mylist.AddBefore(mylist.Last.Previous, "electronics");
            mylist.AddAfter(mylist.First.Next, "to");
            LinkedListNode<string> foundnode = mylist.Find("electronics");
            foundnode.Value = "my";


            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
    }

