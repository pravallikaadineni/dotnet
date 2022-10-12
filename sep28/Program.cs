using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_library;


namespace sep28demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            studentoperations co = new studentoperations();
            BLL_class bal = new BLL_class();
            Console.WriteLine("Add student");
            Console.WriteLine("enter new student id");

            bal.Studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student name");
            bal.name = Console.ReadLine();

            Console.WriteLine("enter course id");
            bal.crsid = Convert.ToInt32( Console.ReadLine());

            co.InsertStudent(bal);
            Console.WriteLine("record Inserted successfully...");
               Console.WriteLine("---------------");

            Console.WriteLine("Update Student");
            Console.WriteLine("enter studentid to update");
            bal.Studid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student name");
            bal.name = Console.ReadLine();
            Console.WriteLine("enter courseid");
            bal.crsid = Convert.ToInt32(Console.ReadLine());
            co.Updatestudent(bal);
            Console.WriteLine("Updated successfully....");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Delete Student");
            Console.WriteLine("enter studentid to delete");
            bal.Studid = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("enter student name");
            // bal.name = Console.ReadLine();
            // Console.WriteLine("enter courseid");
            // bal.crsid = Convert.ToInt32(Console.ReadLine());
            co.Deletestudent(bal);
            Console.WriteLine("Deleted successfully....");
            Console.WriteLine("----------------------------");



        }
    }
}
