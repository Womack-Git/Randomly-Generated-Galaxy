using System;

namespace Universe {

  class MainClass {
    public static void Main (string[] args) {    
    
      Random rand = new Random();
      Galaxy[] galaxies;

      //Galaxies
      int num = rand.Next(2, 5);
      galaxies = new Galaxy[num];

      for(int i = 0; i<galaxies.Length ; i++){
        galaxies[i] = new Galaxy();
      }

      //print galaxies
      foreach(Galaxy g in galaxies){
        Console.ForegroundColor = ConsoleColor.Magenta;
        g.GetGalaxy();
        Console.ResetColor();
      }
    }
  }
}