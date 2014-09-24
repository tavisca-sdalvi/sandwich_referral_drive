using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;
using System.Configuration;
using BusinessLogicLayer;
using DataAccessLayer;
using System.IO;

namespace SandwichReferralSystem
{
    public partial class ApplicantDetails : Form
    {
        DataGridViewRow row;
        DataAccessLayer.IFileReadWrite SQLUpdateObj = new DataAccessLayer.SQLReadWrite();
        DataAccessLayer.IFileReadWrite SQLSearchObj = new DataAccessLayer.SQLReadWrite();



         public enum SearchByCategory
         
            {
               Name,
               Referred_By,
               CURRENT_STATUS
            }



         public ApplicantDetails()
          {
            ApplicantDetails.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
          }

        private void dataGridView1_Load(object sender, EventArgs e)
        {

         
        }
        private async void Viewbutton_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            DataAccessLayer.IFileReadWrite sqlReadObj = new DataAccessLayer.SQLReadWrite();
            dataGridView1.DataSource = await Task.FromResult<DataTable>(sqlReadObj.Read());

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dataGridView1.Rows[e.RowIndex];
                RefferencedByTextbox.Text = row.Cells["REFERRAL_NAME"].Value.ToString();
                NameTextbox.Text = row.Cells["APPLICANT_NAME"].Value.ToString();
                PostTextbox.Text = row.Cells["Post_APPLYING_FOR"].Value.ToString();
                ExperienceTextbox.Text = row.Cells["YEARS_OF_EXPERIENCE"].Value.ToString();
                EmailTextbox.Text = row.Cells["APPLICANT_EMAIL"].Value.ToString();
                StatusComboBox.Text = row.Cells["CURRENT_STATUS"].Value.ToString();
                EmpidTextbox.Text = row.Cells["APPLICANT_ID"].Value.ToString();
            }

        }

        public void ModifyButton_Click(object sender, EventArgs e)
        {

            string sender_of_mail = ConfigurationManager.AppSettings["modifiedstatussender"];
            string receiver_of_mail = EmailTextbox.Text;
            string mailBody = File.ReadAllText("C:/Users/sdalvi/Desktop/sandwich_project/final sandwich/SandwichReferralSystemSolution/BusinessLogicLayer/EmailBodyTemplate/StatusChange.html");

            string body = string.Format(mailBody,StatusComboBox.Text);
           
            string subject = ConfigurationManager.AppSettings["modifiedstatusemailsubject"];
            EmailSend ES = new EmailSend();
            ES.SendMail(sender_of_mail,receiver_of_mail,body,subject);


            int empidstr = Convert.ToInt32(EmpidTextbox.Text);
            string statusstr = StatusComboBox.Text;

            SQLUpdateObj.Update(statusstr, empidstr);

        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            //DataAccessLayer.IFileReadWrite excelReadObj = new DataAccessLayer.ExcelReadWrite();
            //DataAccessLayer.IFileReadWrite excelSearchObj = new DataAccessLayer.ExcelReadWrite();
            //string searchContent=SearchTb.Text;
            //if (SearchcomboBox.Text == "Name")
            //{
            //    dataGridView1.DataSource = excelSearchObj.Search(searchContent,SearchcomboBox.Text);
            //}
            //else if (SearchcomboBox.Text == "Referred_By")
            // {
            //     dataGridView1.DataSource = excelSearchObj.Search(searchContent,SearchcomboBox.Text);

            // }

            //else
            //    if (SearchcomboBox.Text == "ApplicationStatus")
            //    {
            //        dataGridView1.DataSource = excelSearchObj.Search(searchContent, SearchcomboBox.Text);
            //    }








            string searchContent = SearchTb.Text;

       
            if (SearchcomboBox.Text == SearchByCategory.Name.ToString())
            {
                ApplicantStatusComboBox.Hide();
                dataGridView1.DataSource = SQLSearchObj.Search(searchContent, SearchcomboBox.Text);
            }
            else if (SearchcomboBox.Text == SearchByCategory.Referred_By.ToString())
            {
               
                dataGridView1.DataSource = SQLSearchObj.Search(searchContent, SearchcomboBox.Text);

            }
            else
                if (SearchcomboBox.Text == SearchByCategory.CURRENT_STATUS.ToString())
                {
                   
                    ApplicantStatusComboBox.Show();


                    dataGridView1.DataSource = SQLSearchObj.Search(ApplicantStatusComboBox.Text, SearchcomboBox.Text);
                }



        }

        private void ApplicantStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = SQLSearchObj.Search(ApplicantStatusComboBox.Text, SearchcomboBox.Text);


        }

        private void SearchcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchcomboBox.Text == SearchByCategory.CURRENT_STATUS.ToString())
            {
                SearchTb.Hide();
                ApplicantStatusComboBox.Show();
            }
            else
            {
                SearchTb.Show();
                ApplicantStatusComboBox.Hide();
            }

        }

     

       
    }
}
