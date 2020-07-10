using BridgePattern.Platforms;

namespace BridgePattern
{
    public class PreemptiveThreadScheduler : ThreadScheduler
    {
        public PreemptiveThreadScheduler(IPlatformThreadScheduler platformThreadScheduler) : base(platformThreadScheduler)
        {
        }
    }
}