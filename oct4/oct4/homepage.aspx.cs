﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oct4
{
    public partial class homepage : System.Web.UI.Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Error(object sender, EventArgs e)
       {
           Exception ex = Server.GetLastError();
           Response.Redirect("~/errorpage.aspx");

       }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoppingCnString"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sweety", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "sweety");



        }
    }
}