using Outrage.EventBus;

namespace Outrage.Patternfly.Messages
{
	public class ToastMessage : IMessage
    {        
        public ToastMessage(string message, string styleClass = null)
        {
            Message = message;
            StyleClass = styleClass;
        }
        public string Message { get; }
        public string StyleClass { get; }
    }
}
