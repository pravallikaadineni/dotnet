using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sep29library;

namespace sep29codefirstdemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            MyContext context = new MyContext();
            context.memberTable.Add(new member{ memberId = 1, memberName = "Amit" });
            context.SaveChanges();
            context.BookTable.Add(new book { bookID = 1, bookName = "billgates",cost=150 });
            context.SaveChanges();
            context.IssuesTable.Add(new Issues { issueID = 1, bookID = 1, memberId = 1 });
            context.SaveChanges();
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
