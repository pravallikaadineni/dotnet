using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceproject
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {

                Teacher teacher = new Teacher();
                teacher.Name = "mr.ramana";
                teacher.Address = "kadapa";
                teacher.DateOfJoining = DateTime.Today;


                Student student = new Student();
                student.Name = "pravallika";
                student.Address = "bombay";
                student.DateOfJoining = DateTime.Today;
            
            OfficeStaff staff = new OfficeStaff();
                staff.Name = "saleem";
                staff.Address = "london";
                staff.DateOfJoining = DateTime.Today;

            Console.WriteLine("=====================================================================");

            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine("=====================================================================");
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine("=====================================================================");
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
            Console.WriteLine("=====================================================================");
        }
        }
    }

