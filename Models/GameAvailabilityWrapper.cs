using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class GameAvailabilityWrapper
    {
        [DataMember(Name = "game")]
        public EventAvailability Availability { get; set; }
    }
}
