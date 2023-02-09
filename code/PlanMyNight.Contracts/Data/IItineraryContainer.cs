namespace Microsoft.Samples.PlanMyNight.Data
{
    using System;
    using Microsoft.Samples.PlanMyNight.Entities;

    public interface IItineraryContainer
    {
        Itinerary GetCurrent();

        void SetCurrent(Itinerary itinerary);
    }
}
