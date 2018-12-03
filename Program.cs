using System;
using System.IO;
using System.Net.Http;

namespace lions
{
    class Program
    {
        static void Main(string[] args)
        {
            AdventParser parser = null;
            if (args == null || args.Length == 0)
            {
                parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2017", new[] { "174", "0174", "3104" });
            }
            else
            {
                parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2017", args);
            }

            parser.Parse();
            Console.ReadKey();
        }
    }
}
