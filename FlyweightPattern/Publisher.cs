namespace FlyweightPattern
{
    public class Publisher
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}