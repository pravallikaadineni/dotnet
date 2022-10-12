using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep5library
{
    public class BookCategory
    {
        public BookCategory()
        {

        }

        public BookCategory(int Catid , string CatName , string Des)
        {
            _catid = Catid;
           
            _catname = CatName;
            _des = Des;
        }

        private int _catid;

        public int CatID
        {
            get { return _catid; }
            set { _catid = value; }
        }
        private string _catname;

        public string CatName
        {
            get { return _catname; }
            set { _catname = value; }
        }

        private string _des;

        public string Des
        {
            get { return _des; }
            set { _des = value; }
        }

    }
}
