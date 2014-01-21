using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class PracticeAvailabilityWrapper
    {
        [DataMember(Name = "practice")]
        public EventAvailability Availability { get; set; }
    }
}
