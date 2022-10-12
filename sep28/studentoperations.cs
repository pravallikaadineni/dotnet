using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_library;

namespace BLL_library
{
    public class studentoperations
    {
        public void InsertStudent(BLL_class bal)
        {
            InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
            student c = new student();
            c.studid = bal.Studid;
            c.name = bal.name;
            c.crsid = bal.crsid;
            context.students.Add(c);
            context.SaveChanges();
        }
        public void Updatestudent(BLL_class bal)
        {
            InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
            List<student> students = context.students.ToList();
            student obj = students.Find(student => student.studid == bal.Studid);
            obj.name = bal.name;
            obj.crsid = bal.crsid;
            context.SaveChanges();
        }


            public void Deletestudent(BLL_class bal)
            {
                InstituteManagementSystemEntities context = new InstituteManagementSystemEntities();
                List<student> students = context.students.ToList();
                student obj = students.Find(student => student.studid == bal.Studid);
                context.students.Remove(obj);
                context.SaveChanges();

            }

        }

    }



