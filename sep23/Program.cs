using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLibrary;



namespace sql
{
    public class Program
    {
        static void Main(string[] args)
    {

        string connectionstring = " Data Source=LAPTOP-SJD7JKLB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True ";
        SqlConnection cn = new SqlConnection(connectionstring);
       // Console.WriteLine("enter the product id to search the product for: ");
        //Class1 b1 = new Class1();
        //b1.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the product id to search the productname for: ");
            Class1 b2 = new Class1();
            b2.ProductName = (Console.ReadLine());

            //SqlCommand cmd = new SqlCommand("select * from Products where ProductId='" + b1.ProductId + "'", cn);
            SqlCommand cmd = new SqlCommand("select * from Products where ProductName='" + b2.ProductName + "'", cn);
            cn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            //Console.WriteLine(dr["ProductId"]);
            Console.WriteLine(dr["ProductName"]);
            Console.WriteLine(dr["SupplierID"]);
            Console.WriteLine(dr["CategoryID"]);
            Console.WriteLine(dr["QuantityPerUnit"]);
            Console.WriteLine(dr["UnitPrice"]);
            Console.WriteLine(dr["UnitsInStock"]);
            Console.WriteLine(dr["UnitsOnOrder"]);
            Console.WriteLine(dr["ReorderLevel"]);
            Console.WriteLine(dr["Discontinued"]);
            Console.WriteLine("================================");
        }

        Console.ReadLine();
        cn.Close();
    }
}
}
