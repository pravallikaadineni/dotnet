using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aug23
{
    internal class program6
    {

        enum Deptnames
        {
            Purchases,
            Sales,
            Training,
            Accounts,
        }

        static void Main(string[] args)
        {
            int myNum = (int)Deptnames.Accounts;
            Console.WriteLine(myNum);
            Console.ReadLine();
        }
    }
    }

