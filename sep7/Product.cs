using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep7library
{
    public delegate void displayProducts(Product p);
    public class Product
    {
        public int Productid { get; set; }
        public string Productname { get; set; }

        public static void Print(Product p)
        {
            Console.WriteLine("Product Id : " + p.Productid);
            Console.WriteLine("Product Name : " + p.Productname);
        }
    }
   

    
}
