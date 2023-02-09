namespace Microsoft.Samples.PlanMyNight.Entities
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public partial class ItineraryActivity
    {
        [DataMember]
        public Activity Activity { get; set; }
    }
}
