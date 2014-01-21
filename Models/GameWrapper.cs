using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class GameWrapper
    {
        [DataMember(Name = "game")]
        public Game Game { get; set; }
    }
}
