using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace sep30_4
{
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
       
                int id = Int32.Parse(TextBox1.Text);
            Label2.Text = c.FindProducts(id);

        }


    }
}