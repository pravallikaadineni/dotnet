using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{ 
   
    public delegate void LengthDelegate();

   
    public class Stringlength
    {
        public void length()
        {
            string str = "pravallika";

            Console.WriteLine("String: " + str);
            Console.WriteLine("String Length: " + str.Length);
              


        Console.ReadKey();
        }
        public delegate string Concat(string s1, string s2);
    }
}



