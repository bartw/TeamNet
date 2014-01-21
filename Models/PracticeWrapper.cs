using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class PracticeWrapper
    {
        [DataMember(Name = "practice")]
        public Practice Practice { get; set; }
    }
}
