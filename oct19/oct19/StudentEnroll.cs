﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oct19
{
    public class StudentEnroll
    {
        public bool EnrollStudent(Student S,Enroll E)
        {
            if (E.fees >0)
            {
               return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
