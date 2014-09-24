using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class ExcelReadWrite:IFileReadWrite
    {
        DataTable dt;
        OleDbConnection conn;

       


      public  void Write(ReferredApplicant reffObj)
        {
            int ReferralNo;
            Connection d = new Connection();
            OleDbConnection conn = d.GetConnection();
            conn.Open();  
          OleDbCommand cm2 = new OleDbCommand("select MAX(ReferralNo) from [Sheet1$]", conn);
            ReferralNo = Convert.ToInt32(cm2.ExecuteScalar()) + 1;

            OleDbCommand cmd = new OleDbCommand("insert into [Sheet1$]  values(?,?,?,?,?,?,?,?,?)", conn);
            cmd.Parameters.Add("Referred_By", OleDbType.VarChar).Value = reffObj.GetReferredEmployeeName();
            cmd.Parameters.Add("Name", OleDbType.VarChar).Value =reffObj.GetApplicantName();
            cmd.Parameters.Add("Post", OleDbType.VarChar).Value = reffObj.GetPost();
            cmd.Parameters.Add("Experience", OleDbType.Integer).Value = reffObj.GetExperianceInYears();
            cmd.Parameters.Add("Email", OleDbType.VarChar).Value = reffObj.GetEmailAddress();
            cmd.Parameters.Add("Resume", OleDbType.VarChar).Value = reffObj.GetResumePath();
            cmd.Parameters.Add("ApplicationStatus", OleDbType.VarChar).Value = reffObj.GetApplicantStatus();
            cmd.Parameters.Add("ReferralNo", OleDbType.Integer).Value = ReferralNo;
            cmd.Parameters.Add("Date_Of_Submission", OleDbType.Date).Value = reffObj.GetDateOfSubmission();
            cmd.ExecuteNonQuery();
        }
        public DataTable Read()
        {
           // try
            //{
                Connection d = new Connection();
                 conn = d.GetConnection();
                conn.Open();

                OleDbDataAdapter myadapter = new OleDbDataAdapter("select * from [Sheet1$]", conn);
                dt = new DataTable();
                myadapter.Fill(dt);

                return dt;
           /* }
            catch (Exception ex)
            {
                
            }
            finally
            {
                
                conn.Close();
            }
            * */

        }
        public void Update(string updatedStatus,int refNo)
        {
            try
            {

                Connection d = new Connection();
                conn = d.GetConnection();
                conn.Open();

                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                myCommand.Connection = conn;
                sql = "Update [Sheet1$] set ApplicationStatus = ' " + updatedStatus + "' where ReferralNo= " + refNo + " ";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                conn.Close();
            }

        }
        public DataView Search(string searchContent,string searchByCategory)
        {
          
            DataView dv = new DataView(Read());
            if(searchContent !="")
            dv.RowFilter = string.Format(searchByCategory+" LIKE '%{0}%' ", searchContent);
            return dv;
        }
    }
}
