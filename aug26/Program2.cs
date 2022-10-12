using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary2.Class1;

namespace aug26program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[2];

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
                Console.WriteLine("Enter rollno");
                s[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter stdname");
                s[i].StdName = Console.ReadLine();
                Console.WriteLine("Enter Deptno");
                s[i].DeptNo = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("----------------------");

            foreach (var item in s)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine( "rollno :"+item.RollNo);
                Console.WriteLine("student name"+item.StdName);
                Console.WriteLine("department number"+item.DeptNo);

            }
            Console.Read();

        }
    }
    }

