using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using productlibrary;
using catgorylibrary;



namespace worksep2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            product product1 = new product();
            product1.Productid = 10;
            product1.Productname = "slate";
            product1.Price = 40;
            product1.Qtyinhand = 23;
            product1.Measure = 12;
            product1._Qtysold = 13;
            product1.Reorder = 1;
            Console.WriteLine(product1.Productid);
            Console.WriteLine(product1.Productname);
            Console.WriteLine(product1.Price);
            Console.WriteLine(product1.Qtyinhand);
            Console.WriteLine(product1.Measure);
            Console.WriteLine(product1.Reorder);
            Console.WriteLine(product1._Qtysold);

            product product2 = new product();
            product2.Productid = 1;
            product2.Productname = "pencil";
            product2.Price = 4;
            product2.Qtyinhand = 3;
            product2.Measure = 11;
            product2._Qtysold = 43;
            product2.Reorder = 23;
            Console.WriteLine(product2.Productid);
            Console.WriteLine(product2.Productname);
            Console.WriteLine(product2.Price);
            Console.WriteLine(product2.Qtyinhand);
            Console.WriteLine(product2.Measure);
            Console.WriteLine(product2.Reorder);
            Console.WriteLine(product2._Qtysold);
            Category cate =new Category();
            cate.Catid = 1;
            cate.Catname = "rrr";
            cate.Description = "eeee";
            Console.WriteLine(cate.Catid);
            Console.WriteLine(cate.Catname);
            Console.WriteLine(cate.Description);
          







            //List<productlist> plist = new List<productlist();
            List<product> Catproducts = new List<product>();
            Catproducts.Add(product1);
            Catproducts.Add(product2);


        }






    }
}


    



