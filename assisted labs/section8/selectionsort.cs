using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    internal class selectionsort
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
            int n = 10;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].CompareTo(students[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = students[smallest];
                students[smallest] = students[i];
                students[i] = temp;
            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }

}

