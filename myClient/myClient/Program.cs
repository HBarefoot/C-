using System;
using MycodeLibrary;

namespace myClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();

            string value = myScrape.ScrpeWebpage("http://henrybarefoot.com:3000");

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
