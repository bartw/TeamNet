using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class RosterWrapper
    {
        [DataMember(Name = "roster")]
        public Roster Roster { get; set; }
    }
}
