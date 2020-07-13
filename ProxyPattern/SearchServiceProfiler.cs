using System.Collections.Generic;
using System.Diagnostics;

namespace ProxyPattern
{
    public class SearchServiceProfiler : ICanSearch
    {
        private readonly SearchService _searchService;

        public SearchServiceProfiler(SearchService searchService)
        {
            _searchService = searchService;
        }
        
        public long ElapsedMilliseconds { get; private set; }
        
        public IList<string> Search(string searchTerm)
        {
            var stopwatch = new Stopwatch();
            
            stopwatch.Start();
            
            var result = _searchService.Search(searchTerm);
            
            stopwatch.Stop();

            ElapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            return result;
        }
    }
}