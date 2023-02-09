namespace Microsoft.Samples.PlanMyNight.Web.ViewModels
{
    using System.Collections.Generic;

    public class ItinerariesViewModel
    {
        public string Owner { get; set; }

        public IEnumerable<ItineraryViewModel> Itineraries { get; set; }
    }
}
