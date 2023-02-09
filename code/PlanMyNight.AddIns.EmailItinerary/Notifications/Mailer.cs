namespace Microsoft.Samples.PlanMyNight.AddIns.EmailItinerary.Notifications
{
    using System;
    using System.Diagnostics;
    using System.Net.Mail;

    public class Mailer : IMailer
    {
        public bool SendMail(MailMessage mail)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                Trace.Fail("error sending mail", ex.ToString());
                return false;
            }
        }
    }
}
