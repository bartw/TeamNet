using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class Address
    {
        [DataMember(Name = "address")]
        public string AddressLine1 { get; set; }
        [DataMember(Name = "address2")]
        public string AddressLine2 { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "State")]
        public string State { get; set; }
        [DataMember(Name = "zip")]
        public string Zip { get; set; }
        [DataMember(Name = "country")]
        public string Country { get; set; }
    }
}
