using SampleApp;

// create List of 'Player' objects. 'Player' is defined in Player.cs.
var players = new List<Player>() { 
  new Player("Eric", 60), 
  new Player("Collin", 50) 
};

// create our custom defined 'Team' object defined in Team.cs
// 'Team' accepts a 'List' of 'Player' objects, the player object is
// defined in Player.cs.
var upward = new Team(players);

// call the 'PrintPlayers' method on our upward 'Team' object.
upward.PrintPlayers();