using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Sep7library;
using static Sep7library.Stringlength;

namespace Sep7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stringlength c = new Stringlength();
            LengthDelegate l = new LengthDelegate(c.length);
            l.Invoke();
            Console.WriteLine("========================================================================");
            greetings class2 = new greetings();
            SecondDelegate s = new SecondDelegate(class2.greet);
            s();
            Console.WriteLine("=========================================================================");
            Maths m = new Maths();
            thirdDelegate[] t = new thirdDelegate[3] { m.Add, m.Sub, m.Mul };
            thirdDelegate k = (thirdDelegate)MulticastDelegate.Combine(t);
            k(40, 50);
            Console.WriteLine("========================================================================");
            Product p1 = new Product() { Productid = 1, Productname = "bench" };
            Product p2 = new Product() { Productid = 2, Productname = "Chair" };
            Product p3 = new Product() { Productid = 3, Productname = "board" };
            Product p4 = new Product() { Productid = 4, Productname = "marker" };
            displayProducts p = new displayProducts(Product.Print);
            p(p1);
            p(p2);
            p(p3);
            p(p4);
            Console.WriteLine("========================================================================");
            Employee e1 = new Employee() { joiningYear = 2000 };
            Employee e2 = new Employee() { joiningYear = 2010 };

            Employee e3 = new Employee() { joiningYear = 2008 };


            join j = delegate (Employee e) { return DateTime.Now.Year - e.joiningYear; };
            int emp1 = j(e1);
            Console.WriteLine("years of service : " + emp1);
            int emp2 = j(e2);
            Console.WriteLine("years of service : " + emp2);
            int emp3 = j(e3);
            Console.WriteLine("years of service : " + emp3);
            Console.WriteLine("===========================================================================");
            Concat y = delegate (string s1, string s2) { return s1 + s2; };
            Console.WriteLine(y("hello to the", "electronic world"));
        }
    }
}

