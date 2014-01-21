using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class Opponent
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "opponent_name")]
        public string OpponentName { get; set; }
        [DataMember(Name = "opponent_contact_phone")]
        public string OpponentContactPhone { get; set; }
        [DataMember(Name = "opponent_contact_email")]
        public string OpponentContactEmail { get; set; }
        [DataMember(Name = "opponent_contact_name")]
        public string OpponentContactName { get; set; }
        [DataMember(Name = "notes")]
        public string Notes { get; set; }
        [DataMember(Name = "league_controlled")]
        public bool LeagueControlled { get; set; }
    }
}
