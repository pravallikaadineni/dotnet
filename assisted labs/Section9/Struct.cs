using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsproject
{
    internal class Struct
    {
        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {

            Student1[] students = new Student1[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].name = "Sweety " + i.ToString();
                students[i].address = "kadapa ";
                students[i].rollNumber = 401;
                students[i].className = "ECE";
                students[i].dateOfBirth = Convert.ToDateTime("2001-05-10 11:00:00");
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i].name + ",");
                Console.WriteLine(students[i].address + ",");
                Console.WriteLine(students[i].rollNumber + ",");
                Console.WriteLine(students[i].className + ",");
                Console.WriteLine(students[i].dateOfBirth);
                Console.WriteLine("========================================================");

            }
        }
    }

    struct Student1
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;
    }
}
