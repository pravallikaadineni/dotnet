using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static inheritproject.iClassTeacher;
using static inheritproject.iSubjectTeacher;
using System.Xml.Linq;

namespace inheritproject
{
    internal class inheritProgram
    {
       
            static void Main(string[] args)
            {
                runApp();
            }

            public static void runApp()
            {
                iSubjectTeacher algebra = new iSubjectTeacher();
                algebra.Name = "Algebra";

                iSubjectTeacher physics = new iSubjectTeacher();
                physics.Name = "Physics";

                iSubjectTeacher algebraTeacher = new iSubjectTeacher();
                algebraTeacher.Name = "Mr.Algebra";
                algebraTeacher.ContactAddress = "Some Address";
                algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
               // algebraTeacher.WhichSubject = algebra;

                iSubjectTeacher physicsTeacher = new iSubjectTeacher();
                physicsTeacher.Name = "Mr.Physics";
                physicsTeacher.ContactAddress = "Some Address";
                physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
                //physicsTeacher.WhichSubject = physics;

                hclass class8 = new hclass();
                class8.Name = "8";

                iClassTeacher teacherOf8 = new iClassTeacher();
                teacherOf8.Name = "Mrs.Class 8 Teachers";
                teacherOf8.ContactAddress = "Some Address";
                teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
                teacherOf8.WhichClass = class8;
            Console.WriteLine(algebraTeacher.Name);
            Console.WriteLine(algebraTeacher.ContactAddress);
            Console.WriteLine(algebraTeacher.DateOfJoining);
            Console.WriteLine(physicsTeacher.Name);
            Console.WriteLine(physicsTeacher.ContactAddress);
            Console.WriteLine(physicsTeacher.DateOfJoining);
            Console.WriteLine(class8.Name);
            

            //class8.WhichTeacher = TeacherOf8;



        }

    }
    }

