using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class EventAvailability
    {
        [DataMember(Name = "available_roster_ids")]
        public List<int> AvailableRosterIds { get; set; }
        [DataMember(Name = "not_available_roster_ids")]
        public List<int> NotAvailableRosterIds { get; set; }
        [DataMember(Name = "maybe_available_roster_ids")]
        public List<int> MaybeAvailableRosterIds { get; set; }
        [DataMember(Name = "not_specified_roster_ids")]
        public List<int> NotSpecifiedRosterIds { get; set; }
    }
}
