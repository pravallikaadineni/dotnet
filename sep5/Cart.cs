using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sep5library
{


    public class Cart : Book
    {
        static int BookCount = 0;
        private int _customerid;

        public int CustomerID
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        private int _bookingid;

        public int BookingID
        {
            get { return _bookingid; }
            set { _bookingid = value; }
        }
        List<Book> myCart = new List<Book>();

        public void AddToCart(Book b)
        {
            BookCount++;
            myCart.Add(b);
        }
        public void Display()
        {
            foreach (var item in myCart)
            {
                Console.WriteLine($"Book Id : {item.BookID}\nBook Name : {item.BookName}\nPrice : {item.BookPrice}\n");
            }
            Console.WriteLine("Number of Books in the Cart : " + BookCount);
            Console.WriteLine("==================================================");
        }
    }
}





