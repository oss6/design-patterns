using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    // The Context class contains the extrinsic state, unique across all original objects.
    // When a context is paired with one of the flyweight objects, it represents the full state of the original object.
    public class Book
    {
        private readonly string _title;
        private readonly DateTime _datePublished;
        private readonly AuthorPublisher _authorPublisher;

        public Book(string authorName, string publisherName, string title, DateTime datePublished)
        {
            _title = title;
            _datePublished = datePublished;
            
            // Get flyweight object
            var factory = new AuthorPublisherFactory();

            _authorPublisher = factory.Get((authorName, publisherName));
        }

        public override string ToString()
        {
            return string.Join("\n", new List<string>
            {
                $"Title: {_title}",
                $"Date published: {_datePublished}",
                $"Author: {_authorPublisher.Author}",
                $"Publisher: {_authorPublisher.Publisher}"
            });
        }
    }
}