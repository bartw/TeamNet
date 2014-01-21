# [TeamNet](http://github.com/bartw/TeamNet)

TeamNet is a .Net 4.5 implementation of the [TeamSnap](http://www.teamsnap.com/) [API](https://github.com/teamsnap/apiv2-docs/wiki/Getting-Started-Guide).
TeamNet is created and maintained by [Bart Wijnants](http://beewee.be).

##Getting Started

```C#
//Get the instance of the TeamNet class
TeamNet instance = TeamNet.Instance;

//Initialize using your TeamSnap username and password.
string token = await instance.Initialize("username", "password");

//The initialize function returns an accesstoken you can save so you won't have to login every time. 
//You can also initialize using this token.
instance.Initialize(token);

//Get a list of the teams you have access to.
var teams = await instance.GetTeams();

//Get YOUR rosters in a team.
var yourRosters = await instance.GetAvailableRosters(TEAM_ID);

//Get all the rosters (that your roster can see) in a team
var rosters = await instance.GetTeamRosters(TEAM_ID, AS_ROSTER_ID);

//Get the games (that your roster can see) in this team.
var games = await instance.GetGames(TEAM_ID, AS_ROSTER_ID);
    
//Get the practices (that your roster can see) in this team.
var practices = await instance.GetPractices(TEAM_ID, AS_ROSTER_ID);

//Get the availabilities for an event
var availabilities = instance.GetEventAvailabilities(TEAM_ID, AS_ROSTER_ID, EVENT_ID, EventType.Practice);
var availabilities = instance.GetEventAvailabilities(TEAM_ID, AS_ROSTER_ID, EVENT_ID, EventType.Game);

//Update availability for a roster member
instance.SetAvailability(TEAM_ID, AS_ROSTER_ID, EVENT_ID, ROSTER_ID, Availability.NotAvailable);
instance.SetAvailability(TEAM_ID, AS_ROSTER_ID, EVENT_ID, ROSTER_ID, Availability.Available);
instance.SetAvailability(TEAM_ID, AS_ROSTER_ID, EVENT_ID, ROSTER_ID, Availability.MaybeAvailable);
