using System;
using MycodeLibrary;


namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string filepath = "/Users/henrybarefoot/Desktop/text.txt";

            string value = myScrape.ScrpeWebpage("http://henrybarefoot.com:3000", filepath);

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
