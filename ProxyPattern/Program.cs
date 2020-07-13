using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main()
        {
            var searchService = new SearchService();
            var searchServiceProfiler = new SearchServiceProfiler(searchService);

            searchServiceProfiler.Search("test");
            
            Console.WriteLine(searchServiceProfiler.ElapsedMilliseconds);
        }
    }
}