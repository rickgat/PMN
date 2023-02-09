namespace Microsoft.Samples.PlanMyNight.Entities
{
    using System;
    using System.Linq;

    [Serializable]
    public partial class Itinerary
    {
        public int TotalEstimatedMinutes
        {
            get
            {
                if (this.Activities != null)
                {
                    return this.Activities.Sum(i => i.EstimatedMinutes);
                }

                return 0;
            }
        }
    }
}