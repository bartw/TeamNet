using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TeamNet
{
    public enum EventType { Game, Practice };
    
    public enum Availability { NotAvailable = 0, Available = 1, MaybeAvailable = 2 };

    public class TeamNet
    {
        private static string _apiBase = "https://api.teamsnap.com/v2";
        
        private HttpClient _client;

        private static TeamNet _instance;
        public static TeamNet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TeamNet();
                }

                return _instance;
            }
        }

        private TeamNet()
        {
            _client = null;
        }

        public async Task<string> Initialize(string username, string password)
        {
            var token = await Authenticate(username, password);
            
            Initialize(token);

            return token;
        }

        public void Initialize(string token)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("X-Teamsnap-Token", token);
        }

        public void UnInitialize()
        {
            _client = null;
        }

        private async Task<string> Authenticate(string username, string password)
        {
            var authClient = new HttpClient();

            authClient.DefaultRequestHeaders.Add("X-Teamsnap-User", username);
            authClient.DefaultRequestHeaders.Add("X-Teamsnap-Password", password);

            var response = await authClient.GetAsync(string.Format("{0}/authentication", _apiBase));
            
            response.EnsureSuccessStatusCode();

            var tokenValues = (from header in response.Headers
                               where header.Key == "X-Teamsnap-Token"
                               select header.Value).FirstOrDefault();

            if (tokenValues != null)
            {
                return tokenValues.FirstOrDefault();
            }

            return null;
        }

        public async Task<IEnumerable<Models.Team>> GetTeams()
        {
            var response = await _client.GetAsync(string.Format("{0}/teams", _apiBase));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            
            var teams = Deserialize<List<Models.TeamWrapper>>(content);

            if (teams != null && teams.Count > 0)
            {
                return from wrapper in teams
                       where wrapper.Team != null
                       select wrapper.Team;
            }

            return null;
        }

        public async Task<IEnumerable<Models.Roster>> GetAvailableRosters(int teamId)
        {
            var response = await _client.GetAsync(string.Format("{0}/teams/{1}/as_roster", _apiBase, teamId));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var availableRosters = Deserialize<List<Models.RosterWrapper>>(content);

            if (availableRosters != null && availableRosters.Count > 0)
            {
                return from wrapper in availableRosters
                       where wrapper.Roster != null
                       select wrapper.Roster;
            }

            return null;
        }

        public async Task<IEnumerable<Models.Roster>> GetTeamRosters(int teamId, int rosterId)
        {
            var response = await _client.GetAsync(string.Format("{0}/teams/{1}/as_roster/{2}/rosters", _apiBase, teamId, rosterId));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var teamRosters = Deserialize<List<Models.RosterWrapper>>(content);

            if (teamRosters != null && teamRosters.Count > 0)
            {
                return from wrapper in teamRosters
                       where wrapper.Roster != null
                       select wrapper.Roster;
            }

            return null;
        }

        public async Task<IEnumerable<Models.Practice>> GetPractices(int teamId, int rosterId)
        {
            var response = await _client.GetAsync(string.Format("{0}/teams/{1}/as_roster/{2}/practices", _apiBase, teamId, rosterId));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var practices = Deserialize<List<Models.PracticeWrapper>>(content);

            if (practices != null && practices.Count > 0)
            {
                return from wrapper in practices
                       where wrapper.Practice != null
                       select wrapper.Practice;
            }

            return null;
        }

        public async Task<IEnumerable<Models.Game>> GetGames(int teamId, int rosterId)
        {
            var response = await _client.GetAsync(string.Format("{0}/teams/{1}/as_roster/{2}/games", _apiBase, teamId, rosterId));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            var games = Deserialize<List<Models.GameWrapper>>(content);

            if (games != null && games.Count > 0)
            {
                return from wrapper in games
                       where wrapper.Game != null
                       select wrapper.Game;
            }

            return null;
        }

        public async Task<Models.EventAvailability> GetEventAvailabilities(int teamId, int rosterId, int eventId, EventType eventType)
        {
            var response = await _client.GetAsync(string.Format("{0}/teams/{1}/as_roster/{2}/events/{3}/availabilities", _apiBase, teamId, rosterId, eventId));
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();

            if (eventType == EventType.Game)
            {
                var availabilities = Deserialize<Models.GameAvailabilityWrapper>(content);

                if (availabilities != null && availabilities.Availability != null)
                {
                    return availabilities.Availability;
                }
            }
            else if (eventType == EventType.Practice)
            {
                var availabilities = Deserialize<Models.PracticeAvailabilityWrapper>(content);

                if (availabilities != null && availabilities.Availability != null)
                {
                    return availabilities.Availability;
                }
            }

            return null;
        }
        
        public async void SetAvailability(int teamId, int asRosterId, int eventId, int rosterId, Availability availability)
        {
            var content = new StringContent(string.Format("{{\"availability\": {{\"status\": {0}}}}}", (int)availability), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync(string.Format("{0}/teams/{1}/as_roster/{2}/events/{3}/availabilities/{4}", _apiBase, teamId, asRosterId, eventId, rosterId), content);
            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
        }

        private static T Deserialize<T>(string json)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));

            using (var stream = new System.IO.MemoryStream(Encoding.Unicode.GetBytes((string)json)))
            {
                return (T)serializer.ReadObject(stream);
            }
        }
    }
}
