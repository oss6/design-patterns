using System.Collections.Generic;

namespace FlyweightPattern
{
    public class AuthorPublisherFactory
    {
        private readonly IDictionary<(string, string), AuthorPublisher> _cache =
            new Dictionary<(string, string), AuthorPublisher>();

        public AuthorPublisher Get((string, string) authorPublisherTuple)
        {
            if (!_cache.TryGetValue(authorPublisherTuple, out var authorPublisher))
            {
                return new AuthorPublisher
                {
                    Author = new Author {FullName = authorPublisherTuple.Item1},
                    Publisher = new Publisher {Name = authorPublisherTuple.Item2}
                };
            }

            return authorPublisher;
        }
    }
}