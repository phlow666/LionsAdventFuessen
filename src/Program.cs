using System;

namespace lions
{
    class Program
    {
        static void Main(params string[] args)
        {
            var parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2018", args);

            parser.Parse();
            Console.ReadKey();
        }
    }
}
