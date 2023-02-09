namespace Microsoft.Samples.PlanMyNight.Entities
{
    using System.Runtime.Serialization;

    [DataContract]
    public class State
    {
        [DataMember]
        public string Abbreviation { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
