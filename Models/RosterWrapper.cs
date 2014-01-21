using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class RosterWrapper
    {
        [DataMember(Name = "roster")]
        public Roster Roster { get; set; }
    }
}
