using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pgrm1lib;

namespace aug26pgrm1
{
    public class program
    {
        static void Main(string[] args)
        {
           
                Student[] S = { new Student(), new Student() };

                S[0].SetStudent(401, "pravalli", 10000);
                S[1].SetStudent(444, "yesh", 8000);

                S[0].PrintStudent();
                S[1].PrintStudent();
                Console.ReadLine();
            }
        }
    }
    

