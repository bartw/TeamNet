using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class PracticeAvailabilityWrapper
    {
        [DataMember(Name = "practice")]
        public EventAvailability Availability { get; set; }
    }
}
