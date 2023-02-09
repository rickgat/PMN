namespace Microsoft.Samples.PlanMyNight.AddIns.EmailItinerary.Notifications
{
    using System.Collections.Generic;
    using System.Net.Mail;

    public interface INotificationService
    {
        bool SendMail(string templateName, MailAddress fromEmail, MailAddress destinyEmail, Dictionary<string, string> fields);
    }
}
