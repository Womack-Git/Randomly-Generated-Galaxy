using System;

namespace Universe {

  public static class UniverseTools {
    public static string GetName(){
      var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      var stringChars = new char[8];
      var random = new Random();

      for (int i = 0; i < stringChars.Length; i++){
        stringChars[i] = chars[random.Next(chars.Length)];
      }
      var Name = new String(stringChars);
      return Name;
    }
  }
}