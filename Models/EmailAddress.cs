using System.Runtime.Serialization;

namespace Teamr.Models
{
    [DataContract]
    public class EmailAddress
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "label")]
        public string Label { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "receive_team_emails")]
        public bool ReceiveTeamEmails { get; set; }
        [DataMember(Name = "hide")]
        public bool Hide { get; set; }
    }
}
