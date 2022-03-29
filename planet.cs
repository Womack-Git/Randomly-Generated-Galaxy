using System;

namespace Universe {
  
  public class Planet {
    public String Name {get; set;}
    public Moon[] Moons;

    public Planet() {
      Name = UniverseTools.GetName();
      Random rand = new Random();
      int num = rand.Next(0, 4);
      Moons = new Moon[num];
      for(int j = 0; j<Moons.Length ; j++){
        Moons[j] = new Moon();
      }
    }

    public static string GetPop(){
      Random rand = new Random();
      var num = rand.Next(100000, 100000001);
      var PopNum = num.ToString();
      return PopNum;
    }

    public void GetPlanet(){
      string PlanetEmoji  = char.ConvertFromUtf32(0x1f30d);
      Console.ForegroundColor = ConsoleColor.Green;
      string galaxystring = $"\t\t{PlanetEmoji}  Planet - {Name} - Population: {GetPop()} - has {Moons.Length} moons";
      Console.WriteLine(galaxystring);
      Console.ResetColor();
      foreach(Moon moon in Moons){
        moon.GetMoon();
      }
    }
  }
}