using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep14library
{


    [Serializable()]
    public class Customeruser
    {
        public long username{ get; set; }
        public long mobileno { get; set; }
        [NonSerialized()]
        private long _pswd;

        public long Password
        {
            get { return _pswd; }
            set { _pswd = value; }
        }
        private bool _login;

        public bool loginstatus
        {
            get { return _login; }
            set { _login = value; }
        }
        public void validateuser()
        {
            if (username == 6302585865 && Password == 123456789)
            {
                loginstatus = true;
                Console.WriteLine("user logged successfully");
            }
            else
            {
                loginstatus = false;
                Console.WriteLine("invalid login details");
            }

        }


 
    }
}

