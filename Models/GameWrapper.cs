using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class GameWrapper
    {
        [DataMember(Name = "game")]
        public Game Game { get; set; }
    }
}
