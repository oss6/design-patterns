using System.Collections.Generic;

namespace ProxyPattern
{
    public class SearchService : ICanSearch
    {
        public IList<string> Search(string searchTerm)
        {
            return new List<string>();
        }
    }
}