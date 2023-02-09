namespace Microsoft.Samples.PlanMyNight.Data
{
    using System.Collections.Generic;
    using Microsoft.Samples.PlanMyNight.Entities;

    public interface IReferenceRepository
    {
        IEnumerable<State> RetrieveStates();

        IEnumerable<string> RetrieveCities(string stateCode);

        IEnumerable<string> RetrieveZipCodes(string stateCode);
    }
}
