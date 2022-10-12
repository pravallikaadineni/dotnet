using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sep5library
{
    public class Book
    {
        public Book()
        {

        }

        public Book(int Bookid ,string BookName ,int BookPrice ,string Author)
        {
            _bookid = Bookid;
            _bname = BookName;
            _price = BookPrice;
            _author = Author;
        }

        private int _bookid;

        public int BookID
        {
            get { return _bookid; }
            set { _bookid = value; }
        }
        private string _bname;

        public string BookName
        {
            get { return _bname; }
            set { _bname = value; }
        }

        private int _price;

        public int BookPrice
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
        private int _pages;

        public int Pages
        {
            get { return _pages; }
            set { _pages = value; }
        }


        public void InsertBook(string bname, int bookid, int price)
        {
            this.BookName = bname;
            this.BookID = bookid;
            this.BookPrice = price;
        }
        public void InsertBook(string bname, int bookid, int price ,string author)
        {
            this.BookName = bname;
            this.BookID = bookid;
            this.BookPrice = price;
            this.Author = author;
        }
        public void InsertBook(string bname, int bookid)
        {
            this.BookName = bname;
            this.BookID = bookid;
           
        }
        public virtual void InsertBook(string bname, int bookid, int price, int pages)
        {
            this.BookName = bname;
            this.BookID = bookid;
            this.BookPrice = price;
            this.Pages = pages;

        }
        

        

    }
}
