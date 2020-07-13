namespace FlyweightPattern
{
    public class Author
    {
        public string FullName { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}