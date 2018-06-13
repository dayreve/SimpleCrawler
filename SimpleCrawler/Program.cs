using System;

namespace SimpleCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
                Crawler.Crawl(args[0], true, Tuple.Create(true, 10));

            else
                Crawler.Crawl("https://github.com/", true, Tuple.Create(true, 10));
        }
    }
}