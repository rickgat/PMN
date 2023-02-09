namespace Microsoft.Samples.PlanMyNight.AddIns.EmailItinerary.Notifications
{
    public interface ITemplateReader
    {
        string RetrieveTemplate(string templateName);
    }
}
