using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_library;

namespace sep30mng
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie;
            cookie = Request.Cookies.Get("proddata");
            products p1 = new products();
            p1.firstname = cookie["firstname"].ToString();
            p1.lastname = cookie["lastname"].ToString();
            p1.city = cookie["city"].ToString();
            p1.state = cookie["state"].ToString();

            ListBox1.Items.Add(p1.firstname + " " + p1.lastname + " " + p1.city + " " + p1.state + " ");

        }
    }
}