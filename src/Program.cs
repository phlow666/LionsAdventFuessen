using System;

namespace lions
{
    class Program
    {
        static void Main(params string[] args)
        {
            var parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2019", args);

            parser.Parse();
            Console.ReadKey();
        }
    }
}
