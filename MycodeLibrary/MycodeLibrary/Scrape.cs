using System;
using System.IO;
using System.Net;

namespace MycodeLibrary
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
