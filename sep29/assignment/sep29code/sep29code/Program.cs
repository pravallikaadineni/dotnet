using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sep29code;

namespace sep29code
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyContext context = new MyContext();
            context.BorrowerTable.Add(new Borrower { borrowerid = 1, borr_Name= "Amit",city="kadapa",state="ap",country="india" });
            context.SaveChanges();
            context.LoanTable.Add(new Loan { LoanId = 1, LoanType = "house loan",  Amt= 2000,duration=100,rateofintrest=2 });
            context.SaveChanges();
           
            Console.WriteLine("done");
            Console.Read();


        }
    }
}
