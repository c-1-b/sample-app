namespace SampleApp
{
  public class Player
  {
    private string name;
    private int age;

    public Player(string name, int age)
    {
      this.name = name;
      this.age = age;
    }

    public string GetDetails()
    {
      return $"Name: {this.name} Age: {this.age}";
    }
  }
}
