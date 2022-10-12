using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayerLibrary
{
    public class DAL_class
    {
        public bool InsertMember(BLL_class member)
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
        public bool UpdateMember(BLL_class Member)
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


        public List<BLL_class> MemberList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ShoppingCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from  [dbo].[fn_memlist]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL_class> memlist = new List<BLL_class>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL_class bal = new BLL_class();
                    bal.Member_Id = Convert.ToInt32(dr["Member_Id"]);
                    bal.Member_Name = dr["Member_Name"].ToString();
                    bal.Acc_Open_Date = Convert.ToDateTime(dr["Acc_open_Date"]);
                    bal.Max_Books_Allowed = Convert.ToInt32(dr["Max_Books_Allowed"]);
                    bal.Penalty_Amount = Convert.ToInt32(dr["Penalty_Amount"]);
                    memlist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return memlist;

        }


    }


}



       