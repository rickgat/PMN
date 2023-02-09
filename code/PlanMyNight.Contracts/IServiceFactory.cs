namespace Microsoft.Samples.PlanMyNight
{
    using System;
    using Microsoft.Samples.PlanMyNight.Data;

    public interface IServiceFactory
    {
        IActivitiesRepository GetActivitiesRepositoryInstance();
        IItinerariesRepository GetItinerariesRepositoryInstance();
        IItineraryContainer GetItineraryContainerInstance();
        IReferenceRepository GetReferenceRepositoryInstance();
    }
}
