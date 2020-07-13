namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main()
        {
            var logger = new Logger();
            var authenticationHandler = new AuthenticationHandler();
            
            logger.SetNext(authenticationHandler);
            
            logger.Handle(new Request
            {
                Title = "Lord Of The Rings",
                Author = "J. R. R. Tolkien"
            });
        }
    }
}