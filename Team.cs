public class Team {
  private List<Player> players;

  public Team(List<Player> players) {
    this.players = players;
  }

  public void PrintPlayers()
  {
    for (int i = 0; i < players.Count; i++)
    {
      string details = players[i].GetDetails();
      Console.WriteLine(details);
    }
  }
}