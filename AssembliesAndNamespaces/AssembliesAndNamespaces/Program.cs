using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "http://henrybarefoot.com:3000/";

            WebClient client = new WebClient();
            string reply = client.DownloadString(address); 

            File.WriteAllText(@"/Users/henrybarefoot/Desktop/WriteText.txt", reply);

            Console.WriteLine(reply);
            Console.ReadLine();
        }
    }
}
 