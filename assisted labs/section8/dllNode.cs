using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assitedprojects
{
    public class dllNode
    {
        private string data;
        private dllNode next = null;
        private dllNode prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public dllNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public dllNode Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }

    }
}
