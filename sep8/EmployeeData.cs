﻿using Sep8library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep8
{



    public delegate void HandleInsertUpdateCustomer(employee c);

    class EmployeeData : EventArgs
    {
        public static event HandleInsertUpdateCustomer InsertEvent;
        public static event HandleInsertUpdateCustomer UpdateEvent;
        public static event HandleInsertUpdateCustomer DeleteEvent;
        public static event HandleInsertUpdateCustomer DisplayEvent;

        //Event takes a parameter Customer object
        public static List<employee> list = new List<employee>();

        static void Main(string[] args)
        {
            InsertEvent += CustomerOperations_InsertEvent;
            UpdateEvent += CustomerOperations_UpdateEvent;
            DeleteEvent += CustomerOperations_DeleteEvent;
            DisplayEvent += CustomerOperations_DisplayEvent;
            login login = new login();

            login.check();


            Console.WriteLine("Menu 1 for Insert, 2 for Update, 3 For Delete ,4 for Display");
            int ch = Convert.ToInt32(Console.ReadLine());
            employee c = new employee();
            employee c2 = new employee();
            c2.EmpId = 2;
            c2.Sal = 75000;
            c2.DeptNo = 402;
            c2.EmpName = "rohi";

            list.Add(c2);


            switch (ch)
            {
                case 1:

                    
                    c.EmpId = 1;
                    c.EmpName = "david";
                    c.DeptNo = 403;
                    c.Sal = 90000;
                    c.Mgr = "rina";



                    InsertEvent(c);
                    break;
                case 2:

                    Console.WriteLine("Enter empid");
                    c.EmpId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter empname");
                    c.EmpName = Console.ReadLine();
                    Console.WriteLine("Enter phone no");
                    c.DeptNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter salary");
                    c.Sal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Manager name");
                    c.Mgr = Console.ReadLine();
                    UpdateEvent(c);
                    break;
                case 3:
                    c.EmpId = 1;
                    DeleteEvent(c);
                    break;
                case 4:

                    DisplayEvent(c);
                    break;

                default:
                    Environment.Exit(1);
                    break;
            }


            Console.Read();
        }

        private void InsertMethod(employee c)
        {
            list.Add(c);
            Console.WriteLine("Addedsuccessfully");
            foreach (var item in list)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.Sal);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.Mgr);
            }
        }
        private void UpdateMethod(employee c)
        {
            employee found = list.Find(x => x.EmpId == c.EmpId);
            found.EmpName = c.EmpName;
            found.Sal = c.Sal;
            found.DeptNo = c.DeptNo;
            found.Mgr = c.Mgr;







            Console.WriteLine("Updated successfully");
        }
        private void DeleteMethod(employee c)
        {
            list.Remove(c);
            Console.WriteLine("Deleted successfully");
            foreach (var item in list)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.Sal);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.Mgr);
            }
        }
        private void DisplayMethod(employee c)
        {

            Console.WriteLine("Displaying the employees");
            foreach (var item in list)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmpName);
                Console.WriteLine(item.Sal);
                Console.WriteLine(item.DeptNo);
                Console.WriteLine(item.Mgr);
                Console.ReadLine();
            }
        }




        private static void CustomerOperations_UpdateEvent(employee c)
        {
            //throw new NotImplementedException();
            EmployeeData operations = new EmployeeData();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.UpdateMethod);
            del.Invoke(c);


        }

        private static void CustomerOperations_InsertEvent(employee c)
        {
            EmployeeData operations = new EmployeeData();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.InsertMethod);
            del.Invoke(c);

        }
        private static void CustomerOperations_DeleteEvent(employee c)
        {
            EmployeeData operations = new EmployeeData();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.DeleteMethod);
            del.Invoke(c);

        }
        private static void CustomerOperations_DisplayEvent(employee c)
        {
            EmployeeData operations = new EmployeeData();
            HandleInsertUpdateCustomer del = new HandleInsertUpdateCustomer(operations.DisplayMethod);
            del.Invoke(c);

        }
    }
}