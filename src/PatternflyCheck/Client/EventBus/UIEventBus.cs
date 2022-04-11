using Outrage.EventBus;

namespace PatternflyCheck.Client.EventBus
{
    public class UIEventBus : ChildEventAggregator, IClientEventBus
    {
        public UIEventBus(IServiceProvider serviceProvider, IRootEventBus rootEventBus) : base(serviceProvider)
        {
            rootEventBus.Subscribe(this);
        }
    }
}
