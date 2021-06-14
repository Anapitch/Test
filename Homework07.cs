using System;
using System.Linq;
public class Text
{
    public static void Main()
    {
      string words = (" ");
      Console.Write(words);
      words = Console.ReadLine();
      string[] array = words.Split(' ');
      var a =
      from k in array
      orderby k
      select k;
      foreach(string res in a.Distinct()) {
         Console.Write(" " + res.ToLower());
      }
      Console.ReadLine();
    }
}