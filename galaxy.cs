using System;


namespace Universe {

  public class Galaxy {
    public String Name {get; set;}
    public Star[] Stars;
    
    public Galaxy(){
      Name = UniverseTools.GetName();

      Random rand = new Random();
      int num = rand.Next(2, 5);
      Stars = new Star[num];
      for(int j = 0; j<Stars.Length ; j++){
        Stars[j] = new Star();
      }
    }

    public void GetGalaxy(){
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine(this);
      foreach(Star star in Stars){
        star.GetStar();
      }
    }

    public override string ToString(){
      string GalaxyEmoji = char.ConvertFromUtf32(0x1f4ab);
      string galaxystring = $"\n{GalaxyEmoji}  Galaxy - {Name} has {Stars.Length} stars";
      return galaxystring;
    }  
  }
}