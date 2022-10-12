using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22
{
    internal class program7
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(45);
            q.Enqueue(60);
            q.Enqueue(33);
            q.Enqueue(86);

            Console.WriteLine("Initially elements are");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            object a2 = q.Dequeue();
            Console.WriteLine(a2);
            Console.WriteLine("After removing element");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("The peak element is" + q.Peek());


            Console.ReadLine();
        }
    }
}
