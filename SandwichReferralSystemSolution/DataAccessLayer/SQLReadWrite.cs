using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class SQLReadWrite:IFileReadWrite
    {

        
        public void Write(ReferredApplicant reffObj)
        {


            string cs = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
    
                SqlCommand cmd = new SqlCommand("spInsertNewRecord", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter prm1 = new SqlParameter("@app_name", SqlDbType.NVarChar);
                SqlParameter prm2 = new SqlParameter("@experience", SqlDbType.Int);
                SqlParameter prm3 = new SqlParameter("@app_email", SqlDbType.NVarChar);
                SqlParameter prm4 = new SqlParameter("@qualification", SqlDbType.NVarChar);
                SqlParameter prm5 = new SqlParameter("@resume", SqlDbType.NVarChar);
                SqlParameter prm6 = new SqlParameter("@post", SqlDbType.NVarChar);
                SqlParameter prm7 = new SqlParameter("@dos", SqlDbType.Date);
                SqlParameter prm8 = new SqlParameter("@status", SqlDbType.NVarChar);
                SqlParameter prm9 = new SqlParameter("@ref_name", SqlDbType.NVarChar);
                SqlParameter prm10 = new SqlParameter("@ref_email", SqlDbType.NVarChar);



                prm1.Value = reffObj.GetReferredEmployeeName();
                prm2.Value = reffObj.GetExperianceInYears();
                prm3.Value = reffObj.GetEmailAddress();
                prm4.Value = reffObj.GetQualification();
                prm5.Value = reffObj.GetResumePath();
                prm6.Value = reffObj.GetPost();
                prm7.Value = reffObj.GetDateOfSubmission();
                prm8.Value = reffObj.GetApplicantStatus();
                prm9.Value = reffObj.GetReferredEmployeeName();
                prm10.Value = reffObj.GetReferrentEmailId();


                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);
                cmd.Parameters.Add(prm3);
                cmd.Parameters.Add(prm4);
                cmd.Parameters.Add(prm5);
                cmd.Parameters.Add(prm6);
                cmd.Parameters.Add(prm7);
                cmd.Parameters.Add(prm8);
                cmd.Parameters.Add(prm9);
                cmd.Parameters.Add(prm10);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "InsertedRow");
            }
        

        public System.Data.DataTable Read()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("spApplicantDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Referral_Records");
            DataTable dt1 = ds.Tables[0];
            return dt1;



        }

        public void Update(string updatedStatus, int refNo)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);


            SqlCommand cmd = new SqlCommand("spUpdateStatus", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm1 = new SqlParameter("@status", SqlDbType.NVarChar);
            SqlParameter prm2 = new SqlParameter("@ApplicantId", SqlDbType.Int);
            prm1.Value = updatedStatus;
            prm2.Value = refNo;
            cmd.Parameters.Add(prm1);
            cmd.Parameters.Add(prm2);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "UpdatedTable");

        }




        public DataView Search(string searchContent, string searchByCategory)
        {

            string cs1 = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection con1 = new SqlConnection(cs1);


            
            SqlCommand sqcmd = new SqlCommand();

            if (searchByCategory == "Name")
            {
                sqcmd.CommandText = "EXECUTE spSearchByName @searchContent";
            }

            else if (searchByCategory == "Referred_By")
            {
                sqcmd.CommandText = "EXECUTE spSearchByReferral @searchContent";
            }

            else
            {
                sqcmd.CommandText = "EXECUTE spSearchByStatus @searchContent";
            }


            sqcmd.Parameters.Add("@searchContent", SqlDbType.NVarChar).Value = searchContent;
            sqcmd.Connection = con1;
            SqlDataAdapter sqdap = new SqlDataAdapter(sqcmd);
            DataSet ds = new DataSet();
            sqdap.Fill(ds, "Applicant");
            DataTable dt = ds.Tables[0];
            DataView dv = new DataView(dt);
            return dv;

           
        }




    }
}
