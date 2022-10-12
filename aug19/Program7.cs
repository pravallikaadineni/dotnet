using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug19_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int subject1, subject2, subject3, tot;
            float percentage;
            string grade;
            Console.Write("enter the first subject marks : ");
            subject1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the second subject marks : ");
            subject2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the third subject marks : ");
            subject3 = Convert.ToInt32(Console.ReadLine());

            tot = subject1 + subject2 + subject3;
            percentage = tot / 3.0f;
            if (percentage > 60)
                grade = "First";
            else
            if (percentage >= 45 && percentage <= 60)
                grade = "second";

            else
                if (percentage < 45 && percentage >= 35)
                grade = "third";
            else
                grade = "Fail";

            Console.Write("Total Marks = {0}\nPercentage = {1}\n Grade = {2}\n", tot, percentage, grade);
            Console.ReadLine();
        }
    }
}
