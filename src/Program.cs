using System;
using System.IO;
using System.Net.Http;

namespace lions
{
    class Program
    {
        static void Main(params string[] args)
        {
            var parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2017", args);

            parser.Parse();
            Console.ReadKey();
        }
    }
}
