using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SandwichReferralSystem
{
    public partial class EmployeeCheck : Form
    {
        public EmployeeCheck()
        {
            InitializeComponent();
        }

       

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string EmployeeEmailId = EmailTextBox.Text;
            string connectionstring = ConfigurationManager.ConnectionStrings["TaviscaSandwichConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("applicantOnYourReferrence", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter prm = new SqlParameter("@EmailId", SqlDbType.NVarChar);
            prm.Value = EmployeeEmailId;
            cmd.Parameters.Add(prm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Applicant");
            ReferralGridView.DataSource = ds.Tables[0];
            
        }

        
    }
}
