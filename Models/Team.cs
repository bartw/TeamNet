using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class Team
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "team_name")]
        public string TeamName { get; set; }
        [DataMember(Name = "team_league")]
        public string TeamLeague { get; set; }
        [DataMember(Name = "team_league_url")]
        public string TeamLeagueUrl { get; set; }
        [DataMember(Name = "team_division")]
        public string TeamDivision { get; set; }
        [DataMember(Name = "team_season")]
        public string TeamSeason { get; set; }
        [DataMember(Name = "is_coed")]
        public bool IsCoed { get; set; }
        [DataMember(Name = "sort_names_by")]
        public string SortNamesBy { get; set; }
        [DataMember(Name = "is_youth")]
        public bool IsYouth { get; set; }
        [DataMember(Name = "currency_symbol")]
        public string CurrencySymbol { get; set; }
        [DataMember(Name = "international_time")]
        public bool InternationalTime { get; set; }
        [DataMember(Name = "international_date")]
        public bool InternationalDate { get; set; }
        [DataMember(Name = "intro_text")]
        public string IntroText { get; set; }
        [DataMember(Name = "cname")]
        public string CName { get; set; }
        [DataMember(Name = "tracks_points")]
        public bool TracksPoints { get; set; }
        [DataMember(Name = "zipcode")]
        public string ZipCode { get; set; }
        [DataMember(Name = "other_sport_name")]
        public string OtherSportName { get; set; }
        [DataMember(Name = "city")]
        public string City { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
        [DataMember(Name = "public_subdomain")]
        public string PublicSubdomain { get; set; }
        [DataMember(Name = "division_id")]
        public int DivisionId { get; set; }
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }
        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }
        [DataMember(Name = "active_at")]
        public string ActiveAt { get; set; }
        [DataMember(Name = "uuid")]
        public string UuId { get; set; }
    }
}
