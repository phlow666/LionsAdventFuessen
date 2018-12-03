using System.IO;
using System.Net.Http;

namespace lions
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new AdventParser("https://www.lions.de/web/lc-fuessen/gewinner-2017", new[] { "174", "0174", "3104" });
            parser.Parse();
        }
    }
}
