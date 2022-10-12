using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    public class array
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students3A, students3B;

            students3A = new string[5] { "sweety", "nani", "yesh", "siva", "bhargav" };
            students3B = new string[5] { "devi", "likki", "priya",  "Sukhwinder", "Gopi",};
            
            string[] subjects = new string[6];
            subjects[0] = "Physics";
            subjects[1] = "Chemistry";
            subjects[2] = "Biology";
            subjects[3] = "Calculus";
            subjects[4] = "Computer Science";
            subjects[5] = "Algebra";


            

            int[] marks = new int[6];
            marks[0] = 67;
            marks[1] = 90;
            marks[2] = 80;
            marks[3] = 55;
            marks[4] = 71;
            marks[5] = 92;

            Console.WriteLine("Students of wings section:");
            foreach (string s in students3A)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("============================================================");

            Console.WriteLine("Students of racer section:");
            foreach (string s in students3B)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("============================================================");

            Console.WriteLine("Marks of bhargav:");
            int total = 0;
            for (int i = 0; i < 6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i] + " = " + marks[i]);
            }
            Console.WriteLine("TOTAL = " + total + "/600 = " + (total * 100 / 600) + " percent");
        }
    }
}

  

