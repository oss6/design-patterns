using System.Collections.Generic;
using BridgePattern.Platforms;

namespace BridgePattern
{
    // The Abstraction provides high-level control logic.
    // It relies on the implementation object to do the actual low-level work.
    public class ThreadScheduler
    {
        private IPlatformThreadScheduler _platformThreadScheduler;

        public ThreadScheduler(IPlatformThreadScheduler platformThreadScheduler)
        {
            _platformThreadScheduler = platformThreadScheduler;
        }

        public void Start(IList<int> threadIds)
        {
            foreach (var threadId in threadIds)
            {
                _platformThreadScheduler.Start(threadId);
            }
        }
    }
}