using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class Practice : Event
    {
        [DataMember(Name = "location_id")]
        public int LocationId { get; set; }
        [DataMember(Name = "time_tbd")]
        public bool TimeTbd { get; set; }
    }
}
