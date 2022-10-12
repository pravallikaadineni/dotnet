using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug22
{
    internal class program6
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            Console.WriteLine("before pop");
            st.Push(1);
            st.Push(2);
            st.Push(3);
             foreach (int j in st)
            {
                Console.WriteLine(j);
            }
             Console.WriteLine("after pop");
            st.Pop();
            foreach (int j in st)
            {
                Console.WriteLine(j);
            }
            int cnt = st.Count;
            bool ans = st.Contains(1);
            Console.WriteLine("Is 1 available on the stack= " + ans);
            /*object[] obj = st.ToArray();
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }*/
            Console.WriteLine(st.Count);

            
            Console.WriteLine("Element at the top of the stack  is : " + st.Peek());
           

            Console.ReadKey();
        }
    }
}
