using Outrage.EventBus;

namespace PatternflyCheck.Client.EventBus
{
    public class RootEventBus : EventAggregator, IRootEventBus
    {
        public RootEventBus(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
