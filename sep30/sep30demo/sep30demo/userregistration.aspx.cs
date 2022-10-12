using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sep30demo
{
    public partial class userregistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Userdata.SetActiveView(PersonalDetails);
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "PersonalDetails")
            {
                Userdata.SetActiveView(PersonalDetails);

            }
            else if (DropDownList1.SelectedValue == "EducationDetails")
            {
                Userdata.SetActiveView(EducationDetails);
            }
            else
            {
                Userdata.SetActiveView(BankDetails);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty
               (FileUpload1.FileName))
            {
                if (FileUpload1.HasFiles)
                {

                    foreach (HttpPostedFile item in FileUpload1.PostedFiles)
                    {
                        string fname = item.FileName;
                        FileInfo finfo = new FileInfo(fname);
                        string ext = finfo.Extension;

                        if (ext == ".pdf")
                        {
                            string s = item.FileName;
                            //string path = @"D:\repos\sep30demo\sep30demo\uploadedfiles\";

                            FileUpload1.SaveAs(Server.MapPath("uploadedfiles") + "\\" + s);
                        }
                        else
                        {
                            Response.Write("U can only upload pdf");
                        }

                    }
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

                       
               







