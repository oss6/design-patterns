using BridgePattern.Platforms;

namespace BridgePattern
{
    public class TimeSlicedThreadScheduler : ThreadScheduler
    {
        public TimeSlicedThreadScheduler(IPlatformThreadScheduler platformThreadScheduler) : base(platformThreadScheduler)
        {
        }
    }
}