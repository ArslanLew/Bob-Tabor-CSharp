using MyCodeLibrary;
using System;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string reply = myScrape.ScrapeWebpage("https://www.youtube.com");
            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
