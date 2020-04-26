using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace WinForm_Feedback
{
    class SendMail
    {
        private string message="";
        private string nameAuthor="";
        private string subject = "";
        const string passMail = "password";

        public SendMail(string bodyMail, string nameAuthor, string subject)
        {
            this.message = bodyMail;
            this.nameAuthor = nameAuthor;
            this.subject = subject;
        }

        public void MySendMail()
        {
            var from = new MailAddress("email@gmail.com"); //Message box
            var to = new MailAddress(nameAuthor);

            try
            {
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(from.Address, passMail);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;

                MailMessage mail = new MailMessage(from, to);
                mail.Subject = subject;
                mail.Body = "It's a simple test message. Please do not answer!" + Environment.NewLine + message;

                ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
            }
        }
    }
}