using System.Runtime.Serialization;

namespace TeamNet.Models
{
    [DataContract]
    public class Event
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "team_id")]
        public int TeamId { get; set; }
        [DataMember(Name = "event_date_start")]
        public string EventDateStart { get; set; }
        [DataMember(Name = "duration_hours")]
        public int? DurationHours { get; set; }
        [DataMember(Name = "duration_minutes")]
        public int? DurationMinutes { get; set; }
        [DataMember(Name = "shortlabel")]
        public string ShortLabel { get; set; }
        [DataMember(Name = "eventname")]
        public string EventName { get; set; }
        [DataMember(Name = "result_url")]
        public string ResultUrl { get; set; }
        [DataMember(Name = "minutes_early")]
        public int? MinutesEarly { get; set; }
        [DataMember(Name = "canceled")]
        public bool Canceled { get; set; }
        [DataMember(Name = "notes")]
        public string Notes { get; set; }
        [DataMember(Name = "event_date_end")]
        public string EventDateEnd { get; set; }
        [DataMember(Name = "display_icon")]
        public string DisplayIcon { get; set; }
        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }
        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }
        [DataMember(Name = "tracks_availability")]
        public bool TracksAvailability { get; set; }
        [DataMember(Name = "location")]
        public Location Location { get; set; }
        //"refreshments" : [],
        //"tbd_date" : null,
        [DataMember(Name = "can_set_availability")]
        public bool CanSetAvailability { get; set; }
        //"availability_cutoff_time" : null
    }
}
