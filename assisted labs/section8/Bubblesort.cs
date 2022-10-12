using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    internal class Bubblesort
    {

        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "sweety";
            students[1] = "bhargav";
            students[2] = "yesh";
            students[3] = "siva";
            students[4] = "nani";
            students[5] = "kamal";
            students[6] = "koushik";
            students[7] = "chintu";
            students[8] = "rohi";
            students[9] = "lohi";

            bool flag = true;
            string temp;
            int numLength = students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }


            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}

   
