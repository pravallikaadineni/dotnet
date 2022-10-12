using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
using HelperLibrary;
namespace Sep26
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Library Management System");
            Console.WriteLine("--------------------------------");
            shopping_helper helper = new shopping_helper();
            shopping_BAL s = new shopping_BAL();

            Console.WriteLine("Enter booknumber");
            s.Book_No =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter bookname");
            s.Book_Name = Console.ReadLine();
            Console.WriteLine("Enter author");
            s.Author = Console.ReadLine().Trim();
            Console.WriteLine("Enter cost");
            s.Cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter category");
            s.Category = Console.ReadLine();
            //helper.AddBook(s);
            bool queryStatus = helper.AddBook(s);
            if (queryStatus)
            {
                Console.WriteLine("Employee added successfully.....");
            }
            else
            {
                Console.WriteLine("Some error occured...");
            }
        }
    }
}
