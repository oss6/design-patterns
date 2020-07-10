namespace AdapterPattern
{
    // The adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The adaptee needs some
    // adaptation before the client code can use it.
    public class ExternalApi
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}