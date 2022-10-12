using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sep5library;

namespace Sep5
{
    public class Program
    {
        static void Main(string[] args)
        {



             Book b1 = new Book(1, "indianpolity by lakshmikanth", 1200, "lakshmikanth");
             Book b2 = new Book();

             b2.InsertBook("indian arts and science", 2, 1000);

             Book b3 = new Book();
             b3.InsertBook("bipin chandra history", 3, 1500);
             
             Book b4 = new Book();
             b4.InsertBook("nithin singhania economy", 4, 1345);
            Cart c1 = new Cart();
             c1.AddToCart(b1);
             c1.AddToCart(b2);
             c1.AddToCart(b3);
             c1.AddToCart(b4);
             c1.Display();
           
        }
    }
}

