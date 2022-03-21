using Outrage.EventBus;

namespace Outrage.Patternfly.Components.Events
{
    public class MessageEventArgs
    {
        public MessageEventArgs(EventContext eventContext, IMessage message)
        {
            this.Context = eventContext;
            this.Message = message;
        }

        public EventContext Context { get; init; }
        public IMessage Message { get; init; }
    }
}
