using Outrage.EventBus;
using Outrage.Patternfly.Components.Alert;

namespace Outrage.Patternfly.Messages
{
	public class ToastMessage : IMessage
    {        
        public ToastMessage(string message, AlertColor color = AlertColor.Default, string? description = null)
        {
            Message = message;
            Description = description;
            Color = color;
        }
        public string Message { get; init; }
        public string? Description { get; init; }
        public AlertColor Color { get; init; }
    }
}
