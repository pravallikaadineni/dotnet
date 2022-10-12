using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productlibrary;







namespace catgorylibrary
{

    public class Category
    {
        //public class category
        //{

            private int _catid;

            public int Catid
            {
                get { return _catid; }
                set { _catid = value; }
            }
            private string _catname;


            public string Catname
            {
                get { return _catname; }
                set { _catname = value; }
            }
            private string _description;

            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }
            /*private List<productlist> _plist;

            public List<Productlist> Plist
            {
                get { return _plist; }
                set { _plist = value; }
            }*/
            private List<product> _plist;

            public List<product> Plist
            {
                get { return _plist; }
                set { _plist = value; }
            }







        }
    }
//}


    
