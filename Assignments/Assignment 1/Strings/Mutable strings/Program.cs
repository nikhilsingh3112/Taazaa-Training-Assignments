using System;
using System.Text;

public class Program {
   public static void Main() {
      StringBuilder str = new StringBuilder("Web World!!",30);
      str.Replace("World", "Arena");

      Console.WriteLine(str);
   }
}