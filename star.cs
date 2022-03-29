using System;

namespace Universe {
    public class Star {
    public String Name {get; set;}
    public String Color {get; set;}
    public Planet[] Planets;

    public Star() {
      Random rand = new Random();
      Name = UniverseTools.GetName();
      Color = GetColor();

      int num = rand.Next(0, 9);
      Planets = new Planet[num];
      for(int j = 0; j<Planets.Length ; j++){
        Planets[j] = new Planet();
      }
    }

    public string GetColor(){
      string[] colors = {"White", "Yellow", "Blue", "Red"};
      var random = new Random();

      int useColor = random.Next(colors.Length);
      string pickColor = colors[useColor];
      return pickColor;
    }

    public void GetStar(){
      switch (GetColor()){
        case "Blue":
          Console.ForegroundColor = ConsoleColor.Blue;
          break;
        case "Red":
          Console.ForegroundColor = ConsoleColor.Red;
          break;
        case "White":
          Console.ForegroundColor = ConsoleColor.White;
          break;
        case "Yellow":
          Console.ForegroundColor = ConsoleColor.Yellow;
          break;
        default:
          Console.ForegroundColor = ConsoleColor.White;
          break;
      }
      string StarEmoji = char.ConvertFromUtf32(0x1f31f);
      string galaxystring = $"\t{StarEmoji} {Console.ForegroundColor} Star - {Name} has {Planets.Length} planets";
      Console.WriteLine(galaxystring);
      Console.ResetColor();
      foreach(Planet planet in Planets){
        planet.GetPlanet();
      }
    }
  }
}