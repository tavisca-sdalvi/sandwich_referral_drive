using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ReferredApplicant
    {
        public string _referredEmployeeName;
        public string _applicantName;
        public string _post;
        public string _emailAddress;
        public int _experienceInYear;
        public DateTime _date_Of_Submission;
        public string _resumePath;
        public string _applicationStatus;
        public string _referrentEmailId;
        public string _qualification;

        public enum Status
        {
            [StringValue("In Queue")]
            In_Queue = 1,
        }

        
        public ReferredApplicant()
        {
            // no arg const
        }
        public ReferredApplicant(string referredEmployeeName, string applicantName,string post,string emailAddress,int experianceInYear,DateTime dateOfSubmission,string resumePath,string referrentmailId,string qualification)
        {
          // Page1 p=new Page1();
            this._referredEmployeeName = referredEmployeeName;
            this._applicantName= applicantName;
            this._post=post;
            this._emailAddress=emailAddress;
            this._experienceInYear = experianceInYear;
            this._date_Of_Submission = dateOfSubmission;
            this._resumePath = resumePath;
            this._referrentEmailId = referrentmailId;
            this._qualification = qualification;
            _applicationStatus = StringEnum.GetStringValue(Status.In_Queue);
         }
        public string GetReferredEmployeeName()
        {
            return _referredEmployeeName;

        }
        public string GetApplicantName()
        {
            return _applicantName;

        }
        public string GetPost()
        {
            return _post;

        }
        public string GetEmailAddress()
        {
            return _emailAddress;

        }
        public int GetExperianceInYears()
        {
            return _experienceInYear;

        }
        public DateTime GetDateOfSubmission()
        {
            return _date_Of_Submission;
        }
        public string GetResumePath()
        {
            return _resumePath;
        }
        public string GetApplicantStatus()
        {
            return _applicationStatus;

        }
        public string GetReferrentEmailId()
        {
            return _referrentEmailId;

        }
        public string GetQualification()
        {
            return _qualification;

        }
      }

    }
public class StringValue : System.Attribute
{
    private string _value;

    public StringValue(string value)
    {
        _value = value;
    }

    public string Value
    {
        get { return _value; }
    }

}
public static class StringEnum
{
    public static string GetStringValue(Enum value)
    {
        string output = null;
        Type type = value.GetType();


        FieldInfo fi = type.GetField(value.ToString());
        StringValue[] attrs =
           fi.GetCustomAttributes(typeof(StringValue),
                                   false) as StringValue[];
        if (attrs.Length > 0)
        {
            output = attrs[0].Value;
        }

        return output;
    }
}
