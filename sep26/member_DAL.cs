using BAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class member_DAL
    {
        public bool InsertMember(member_BAL member)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoppingCnString"].ConnectionString);
            SqlCommand cmdInsert = new SqlCommand("insert into Member(Member_Id,Member_Name,Acc_Open_Date,Max_Books_Allowed,Penalty_Amount) values(@Member_Id,@Member_Name,@Acc_Open_Date,@Max_Books_Allowed,@Penalty_Amount)", cn);

            cmdInsert.Parameters.AddWithValue("@Member_Id", member.Member_Id);
            cmdInsert.Parameters.AddWithValue("@Member_Name", member.Member_Name);
            cmdInsert.Parameters.AddWithValue("@Acc_Open_Date", member.Acc_Open_Date);
            cmdInsert.Parameters.AddWithValue("@Max_Books_Allowed", member.Max_Books_Allowed);
            cmdInsert.Parameters.AddWithValue("@Penalty_Amount", member.Penalty_Amount);
            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;

        }
        public bool UpdateMember(member_BAL Member)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["shoppingCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[sp_UpdateMember]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@Member_Id", Member.Member_Id);
            cmdUpdate.Parameters.AddWithValue("@Member_Name", Member.Member_Name);
            cmdUpdate.Parameters.AddWithValue("@Acc_Open_Date", Member.Acc_Open_Date);
            cmdUpdate.Parameters.AddWithValue("@Max_Bokks_Allowed", Member.Max_Books_Allowed);
            cmdUpdate.Parameters.AddWithValue("@Penalty_Amount", Member.Penalty_Amount);
            cn.Open();
            int i = cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;

        }


    }
}



       
