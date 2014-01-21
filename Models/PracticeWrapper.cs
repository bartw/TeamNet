using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class PracticeWrapper
    {
        [DataMember(Name = "practice")]
        public Practice Practice { get; set; }
    }
}
