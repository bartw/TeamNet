using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class Game : Event
    {
        //"score_for" : null,
        //"score_against" : null,
        //"shootout_for" : null,
        //"shootout_against" : null,
        [DataMember(Name = "is_ot")]
        public bool IsOt { get; set; }
        [DataMember(Name = "is_shootout")]
        public bool IsShootout { get; set; }
        [DataMember(Name = "home_or_away")]
        public int HomeOrAway { get; set; }
        [DataMember(Name = "no_count")]
        public bool NoCount { get; set; }
        [DataMember(Name = "time_tbd")]
        public bool TimeTbd { get; set; }
        //"event_result" : null,
        //"uniform" : null,
        [DataMember(Name = "LeagueControlled")]
        public bool LeagueControlled { get; set; }
        [DataMember(Name = "opponent")]
        public Opponent Opponent { get; set; }
        //"formatted_result" : null,
        //"availability_cutoff_time" : null
    }
}
