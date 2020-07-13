namespace ChainOfResponsibilityPattern
{
    public class Request : IRequest
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
}