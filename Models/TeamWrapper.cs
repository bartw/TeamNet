using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class TeamWrapper
    {
        [DataMember(Name = "team")]
        public Team Team { get; set; }
    }
}
