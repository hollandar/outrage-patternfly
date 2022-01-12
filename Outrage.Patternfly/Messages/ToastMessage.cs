using Outrage.EventBus;
using Outrage.Patternfly.Components.Alert;

namespace Outrage.Patternfly.Messages
{
	public class ToastMessage : IMessage
    {        
        public ToastMessage(string message, string? description = null, AlertColor styleClass = AlertColor.Default)
        {
            Message = message;
            Description = description;
            StyleClass = styleClass;
        }
        public string Message { get; init; }
        public string? Description { get; init; }
        public AlertColor StyleClass { get; init; }
    }
}
