using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FindReminder
{
   public class UnnotifiedApplicant
    {
        DataTable dt;
        static void Main(string[] args)
        {
            
        }
        public List<string> reminderEmail()
        {
            List<string> newRefferdEmp = new List<string>();

            string connectionstring = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select * from Referral_Records where CURRENT_STATUS='In Queue'", conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Unnotified_Records");
            DataTable dt1 = ds.Tables[0];
 

            foreach (DataRow row in dt1.Rows)
            {
                DateTime subDate = Convert.ToDateTime(row["Date_Of_Submission"]);
                TimeSpan span = DateTime.Now.Subtract(subDate);
                if (span.Days >=7 )
                {
                    string name = row["APPLICANT_ID"].ToString();
                    newRefferdEmp.Add(name);
                }

            }

            return newRefferdEmp;
        }
    }
}
