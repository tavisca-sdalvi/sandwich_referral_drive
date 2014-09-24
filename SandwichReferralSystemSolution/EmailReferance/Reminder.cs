using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Net.Mail;
using BusinessLogicLayer;
using FindReminder;

namespace EmailReferance
{
    class Reminder
    {
        

        DataTable dt;

        static void Main(string[] args)
        {
            EmailSend ES3 = new EmailSend();
            string Reciever = "";
            UnnotifiedApplicant r = new UnnotifiedApplicant();
            List<string> unnotifiedApplicant = new List<string>();
            unnotifiedApplicant = r.reminderEmail();
            foreach (string name in unnotifiedApplicant)
            {
                Reciever += name + ",";

            }
            string body="Please Take appropiate action on Status of Referred Candidate  ---  " + Reciever;
            Console.WriteLine(body);
            ES3.SendMail("sandwichtavisca@gmail.com", "athorat@tavisca.com",body, "Unchanged Status Remainder");

        }
       
    }
}