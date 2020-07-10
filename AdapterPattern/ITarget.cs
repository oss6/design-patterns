namespace AdapterPattern
{
    // The target defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }
}