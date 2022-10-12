using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class shopping_BAL
    {
		private int _bookno ;

		public int Book_No
		{
			get { return  _bookno ; }
			set { _bookno = value; }
		}

        private string _bookname;

        public string Book_Name
        {
            get { return _bookname; }
            set { _bookname = value; }
        }


		private string  _author;

		public string   Author
		{
			get { return _author; }
			set { _author = value; }
		}
		private double _cost;

		public  double Cost
		{
			get { return _cost; }
			set { _cost = value; }
		}
		private string _category;

		public string Category
		{
			get { return _category; }
			set { _category = value; }
		}



	}
}
