using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderServices
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public bool IsSenior()
        {
            return Age >= 60;
        }
    }
}
