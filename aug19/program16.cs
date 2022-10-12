using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19projects
{
    internal class program16
    {
        static void Main(string[] args)
        {
            int point = 100;
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("HIT or MISS");
                s = Console.ReadLine();
                if (s == "HIT" || s == "hit")
                {
                    point += 10;
                }
                else
                {
                    point -= 20;
                }
            }
            Console.WriteLine("Point = {0}", point);
        }
    }
    
}
