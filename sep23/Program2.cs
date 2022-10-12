using sep23library;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionstring = " Data Source=LAPTOP-SJD7JKLB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True ";
            SqlConnection cn = new SqlConnection(connectionstring);
            // Console.WriteLine("enter the product id to search the product for: ");
           // Class1 b1 = new Class1();
            //b1.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the product name  to search the productname for: ");
            Class1 b2 = new Class1();
            b2.ProductName = (Console.ReadLine());

            //SqlCommand cmd = new SqlCommand("select * from v_Products where ProductId='" + b1.ProductId + "'", cn);
            SqlCommand cmd = new SqlCommand("select * from v_Products where ProductName='" + b2.ProductName + "'", cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["ProductId"]);
                Console.WriteLine(dr["ProductName"]);
                Console.WriteLine(dr["unitprice"]);
                Console.WriteLine("================================");
            }

            Console.ReadLine();
            cn.Close();
        }
    }
}
            