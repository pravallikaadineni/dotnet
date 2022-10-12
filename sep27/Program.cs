using disconnected_helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using disconnected_BLL;

namespace Sep27demo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Institute Management System");
            Console.WriteLine("--------------------------------");
            helper_class helper = new helper_class();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine(" 1. Add New Student \n 2. Update Student \n 3. Find Student \n 4. Show All \n 5. Delete \n ");
            Console.WriteLine("--------------------------------");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            BLL_class s = new BLL_class();

            switch (userchoice)
            {
                case 1:

                    Console.WriteLine("Enter student id");
                    s.Studid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter studentname");
                    s.name = Console.ReadLine();
                    Console.WriteLine("Enter course id");
                    s.crsid = Convert.ToInt32(Console.ReadLine());


                    bool queryStatus = helper.AddNewStudent(s);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;

                case 2:
                  Console.WriteLine("enter original student id");
               int studid = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("enter new student id");
               s.Studid = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Enter name");
               s.name = Console.ReadLine().Trim();
               Console.WriteLine("Enter courseid");
               s.crsid = Convert.ToInt32(Console.ReadLine());




               queryStatus = helper.EditstudentData(studid, s);
               if (queryStatus)
               {
                   Console.WriteLine("Student updated successfully.....");
               }
               else
               {
                   Console.WriteLine("Some error occured...");
               }

               break;
                case 3:
                     Console.WriteLine("enter  emp id");
                    s.Studid = Convert.ToInt32(Console.ReadLine());
                    BLL_class data = helper.LocateStudent(s.Studid);
                    if (data != null)
                    {
                        Console.WriteLine("Following are the details");
                        Console.WriteLine(data.Studid);
                        Console.WriteLine(data.name);
                        Console.WriteLine(data.crsid);

                    }
                    else
                    {
                        Console.WriteLine("Invalid employee id");
                    }
                    break;
                case 4:


                     List<BLL_class> slist = new List<BLL_class>();
                     slist = helper.studentList();
                     Console.WriteLine( "studid" + "        " + "name" + "          " + "crsid");
                     foreach (var item in slist)
                     {
                         Console.WriteLine(item.Studid + "       " + item.name + "           " + item.crsid);
                         
                         Console.WriteLine();
                     }

                     break;
                case 5:
                         Console.WriteLine("enter  student id");
                         s.Studid = Convert.ToInt32(Console.ReadLine());
                         queryStatus = helper.RemoveStudentData(s.Studid);
                         if (queryStatus)
                         {
                             Console.WriteLine("Employee Deleted successfully.....");
                         }
                         else
                         {
                             Console.WriteLine("Some error occured...");
                         }


                         break;
                     default:
                         break;
                 }
                    Console.ReadKey();


            }
        }
    }


