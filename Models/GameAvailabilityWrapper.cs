using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class GameAvailabilityWrapper
    {
        [DataMember(Name = "game")]
        public EventAvailability Availability { get; set; }
    }
}
