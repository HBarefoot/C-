﻿using System;
using System.Net;
using System.IO;
namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrpeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrpeWebpage(string url, string filepath)
        {
            string reply = GetWebPage(url);
            File.WriteAllText(filepath, reply);

            return reply;
        }

        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
