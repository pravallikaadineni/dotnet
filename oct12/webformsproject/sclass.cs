using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace webformsproject
{
    public class sclass
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public sclass()
        {
            sql = new SqlConnection("Data Source=LAPTOP-SJD7JKLB\\SQLEXPRESS;Initial Catalog=RainbowSchool;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from class", sql);



            da.Fill(ds, "class");
            DataTable dt_proddata = ds.Tables["class"];
            return dt_proddata;
        }

        public string Findclass(int classno)
        {
            DataTable class3 = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = class3.Columns["classno"];
            class3.PrimaryKey = keycolumns;
            DataRow dr = class3.Rows.Find(classno);
            string ans = dr[0].ToString() + " " + dr[1].ToString();
            return ans;
        }
    }
}