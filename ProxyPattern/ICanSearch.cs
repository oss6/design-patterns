using System.Collections.Generic;

namespace ProxyPattern
{
    public interface ICanSearch
    {
        IList<string> Search(string searchTerm);
    }
}