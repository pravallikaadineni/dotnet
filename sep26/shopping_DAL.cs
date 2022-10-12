using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using BAL;

namespace DAL
{
    public class shopping_DAL
    {
        public bool InsertBook(shopping_BAL book)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoppingCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into book(book_No,book_Name,author,cost,category) values(@bookno,@bookname,@author,@cost,@category)", cn);
            cmdInsert.Parameters.AddWithValue("@bookno", book.Book_No);
            cmdInsert.Parameters.AddWithValue("@bookname", book.Book_Name);
            cmdInsert.Parameters.AddWithValue("@author", book.Author);
            cmdInsert.Parameters.AddWithValue("@cost", book.Cost);
            cmdInsert.Parameters.AddWithValue("@category",book.Category);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;


        }


    }
}
