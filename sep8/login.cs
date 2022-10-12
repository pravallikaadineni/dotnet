using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep8library
{
    public class login
    {
        public void check()
        {
            Action<string, string> checkcredentials = (u, p) =>
            {
                if (u != "" && u == "bac" && p != "" && p == "abc@123")
                {
                    Console.WriteLine("U are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
            };
            checkcredentials("bac", "abc@123");
            Console.WriteLine("---------------------------");
        }

    }

}

