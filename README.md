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

foreach (var team in teams)
{
  //Get YOUR rosters in a team.
  var yourRosters = await instance.GetAvailableRosters(team.Id);

  foreach (var roster in yourRosters)
  {
    //Get all the rosters for this roster in a team
    var rosters = await instance.GetTeamRosters(team.Id, roster.Id);
    //Get the games for this roster in this team.
    var games = await instance.GetGames(team.Id, roster.Id);
    //Get the practices for this roster in this team.
    var practices = await instance.GetPractices(team.Id, roster.Id);

    foreach (var game in games)
    {
      //Get availability
      var availabilities = instance.GetEventAvailabilities(team.Id, roster.Id, game.Id, EventType.Game);
    }

    foreach (var practice in practices)
    {
      //Get availability
      var availabilities = instance.GetEventAvailabilities(team.Id, roster.Id, practice.Id, EventType.Practice);
    }
  }
}
