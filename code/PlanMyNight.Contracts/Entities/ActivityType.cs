namespace Microsoft.Samples.PlanMyNight.Entities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ActivityType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PluralizedName { get; set; }
    }
}
