using disconnected_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using disconnected_BLL;

namespace disconnected_helper
{
    public class helper_class
    {
        DAL_class dal = new DAL_class();

        public bool AddNewStudent(BLL_class student)
        {
            return dal.InsertStudent(student);
        }


        public bool RemoveStudentData(int studid)
        {
            return dal.DeleteStudent(studid);
        }
        public bool EditstudentData(int studid, BLL_class student)
        {
            return dal.Updatestudent(studid, student);
        }

        public BLL_class LocateStudent(int stdid)
        {
            return dal.FindStudent(stdid);
        }
        public List<BLL_class> studentList()
        {
            return dal.ShowAllstudents();
        }

    }
}
//Data Source=LAPTOP-SJD7JKLB\SQLEXPRESS;Initial Catalog=InstituteManagementSystem;Integrated Security=True 

