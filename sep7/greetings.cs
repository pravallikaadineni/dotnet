using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{
    public delegate void SecondDelegate();
    public class greetings
    {
        public void greet()
        {
            string str = "anitha";

            Console.WriteLine("hello" + str);
            //Console.WriteLine("String Length: " + str.Length);

            Console.ReadKey();


        }
    }
}
