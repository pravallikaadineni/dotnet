using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritproject
{
    public class iClassTeacher : iTeacher
    {
        public hclass whichClass;

        public hclass WhichClass
        {
            get { return whichClass; }
            set { whichClass = value; }
        }
    }
}




