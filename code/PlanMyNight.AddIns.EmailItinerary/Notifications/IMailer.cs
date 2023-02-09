namespace Microsoft.Samples.PlanMyNight.AddIns.EmailItinerary.Notifications
{
    using System.Net.Mail;

    public interface IMailer
    {
        bool SendMail(MailMessage mail);
    }
}
