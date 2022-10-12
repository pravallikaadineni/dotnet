using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug18_10_
{
    internal class project16
    {
        static void Main(string[] args)
        {
            string username, password;
            Console.WriteLine("Enter your First Name");
            String FirstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            String LastName = Console.ReadLine();
            Console.WriteLine("enter username");
            username = Console.ReadLine();
            Console.WriteLine("enter your password");
            password = Console.ReadLine();


            if (username == (FirstName) && password == (LastName))
            {
                Console.WriteLine("you have logged in successfully");
                Console.WriteLine("Welcome to my app");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your credentials is wrong");
            }
            Console.ReadLine();

        }
    }
}
