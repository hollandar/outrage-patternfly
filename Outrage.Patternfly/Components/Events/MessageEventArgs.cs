using Outrage.EventBus;

namespace Outrage.Patternfly.Components.Events
{
    public class MessageEventArgs
    {
        public EventContext Context { get; set; }
        public IMessage Message { get; set; }
    }
}
