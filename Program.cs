using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;

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

    public class AdventParser
    {
        private readonly string url;
        private readonly string[] numbers;

        public AdventParser(string url, string[] numbers)
        {
            this.url = url;
            this.numbers = numbers;
        }

        public void Parse()
        {
            this.GetPage();
        }

        List<string> winNumbers = new List<string>();

        private void GetPage()
        {
            var web = new HtmlWeb();
            var doc = web.Load(this.url);

            foreach (var number in this.numbers)
            {
                if (doc.ParsedText.Contains(number))
                {
                    winNumbers.Add(number);
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





            /* 
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(this.url);
            var pageContents = await response.Content.ReadAsStringAsync();
            HtmlDocument pageDocument = new HtmlDocument();
            pageDocument.LoadHtml(pageContents);
            */
        }
    }
}
