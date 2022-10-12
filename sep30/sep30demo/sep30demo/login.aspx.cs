using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sep30demo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("welcome to login page");
            }
            else
            {
                if(txt1.Text=="sweety" && txt2.Text=="abc@123")
                {
                    Response.Redirect("~/welcome.aspx");

                    Response.Write("successfull login");

                }
                else
                {
                    Response.Write("invalid credentials");
                }


            }
           
                 

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}