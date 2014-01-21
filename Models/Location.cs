using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "location_name")]
        public string LocationName { get; set; }
        [DataMember(Name = "location_url")]
        public string LocationUrl { get; set; }
        [DataMember(Name = "address")]
        public string Address { get; set; }
        [DataMember(Name = "location_phone")]
        public string LocationPhone { get; set; }
        [DataMember(Name = "notes")]
        public string Notes { get; set; }
        [DataMember(Name = "league_controlled")]
        public bool LeagueControlled { get; set; }
    }
}
