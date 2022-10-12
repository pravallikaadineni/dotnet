using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    internal class insertionsort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[10];
            students[0] = "avs";
            students[1] = "bhargav";
            students[2] = "yesh";
            students[3] = "siva";
            students[4] = "nani";
            students[5] = "kamal";
            students[6] = "koushik";
            students[7] = "chintu";
            students[8] = "rohi";
            students[9] = "lohi";
            int n = 10, i, j, flag;
            string val;
            for (i = 1; i < n; i++)
            {
                val = students[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val.CompareTo(students[j]) < 0)
                    {
                        students[j + 1] = students[j];
                        j--;
                        students[j + 1] = val;
                    }
                    else flag = 1;
                }


            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }

    }
}
