using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BAL_library;

namespace sep30mng
{
    public partial class Frmproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtdob.Text = c1.SelectedDate.ToLongDateString();

        }

        protected void txtdob_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnsignup_Click(object sender, EventArgs e)
        {
               products p=new products();
            p.firstname=txtfrst.Text;
            p.lastname=txtlast.Text;
            p.dateofbirth=Convert.ToDateTime( txtdob.Text );
            p.city = txtcity.Text;
            p.state = txtstate.Text;

            HttpCookie cookie = new HttpCookie("proddata");
            cookie.Expires = DateTime.Now.AddMinutes(10);
            cookie.Values.Add("firstname", p.firstname);
            cookie.Values.Add("lastname", p.lastname);
            cookie.Values.Add("city", p.city);
            cookie.Values.Add("state", p.state);
            Response.Cookies.Add(cookie);
            Label1.Text = "Thanks for the input";


        }
    }
}