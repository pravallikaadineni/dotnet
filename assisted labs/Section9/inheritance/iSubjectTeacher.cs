using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritproject
{
    public class iSubjectTeacher : iTeacher
    {
        private String whichSubject;

        public string WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }

    }
}








