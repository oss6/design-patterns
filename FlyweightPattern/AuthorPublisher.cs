namespace FlyweightPattern
{
    // The Flyweight class contains the portion of the original object’s state that can be shared between multiple objects.
    // The same flyweight object can be used in many different contexts.
    public class AuthorPublisher
    {
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}