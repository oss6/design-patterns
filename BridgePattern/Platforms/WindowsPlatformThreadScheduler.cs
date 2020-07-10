namespace BridgePattern.Platforms
{
    // Concrete Implementations contain platform-specific code.
    public class WindowsPlatformThreadScheduler : IPlatformThreadScheduler
    {
        public bool IsPoolEmpty()
        {
            return false;
        }

        public bool IsWorkDone(int id)
        {
            return false;
        }
        
        public void Start(int id)
        {
            
        }
    }
}