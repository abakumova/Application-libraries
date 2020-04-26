using System;
using System.Text.RegularExpressions;

namespace FeedbackForm
{
    public partial class MainForm : System.Web.UI.Page
    {
        static string patternEmail = @"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";
        Regex regexEmail = new Regex(patternEmail);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
     
        protected void send_Click(object sender, EventArgs e)
        {
            if (regexEmail.IsMatch(email.Text))
            {
                WinForm_Feedback.SendMail sendMail = new WinForm_Feedback.SendMail(message.Text, email.Text, subject.Text);
                sendMail.MySendMail();
                valid.Text = "Email has been sent";
            }
            else
            {
                valid.Text = "Please, provide valid email address (test@gmail.com)";
            }            
        }
    }
}