using System;

namespace lions
{
  class Program
  {
    static void Main(params string[] args)
    {
      var parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinnzahlen2020", args);

      parser.Parse();
      Console.ReadKey();
    }
  }
}
