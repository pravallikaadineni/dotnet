using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oct3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID.ToString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            string username = TextBox1.Text;
            Session["uname"] = username;
            Response.Redirect("~/logintable.aspx");

            if (TextBox1.Text=="sweety@gmail.com"&& TextBox2.Text=="1234")
            {
                Response.Write("you logged in successfully");
            }
            else
            {
                Response.Write("Invalid credentials");
            }
        }
    }
}