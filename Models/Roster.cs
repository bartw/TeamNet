using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class Roster
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "first")]
        public string First { get; set; }
        [DataMember(Name = "last")]
        public string Last { get; set; }
        [DataMember(Name = "is_owner")]
        public bool IsOwner { get; set; }
        [DataMember(Name = "thumbnail_picture_url")]
        public string ThumbnailPictureUrl { get; set; }
        [DataMember(Name = "non_player")]
        public bool NonPlayer { get; set; }
        [DataMember(Name = "roster_email_addresses")]
        public List<EmailAddress> RosterEmailAddresses { get; set; }
        [DataMember(Name = "is_manager")]
        public bool IsManager { get; set; }
        [DataMember(Name = "IsCommissioner")]
        public bool IsCommissioner { get; set; }
        [DataMember(Name = "address")]
        public Address Address { get; set; }

        //"roster_telephone_numbers" : [],
    }
}
