namespace Microsoft.Samples.PlanMyNight.Web.ViewModels
{
    using System.Collections.Generic;
    using Microsoft.Samples.PlanMyNight.Entities;

    public class ItineraryCommentsViewModel
    {
        public long ItineraryId { get; set; }

        public IEnumerable<ItineraryComment> Comments { get; set; }
    }
}
