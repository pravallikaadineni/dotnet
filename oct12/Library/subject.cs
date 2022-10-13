using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class subject
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public subject()
        {
            sql = new SqlConnection("Data Source=LAPTOP-SJD7JKLB\\SQLEXPRESS;Initial Catalog=RainbowSchool;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from subject", sql);



            da.Fill(ds, "subject");
            DataTable dt_proddata = ds.Tables["subject"];
            return dt_proddata;
        }
        public string Findsubject(int subid)
        {
            DataTable subject = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = subject.Columns["subid"];
            subject.PrimaryKey = keycolumns;
            DataRow dr = subject.Rows.Find(subid);
            string ans = dr[0].ToString() + " " + dr[1].ToString() ;
            return ans;
        }

    }
}
