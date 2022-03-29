using System;

namespace Universe{
  public class Moon {
    public String Name {get; set;}

    public Moon(){
     Name = UniverseTools.GetName();
    }

    public static string GetCheese(){
      Random rand = new Random();
      var num = rand.Next(0,12);
      var CheeseLvl = num.ToString();
      return CheeseLvl;
    }

    public void GetMoon(){
      string MoonEmoji = char.ConvertFromUtf32(0x1f311);
      Console.ForegroundColor = ConsoleColor.Cyan;
      string galaxystring = $"\t\t\t{MoonEmoji}  Moon - {Name} - Cheese Level: {GetCheese()}";
      Console.WriteLine(galaxystring);
      Console.ResetColor();
    }
  }
}