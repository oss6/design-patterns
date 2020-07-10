using System.Collections.Generic;
using BridgePattern.Platforms;

namespace BridgePattern
{
    class Program
    {
        static void Main()
        {
            var unixThreadScheduler = new UnixPlatformThreadScheduler();
            var threadScheduler = new ThreadScheduler(unixThreadScheduler);
            
            threadScheduler.Start(new List<int> { 124, 4885, 577 });
        }
    }
}