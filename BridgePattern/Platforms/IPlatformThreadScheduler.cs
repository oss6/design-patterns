
namespace BridgePattern.Platforms
{
    // The Implementation declares the interface that’s common for all concrete implementations.
    // An abstraction can only communicate with an implementation object via methods that are declared here.
    public interface IPlatformThreadScheduler
    {
        bool IsPoolEmpty();
        bool IsWorkDone(int id);
        void Start(int id);
    }
}