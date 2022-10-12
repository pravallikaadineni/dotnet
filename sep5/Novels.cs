using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep5library
{
    
    public class Novels : Book
    {
        private int _nop;

        public int numberOfPages
        {
            get { return _nop; }
            set { _nop = value; }
        }

        public void InsertBook(int bookid, string bname, int price, int pageNo)
        {

            this.BookName = bname;
            this.BookID = bookid;
            this.BookPrice = price;

            this.numberOfPages = pageNo;
        }
        public void InsertBook(int bookid, string bname, int price)
        {

            this.BookID = bookid;
            this.BookName = bname;
            this.BookPrice = price;

        }
    }
}

