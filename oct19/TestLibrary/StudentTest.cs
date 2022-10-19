using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using oct19;

namespace TestLibrary
{
    [TestFixture]


    public class StudentTest
    {

       // [TestCase(0, ExpectedResult = false)]
        [TestCase(76, ExpectedResult = true)]
        public bool GetFees(int fees)
        {
            Student s = new Student();
            s.rollno = 1;
            s.name = "sweety";
            s.coursename = CoursrName.JAVA;
            Enroll e = new Enroll();
            e.enrollno = 10;
            e.fees = 500;
            StudentEnroll se = new StudentEnroll();

            bool ans = se.EnrollStudent(s, e);

            return ans;
        }

    }
   
    }


