﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.work();
            Manager m= new Manager();
            m.work();
            Clerk c =new Clerk();
            c.work();
            Savings s = new Savings(); 
           
            s.CalculateInterest();
            s.PrintBalance();

            Current cu = new Current();
            cu.CalculateInterest();
            cu.PrintBalance();

            s.withdraw();
            cu.Currentwithdraw();
            s.deposit();
            cu.currentdeposit();
            Console.ReadLine();
        }
       
    }
    
}
