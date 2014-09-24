using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;
using System.Data.OleDb;
using System.Configuration;
using DataAccessLayer;
using System.IO;


namespace SandwichReferralSystem
{
    public partial class NewApplicantForm : Form
    {
        public NewApplicantForm()
        {
            InitializeComponent();
          
        }

        bool flag = true;

        public void UploadResumeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\";
            ofd.Title = "Browse files";
            ofd.CheckFileExists = true;
            ofd.CheckFileExists = true;
            ofd.DefaultExt = "pdf| doc| docx";
            ofd.Filter = "Text Files (*.pdf)|*.pdf|(*.doc)|*.doc|(*.docx)|*.docx ";
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;



            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ResumeTextbox.Text = ofd.FileName;
            }


            string strfilename = "";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strfilename = ofd.FileName;
            }
            ResumeTextbox.Text = strfilename;
           
        }

        DataAccessLayer.IFileReadWrite SQLWriteObj;

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            string referrenceByName = ReferrancedByNameTextbox.Text;
            string applicantName = ApplicantNameTextbox.Text;
            string post = ApplicantAppliedForPostComboBox.Text;
            string emailAddress = EmailTextbox.Text;

            int experianceInYears = Convert.ToInt32(ExperienceTextbox.Text);
            DateTime dateOfSubmission = Convert.ToDateTime((DateTextbox.Text));
            string resumePath = ResumeTextbox.Text;
            string referrentEmailId = ReferrentEmailIdTextBox.Text;
            string qualification = QualificationTextBox.Text;

            string mailBody = File.ReadAllText("C:/Users/sdalvi/Desktop/sandwich_project/final sandwich/SandwichReferralSystemSolution/BusinessLogicLayer/EmailBodyTemplate/ApplicantEntry.html");
            BusinessLogicLayer.ReferredApplicant refAppObj = new BusinessLogicLayer.ReferredApplicant(referrenceByName, applicantName, post, emailAddress, experianceInYears, dateOfSubmission, resumePath,referrentEmailId,qualification);

            string classNameStr = ConfigurationManager.AppSettings["selectSql"];
            Type concreteType = Type.GetType(classNameStr);
            this.SQLWriteObj = (IFileReadWrite)Activator.CreateInstance(concreteType);
            SQLWriteObj.Write(refAppObj);

            BusinessLogicLayer.EmailSend emailSendObj = new BusinessLogicLayer.EmailSend();
            emailSendObj.SendMail(ConfigurationManager.AppSettings["emailsender"], ConfigurationManager.AppSettings["emailreceiver"], resumePath,mailBody, ConfigurationManager.AppSettings["NewEntrySubject"]);


            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }




        }

       
        public void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTb.Text == "HrTeam" && PasswordTb.Text == "123456")
            {
                this.Hide();
                ApplicantDetails obj = new ApplicantDetails();
                obj.Show();
            }

            if (UserNameTb.Text == "Employee" && PasswordTb.Text == "abcdef")
            {
                this.Hide();
                EmployeeCheck obj = new EmployeeCheck();
                obj.Show();
            }


        }

        

        private void ReferrancedByNameTextbox_Validating(object sender, CancelEventArgs e)
        {


            Regex rx_name = new Regex("^([A-Za-z])");
            if (!rx_name.IsMatch(ReferrancedByNameTextbox.Text))
            {
                e.Cancel = false;
                ReferrencedByValidatorLabel.Text = "*Only alphabets are allowed in this field!";
                ReferrancedByNameTextbox.Text = " ";
                flag = false;
            }
            else
            {
                ReferrencedByValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }



        }

        private void ApplicantNameTextbox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_name = new Regex("^[a-zA-Z]");
            if (!rx_name.IsMatch(ApplicantNameTextbox.Text))
            {
                e.Cancel = false;
                NameValidatorLabel.Text = "*Only alphabets are allowed in this field!";
                ApplicantNameTextbox.Text = " ";
                flag = false;
            }
            else
            {
                NameValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }



        }

        

        private void ApplicantAppliedForPostComboBox_Validating(object sender, CancelEventArgs e)
        {


            if (ApplicantAppliedForPostComboBox.SelectedIndex == -1)
            {
                e.Cancel = false;
                PostValidatorLabel.Text = "*Please select a post!";
                flag = false;
            }
            else
            {
                PostValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }



        }

        private void EmailTextbox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_email = new Regex("([A-Za-z0-9])+@([A-Za-z0-9]{3,15})+.([A-Za-z]{2,4})$");
            if (!rx_email.IsMatch(EmailTextbox.Text))
            {
                e.Cancel = false;
                EmailValidatorLabel.Text = "*Please enter a valid E-Mail ID!";
                EmailTextbox.Text = " ";
                flag = false;
            }
            else
            {
                EmailValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }




        }

        private void ExperienceTextbox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_experience = new Regex("[0-9]{1,2}$");
            if (!rx_experience.IsMatch(ExperienceTextbox.Text))
            {
                e.Cancel = false;
                ApplicantExperienceValidatorLabel.Text = "*This field cannot accept more than 2 digits!";
                ExperienceTextbox.Text = "";
                flag = false;
            }
            else
            {
               ApplicantExperienceValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }



        }

        private void DateTextbox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_date = new Regex("([0-9]{4})-([0-12]{1,2})-([0-30]{1,2})");
            if (!rx_date.IsMatch(DateTextbox.Text))
            {
                e.Cancel = false;
                DateValidatorLabel.Text = "*Please enter a valid date!";
                DateTextbox.Text = " ";
                flag = false;
            }
            else
            {
                DateValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }


        }

        private void QualificationTextBox_Validating(object sender, CancelEventArgs e)
        {

            Regex rx_qual = new Regex("^([A-Za-z0-9])+.([A-Za-z0-9])$");
            if (!rx_qual.IsMatch(QualificationTextBox.Text))
            {
                e.Cancel = false;
                QualificationValidatorLabel.Text = "*Please enter a valid Qualification!";
                QualificationTextBox.Text = " ";
                flag = false;
            }
            else
            {
                QualificationValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }














        }

        private void ReferrentEmailIdTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex rx_qual = new Regex("([A-Za-z0-9])+@([A-Za-z0-9]{3,15})+.([A-Za-z]{2,4})$");
            if (!rx_qual.IsMatch(ReferrentEmailIdTextBox.Text))
            {
                e.Cancel = false;
                ReferralEmailValidatorLabel.Text = "*Please enter a valid Email ID!";
                ReferrentEmailIdTextBox.Text = " ";
                flag = false;
            }
            else
            {
                ReferralEmailValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }


        }

        private void ResumeTextbox_Validating(object sender, CancelEventArgs e)
        {


            if (ResumeTextbox.Text == null)
            {
                e.Cancel = false;
                UploadValidatorLabel.Text = "*Please select a pdf/doc/docx file!";
                ResumeTextbox.Text = " ";
                flag = false;
            }
            else
            {
                UploadValidatorLabel.Text = " ";
                flag = true;
            }
            if (flag == false)
            {
                SubmitButton.Enabled = false;
            }
            else
            {
                SubmitButton.Enabled = true;
            }



        }

   
        

    }
}







       
      

