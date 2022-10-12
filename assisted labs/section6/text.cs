using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    internal class text
    {
        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {
            string ganesh = "happy ganesh chaturthi.";
            Console.WriteLine("Original string=" + ganesh);
            Console.WriteLine("Clone of a string =" + ganesh.Clone());
            Console.WriteLine("Compare two strings =" + ganesh.CompareTo("Mary had a little lamb"));
            Console.WriteLine("Characters in a string =" + ganesh.Contains("z"));
            Console.WriteLine("String ending with =" + ganesh.EndsWith("chaturthi."));
            Console.WriteLine("All lowercase =" + ganesh.ToLower());
            Console.WriteLine("All uppercase =" + ganesh.ToUpper());
            Console.WriteLine("Insert string within a string =" + ganesh.Insert(1, "  wish u"));
            Console.WriteLine("Splitting string into words:");
            //string[] parts = mary.Split()
                string[] parts = ganesh.Split( 'g');

            foreach (var p in parts)
            {
                Console.WriteLine($"Substring: {p}");
            }
            

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());

        }
    }
}

