using System;
using System.IO;
using System.Net;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://www.youtube.com");
            File.WriteAllTextAsync(@"F:\Console Apps\BobTaborCSharp\AssembliesAndNamespaces\TextFile1.txt", reply);
        }
    }
}
