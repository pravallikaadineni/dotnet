using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assitedprojects
{
    public class sllNode
    {
       
            private string data;
            private sllNode next = null;
            public string Data
            {
                get { return this.data; }
                set { this.data = value; }
            }

            public sllNode Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }
    }



