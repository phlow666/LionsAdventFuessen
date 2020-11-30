using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace lions
{
  public class AdventParser
  {
    private readonly string url;
    private readonly string[] numbers;

    public AdventParser(string url, string[] numbers)
    {
      if (numbers == null || numbers.Length == 0)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Keine Parameter");
        Console.ForegroundColor = ConsoleColor.White;
      }
      this.url = url;
      this.numbers = numbers;
    }

    public void Parse()
    {
      this.GetPage();
    }

    readonly List<string> winNumbers = new List<string>();

    private void GetPage()
    {
      var web = new HtmlWeb();
      var doc = web.Load(this.url);

      foreach (var number in this.numbers)
      {
        Console.Write($"Gesuchte Zahl {number}: ");
        if (doc.ParsedText.Contains(number))
        {
          winNumbers.Add(number);
          Console.WriteLine("GEFUNDEN");
        }
        else
        {
          Console.WriteLine("NICHT GEFUNDEN");
        }
      }

      if (winNumbers.Any())
      {
        Console.ForegroundColor = ConsoleColor.Green;
        foreach (var win in winNumbers)
        {
          Console.WriteLine($"Gewonnen {win}!");
        }

      }
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Niete!");
      }
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
