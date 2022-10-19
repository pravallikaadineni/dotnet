using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CustomerOrderServices
{

    public class CustomerOrder
    {
        public void ApplyDiscount(Customer cust, Order order)
        {
            if (cust.CustomerType == CustomerType.Premium)
            {
                order.Amount = order.Amount - ((order.Amount * 10) / 100);
            }
            else if (cust.CustomerType == CustomerType.Gold)
            {
                order.Amount = order.Amount - ((order.Amount * 5) / 100);
            }
        }
        public void GetCustomers(Customer c1)
        {
            SqlConnection sql = new SqlConnection("Data Source=LAPTOP-SJD7JKLB\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Customers", sql);
            sql.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<Customer> custList = new List<Customer>();
            // Customer c = new Customer();
            while (dr.Read())
            {
                Customer cust = new Customer();
                cust.CustName = dr["ContactName"].ToString();
                cust.CustID = dr[0].ToString();

                // cust.CustID = dr[0].ToString();
                custList.Add(cust);

            }
            sql.Close();
            c1.Customers = custList;
        }
    }
}